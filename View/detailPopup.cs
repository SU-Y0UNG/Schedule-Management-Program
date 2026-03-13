using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Project_Maver.Common;
using Project_Maver.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Maver_켈린더.Calendar;



namespace maverCalender
{
    public partial class detailPopup : Form
    {
        // 승환(3월10)
        public int event_id { get; set; }
        public string title { get; set; }
        public string memo { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public ScheduleData SelectedSchedule { get; set; }

        public event Action<detailPopup> ScheduleSaved;


        public DateTime StartDate
        {
            get { return dtpStartDate.Value; }
            set { dtpStartDate.Value = value; }
        }
        public DateTime EndDate
        {
            get { return dtpEndDate.Value; }
            set { dtpEndDate.Value = value; }
        }

        public DateTime selectedDate;

        // 승환(3월10)
        //public string title {  get; set; }
        //public event Action<detailPopup> ScheduleSaved;

        pnlRepeat repeat = new pnlRepeat();
        public detailPopup()
        {
            InitializeComponent();

            repeat.Location = new Point(108, 350);
            //패널추가

            this.Controls.Add(repeat);
            //추가하고 숨기기

            btnColor.Visible = true;
            repeat.Visible = false;

        }


        private void detailPopup_Load(object sender, EventArgs e)
        {
            //수영
           
            worldTime();


            if (selectedDate == DateTime.MinValue)
            {
                selectedDate = DateTime.Today;
            }

            // DateTimePicker 범위 체크
            if (selectedDate < dtpStartDate.MinDate)
            {
                selectedDate = dtpStartDate.MinDate;
            }

            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "HH:mm";
            dtpStartDate.Value = selectedDate;

            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "HH:mm";
            dtpEndDate.Value = selectedDate;

            // 개인인지 그룹으로 만들지 지정하는 콤보박스 세팅
            setShareCombobox();
        }

        public void textContent()
        {
            txtMemo.Text = "";
            txtTitle.Text = "";
        }

        public class ComboItem
        {
            public string share_name { get; set; }
            public int share_id { get; set; }

            public override string ToString()
            {
                return share_name;
            }
        }

        public void setShareCombobox()
        {
            string sql = " select 0 as share_id, \"개인 캘린더\" as share_name "
                       + " from dual "
                       + " union "
                       + " select distinct a.share_id,a.share_name "
                       + " from share_group a join share_member b on a.share_id = b.share_id "
                       + " where b.user_id = @userId";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("userId", UserSession.UserId);

            DataTable comboData = DbManager.select_Query(sql, param);

            if (comboData.Rows.Count > 0)
            {
                cbChoice.Items.Clear();

                for (int i = 0; i < comboData.Rows.Count; i++)
                {
                    DataRow r = comboData.Rows[i];
                    int id = Convert.ToInt32(r["share_id"]);
                    cbChoice.Items.Add(new ComboItem { share_id = id, share_name = r["share_name"].ToString() });
                }
            }

            if(event_id == 0)
            {
                cbChoice.SelectedIndex = 0;
            }
            else
            {
                // 1. 해당 일정의 share_id를 가져오는 쿼리 (NULL이면 0으로 치환)
                string sharesql = "SELECT IFNULL(share_id, 0) as share_id FROM events WHERE event_id = @eventId";

                Dictionary<string, object> p = new Dictionary<string, object>();
                p.Add("eventId", event_id);

                DataTable dt = DbManager.select_Query(sharesql, p);

                if (dt.Rows.Count > 0)
                {
                    // DB에서 가져온 share_id (개인이면 0, 그룹이면 해당 숫자)
                    int targetShareId = Convert.ToInt32(dt.Rows[0]["share_id"]);

                    // 2. 콤보박스 아이템 중 targetShareId와 일치하는 것을 찾아 선택
                    for (int i = 0; i < cbChoice.Items.Count; i++)
                    {
                        if (cbChoice.Items[i] is ComboItem item)
                        {
                            if (item.share_id == targetShareId)
                            {
                                cbChoice.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                }

            }

        }



        public Color btncolor = Color.Pink;
        public Color selectedColor = Color.SkyBlue;

        // 승환
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStartDate.Value.Date;
            DateTime end = dtpEndDate.Value.Date;

            if (start > end)
            {
                MessageBox.Show("시작 날짜가 끝 날짜보다 늦습니다.\n날짜를 수정하세요.",
                                "날짜 오류",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }




            var dates = GenerateRepeatDates(
                repeat.RepeatType,
                repeat.RepeatInterval,
                repeat.RepeatDays,
                repeat.RepeatStartDate,
                repeat.RepeatEndDate
            );//반복 일정을 달력에 효과적으로 표시하기 위해 DB에 저장된 "반복 규칙"을 실제 "날짜 목록"으로 펼치기 위해서
            string connectionString = "Server=192.168.0.96;Port=3306; Database=MaverDB;Uid=maver_admin;Pwd=moble1234;";
            string query = @"INSERT INTO events (user_id, title,share_id, start_date, end_date, start_time, end_time, memo, repeat_type, repeat_interval, repeat_start_date, repeat_end_date, repeat_days, color) 
                     VALUES (@UserId, @Title,@ShareId, @StartDate, @EndDate, @StartTime, @EndTime, @Memo, @rType, @rInterval,@rStart, @rEnd, @rDays, @color)";
            conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);

                // 3. 파라미터를 통해 값 할당 (보안을 위해 직접 대입 대신 이 방식을 권장합니다)
                cmd.Parameters.AddWithValue("@UserId", UserSession.UserId);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);
                cmd.Parameters.AddWithValue("@Memo", txtMemo.Text);
                cmd.Parameters.AddWithValue("@StartTime", dtpStartTime.Value);
                cmd.Parameters.AddWithValue("@EndTime", dtpEndTime.Value);
                cmd.Parameters.AddWithValue("@rType", repeat.RepeatType);

                if (cbChoice.SelectedItem is ComboItem selected)
                {
                    int selectedId = (int)selected.share_id;

                    if (selectedId == 0)
                    {
                        // 개인 캘린더일 경우 DB에 NULL로 저장
                        cmd.Parameters.AddWithValue("@ShareId", DBNull.Value);
                    }
                    else
                    {
                        // 그룹일 경우 해당 ID 저장
                        cmd.Parameters.AddWithValue("@ShareId", selectedId);
                    }
                }

                if (repeat.RepeatType == "none")
                {
                    cmd.Parameters.AddWithValue("@rInterval", DBNull.Value);
                    cmd.Parameters.AddWithValue("@rStart", DBNull.Value);
                    cmd.Parameters.AddWithValue("@rEnd", DBNull.Value);
                    cmd.Parameters.AddWithValue("@rDays", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@rInterval", repeat.RepeatInterval);
                    cmd.Parameters.AddWithValue("@rStart", repeat.RepeatStartDate.Date);
                    cmd.Parameters.AddWithValue("@rEnd", repeat.RepeatEndDate.Date);
                    cmd.Parameters.AddWithValue("@rDays", repeat.RepeatDays);
                }
                cmd.Parameters.AddWithValue("@color", selectedColor.ToString());


                // 4. 쿼리 실행
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("일정이 성공적으로 저장되었습니다!");
                    //this.Close(); // 저장 후 팝업 닫기
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            // 승환(3.10)
            SelectedSchedule = new ScheduleData
            {
                title = txtTitle.Text,
                memo = txtMemo.Text,
                startDate = dtpStartDate.Value,
                endDate = dtpEndDate.Value,
                startTime = dtpStartTime.Value,
                endTime = dtpEndTime.Value
            };
            this.DialogResult = DialogResult.OK;
            this.Close();

            //수영
            MessageBox.Show(selectedColor.ToString());
            this.DialogResult = DialogResult.OK; // 저장 후 창 닫기
            this.Close();

        }
        // 승환(3/10)
        public string getDetailPopupTitle()
        {
            return txtTitle.Text;
        }

        // 승환
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("이 일정을 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    // 2. DB 연결 (MySQL/MariaDB 기준)
                    conn = new MySqlConnection("Server=192.168.0.96;Port=3306; Database=MaverDB;Uid=maver_admin;Pwd=moble1234;");

                    conn.Open();

                    // 3. event_id를 조건으로 삭제 쿼리 작성
                    // image_df9ae7.png의 public string event_id를 사용합니다.
                    string sql = "DELETE FROM events WHERE event_id = @eventId";

                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@eventId", this.event_id);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("삭제되었습니다.");
                        // 4. 삭제 성공 시 팝업을 닫고 부모 창에 OK를 보냄 (새로고침 용도)
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("삭제할 데이터를 찾지 못했습니다. (ID: " + this.event_id + ")");
                    }

                }
                catch (Exception ex)
                {
                    // image_e07c66.png에서 보셨던 Fatal error 등을 여기서 잡습니다.
                    MessageBox.Show("삭제 실패: " + ex.Message);
                }
            }
        }
        // 승환
        public void setMode(string mode)
        {
            if (mode == "Add")
            {
                btnSave.Visible = true;    // 저장 버튼 보임
                btnUpdate.Visible = false; // 수정 버튼 숨김
                btnDelete.Visible = false; // 삭제 버튼 숨김
                //lblHeader.Text = "새 일정 등록"; // 제목도 바꿔주면 좋음
            }
            else if (mode == "View")
            {
                btnSave.Visible = false;   // 저장 버튼 숨김
                btnUpdate.Visible = true;  // 수정 버튼 보임
                btnDelete.Visible = true;  // 삭제 버튼 보임
                //lblHeader.Text = "일정 상세보기";
            }
        }
        // 승환
        private string selectedScheduleId;
        public detailPopup(string id)
        {
            InitializeComponent();
            this.selectedScheduleId = id;
        }
        // 승환
        public void setDetailData(string title, string memo, string sDate, string eDate)
        {
            // 1. 텍스트 정보 채우기
            this.txtTitle.Text = title;
            this.txtMemo.Text = memo;

            // 2. 날짜 정보 채우기 (문자열을 DateTime으로 변환)
            if (DateTime.TryParse(sDate, out DateTime startDate))
                this.dtpStartDate.Value = startDate;

            if (DateTime.TryParse(eDate, out DateTime endDate))
                this.dtpEndDate.Value = endDate;
        }

        // 승환,수영(반복부분 추가)
        private void LoadDetailData(string userid)
        {
            string connstr = "Server=192.168.0.96;Port=3306; Database=MaverDB;Uid=maver_admin;Pwd=moble1234;";
            conn = new MySqlConnection(connstr);
            try
            {
                conn.Open();

                // 2. 쿼리 작성 (필요한 컬럼만 지정)
                string sql = @"SELECT user_id, title, start_time, end_time, start_date, end_date, memo,  repeat_type, repeat_interval, repeat_start_date, repeat_end_date, repeat_days, color
                           FROM events 
                           WHERE user_id = @userid"; // id는 이 폼을 열 때 넘겨받은 변수여야 합니다.

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userid", userid); // 예시로 1번 데이터를 가져옵니다.

                MySqlDataReader reader = cmd.ExecuteReader();

                // 3. 데이터를 UI 칸에 채우기
                if (reader.Read())
                {
                    // 문자열 데이터 (텍스트박스)
                    //txtUserid.Text = reader["user_id"].ToString();
                    txtTitle.Text = reader["title"].ToString();
                    txtMemo.Text = reader["memo"]?.ToString() ?? ""; // 메모가 비어있을 경우 대비

                    // 날짜 데이터 (DateTimePicker)
                    // DB 타입이 Date나 DateTime일 경우입니다.
                    dtpStartDate.Value = Convert.ToDateTime(reader["start_date"]);
                    dtpEndDate.Value = Convert.ToDateTime(reader["end_date"]);

                    // 시간 데이터 (DateTimePicker의 Format을 Time으로 설정했을 경우)
                    // DB 타입이 Time일 경우 TimeSpan으로 읽어와 처리할 수 있습니다.
                    if (reader["start_time"] != DBNull.Value)
                    {
                        TimeSpan startTime = (TimeSpan)reader["start_time"];
                        dtpStartTime.Value = DateTime.Today.Add(startTime);
                    }

                    if (reader["end_time"] != DBNull.Value)
                    {
                        TimeSpan endTime = (TimeSpan)reader["end_time"];
                        dtpEndTime.Value = DateTime.Today.Add(endTime);
                    }
                    if (reader["repeat_type"] != DBNull.Value)
                    {
                        repeat.RepeatType = reader["repeat_type"].ToString();
                    }
                    if (reader["repeat_Interval"] != DBNull.Value)
                    {
                        repeat.RepeatInterval = Convert.ToInt32(reader["repeat_Interval"]);
                    }
                    if (reader["repeat_start_date"] != DBNull.Value)
                    {
                        repeat.RepeatStartDate = Convert.ToDateTime(reader["repeat_start_date"]);
                    }
                    if (reader["repeat_end_date"] != DBNull.Value)
                    {
                        repeat.RepeatEndDate = Convert.ToDateTime(reader["repeat_end_date"]);
                    }
                    if (reader["repeat_days"] != DBNull.Value)
                    {
                        repeat.RepeatDays = Convert.ToInt32(reader["repeat_days"]);
                    }
                    if (reader["color"] != DBNull.Value)
                    {
                        string colorName = reader["color"].ToString();
                        btnColor.BackColor = Color.FromName(colorName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"에러 이유: {ex.Message}\n\n위치: {ex.StackTrace}");
            }
        }
        // 승환
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //            string connStr = "Server=192.168.0.96;Port=3306; Database=MaverDB;Uid=maver_admin;Pwd=moble1234;";
            //            conn = new MySqlConnection(connStr);
            //            try
            //            {
            //                conn.Open();

            //                // 2. UPDATE 쿼리 (화면의 입력값을 DB에 반영)
            //                // 주의: WHERE 절에는 'user_id'가 아닌 고유 키인 'event_id'를 쓰는 것이 안전합니다.
            //                string sql = @"UPDATE events 
            //                           SET title = @title, 
            //                               start_date = @start_date, 
            //                               end_date = @end_date, 
            //                               start_time = @start_time, 
            //                               end_time = @end_time,
            //                               memo = @memo,
            //                               repeat_type = @rtype, 
            //                               repeat_interval = @rinter, 
            //                               repeat_days = @rdays, 
            //                               repeat_end_date = @rend,
            //                               repeat_start_date=@rstart,
            //                               color=@color
            //                           WHERE user_id = @user_id and event_id = @event_id"; // 여기서는 일단 기존처럼 user_id를 기준으로 합니다.
            ////************************************************************************** 이벤트 아이디 추가

            //                MySqlCommand cmd = new MySqlCommand(sql, conn);
            //                cmd.Parameters.Clear(); // 파라미터 중복 방지

            //                // 3. 파라미터 매핑 (화면의 컨트롤 값을 DB로 전달)
            //                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
            //                cmd.Parameters.AddWithValue("@start_date", dtpStartDate.Value.ToString("yyyy-MM-dd"));
            //                cmd.Parameters.AddWithValue("@end_date", dtpEndDate.Value.ToString("yyyy-MM-dd"));
            //                cmd.Parameters.AddWithValue("@start_time", dtpStartTime.Value.ToString("HH:mm:ss"));
            //                cmd.Parameters.AddWithValue("@end_time", dtpEndTime.Value.ToString("HH:mm:ss"));
            //                cmd.Parameters.AddWithValue("@user_id", UserSession.UserId); // 기준이 되는 ID
            //                cmd.Parameters.AddWithValue("@memo", txtMemo.Text);
            //                cmd.Parameters.AddWithValue("@rtype", repeat.RepeatType);
            //                cmd.Parameters.AddWithValue("@rinter", repeat.RepeatInterval);
            //                cmd.Parameters.AddWithValue("@rdays", repeat.RepeatDays);
            //                cmd.Parameters.AddWithValue("@rstart", repeat.RepeatStartDate);
            //                cmd.Parameters.AddWithValue("@rend", repeat.RepeatEndDate);
            //                cmd.Parameters.AddWithValue("@color", btnColor.BackColor.Name);
            //                cmd.Parameters.AddWithValue("@event_id", event_id);


            //                // 4. 실행
            //                int result = cmd.ExecuteNonQuery();

            //                if (result > 0)
            //                {
            //                    MessageBox.Show("일정이 성공적으로 수정되었습니다!");
            //                    this.DialogResult = DialogResult.OK;
            //                    this.Close(); // 저장 후 팝업 닫기
            //                }
            //                else
            //                {
            //                    // 💡 아무 반응이 없었던 이유는 아마 이 조건문에서 0이 나왔기 때문일 것입니다.
            //                    MessageBox.Show("수정된 내용이 없습니다. 입력 데이터(ID, 제목)를 확인하세요.");
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show("저장 중 오류 발생: " + ex.Message);
            //            }
            // event_id가 비어있는지 먼저 체크 (사진 3의 '수정 내용 없음' 방지)
            if (this.event_id <= 0)
            {
                MessageBox.Show("오류: 일정을 식별할 수 있는 ID가 없습니다.");
                return;
            }

            string connStr = "Server=192.168.0.96;Port=3306; Database=MaverDB;Uid=maver_admin;Pwd=moble1234;";
            using (MySqlConnection conn = new MySqlConnection(connStr)) // using 사용 권장
            {
                try
                {
                    conn.Open();
                    string sql = @"UPDATE events 
                           SET title = @title, 
                               start_date = @start_date, end_date = @end_date, 
                               start_time = @start_time, end_time = @end_time,
                               memo = @memo, repeat_type = @rtype, 
                               repeat_interval = @rinter, repeat_days = @rdays, 
                               repeat_end_date = @rend, repeat_start_date = @rstart,
                               color = @color
                           WHERE event_id = @eid"; // WHERE 조건 확인

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    // 파라미터 추가
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@start_date", dtpStartDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@end_date", dtpEndDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@start_time", dtpStartTime.Value.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@end_time", dtpEndTime.Value.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@memo", txtMemo.Text ?? "");
                    cmd.Parameters.AddWithValue("@rtype", repeat.RepeatType ?? "none");
                    cmd.Parameters.AddWithValue("@rinter", repeat.RepeatInterval);
                    cmd.Parameters.AddWithValue("@rdays", repeat.RepeatDays);
                    cmd.Parameters.AddWithValue("@color", selectedColor.ToString());
                    cmd.Parameters.AddWithValue("@eid", this.event_id);

                    // 반복 날짜 처리 (0001-01-01 방어)
                    if (repeat.RepeatStartDate.Year <= 1753)
                        cmd.Parameters.AddWithValue("@rstart", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@rstart", repeat.RepeatStartDate.ToString("yyyy-MM-dd"));

                    if (repeat.RepeatEndDate.Year <= 1753)
                        cmd.Parameters.AddWithValue("@rend", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@rend", repeat.RepeatEndDate.ToString("yyyy-MM-dd"));

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("일정이 성공적으로 수정되었습니다!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"수정 실패: ID {this.event_id}에 해당하는 데이터가 없습니다.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fatal Error 상세내용:\n" + ex.Message);
                }
            }
        }

        //수영
        private void cbWorldTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            //선택된 시간대 객체를 가져오기
            TimeZoneInfo selectedZone = (TimeZoneInfo)cbWorldTime.SelectedItem;

            //현재 시간을 해당시간대로 변환
            DateTime currentTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, selectedZone);

            //라벨에 시간 표시(날짜와 해당시간대)
            lbStandardTime.Text = currentTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        //수영
        public void worldTime()
        {
            foreach (TimeZoneInfo timeZone in TimeZoneInfo.GetSystemTimeZones())
            {
                cbWorldTime.Items.Add(timeZone);
            }

            // 콤보박스에 이름이 보이도록 설정
            cbWorldTime.DisplayMember = "DisplayName";
        }

        //수영
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            {
                // 색상 선택창 띄우기
                if (colorDialog.ShowDialog(this) == DialogResult.OK)
                {
                    selectedColor = colorDialog.Color;
                    // 버튼 배경색을 선택한 색으로 바꿔서 사용자가 바로 확인하게 함
                    btnColor.BackColor = selectedColor;
                }

            }
        }

        public List<DateTime> GenerateRepeatDates(
            string repeatType, int interval, int repeatDays, DateTime startDate, DateTime endDate)
        {
            List<DateTime> dates = new List<DateTime>();
            DateTime current = startDate;
            while (current <= endDate)
            {
                if (repeatType == "매주")
                {// 현재 날짜의 요일을 비트 값으로 변환
                    int dayFlag = 1 << (int)current.DayOfWeek;
                    if ((repeatDays & dayFlag) != 0)
                    {
                        dates.Add(current);
                    }
                    current = current.AddDays(1);
                }
                else if (repeatType == "매월")
                {
                    dates.Add(current);
                    current = current.AddMonths(interval);
                }
                else if (repeatType == "매년")
                {
                    dates.Add(current);
                    current = current.AddYears(interval);
                }
                else
                {
                    dates.Add(current);
                    break;
                }

            }
            return dates;
        }

        private void cbRepeat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CheckBox[] days = { repeat.cbSun, repeat.cbSat, repeat.cbFri, repeat.cbThu, repeat.cbWed, repeat.cbTue, repeat.cbMon };

            string selectedType = cbRepeat.SelectedItem.ToString();

            // 초기화: 모든 패널 숨기기
            //weekly.Visible = false;
            //monthly.Visible = false;
            repeat.Visible = false;

            foreach (var cb in days) { cb.Visible = false; }
            repeat.lbChange.Visible = false;
            repeat.numInterval.Enabled = false;
            // 선택된 유형에 따라 패널 보이기
            switch (selectedType)
            {
                case "매주":
                    repeat.Visible = true;
                    repeat.lbChoice.Text = selectedType;
                    repeat.lbChange.Text = "주";
                    repeat.lbChange.Visible = true;

                    repeat.numInterval.Enabled = true;
                    repeat.numInterval.Value = 1;
                    foreach (var cb in days)
                        cb.Visible = true;

                    break;

                case "매월":
                    repeat.Visible = true;
                    repeat.lbChoice.Text = selectedType;
                    repeat.lbChange.Visible = true;
                    repeat.numInterval.Enabled = true;
                    repeat.numInterval.Text = " ";
                    foreach (var cb in days)
                        cb.Visible = false;
                    repeat.lbChange.Text = "개월";

                    break;
                case "매년":
                    repeat.Visible = true;
                    repeat.lbChoice.Text = selectedType;
                    repeat.lbChange.Visible = false;
                    repeat.numInterval.Text = "-";
                    repeat.numInterval.Enabled = false;
                    foreach (var cb in days)
                        cb.Visible = false;


                    break;

                case "NONE":
                default:
                    // 아무것도 안 보여줌
                    break;
            }
            repeat.BringToFront();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbOff_Click(object sender, EventArgs e)
        {
            pbOn.BringToFront();
            //dtpStartTime.Visible = false;
            //dtpEndTime.Visible = false;
            dtpStartTime.Enabled = false;
            dtpEndTime.Enabled = false;
        }

        private void pbOn_Click(object sender, EventArgs e)
        {
            pbOff.BringToFront();
            //dtpStartTime.Visible = true;
            //dtpEndTime.Visible = true;
            dtpStartTime.Enabled = true;
            dtpEndTime.Enabled = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            btnMinus.Visible = false;
            btnPlus.Visible = true;
            cbAlert.Visible = false;
            lbLine9.Visible = false;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            btnPlus.Visible = false;
            btnMinus.Visible = true;
            cbAlert.Visible = true;
        }
        public class ScheduleData
        {
            public string title { get; set; }
            public string memo { get; set; }
            public DateTime startDate { get; set; }
            public DateTime endDate { get; set; }
            public DateTime startTime { get; set; }
            public DateTime endTime { get; set; }
        }

    }
}
