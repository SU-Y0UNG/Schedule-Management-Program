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
        // 승환(3/10)
        public void setDetailPopupText(string text)
        {
            //lbText.Text = text;
        }

        public void addTitleLabel(string text)
        {
            Label label = new Label();
            label.Text = text;
            label.AutoSize = true;
            label.MaximumSize = new Size(this.Width - 10, 0); // 칸 너비를 넘지 않게 설정
            label.Font = new Font("맑은 고딕", 9, FontStyle.Regular);
            label.BackColor = Color.LightBlue; // 구분하기 쉽게 색상 지정
            label.Margin = new Padding(3, 1, 3, 1);

            int currentControlsCount = this.Controls.Count;
            label.Location = new Point(5, 20 + (currentControlsCount * 20));

            //수영 추가
            label.Tag = text;

            label.Click += (s, e) =>
            {
                Maver_켈린더.Calendar calendar = this.FindForm() as Maver_켈린더.Calendar;

                if (calendar != null)
                {
                    string clickedTitle = (string)((Label)s).Tag;
                    calendar.ShowDetailPanel(this, clickedTitle);

                }
            };

            this.Controls.Add(label);
            label.BringToFront();
        }

        // 은비 추가
        public void SetHoliday(string holidayName)
        {
            // 1. 날짜 색상을 빨간색으로 변경
            if (lbDay != null) lbDay.ForeColor = Color.Red;

            // 2. 공휴일 이름 라벨에 텍스트 넣기
            // (디자인 창에서 lblHolidayName이라는 라벨을 미리 만들어두세요!)
            if (lbHolidayName != null)
            {
                lbHolidayName.Text = holidayName;
                lbHolidayName.ForeColor = Color.Red; // 이름도 빨간색으로
            }
        }

        // 빨간글씨 (일요일이나 공휴일)
        public void SetColorRed()
        {
            if (lbDay != null) // 날짜 숫자가 써있는 라벨 이름
            {
                lbDay.ForeColor = Color.Red;
            }
        }

        // 토요일 파란글씨
        public void SetColorBlue()
        {
            if (lbDay != null)
            {
                // 텍스트 색상을 파란색으로 변경
                lbDay.ForeColor = Color.Blue;
            }
        }

    }
}
