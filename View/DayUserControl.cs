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
    public partial class DayUserControl : UserControl
    {
        // 이 칸의 날짜
        public DateTime _date;

        public DayUserControl()
        {
            InitializeComponent();
        }

        // day = 요일, thisDate = 이 칸에 들어올 날짜
        public DayUserControl(int day, DateTime thisDate) 
        {
            InitializeComponent();
            _date = thisDate;
            lbDay.Text = day.ToString();
        }
    }
}
