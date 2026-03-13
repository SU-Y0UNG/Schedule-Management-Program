namespace Project_Maver.View
{
    partial class pnlDetail
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            btnSang = new Button();
            btnClose = new Button();
            lbDetailTitle = new Label();
            lbDetailStartDate = new Label();
            lbDetailEndDate = new Label();
            lbDetailMemo = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSang
            // 
            btnSang.BackColor = Color.White;
            btnSang.FlatStyle = FlatStyle.Popup;
            btnSang.Location = new Point(98, 108);
            btnSang.Name = "btnSang";
            btnSang.Size = new Size(95, 23);
            btnSang.TabIndex = 1;
            btnSang.Text = "상세정보확인";
            btnSang.UseVisualStyleBackColor = false;
            btnSang.Click += btnSang_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(251, 97);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(48, 44);
            btnClose.TabIndex = 2;
            btnClose.Text = "닫기";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lbDetailTitle
            // 
            lbDetailTitle.AutoSize = true;
            lbDetailTitle.BorderStyle = BorderStyle.FixedSingle;
            lbDetailTitle.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbDetailTitle.Location = new Point(14, 10);
            lbDetailTitle.Name = "lbDetailTitle";
            lbDetailTitle.Size = new Size(2, 27);
            lbDetailTitle.TabIndex = 3;
            // 
            // lbDetailStartDate
            // 
            lbDetailStartDate.AutoSize = true;
            lbDetailStartDate.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbDetailStartDate.Location = new Point(68, 44);
            lbDetailStartDate.Name = "lbDetailStartDate";
            lbDetailStartDate.Size = new Size(0, 20);
            lbDetailStartDate.TabIndex = 3;
            // 
            // lbDetailEndDate
            // 
            lbDetailEndDate.AutoSize = true;
            lbDetailEndDate.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbDetailEndDate.Location = new Point(179, 44);
            lbDetailEndDate.Name = "lbDetailEndDate";
            lbDetailEndDate.Size = new Size(0, 20);
            lbDetailEndDate.TabIndex = 3;
            // 
            // lbDetailMemo
            // 
            lbDetailMemo.AutoSize = true;
            lbDetailMemo.Location = new Point(39, 73);
            lbDetailMemo.Name = "lbDetailMemo";
            lbDetailMemo.Size = new Size(0, 15);
            lbDetailMemo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(153, 44);
            label1.Name = "label1";
            label1.Size = new Size(20, 20);
            label1.TabIndex = 5;
            label1.Text = "~";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 44);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 6;
            label2.Text = "기간 :";
            // 
            // pnlDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label2);
            Controls.Add(lbDetailMemo);
            Controls.Add(lbDetailEndDate);
            Controls.Add(lbDetailStartDate);
            Controls.Add(lbDetailTitle);
            Controls.Add(btnClose);
            Controls.Add(btnSang);
            Controls.Add(label1);
            Location = new Point(14, 10);
            Name = "pnlDetail";
            Size = new Size(298, 140);
            Load += pnlDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSang;
        private Button btnClose;
        private Label lbDetailTitle;
        private Label lbDetailStartDate;
        private Label lbDetailEndDate;
        private Label lbDetailMemo;
        private Label label1;
        private Label label2;
    }
}
