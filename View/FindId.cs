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
    public partial class FindId : Form
    {
        public FindId()
        {
            InitializeComponent();
        }

        private void btnFindID_Click(object sender, EventArgs e)
        {
            // 1. 입력값 누락 확인
            if (String.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("이름과 이메일, 전화번호 모두 입력해주세요.");
                return;
            }

            // 2. JoinMember 클래스의 메서드 호출

            String foundId = JoinMember.FindUserId(txtName.Text, txtEmail.Text, txtPhone.Text);
            // JoinMember 클래스의 FindUserId 메서드에 텍스트 박스에 입력된 값들을 전달
            {
                // 3. 결과 처리
                if (foundId != null)
                {
                    MessageBox.Show($"{txtName.Text}님의 아이디는 [{foundId}] 입니다.");

                    //*****************서현****************************//
                    this.Close();
                    //************************************************//
                }

                else
                {
                    MessageBox.Show("일치하는 회원 정보가 없습니다.");
                }
               
            }

        }

        
    }
}
