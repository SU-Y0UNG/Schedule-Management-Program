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

        //로그인 클릭 이벤트
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtIdEmail2.Text; // 텍스트 박스에 아이디와 비밀번호를 입력하면 id와 pw에 저장한다.
            string pw = txtPassword2.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pw))
            {
                MessageBox.Show("아이디와 비밀번호를 모두 입력해주세요.");
                return;
            }

            bool isSuccess = JoinMember.LoginCheck(id, pw); 
            //JoinMember 로직을 호출해서 DB에 일치하는 회원이 있는지 확인한다. 

            if (isSuccess)
            {

                // 전역 변수 처럼 유저 아이디 값 입력 후 유저 정보를 저장한다.
                // 로그인에 성공하면 현재 사용자의 아이디를 UserSession을 통해 전역 변수로 저장된다.
                // 이러면 다른 화면에서도 누가 로그인 했는지 알 수 있다.
                UserSession.UserId = id;
                MessageBox.Show($"{UserSession.UserId}님, 환영합니다!");


                // 현재 로그인 창을 닫으면서 성공신호를 보낸다.
                this.DialogResult = DialogResult.OK;
                this.Close();
                //****************

                // 비밀번호 필드 초기화 (다시 돌아왔을 때 보안을 위해)
                txtPassword2.Clear();
            }

            else
            {
                // 5. 실패 시 메시지 처리
                MessageBox.Show("아이디(이메일) 또는 비밀번호를 다시 확인해주세요.", "로그인 실패");

                // 로그인 성공 후 로그아웃해서 다시 돌아오거나, 로그인에 실패했을 때 비밀번호 칸을 비워
                txtPassword2.Clear(); // 비번 칸 비워주기

                txtPassword2.Focus(); // 비번 칸에 커서 두기
            }
        }

        // 회원 가입 화면 이동
        // 회원 가입 링크버튼을 눌러서 실행한다.
        private void lklMember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1. 회원가입 폼 객체 생성
            JoinMembership joinForm = new JoinMembership();

            // 2. 창 띄우기
            // ShowDialog()는 가입 창이 닫힐 때까지 로그인 창을 조작할 수 없게 만듭니다.
            joinForm.ShowDialog();

            // 만약 가입 창을 띄우면서 로그인 창을 아예 숨기고 싶다면:
            // this.Hide();
            // joinForm.ShowDialog();
            // this.Show();
        }

        //아이디 찾기 화면 이동
        // 아이디 찾기 링크 버튼을 눌러서 실행한다.
        private void lklId_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1.아이디 찾기 폼 객체를 생성
            FindId fi = new FindId();

            // 창 띄우기
            fi.ShowDialog();
        }

        //비번 찾기 화면 이동
        // 비번 찾기 링크버튼을 눌러서 실행한다.
        private void lklPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1.비번 찾기 폼 객체를 생성
            Findpw fpw = new Findpw();

            // 창 띄우기
            fpw.ShowDialog();
        }
    }
}
