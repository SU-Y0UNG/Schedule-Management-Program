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
            flpEvent.Click += ForwardClick;
            lbDay.Click += ForwardClick;
        }
        private void ForwardClick(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        public FlowLayoutPanel EventPanel
        {
            get { return flpEvent; }
        }
        // day = 요일, thisDate = 이 칸에 들어올 날짜
        public DayUserControl(int day, DateTime thisDate) 
        {
            InitializeComponent();
            flpEvent.Click += ForwardClick;
            lbDay.Click += ForwardClick;

            this.Margin = new Padding(0);
            this.Padding = new Padding(3);
            _date = thisDate;
            lbDay.Text = day.ToString();
            this.BorderStyle = BorderStyle.None;
            if (_date.Date == DateTime.Today)
            {
                this.BackColor = Color.LightSteelBlue;
                this.BorderStyle = BorderStyle.FixedSingle;
            }
        }
        public event Action<string> TitleLabelClicked;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // 진한 검정색 펜 생성 (두께 1)
            using (Pen pen = new Pen(Color.Black, 1))
            {
                // 1. 오른쪽 세로선 그리기
                e.Graphics.DrawLine(pen, this.Width - 1, 0, this.Width - 1, this.Height);

                // 2. 아래쪽 가로선 그리기
                e.Graphics.DrawLine(pen, 0, this.Height - 1, this.Width, this.Height - 1);

                // 2. [추가] 맨 왼쪽 칸들만 왼쪽 선을 그립니다.
                // 일요일이거나, X 좌표가 0인 위치에 배치된다면 왼쪽 선을 추가합니다.
                if (this.Left == 0 || _date.DayOfWeek == DayOfWeek.Sunday)
                {
                    e.Graphics.DrawLine(pen, 0, 0, 0, this.Height);
                }

                // 3. [추가] 맨 윗줄 칸들만 위쪽 선을 그립니다.
                // 1일부터 7일까지(첫째 줄)라면 위쪽 선을 추가합니다.
                // 또는 부모 컨테이너에서의 Top 좌표가 0인 경우로 체크해도 됩니다.
                if (_date.Day <= 7) // 캘린더 배치 로직에 따라 숫자는 조정될 수 있어요!
                {
                    e.Graphics.DrawLine(pen, 0, 0, this.Width, 0);
                }
            }
        }

        // 승환(3/10) + 수영 (색상, 연속색상)
        public void setDetailPopupText(string text)
        {
            //lbText.Text = text;
        }

        public void addTitleLabel(string text, Color color, bool isSingleDay)
        {

            Label label = new Label();
            label.Text = text;
            label.AutoSize = false;
            label.Width = this.flpEvent.Width;
            label.Height = 16; //라벨 크기(높이 조정)
            //label.Dock = DockStyle.Right;
            //label.MaximumSize = new Size(this.Width, 100); // 칸 너비를 넘지 않게 설정
            label.Font = new Font("맑은 고딕", 9, FontStyle.Regular);
            label.BackColor = color; // 구분하기 쉽게 색상 지정
            label.Margin = new Padding(0, 1, 0, 0);

            //this.flpEvent.Controls.Add(label);
            //label.BringToFront();
            flpEvent.Controls.Add(label); // 자동으로 아래로 쌓입니다.
            label.BringToFront();

            if (!isSingleDay)
            {
                int multiDayCount = 0;
                foreach (Control c in this.flpEvent.Controls)
                {
                    if (c.Tag != null && c.Tag.ToString().Contains("연속"))
                        multiDayCount++;
                }
                label.Tag = text + "_연속";
                label.BringToFront();
                this.flpEvent.Controls.Add(label);
                // 여러 날짜 걸친 일정은 맨 위로 보내기 위해 가장 먼저 추가
                this.flpEvent.Controls.SetChildIndex(label, multiDayCount);
            }
            else
            {
                label.Tag = text;
                label.BringToFront();
                // 단일 일정은 기본적으로 맨 뒤에 추가
                this.flpEvent.Controls.Add(label);
            }



            label.Click += (s, e) =>
            {
                // 승환 ////////////////////////////
                TitleLabelClicked?.Invoke(text);
                ////////////////////////////////////
                Maver_켈린더.Calendar calendar = this.FindForm() as Maver_켈린더.Calendar;

                if (calendar != null)
                {
                    string clickedTitle = (string)((Label)s).Tag;
                    calendar.ShowDetailPanel(this, clickedTitle);

                }
            };

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
