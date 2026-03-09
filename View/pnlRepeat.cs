using maverCalender;
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
    public partial class pnlRepeat : UserControl
    {

        //detailPopup detail = new detailPopup();
        public pnlRepeat()
        {
            InitializeComponent();
        }

        
   
        private int GetSelectedDays()
        {
            int days = 0;
            if (cbSun.Checked) days += 1;   // 2^0
            if (cbMon.Checked) days += 2;   // 2^1
            if (cbTue.Checked) days += 4;   // 2^2
            if (cbWed.Checked) days += 8;   // 2^3
            if (cbTur.Checked) days += 16;  // 2^4 = 16
            if (cbFri.Checked) days += 32;  // 2^5 = 32
            if (cbSat.Checked) days += 64;  // 2^6 = 64
                                            // ... 나머지 요일 합산
            return days; // DB에 이 정수 값을 저장
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void rbNon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNon.Checked)
            {
                dtpStartTime.Visible = false;
                dtpEndTime.Visible = false;
            }

        }

        private void rbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDate.Checked)
            {
                dtpStartTime.Visible = true;
                dtpEndTime.Visible = true;
            }
        }
              

        private void pnlRepeat_Load(object sender, EventArgs e)
        {
            
        }
    }
}
