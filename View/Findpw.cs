using Project_Maver.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient; // DB연결을 위해 필요하다
using Project_Maver.Common;  // DbManager, 전역변수 UserSession사용

namespace Project_Maver.View
{
    public partial class Findpw : Form
    {
        public Findpw()
        {
            InitializeComponent();
        }

        private void btnFindPW_Click(object sender, EventArgs e)
        {
            // 서현 수정함 이번엔 JoinMember클래스를 사용하지 않고 여기서 직접 데이터베이스를 불러옴

            // 아이디, 이메일 입력 확인
            string inputID = txtId1.Text.Trim();
            string inputEmail = txtEmail1.Text.Trim();
            // Trim(): 사용자가 아이디 앞뒤에 실수로 넣은 공백을 자동으로 제거해준다.

            // 1. 입력 검증
            if (string.IsNullOrEmpty(inputID) || string.IsNullOrEmpty(inputEmail))
            {
                MessageBox.Show("아이디와 이메일을 모두 입력해주세요");
                return;
            }


            string checkSql = "SELECT * FROM user WHERE id = @id AND email = @email";
            Dictionary<string, object> checkParams = new Dictionary<string, object>
            {
                {"@id", inputID},
                {"@email", inputEmail}
            };

            DataTable dt = DbManager.select_Query(checkSql, checkParams);

            if (dt.Rows.Count > 0)
            {
                // 2.임시 비밀번호 생성(6자리 숫자 + 문자)
                string tempPw = CreateRandomPassword(6);

                // 3. 비밀번호 업데이트

                string updateSql = "UPDATE user SET pw = @pw WHERE id = @id";
                Dictionary<string, object> updateParams = new Dictionary<string, object>
                {
                    {"@pw", tempPw},
                    {"@id", inputID}
                };

                int result = DbManager.void_query(updateSql, updateParams);

                if (result > 0)
                {
                    // 4. 메세지 박스로 임시 비번 출력 후 창 닫기
                    MessageBox.Show($"{inputID}님의 임시 비밀번호가 발급되었습니다. \n\n" +
                        $"임시 비밀번호 : [{tempPw}]\n\n" +
                        "로그인 후 반드시 비밀번호를 변경해주세요.");

                    this.Close();
                }
            }

            else
            {
                MessageBox.Show("일치하는 회원이 없습니다.");
            }
        }


        // 랜덤 비밀번호 생성기
        private string CreateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder result = new StringBuilder();
            Random rnd = new Random();

            for(int i=0; i < length; i++)
            {
                result.Append(chars[rnd.Next(chars.Length)]);
            }

            return result.ToString();
        }

    }
}
