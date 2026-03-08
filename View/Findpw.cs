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
            // 1. 아이디 입력 확인
            string inputID = txtId1.Text.Trim();

            if(string.IsNullOrEmpty(inputID))
            {
                MessageBox.Show("아이디를 입력해주세요");
                return;
            }

            string foundPw = JoinMember.FindUserPassword(inputID);

            if (foundPw !=null)
            {
                MessageBox.Show($"해당 아이디의 비밀번호는 [{foundPw}]입니다.");

                Updatepw upw = new Updatepw(inputID);
                upw.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("존재하지 않는 아이디입니다.");
            }
        }
    }
}
