using maverCalender;
using Project_Maver.Common;
using Project_Maver.View;
using System.Data;

namespace Maver_켈린더
{
    public partial class Calendar : Form
    {

        private int currentYear;        // 현재년도
        private int currentMonth;       // 현재 달

        public Calendar()
        {
            InitializeComponent();

            tableLayoutPanel1.BringToFront();
            pnlCategori.BringToFront();
            flpMain.SendToBack();
            flpMain.Dock = DockStyle.None;

            currentYear = DateTime.Now.Year;
            currentMonth = DateTime.Now.Month;

            lbThisDate.Text = currentYear.ToString() + "." + currentMonth.ToString();
            pnlDt.Visible = false;
        }


        private void Calendar_Load(object sender, EventArgs e)
        {
            // 전역 변수 UserSession에서 아이디를 가져와 라벨에 표시
            if (UserSession.UserId != null)
            {
                lbID.Text = UserSession.UserId + "님 접속 중";
            }

            //영현
            RefreshTreeView();

            string checkSql = @"SELECT g.share_id
                                FROM share_group g
                                JOIN share_member m ON g.share_id = m.share_id
                                WHERE m.user_id = @id
                                GROUP BY g.share_id
                                HAVING COUNT(m.user_id) = 1";

            var param = new Dictionary<string, object> { { "@id", UserSession.UserId } };
            DataTable dtCheck = DbManager.select_Query(checkSql, param);

            if (dtCheck == null || dtCheck.Rows.Count == 0)
            {
                CreateDefaultCalendar();
            }

            // 은비 - 캘린더 그리기
            DisplayDays(currentYear, currentMonth);
        }

        private void CreateDefaultCalendar()
        {
            string groupSql = "INSERT INTO share_group (share_name, color) VALUES (@name, @color); Select LAST_INSERT_ID(); ";
            var groupParam = new Dictionary<string, object>
            {
                //여기 만들면 두개 생김.
                {"@name", "개인 캘린더" },
                {"@color","#A0A0A0" }
            };

            DataTable dt = DbManager.select_Query(groupSql, groupParam);

            if (dt != null && dt.Rows.Count > 0)
            {
                int newId = Convert.ToInt32(dt.Rows[0][0]);
                string memberSql = "INSERT INTO share_member(share_id, user_id, role) VALUES (@sid, @id, @role)";
                var memberParam = new Dictionary<string, object>
                {
                    {"@sid", newId },
                    {"@id", UserSession.UserId },
                    {"@role", UserSession.UserId }
                };
                DbManager.void_query(memberSql, memberParam);
            }
        }


        private void btnToday_Click(object sender, EventArgs e)
        {
            //IDtest id = new IDtest(); // 여긴 임시로 아이디 폼에서 전역변수로 선언한 아이디가 제대로 다음 화면에서도 그 정보를 유지하는지 확인 한 것

            //id.ShowDialog();
        }


        //------------------------------------------------------------------------------------
        // 2026-03-09 영현 추가
        //------------------------------------------------------------------------------------
        bool isMenuOpen = false;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // 오버레이 패널과 사이드바 제어 시작
            if (!isMenuOpen)
            {
                pnlCategori.Left = 10;
                pnlCategori.Top = 70;
                isMenuOpen = true;
            }
            else
            {
                CloseMenu();
            }

            // tmrSideMenu.Start(); // 타이머 시작 (애니메이션 구동)
        }
        private void CloseMenu()
        {
            pnlCategori.Left = -300;
            isMenuOpen = false;
        }

        private void cdMain_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            // 포커스 테두리나 배경색이 남지 않도록 선택 직후 다른 컨트롤로 포커스 이동
            // 단, 이 방법은 키보드 방향키 조작이 어려워질 수 있습니다.
            this.ActiveControl = null;
        }

        private void cdMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pnlCategori.Focus();

        }

        private void cdMain_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            // 1. 노드가 선택되었을 때 기본적으로 그려지는 파란색 상자 무시.
            if ((e.State & TreeNodeStates.Selected) != 0)
            {
                // 선택되었을 때 배경색 (예: 흰색이나 아주 연한 회색)
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.Bounds);

                // 글자색을 검정으로 고정 (파란 배경일 때 흰색으로 변하는 것 방지)
                TextRenderer.DrawText(e.Graphics, e.Node.Text, e.Node.NodeFont ?? e.Node.TreeView.Font,
                                      e.Bounds, Color.Black, TextFormatFlags.VerticalCenter);
            }
            else
            {
                // 선택되지 않은 일반 상태는 기본 대로 그립니다.
                e.DrawDefault = true;
            }
        }
        private void PictureBox2_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(215, 217, 219), 2))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, pictureBox2.Width, pictureBox2.Height);
            }
        }

        //makeShare랑 연결
        private void CalenderPlus_Click(object sender, EventArgs e)
        {
            // 캘린더 추가할때 로그인 여부 (로그인 안하면 캘린더 추가x)
            if (string.IsNullOrEmpty(UserSession.UserId))
            {
                MessageBox.Show("로그인이 필요합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 로그인된 경우 선택 가능
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("공용 캘린더 추가", null, (s, ev) => openMakeShareForm("공용"));
            menu.Show(CalenderPlus, new Point(0, CalenderPlus.Height));
        }
        private void openMakeShareForm(string mode)
        {
            makeShare frm = new makeShare(mode);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshTreeView();
            }
        }

        // RefreshTreeView() >> 카테고리에 목록 집어넣음. 중요함!!!!!!!!!!!
        public void RefreshTreeView()
        {
            TreeNode privateRoot = treeView1.Nodes.Find("ndPrivate", true).FirstOrDefault();
            TreeNode publicRoot = treeView1.Nodes.Find("ndPublic", true).FirstOrDefault();
            if (privateRoot == null || publicRoot == null) return;

            privateRoot.Nodes.Clear();
            publicRoot.Nodes.Clear();

            // 로그인 되어있으면 '개인 캘린더' 추가
            if (!string.IsNullOrEmpty(UserSession.UserId))
            {
                TreeNode privateNode = new TreeNode("개인 캘린더");
                privateNode.ForeColor = Color.DarkBlue;
                privateRoot.Nodes.Add(privateNode);
            }

            // DB에서 내가 속한 캘린더 목록 가져오기
            string sql = @"SELECT g.share_id, g.share_name, 
                (SELECT COUNT(*) FROM share_member WHERE share_id = g.share_id) as member_count
                FROM share_group g 
                JOIN share_member m ON g.share_id = m.share_id 
                WHERE m.user_id = @id";

            var param = new Dictionary<string, object> { { "@id", UserSession.UserId } };
            DataTable dt = DbManager.select_Query(sql, param);

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int memberCount = Convert.ToInt32(row["member_count"]);
                    // 멤버가 나 포함 2명 이상일때만 '공용'목록에 추가
                    if (memberCount > 1)
                    {
                        TreeNode sharedNode = new TreeNode(row["share_name"].ToString());
                        sharedNode.Tag = row["share_id"];
                        treeView1.Nodes[0].Nodes[1].Nodes.Add(sharedNode);
                    }
                }
            }
            treeView1.ExpandAll();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "개인캘린더")
            {
                e.Node.ForeColor = Color.DarkBlue;
                treeView1.SelectedNode.BackColor = Color.WhiteSmoke;

            }
        }
        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Node == null || e.Bounds.IsEmpty) return;

            Color textColor = e.Node.ForeColor;
            if (textColor == Color.Empty || textColor.Name == "0")
                textColor = treeView1.ForeColor;

            if ((e.State & TreeNodeStates.Selected) != 0)
            {
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, e.Node.NodeFont ?? treeView1.Font, e.Bounds, textColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
            else
            {
                e.DrawDefault = true;
            }
        }
        //---------------------------------------------------
        // 2026-03-09 은비 - 캘린더 화면구현
        // 2026-03-10 은비 - 공휴일 추가
        //---------------------------------------------------

        private void DisplayDays(int year, int month)
        {
            flpMain.Controls.Clear();

            // 이번달 1일이 무슨 요일인지
            // 0:일요일 ~ 6:토요일
            DateTime startOfMonth = new DateTime(year, month, 1);
            int startDayOfWeek = (int)startOfMonth.DayOfWeek;

            Holidays holidays = new Holidays();
            var holiday = holidays.getHolidays(year);

            // 이번달의 마지막 날짜(28,30,31) 확인
            int LastDayOfCurMonth = DateTime.DaysInMonth(year, month);

            // 1일 시작 전 앞자리 빈칸 만들기
            for (int i = 0; i < startDayOfWeek; i++)
            {
                UserControl day = new DayUserControl();
                flpMain.Controls.Add(day);
            }

            // 실제 날짜 칸 생성 시작
            for (int i = 1; i <= LastDayOfCurMonth; i++)
            {
                DateTime dateForSlot = new DateTime(year, month, i);

                DayUserControl duc = new DayUserControl(i, dateForSlot);
                duc.Tag = dateForSlot;


                // 공휴일 이름까지 함께 처리
                if (holiday.ContainsKey(dateForSlot))
                {
                    // 딕셔너리에서 날짜(Key)로 이름(Value)을 찾아서 넘겨줌
                    string name = holiday[dateForSlot];
                    duc.SetHoliday(name);
                }
                else if (dateForSlot.DayOfWeek == DayOfWeek.Sunday)
                {
                    // 이름은 없지만 일요일인 경우
                    duc.SetColorRed();
                }
                else if (dateForSlot.DayOfWeek == DayOfWeek.Saturday)
                {
                    // 토요일인 경우 (파란색)
                    duc.SetColorBlue();
                }

                //// 오늘날짜 패널 포커싱
                //if (dateForSlot.Date == DateTime.Today)
                //{
                //    // 배경색을 조금 더 강조하거나 테두리 효과를 줍니다.
                //    duc.BackColor = Color.LightSteelBlue; // 선택된 느낌의 색상
                //    duc.BorderStyle = BorderStyle.FixedSingle; // 테두리 추가로 포커스 효과

                //    // 만약 폼이 로드되자마자 이 컨트롤로 스크롤을 맞추고 싶다면
                //    // duc.Select();
                //}


                // 승환(3/10)
                //flpMain.Controls.Add(duc);

                // 각 유저컨트롤에 클릭이벤트!!
                duc.Click += (s, e) =>
                {
                    MessageBox.Show(dateForSlot.ToString());
                    //===================================================
                    // 승환(3.10)+수영(3.10)
                    //===================================================
                    detailPopup popup = new detailPopup();
                    popup.selectedDate =  dateForSlot; //선택한 날짜가 뜨도록


                    if (popup.ShowDialog() == DialogResult.OK)
                    {
                        string title = popup.getDetailPopupTitle();
                        //수영 추가
                        Color color = popup.selectedColor;
                        //duc.addTitleLabel(title,color);

                        DateTime start = popup.StartDate;
                        DateTime end = popup.EndDate;

                        bool isSingleDay = (start.Date == end.Date);

                        for (DateTime d = start; d <= end; d = d.AddDays(1))
                        {
                            foreach (Control c in flpMain.Controls)
                            {
                                DayUserControl control = c as DayUserControl;
                                if (control != null && control._date.Date == d.Date)
                                {
                                    string labelText = (d.Date == start.Date) ? title : "";
                                    control.addTitleLabel(labelText, color, isSingleDay);
                                }
                            }
                        }

                    }
                };

                flpMain.Controls.Add(duc);
            }


        }

        // 전 달로 가는버튼 <
        private void btnBeforeDate_Click(object sender, EventArgs e)
        {
            currentMonth--;
            if (currentMonth < 1)
            {
                currentMonth = 12;
                currentYear--;
            }
            //lbThisDate.Text = currentYear.ToString() + "." + currentMonth.ToString();
            DisplayDays(currentYear, currentMonth);
        }

        // 다음 달로 가는버튼 >
        private void btnAfterDate_Click(object sender, EventArgs e)
        {
            currentMonth++;
            if (currentMonth > 12)
            {
                currentMonth = 1;
                currentYear++;
            }
            //lbThisDate.Text = currentYear.ToString() + "." + currentMonth.ToString();
            DisplayDays(currentYear, currentMonth);
        }

        // 은비 - 추가
        // 오늘 날짜로 찾아가는 버튼
        private void btnGoToday_Click(object sender, EventArgs e)
        {
            int todayYear = DateTime.Today.Year;
            int todayMonth = DateTime.Today.Month;

            currentYear = todayYear;
            currentMonth = todayMonth;

            DisplayDays(currentYear, currentMonth);
        }



        // 서현 - 로그인, 로그아웃 추가
        // 현재 UserSession에 저장된 아이디가 있는지 확인하여 화면의 글자들을 바꿔주는 역할을 한다.
        private void UpdateLoginLogout()
        {
            if (string.IsNullOrEmpty(UserSession.UserId))
            {
                // 1. 로그아웃 상태
                lbID.Text = "로그인 해주세요";
                btnLogInOut.Text = "로그인";

                RefreshTreeView(); //영현
            }
            else
            {
                lbID.Text = $"{UserSession.UserId}님 환영합니다!";
                btnLogInOut.Text = "로그아웃";

                RefreshTreeView(); //영현
            }
        }

        //시작하고 로그인 버튼 누를 시 발생하는 이벤트, 로그인 화면 이동
        private void btnLogInOut_Click(object sender, EventArgs e)
        {
            if (btnLogInOut.Text == "로그인")
            {
                // 로그인 창 띄우기
                logIn lin = new logIn();
                lin.ShowDialog();

                //로그인 창이 닫히면(성공/실패 여부 상관없이) 새로고침
                //UI 새로고침
                UpdateLoginLogout();
            }

            else
            {
                //로그아웃 확인 창 띄우기
                if (MessageBox.Show("로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // 세션 정보 초기화 및 UI복구
                    UserSession.UserId = null;
                    UpdateLoginLogout();
                    MessageBox.Show("성공적으로 로그아웃되었습니다.");
                }

            }
        }
        pnlDetail pnlDt = new pnlDetail();
        //수영
        public void ShowDetailPanel(DayUserControl day, string title)
        {
            if (!this.Controls.Contains(pnlDt)) { this.Controls.Add(pnlDt); }
            // DayUserControl 위치를 Form 기준 좌표로 변환
            Point pos = day.Parent.PointToScreen(day.Location);
            pos = this.PointToClient(pos);

            // 패널 위치 (오른쪽 아래)
            pnlDt.Location = new Point(
                pos.X + day.Width / 2,
                pos.Y + day.Height / 2
            );

            // 상세정보 표시
            //lblDetailTitle.Text = title;

            pnlDt.Visible = true;
            pnlDt.BringToFront();
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {

        }


        // 일정 검색해서 찾은 날 포커싱
        public void focusSearchEvents(DateTime targetDate)
        {
            // 1. 해당 연/월로 이동
            currentYear = targetDate.Year;
            currentMonth = targetDate.Month;

            // 2. 화면 다시 그리기
            DisplayDays(currentYear, currentMonth);

            // 3. 생성된 날짜 칸(DayUserControl)들 중에서 해당 날짜 찾아서 포커스
            foreach (Control control in flpMain.Controls)
            {
                if (control is DayUserControl duc && duc.Tag != null)
                {
                    // 각 날짜에 태그값 추가
                    DateTime ducDate = (DateTime)duc.Tag;

                    if (ducDate.Date == targetDate.Date)
                    {
                        //duc.BorderStyle = Color.LightSteelBlue;
                        duc.Focus(); // 컨트롤에 포커스 주기
                        break;
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 창 띄우기
            SearchEventForm searchForm = new SearchEventForm(txtSearch.Text);
            searchForm.ShowDialog();

        }
    }
}
