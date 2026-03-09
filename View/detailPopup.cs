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



namespace maverCalender
{
    public partial class detailPopup : Form
    {

        pnlRepeat repeat = new pnlRepeat();
        public detailPopup()
        {
            InitializeComponent();

            repeat.Location = new Point(108, 350);
            //패널추가

            this.Controls.Add(repeat);
            //추가하고 숨기기

            repeat.Visible = false;

        }


        private void detailPopup_Load(object sender, EventArgs e)
        {
            //수영
            GetWeather();
            worldTime();

            // 승환
            LoadDetailData("user1");
            textContent();
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "HH:mm";

            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "HH:mm";
        }

        public void textContent()
        {
            txtMemo.Text = "";
            txtTitle.Text = "";
            txtUserid.Text = "";
        }



        //날씨(수영)       
        public async void GetWeather()
        {
            string apiKey = "c7772d91da4472af145add9c179343de";
            string cityName = "Seoul";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=metric&lang=kr";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // API에 데이터 요청
                    string response = await client.GetStringAsync(url);

                    // JSON 데이터를 클래스 객체로 변환
                    WeatherInfo data = JsonConvert.DeserializeObject<WeatherInfo>(response);

                    // 화면에 표시 (레이블 등)
                    lblCity.Text = data.Name;
                    lblTemp.Text = $"{data.Main.Temp} °C";
                    lblDesc.Text = data.Weather[0].Description;

                    // 아이콘 이미지 불러오기 (이미지 URL 활용)
                    string iconUrl = $"http://openweathermap.org/img/wn/{data.Weather[0].Icon}@2x.png";
                    pbWeather.Load(iconUrl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("날씨 정보를 가져오지 못했습니다: " + ex.Message);
                }
            }
        }

        //구글 로그인(수영)
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            /*토큰이 로컬에 저장되기 때문에 다음에는 자동인증되는걸 방지하기 위해
            삭제하고 다시 로그인하는 부분 추기*/
            string tokenDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "token");

            if (Directory.Exists(tokenDir))
            {
                Directory.Delete(tokenDir, true);
            }

            //구글 로그인 발급되는 인증정보를 토큰에 저장하는 객체
            UserCredential credential;
            //파일 경로를 합쳐준다(Common안에 있는걸 합쳐주는 함수)
            string path = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Common",
                "client_secrets.json");

            // 프로젝트 폴더에 넣어둔 'client_secrets.json' 파일을 읽어옵니다.
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                string[] scopes = { CalendarService.Scope.Calendar };

                // 구글 인증 브라우저를 띄웁니다.
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore("token.json", true));
            }

            MessageBox.Show("로그인 성공!");
        }



        private Color selectedColor = Color.SkyBlue;
        // 승환
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private void btnSave_Click(object sender, EventArgs e)
        {
            var dates = GenerateRepeatDates(
    repeat.RepeatType,
    repeat.RepeatInterval,
    repeat.RepeatDays,
    repeat.RepeatStartDate,
    repeat.RepeatEndDate
);//반복 일정을 달력에 효과적으로 표시하기 위해 DB에 저장된 "반복 규칙"을 실제 "날짜 목록"으로 펼치기 위해서
            string connectionString = "Server=192.168.0.96;Port=3306; Database=MaverDB;Uid=maver_admin;Pwd=moble1234;";
            string query = @"INSERT INTO events (user_id, title, start_date, end_date, start_time, end_time, memo, repeat_type, repeat_interval, repeat_start_date, repeat_end_date, repeat_days, color) 
                     VALUES (@UserId, @Title, @StartDate, @EndDate, @StartTime, @EndTime, @Memo, @rType, @rInterval,@rStart, @rEnd, @rDays, @color)";
            conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);

                // 3. 파라미터를 통해 값 할당 (보안을 위해 직접 대입 대신 이 방식을 권장합니다)
                cmd.Parameters.AddWithValue("@UserId", txtUserid.Text);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);
                cmd.Parameters.AddWithValue("@Memo", txtMemo.Text);
                cmd.Parameters.AddWithValue("@StartTime", dtpStartTime.Value);
                cmd.Parameters.AddWithValue("@EndTime", dtpEndTime.Value);
                cmd.Parameters.AddWithValue("@rType", repeat.RepeatType);
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
                    this.Close(); // 저장 후 팝업 닫기

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //수영
            MessageBox.Show(selectedColor.ToString());
            this.DialogResult = DialogResult.OK; // 저장 후 창 닫기
            this.Close();

        }
        // 승환
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 사용자에게 정말 삭제할지 확인 (실수 방지)
            DialogResult confirm = MessageBox.Show("이 일정을 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                string connectionString = "Server=192.168.0.96;Port=3306; Database=MaverDB;Uid=maver_admin;Pwd=moble1234;";
                string query = "DELETE FROM events WHERE user_Id = @UserId AND title = @Title";
                conn = new MySqlConnection(connectionString);
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand(query, conn);
                    // 삭제조건은 user_id와 title을 쓰면 그 행이 삭제
                    cmd.Parameters.AddWithValue("@UserId", txtUserid.Text);
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("일정이 삭제되었습니다.");
                        this.Close(); // 팝업 닫기
                    }
                    else
                    {
                        MessageBox.Show("삭제할 일정을 찾을 수 없습니다.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        // 승환
        private string selectedScheduleId;
        public detailPopup(string id)
        {
            InitializeComponent();
            this.selectedScheduleId = id;
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
                    txtUserid.Text = reader["user_id"].ToString();
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
            string connStr = "Server=192.168.0.96;Port=3306; Database=MaverDB;Uid=maver_admin;Pwd=moble1234;";
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                // 2. UPDATE 쿼리 (화면의 입력값을 DB에 반영)
                // 주의: WHERE 절에는 'user_id'가 아닌 고유 키인 'event_id'를 쓰는 것이 안전합니다.
                string sql = @"UPDATE events 
                           SET title = @title, 
                               start_date = @start_date, 
                               end_date = @end_date, 
                               start_time = @start_time, 
                               end_time = @end_time,
                               memo = @memo,
                               repeat_type = @rtype, 
                               repeat_interval = @rinter, 
                               repeat_days = @rdays, 
                               repeat_end_date = @rend,
                               repeat_start_date=@rstart,
                               color=@color
                           WHERE user_id = @user_id"; // 여기서는 일단 기존처럼 user_id를 기준으로 합니다.

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                // 3. 파라미터 매핑 (화면의 컨트롤 값을 DB로 전달)
                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@start_date", dtpStartDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@end_date", dtpEndDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@start_time", dtpStartTime.Value.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@end_time", dtpEndTime.Value.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@user_id", txtUserid.Text); // 기준이 되는 ID
                cmd.Parameters.AddWithValue("@memo", txtMemo.Text);
                cmd.Parameters.AddWithValue("@rtype", repeat.RepeatType);
                cmd.Parameters.AddWithValue("@rinter", repeat.RepeatInterval);
                cmd.Parameters.AddWithValue("@rdays", repeat.RepeatDays);
                cmd.Parameters.AddWithValue("@rstart", repeat.RepeatStartDate);
                cmd.Parameters.AddWithValue("@rend", repeat.RepeatEndDate);
                cmd.Parameters.AddWithValue("@color", btnColor.BackColor.Name);


                // 4. 실행
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("일정이 성공적으로 수정되었습니다!");
                    this.Close(); // 저장 후 팝업 닫기
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("저장 중 오류 발생: " + ex.Message);
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

      
    }
}
