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
    public partial class pnlDetail : UserControl
    {
        public pnlDetail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pnlDetail_Load(object sender, EventArgs e)
        {

        }
        // 승환(3/10)
        public void setData(string title, string memo, string startDate, string endDate, string startTime, string endTime)
        {
            MessageBox.Show($"데이터 확인: {title} / {memo}");
            lbDetailTitle.Text = title;
            lbDetailMemo.Text = memo;
            lbDetailStartDate.Text = startDate;
            lbDetailEndDate.Text = endDate;
            lbDetailStartTime.Text = startTime;
            lbDetailEndTime.Text = endTime;

            this.Invalidate();
            this.Update();
            this.Visible = true;
        }

        private void btnSang_Click(object sender, EventArgs e)
        {
            // 1. 상세 팝업 객체 생성
            detailPopup popup = new detailPopup();

            // 2. '보기' 모드로 설정 (수정/삭제 버튼 활성화)
            popup.setMode("View");

            // 3. 현재 요약창에 떠 있는 텍스트들을 상세 팝업으로 전달 (매우 중요!)
            // 아래 레이블 이름(lbDetailTitle 등)은 실제 사용하시는 이름으로 확인하세요.
            popup.setDetailData(
                lbDetailTitle.Text,     // 제목
                lbDetailMemo.Text,      // 메모
                lbDetailStartDate.Text, // 시작일
                lbDetailEndDate.Text,   // 종료일
                lbDetailStartTime.Text, // 시작시간
                lbDetailEndTime.Text    // 종료시간
            );

            // 4. 팝업 띄우기
            popup.ShowDialog();
        }
    }
}
