using maverCalender;
using Project_Maver.Common;
using Project_Maver.View;

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

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // 1. 사용자에게 정말 로그아웃할지 물어봅니다 (선택 사항)
            DialogResult result = MessageBox.Show("로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // 2. 전역 변수에 저장된 로그인 정보를 비웁니다 (보안)
                UserSession.Logout();

                // 3. 현재 캘린더 창을 닫습니다.
                this.Close();

                // 이 Close()가 호출되면, 로그인 창의 'calendarForm.ShowDialog()'가 종료되면서
                // 그 다음 줄인 'this.Show()'가 실행되어 로그인 창이 다시 뜹니다.
            }
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            // 전역 변수 UserSession에서 아이디를 가져와 라벨에 표시
            if (UserSession.UserId != null)
            {
                lbID.Text = UserSession.UserId + "님 접속 중";
            }

            DisplayDays(currentYear, currentMonth);
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

        //---------------------------------------------------
        // 2026-03-09 은비 - 캘린더 화면구현
        //---------------------------------------------------

        private void DisplayDays(int year, int month)
        {
            flpMain.Controls.Clear();

            // 이번달 1일이 무슨 요일인지
            // 0:일요일 ~ 6:토요일
            DateTime startOfMonth = new DateTime(year, month, 1);
            int startDayOfWeek = (int)startOfMonth.DayOfWeek;


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

                // 승환(3/10)
                flpMain.Controls.Add(duc);

                // 각 유저컨트롤에 클릭이벤트!!
                duc.Click += (s, e) =>
                {
                    MessageBox.Show(dateForSlot.ToString());
                    //===================================================
                    // 승환(3.10)
                    //===================================================
                    detailPopup popup = new detailPopup();
                    //popup.ShowDialog();

                    if(popup.ShowDialog() == DialogResult.OK)
                    {
                        string title = popup.getDetailPopupTitle();
                        duc.addTitleLabel(title);
                    }
                };

                flpMain.Controls.Add(duc);
            }


        }

        private void btnBeforeDate_Click(object sender, EventArgs e)
        {
            currentMonth--;
            if (currentMonth < 1)
            {
                currentMonth = 12;
                currentYear --;
            }
            lbThisDate.Text = currentYear.ToString() + "." + currentMonth.ToString();
            DisplayDays(currentYear,currentMonth);
        }

        private void btnAfterDate_Click(object sender, EventArgs e)
        {
            currentMonth++;
            if (currentMonth > 12)
            {
                currentMonth = 1;
                currentYear++;
            }
            lbThisDate.Text = currentYear.ToString() + "." + currentMonth.ToString();
            DisplayDays(currentYear, currentMonth);
        }
    }
}
