namespace Project_Maver.View
{
    partial class pnlRepeat
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
            lbRepeatTitle = new Label();
            label2 = new Label();
            lbType = new Label();
            lbChoice = new Label();
            lbNum = new Label();
            lbChange = new Label();
            cbSun = new CheckBox();
            tbNum = new TextBox();
            cbMon = new CheckBox();
            cbTue = new CheckBox();
            cbWed = new CheckBox();
            cbTur = new CheckBox();
            cbFri = new CheckBox();
            cbSat = new CheckBox();
            lbTime = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            lbEnd = new Label();
            rbNon = new RadioButton();
            rbDate = new RadioButton();
            dtpStartTime = new DateTimePicker();
            dtpEndTime = new DateTimePicker();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbRepeatTitle
            // 
            lbRepeatTitle.AutoSize = true;
            lbRepeatTitle.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbRepeatTitle.Location = new Point(13, 9);
            lbRepeatTitle.Name = "lbRepeatTitle";
            lbRepeatTitle.Size = new Size(34, 17);
            lbRepeatTitle.TabIndex = 0;
            lbRepeatTitle.Text = "반복";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(-11, 17);
            label2.Name = "label2";
            label2.Size = new Size(464, 17);
            label2.TabIndex = 0;
            label2.Text = "____________________________________________________________________________";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(13, 45);
            lbType.Name = "lbType";
            lbType.Size = new Size(55, 15);
            lbType.TabIndex = 1;
            lbType.Text = "반복주기";
            // 
            // lbChoice
            // 
            lbChoice.AutoSize = true;
            lbChoice.Location = new Point(70, 45);
            lbChoice.Name = "lbChoice";
            lbChoice.Size = new Size(12, 15);
            lbChoice.TabIndex = 1;
            lbChoice.Text = "-";
            // 
            // lbNum
            // 
            lbNum.AutoSize = true;
            lbNum.Location = new Point(13, 73);
            lbNum.Name = "lbNum";
            lbNum.Size = new Size(31, 15);
            lbNum.TabIndex = 1;
            lbNum.Text = "주기";
            // 
            // lbChange
            // 
            lbChange.AutoSize = true;
            lbChange.Location = new Point(108, 73);
            lbChange.Name = "lbChange";
            lbChange.Size = new Size(19, 15);
            lbChange.TabIndex = 1;
            lbChange.Text = "주";
            // 
            // cbSun
            // 
            cbSun.AutoSize = true;
            cbSun.Location = new Point(74, 94);
            cbSun.Name = "cbSun";
            cbSun.Size = new Size(38, 19);
            cbSun.TabIndex = 2;
            cbSun.Text = "일";
            cbSun.UseVisualStyleBackColor = true;
            // 
            // tbNum
            // 
            tbNum.Location = new Point(70, 67);
            tbNum.Name = "tbNum";
            tbNum.Size = new Size(32, 23);
            tbNum.TabIndex = 3;
            // 
            // cbMon
            // 
            cbMon.AutoSize = true;
            cbMon.Location = new Point(118, 94);
            cbMon.Name = "cbMon";
            cbMon.Size = new Size(38, 19);
            cbMon.TabIndex = 2;
            cbMon.Text = "월";
            cbMon.UseVisualStyleBackColor = true;
            // 
            // cbTue
            // 
            cbTue.AutoSize = true;
            cbTue.Location = new Point(162, 94);
            cbTue.Name = "cbTue";
            cbTue.Size = new Size(38, 19);
            cbTue.TabIndex = 2;
            cbTue.Text = "화";
            cbTue.UseVisualStyleBackColor = true;
            // 
            // cbWed
            // 
            cbWed.AutoSize = true;
            cbWed.Location = new Point(206, 94);
            cbWed.Name = "cbWed";
            cbWed.Size = new Size(38, 19);
            cbWed.TabIndex = 2;
            cbWed.Text = "수";
            cbWed.UseVisualStyleBackColor = true;
            // 
            // cbTur
            // 
            cbTur.AutoSize = true;
            cbTur.Location = new Point(250, 94);
            cbTur.Name = "cbTur";
            cbTur.Size = new Size(38, 19);
            cbTur.TabIndex = 2;
            cbTur.Text = "목";
            cbTur.UseVisualStyleBackColor = true;
            // 
            // cbFri
            // 
            cbFri.AutoSize = true;
            cbFri.Location = new Point(294, 94);
            cbFri.Name = "cbFri";
            cbFri.Size = new Size(38, 19);
            cbFri.TabIndex = 2;
            cbFri.Text = "금";
            cbFri.UseVisualStyleBackColor = true;
            // 
            // cbSat
            // 
            cbSat.AutoSize = true;
            cbSat.Location = new Point(338, 94);
            cbSat.Name = "cbSat";
            cbSat.Size = new Size(38, 19);
            cbSat.TabIndex = 2;
            cbSat.Text = "토";
            cbSat.UseVisualStyleBackColor = true;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Location = new Point(13, 126);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(31, 15);
            lbTime.TabIndex = 1;
            lbTime.Text = "시간";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(70, 124);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(99, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(175, 124);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(99, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // lbEnd
            // 
            lbEnd.AutoSize = true;
            lbEnd.Location = new Point(13, 165);
            lbEnd.Name = "lbEnd";
            lbEnd.Size = new Size(31, 15);
            lbEnd.TabIndex = 1;
            lbEnd.Text = "종료";
            // 
            // rbNon
            // 
            rbNon.AutoSize = true;
            rbNon.Location = new Point(72, 162);
            rbNon.Name = "rbNon";
            rbNon.Size = new Size(49, 19);
            rbNon.TabIndex = 5;
            rbNon.TabStop = true;
            rbNon.Text = "없음";
            rbNon.UseVisualStyleBackColor = true;
            rbNon.CheckedChanged += rbNon_CheckedChanged;
            // 
            // rbDate
            // 
            rbDate.AutoSize = true;
            rbDate.Location = new Point(138, 163);
            rbDate.Name = "rbDate";
            rbDate.Size = new Size(49, 19);
            rbDate.TabIndex = 5;
            rbDate.TabStop = true;
            rbDate.Text = "날짜";
            rbDate.UseVisualStyleBackColor = true;
            rbDate.CheckedChanged += rbDate_CheckedChanged;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Short;
            dtpStartTime.Location = new Point(70, 189);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(99, 23);
            dtpStartTime.TabIndex = 4;
            // 
            // dtpEndTime
            // 
            dtpEndTime.Format = DateTimePickerFormat.Short;
            dtpEndTime.Location = new Point(175, 189);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(99, 23);
            dtpEndTime.TabIndex = 4;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(213, 246);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 6;
            btnOk.Text = "설정";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(301, 246);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pnlRepeat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(rbDate);
            Controls.Add(rbNon);
            Controls.Add(dateTimePicker2);
            Controls.Add(dtpEndTime);
            Controls.Add(dtpStartTime);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbNum);
            Controls.Add(cbSat);
            Controls.Add(cbFri);
            Controls.Add(cbTur);
            Controls.Add(cbWed);
            Controls.Add(cbTue);
            Controls.Add(cbMon);
            Controls.Add(cbSun);
            Controls.Add(lbChoice);
            Controls.Add(lbChange);
            Controls.Add(lbEnd);
            Controls.Add(lbTime);
            Controls.Add(lbNum);
            Controls.Add(lbType);
            Controls.Add(lbRepeatTitle);
            Controls.Add(label2);
            Location = new Point(108, 267);
            Name = "pnlRepeat";
            Size = new Size(394, 291);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbRepeatTitle;
        private Label label2;
        private Label lbType;
        private Label lbNum;
        private Label lbTime;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label lbEnd;
        private RadioButton rbNon;
        private RadioButton rbDate;
        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpEndTime;
        private Button btnOk;
        public Label lbChoice;
        public Label lbChange;
        public TextBox tbNum;
        public CheckBox cbSun;
        public CheckBox cbMon;
        public CheckBox cbTue;
        public CheckBox cbWed;
        public CheckBox cbTur;
        public CheckBox cbFri;
        public CheckBox cbSat;
        public Button btnCancel;
    }
}
