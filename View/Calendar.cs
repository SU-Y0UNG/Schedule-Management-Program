using Project_Maver.Common;

namespace Maver_켈린더
{
    public partial class Calendar : Form
    {

        public Calendar()
        {
            InitializeComponent();
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
        }

     
        private void btnToday_Click(object sender, EventArgs e)
        {
            //IDtest id = new IDtest(); // 여긴 임시로 아이디 폼에서 전역변수로 선언한 아이디가 제대로 다음 화면에서도 그 정보를 유지하는지 확인 한 것

            //id.ShowDialog();
        }
    }
}
