using Project_Maver.Common;

namespace maverCalender
{
    partial class detailPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detailPopup));
            btnClose = new Button();
            lbTitle = new Label();
            cbChoice = new ComboBox();
            lbLine = new Label();
            lbLine5 = new Label();
            lbToday = new Label();
            lbStart = new Label();
            lbEnd = new Label();
            pbWatch = new PictureBox();
            pbOff = new PictureBox();
            pbWorld = new PictureBox();
            lbLine1 = new Label();
            lbLine2 = new Label();
            lbLine4 = new Label();
            lbReply = new Label();
            lbPlace = new Label();
            lbLine6 = new Label();
            lbLine7 = new Label();
            lbExplanation = new Label();
            lbInvite = new Label();
            lbLine8 = new Label();
            lbalert = new Label();
            lbLine9 = new Label();
            pbReply = new PictureBox();
            pbPlace = new PictureBox();
            pbExplanation = new PictureBox();
            pbInvite = new PictureBox();
            pbAlert = new PictureBox();
            btnSave = new Button();
            cbAlert = new ComboBox();
            btnPlus = new Button();
            pbOn = new PictureBox();
            btnLogin = new Button();
            dtpStartDate = new DateTimePicker();
            lblDesc = new Label();
            lblTemp = new Label();
            lblCity = new Label();
            pbWeather = new PictureBox();
            dtpEndDate = new DateTimePicker();
            dtpStartTime = new DateTimePicker();
            dtpEndTime = new DateTimePicker();
            txtTitle = new TextBox();
            cbWorldTime = new ComboBox();
            txtMemo = new TextBox();
            lbUserid = new Label();
            txtUserid = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            cbRepeat = new ComboBox();
            btnColor = new RoundButton();
            lbPlan = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lbWorldTime = new Label();
            btnMinus = new Button();
            lbStandardTime = new Label();
            ((System.ComponentModel.ISupportInitialize)pbWatch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbWorld).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbReply).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPlace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbExplanation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInvite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAlert).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbWeather).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(7, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(29, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(242, 16);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(34, 17);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "일정";
            // 
            // cbChoice
            // 
            cbChoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChoice.ForeColor = Color.Black;
            cbChoice.FormattingEnabled = true;
            cbChoice.Items.AddRange(new object[] { "내 캘린더" });
            cbChoice.Location = new Point(57, 67);
            cbChoice.Name = "cbChoice";
            cbChoice.Size = new Size(103, 23);
            cbChoice.TabIndex = 2;
            // 
            // lbLine
            // 
            lbLine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbLine.AutoSize = true;
            lbLine.ForeColor = Color.LightGray;
            lbLine.Location = new Point(57, 118);
            lbLine.Name = "lbLine";
            lbLine.Size = new Size(427, 15);
            lbLine.TabIndex = 3;
            lbLine.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbLine5
            // 
            lbLine5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbLine5.AutoSize = true;
            lbLine5.ForeColor = Color.LightGray;
            lbLine5.Location = new Point(57, 214);
            lbLine5.Name = "lbLine5";
            lbLine5.Size = new Size(427, 15);
            lbLine5.TabIndex = 3;
            lbLine5.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbToday
            // 
            lbToday.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbToday.AutoSize = true;
            lbToday.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbToday.ForeColor = Color.Gray;
            lbToday.Location = new Point(80, 141);
            lbToday.Name = "lbToday";
            lbToday.Size = new Size(31, 15);
            lbToday.TabIndex = 4;
            lbToday.Text = "종일";
            // 
            // lbStart
            // 
            lbStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbStart.AutoSize = true;
            lbStart.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbStart.ForeColor = Color.Black;
            lbStart.Location = new Point(80, 168);
            lbStart.Name = "lbStart";
            lbStart.Size = new Size(31, 15);
            lbStart.TabIndex = 4;
            lbStart.Text = "시작";
            // 
            // lbEnd
            // 
            lbEnd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbEnd.AutoSize = true;
            lbEnd.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbEnd.ForeColor = Color.Black;
            lbEnd.Location = new Point(80, 199);
            lbEnd.Name = "lbEnd";
            lbEnd.Size = new Size(31, 15);
            lbEnd.TabIndex = 4;
            lbEnd.Text = "종료";
            // 
            // pbWatch
            // 
            pbWatch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbWatch.Image = (Image)resources.GetObject("pbWatch.Image");
            pbWatch.Location = new Point(60, 141);
            pbWatch.Name = "pbWatch";
            pbWatch.Size = new Size(17, 15);
            pbWatch.SizeMode = PictureBoxSizeMode.Zoom;
            pbWatch.TabIndex = 5;
            pbWatch.TabStop = false;
            // 
            // pbOff
            // 
            pbOff.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbOff.Image = (Image)resources.GetObject("pbOff.Image");
            pbOff.Location = new Point(420, 138);
            pbOff.Name = "pbOff";
            pbOff.Size = new Size(35, 15);
            pbOff.SizeMode = PictureBoxSizeMode.Zoom;
            pbOff.TabIndex = 5;
            pbOff.TabStop = false;
            pbOff.Click += pbOff_Click;
            // 
            // pbWorld
            // 
            pbWorld.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbWorld.Image = (Image)resources.GetObject("pbWorld.Image");
            pbWorld.Location = new Point(60, 243);
            pbWorld.Name = "pbWorld";
            pbWorld.Size = new Size(17, 15);
            pbWorld.SizeMode = PictureBoxSizeMode.Zoom;
            pbWorld.TabIndex = 5;
            pbWorld.TabStop = false;
            // 
            // lbLine1
            // 
            lbLine1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbLine1.AutoSize = true;
            lbLine1.ForeColor = Color.LightGray;
            lbLine1.Location = new Point(57, 297);
            lbLine1.Name = "lbLine1";
            lbLine1.Size = new Size(427, 15);
            lbLine1.TabIndex = 3;
            lbLine1.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbLine2
            // 
            lbLine2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbLine2.AutoSize = true;
            lbLine2.ForeColor = Color.LightGray;
            lbLine2.Location = new Point(57, 344);
            lbLine2.Name = "lbLine2";
            lbLine2.Size = new Size(427, 15);
            lbLine2.TabIndex = 3;
            lbLine2.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbLine4
            // 
            lbLine4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbLine4.AutoSize = true;
            lbLine4.ForeColor = Color.LightGray;
            lbLine4.Location = new Point(57, 395);
            lbLine4.Name = "lbLine4";
            lbLine4.Size = new Size(427, 15);
            lbLine4.TabIndex = 3;
            lbLine4.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbReply
            // 
            lbReply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbReply.AutoSize = true;
            lbReply.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbReply.ForeColor = Color.Gray;
            lbReply.Location = new Point(80, 327);
            lbReply.Name = "lbReply";
            lbReply.Size = new Size(31, 15);
            lbReply.TabIndex = 4;
            lbReply.Text = "반복";
            // 
            // lbPlace
            // 
            lbPlace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbPlace.AutoSize = true;
            lbPlace.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbPlace.ForeColor = Color.Gray;
            lbPlace.Location = new Point(80, 378);
            lbPlace.Name = "lbPlace";
            lbPlace.Size = new Size(31, 15);
            lbPlace.TabIndex = 4;
            lbPlace.Text = "장소";
            // 
            // lbLine6
            // 
            lbLine6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbLine6.AutoSize = true;
            lbLine6.ForeColor = Color.LightGray;
            lbLine6.Location = new Point(57, 444);
            lbLine6.Name = "lbLine6";
            lbLine6.Size = new Size(427, 15);
            lbLine6.TabIndex = 3;
            lbLine6.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbLine7
            // 
            lbLine7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbLine7.AutoSize = true;
            lbLine7.ForeColor = Color.LightGray;
            lbLine7.Location = new Point(57, 495);
            lbLine7.Name = "lbLine7";
            lbLine7.Size = new Size(427, 15);
            lbLine7.TabIndex = 3;
            lbLine7.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbExplanation
            // 
            lbExplanation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbExplanation.AutoSize = true;
            lbExplanation.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbExplanation.ForeColor = Color.Gray;
            lbExplanation.Location = new Point(80, 427);
            lbExplanation.Name = "lbExplanation";
            lbExplanation.Size = new Size(31, 15);
            lbExplanation.TabIndex = 4;
            lbExplanation.Text = "메모";
            // 
            // lbInvite
            // 
            lbInvite.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbInvite.AutoSize = true;
            lbInvite.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbInvite.ForeColor = Color.Gray;
            lbInvite.Location = new Point(80, 478);
            lbInvite.Name = "lbInvite";
            lbInvite.Size = new Size(31, 15);
            lbInvite.TabIndex = 4;
            lbInvite.Text = "초대";
            // 
            // lbLine8
            // 
            lbLine8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbLine8.AutoSize = true;
            lbLine8.ForeColor = Color.LightGray;
            lbLine8.Location = new Point(77, 545);
            lbLine8.Name = "lbLine8";
            lbLine8.Size = new Size(407, 15);
            lbLine8.TabIndex = 3;
            lbLine8.Text = "________________________________________________________________________________\r\n";
            // 
            // lbalert
            // 
            lbalert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbalert.AutoSize = true;
            lbalert.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbalert.ForeColor = Color.Gray;
            lbalert.Location = new Point(80, 530);
            lbalert.Name = "lbalert";
            lbalert.Size = new Size(31, 15);
            lbalert.TabIndex = 4;
            lbalert.Text = "알림";
            // 
            // lbLine9
            // 
            lbLine9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbLine9.AutoSize = true;
            lbLine9.ForeColor = Color.LightGray;
            lbLine9.Location = new Point(57, 594);
            lbLine9.Name = "lbLine9";
            lbLine9.Size = new Size(427, 15);
            lbLine9.TabIndex = 3;
            lbLine9.Text = "____________________________________________________________________________________\r\n";
            // 
            // pbReply
            // 
            pbReply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbReply.Image = (Image)resources.GetObject("pbReply.Image");
            pbReply.Location = new Point(60, 327);
            pbReply.Name = "pbReply";
            pbReply.Size = new Size(17, 15);
            pbReply.SizeMode = PictureBoxSizeMode.Zoom;
            pbReply.TabIndex = 5;
            pbReply.TabStop = false;
            // 
            // pbPlace
            // 
            pbPlace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbPlace.Image = (Image)resources.GetObject("pbPlace.Image");
            pbPlace.Location = new Point(60, 377);
            pbPlace.Name = "pbPlace";
            pbPlace.Size = new Size(17, 15);
            pbPlace.SizeMode = PictureBoxSizeMode.Zoom;
            pbPlace.TabIndex = 5;
            pbPlace.TabStop = false;
            // 
            // pbExplanation
            // 
            pbExplanation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbExplanation.Image = (Image)resources.GetObject("pbExplanation.Image");
            pbExplanation.Location = new Point(60, 427);
            pbExplanation.Name = "pbExplanation";
            pbExplanation.Size = new Size(17, 15);
            pbExplanation.SizeMode = PictureBoxSizeMode.Zoom;
            pbExplanation.TabIndex = 5;
            pbExplanation.TabStop = false;
            // 
            // pbInvite
            // 
            pbInvite.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbInvite.Image = (Image)resources.GetObject("pbInvite.Image");
            pbInvite.Location = new Point(58, 476);
            pbInvite.Name = "pbInvite";
            pbInvite.Size = new Size(20, 17);
            pbInvite.SizeMode = PictureBoxSizeMode.Zoom;
            pbInvite.TabIndex = 5;
            pbInvite.TabStop = false;
            // 
            // pbAlert
            // 
            pbAlert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbAlert.Image = (Image)resources.GetObject("pbAlert.Image");
            pbAlert.Location = new Point(60, 530);
            pbAlert.Name = "pbAlert";
            pbAlert.Size = new Size(17, 15);
            pbAlert.SizeMode = PictureBoxSizeMode.Zoom;
            pbAlert.TabIndex = 5;
            pbAlert.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(451, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(44, 24);
            btnSave.TabIndex = 0;
            btnSave.Text = "저장";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbAlert
            // 
            cbAlert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbAlert.BackColor = Color.Snow;
            cbAlert.FormattingEnabled = true;
            cbAlert.Items.AddRange(new object[] { "알림없음", "정시", "5분 전", "10분 전", "15분 전", "30분 전", "1시간 전", "2시간 전", "3시간 전", "12시간 전", "1일(24시간) 전", "2일(48시간) 전", "1주일(168시간) 전" });
            cbAlert.Location = new Point(80, 568);
            cbAlert.Name = "cbAlert";
            cbAlert.Size = new Size(389, 23);
            cbAlert.TabIndex = 7;
            // 
            // btnPlus
            // 
            btnPlus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPlus.FlatAppearance.BorderSize = 0;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.ForeColor = Color.DimGray;
            btnPlus.Location = new Point(451, 515);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(29, 30);
            btnPlus.TabIndex = 0;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // pbOn
            // 
            pbOn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbOn.Image = (Image)resources.GetObject("pbOn.Image");
            pbOn.Location = new Point(420, 138);
            pbOn.Name = "pbOn";
            pbOn.Size = new Size(35, 15);
            pbOn.SizeMode = PictureBoxSizeMode.Zoom;
            pbOn.TabIndex = 5;
            pbOn.TabStop = false;
            pbOn.Click += pbOn_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Location = new Point(13, 677);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(53, 33);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Google";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpStartDate.Location = new Point(150, 163);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(179, 23);
            dtpStartDate.TabIndex = 9;
            // 
            // lblDesc
            // 
            lblDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(118, 723);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(31, 15);
            lblDesc.TabIndex = 10;
            lblDesc.Text = "desc";
            // 
            // lblTemp
            // 
            lblTemp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTemp.AutoSize = true;
            lblTemp.Location = new Point(54, 723);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(35, 15);
            lblTemp.TabIndex = 10;
            lblTemp.Text = "temp";
            // 
            // lblCity
            // 
            lblCity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCity.AutoSize = true;
            lblCity.Location = new Point(13, 723);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(26, 15);
            lblCity.TabIndex = 10;
            lblCity.Text = "city";
            // 
            // pbWeather
            // 
            pbWeather.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbWeather.Location = new Point(292, 715);
            pbWeather.Name = "pbWeather";
            pbWeather.Size = new Size(37, 34);
            pbWeather.SizeMode = PictureBoxSizeMode.StretchImage;
            pbWeather.TabIndex = 11;
            pbWeather.TabStop = false;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpEndDate.Location = new Point(150, 192);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(179, 23);
            dtpEndDate.TabIndex = 9;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(358, 163);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(97, 23);
            dtpStartTime.TabIndex = 9;

            // 
            // dtpEndTime
            // 
            dtpEndTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(358, 192);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(97, 23);
            dtpEndTime.TabIndex = 9;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.Location = new Point(137, 101);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(332, 23);
            txtTitle.TabIndex = 14;
            txtTitle.Text = " ";
            // 
            // cbWorldTime
            // 
            cbWorldTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbWorldTime.FormattingEnabled = true;
            cbWorldTime.Location = new Point(115, 239);
            cbWorldTime.Name = "cbWorldTime";
            cbWorldTime.Size = new Size(179, 23);
            cbWorldTime.TabIndex = 15;
            cbWorldTime.SelectedIndexChanged += cbWorldTime_SelectedIndexChanged;
            // 
            // txtMemo
            // 
            txtMemo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMemo.Location = new Point(117, 424);
            txtMemo.Name = "txtMemo";
            txtMemo.Size = new Size(352, 23);
            txtMemo.TabIndex = 16;
            txtMemo.Text = " ";
            // 
            // lbUserid
            // 
            lbUserid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbUserid.AutoSize = true;
            lbUserid.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbUserid.ForeColor = Color.Gray;
            lbUserid.Location = new Point(54, 41);
            lbUserid.Name = "lbUserid";
            lbUserid.Size = new Size(21, 17);
            lbUserid.TabIndex = 4;
            lbUserid.Text = "ID";
            // 
            // txtUserid
            // 
            txtUserid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUserid.Location = new Point(77, 38);
            txtUserid.Name = "txtUserid";
            txtUserid.Size = new Size(83, 23);
            txtUserid.TabIndex = 17;
            txtUserid.Text = " ";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Location = new Point(433, 639);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(44, 24);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.Location = new Point(383, 639);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(44, 24);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "수정";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbRepeat
            // 
            cbRepeat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbRepeat.FormattingEnabled = true;
            cbRepeat.Items.AddRange(new object[] { "매주", "매월", "매년" });
            cbRepeat.Location = new Point(115, 324);
            cbRepeat.Name = "cbRepeat";
            cbRepeat.Size = new Size(354, 23);
            cbRepeat.TabIndex = 20;
            cbRepeat.SelectedIndexChanged += cbRepeat_SelectedIndexChanged_1;
            // 
            // btnColor
            // 
            btnColor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnColor.BackColor = Color.Bisque;
            btnColor.FlatAppearance.BorderSize = 0;
            btnColor.FlatStyle = FlatStyle.Flat;
            btnColor.Location = new Point(60, 105);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(17, 17);
            btnColor.TabIndex = 21;
            btnColor.UseVisualStyleBackColor = false;
            btnColor.Click += btnColor_Click;
            // 
            // lbPlan
            // 
            lbPlan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbPlan.AutoSize = true;
            lbPlan.BackColor = Color.Transparent;
            lbPlan.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbPlan.ForeColor = Color.Gray;
            lbPlan.Location = new Point(86, 105);
            lbPlan.Name = "lbPlan";
            lbPlan.Size = new Size(47, 17);
            lbPlan.TabIndex = 4;
            lbPlan.Text = "일정명";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(115, 370);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 23);
            textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(115, 475);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(354, 23);
            textBox2.TabIndex = 22;
            // 
            // lbWorldTime
            // 
            lbWorldTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbWorldTime.AutoSize = true;
            lbWorldTime.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbWorldTime.ForeColor = Color.Gray;
            lbWorldTime.Location = new Point(80, 237);
            lbWorldTime.Name = "lbWorldTime";
            lbWorldTime.Size = new Size(31, 30);
            lbWorldTime.TabIndex = 4;
            lbWorldTime.Text = "표준\r\n시간";
            // 
            // btnMinus
            // 
            btnMinus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMinus.FlatAppearance.BorderSize = 0;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinus.ForeColor = Color.DimGray;
            btnMinus.Location = new Point(451, 515);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(29, 30);
            btnMinus.TabIndex = 0;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // lbStandardTime
            // 
            lbStandardTime.Location = new Point(115, 274);
            lbStandardTime.Name = "lbStandardTime";
            lbStandardTime.Size = new Size(179, 23);
            lbStandardTime.TabIndex = 23;
            // 
            // detailPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(534, 761);
            Controls.Add(lbStandardTime);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnColor);
            Controls.Add(cbRepeat);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(txtUserid);
            Controls.Add(txtMemo);
            Controls.Add(cbWorldTime);
            Controls.Add(pbWeather);
            Controls.Add(lblCity);
            Controls.Add(lblTemp);
            Controls.Add(dtpEndTime);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartTime);
            Controls.Add(lblDesc);
            Controls.Add(dtpStartDate);
            Controls.Add(btnLogin);
            Controls.Add(cbAlert);
            Controls.Add(pbOff);
            Controls.Add(pbAlert);
            Controls.Add(pbInvite);
            Controls.Add(pbExplanation);
            Controls.Add(pbPlace);
            Controls.Add(pbReply);
            Controls.Add(pbWorld);
            Controls.Add(pbWatch);
            Controls.Add(lbEnd);
            Controls.Add(lbStart);
            Controls.Add(lbalert);
            Controls.Add(lbInvite);
            Controls.Add(lbPlace);
            Controls.Add(lbExplanation);
            Controls.Add(lbWorldTime);
            Controls.Add(lbReply);
            Controls.Add(lbToday);
            Controls.Add(lbUserid);
            Controls.Add(lbPlan);
            Controls.Add(lbLine9);
            Controls.Add(lbLine8);
            Controls.Add(lbLine7);
            Controls.Add(lbLine6);
            Controls.Add(lbLine4);
            Controls.Add(lbLine2);
            Controls.Add(lbLine1);
            Controls.Add(lbLine5);
            Controls.Add(cbChoice);
            Controls.Add(lbTitle);
            Controls.Add(btnSave);
            Controls.Add(btnPlus);
            Controls.Add(btnClose);
            Controls.Add(txtTitle);
            Controls.Add(pbOn);
            Controls.Add(btnMinus);
            Controls.Add(lbLine);
            Name = "detailPopup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "detailPopup";
            Load += detailPopup_Load;
            ((System.ComponentModel.ISupportInitialize)pbWatch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOff).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbWorld).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbReply).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPlace).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbExplanation).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInvite).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAlert).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbWeather).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label lbTitle;
        private ComboBox cbChoice;
        private Label lbLine;
        private Label lbPlan;
        private Label lbLine5;
        private Label lbToday;
        private Label lbStart;
        private Label lbEnd;
        private PictureBox pbWatch;
        private PictureBox pbOff;
        private PictureBox pbWorld;
        private Label lbLine1;
        private Label lbLine2;
        private Label lbLine4;
        private Label lbReply;
        private Label lbPlace;
        private Label lbLine6;
        private Label lbLine7;
        private Label lbExplanation;
        private Label lbInvite;
        private Label lbLine8;
        private Label lbalert;
        private Label lbLine9;
        private PictureBox pbReply;
        private PictureBox pbPlace;
        private PictureBox pbExplanation;
        private PictureBox pbInvite;
        private PictureBox pbAlert;
        private Button btnSave;
        private ComboBox cbAlert;
        private Button btnPlus;
        private PictureBox pbOn;
        private Button btnLogin;
        private DateTimePicker dtpStartDate;
        private Label lblDesc;
        private Label lblTemp;
        private Label lblCity;
        private PictureBox pbWeather;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpEndTime;
        private RoundButton btnSelectColor;
        private ComboBox cbWorldTime;
        private TextBox txtMemo;
        private Label lbUserid;
        private TextBox txtUserid;
        private Button btnDelete;
        private Button btnUpdate;
        private RoundButton btnColor;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbWorldTime;
        public ComboBox cbRepeat;
        private Button btnMinus;
        private Label lbStandardTime;
        public TextBox txtTitle;
        //private RoundButton btnSelectColor;
    }
}