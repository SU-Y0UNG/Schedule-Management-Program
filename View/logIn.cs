using Maver_켈린더;
using Project_Maver.Common;
using Project_Maver.View;

namespace maverCalender
{
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtIdEmail2.Text;
            string pw = txtPassword2.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pw))
            {
                MessageBox.Show("아이디와 비밀번호를 모두 입력해주세요.");
                return;
            }

            bool isSuccess = JoinMember.LoginCheck(id, pw);

            if (isSuccess)
            {

                //전역 변수 처럼 유저 아이디 값 입력 후 저장
                UserSession.UserId = id;
                MessageBox.Show($"{UserSession.UserId}님, 환영합니다!");

                this.Hide();

                // 로그인 창 숨기기

                // 캘린더 폼 생성 시 아이디를 인자로 전달
                Calendar calendarForm = new Calendar();

                // 캘린더 창을 띄우고, 닫힐 때까지 대기
                calendarForm.ShowDialog();

                // 캘린더 창이 닫히면(로그아웃 등) 다시 로그인 창을 보여줌
                this.Show();

                // 비밀번호 필드 초기화 (다시 돌아왔을 때 보안을 위해)
                txtPassword2.Clear();
            }

            else
            {
                // 5. 실패 시 메시지 처리
                MessageBox.Show("아이디(이메일) 또는 비밀번호를 다시 확인해주세요.", "로그인 실패");
                txtPassword2.Clear(); // 비번 칸 비워주기
                txtPassword2.Focus(); // 비번 칸에 커서 두기
            }
        }

        // 회원 가입 화면 이동
        private void lklMember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1. 회원가입 폼 객체 생성
            JoinMembership joinForm = new JoinMembership();

            // 2. 창 띄우기 (ShowDialog 방식 추천)
            // ShowDialog()는 가입 창이 닫힐 때까지 로그인 창을 조작할 수 없게 만듭니다.
            joinForm.ShowDialog();

            // 만약 가입 창을 띄우면서 로그인 창을 아예 숨기고 싶다면:
            // this.Hide();
            // joinForm.ShowDialog();
            // this.Show();
        }

        //아이디 찾기 화면 이동
        private void lklId_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1.아이디 찾기 폼 객체를 생성
            FindId fi = new FindId();

            // 창 띄우기
            fi.ShowDialog();
        }

        //비번 찾기 화면 이동
        private void lklPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1.비번 찾기 폼 객체를 생성
            Findpw fpw = new Findpw();

            // 창 띄우기
            fpw.ShowDialog();
        }
    }
}
