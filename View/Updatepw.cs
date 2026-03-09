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
    public partial class Updatepw : Form
    {
        private string targetId;

        // 생성자를 통해 아이디를 받아온다.
        public Updatepw(string id)
        {
            InitializeComponent();
            this.targetId = id;
        }

        private void btnFindPW_Click(object sender, EventArgs e)
        {
            // 새 비밀번호와 확인용 비밀번호가 일치하는지 검사
            if (txtNewPw.Text != txtCheckNewPw.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
                return;
            }

            // DB 업데이트 실행 (JoinMember.UpdatePassword 메서드 호출)
            if (JoinMember.UpdatePassword(targetId, txtNewPw.Text))
            {
                MessageBox.Show("비밀번호가 성공적으로 변경되었습니다.");
                this.Close();
            }

            else
            {
                MessageBox.Show("변경에 실패했습니다. 다시 시도해주세요");
            }
        }
    }
}
