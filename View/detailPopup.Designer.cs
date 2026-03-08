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
            lbPlan = new Label();
            lbLine5 = new Label();
            lbToday = new Label();
            lbStart = new Label();
            lbEnd = new Label();
            pbWatch = new PictureBox();
            pbOff = new PictureBox();
            pbWorld = new PictureBox();
            pictureBox2 = new PictureBox();
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
            cb = new ComboBox();
            btnAdd = new Button();
            pbOn = new PictureBox();
            btnLogin = new Button();
            dtpStartDate = new DateTimePicker();
            lblDesc = new Label();
            lblTemp = new Label();
            lblCity = new Label();
            pictureBoxWeather = new PictureBox();
            btnGetWeather = new Button();
            dtpEndDate = new DateTimePicker();
            dtpStartTime = new DateTimePicker();
            dtpEndTime = new DateTimePicker();
            btnSelectColor = new RoundButton();
            txtTitle = new TextBox();
            cbWorldTime = new ComboBox();
            txtMemo = new TextBox();
            lbUserid = new Label();
            txtUserid = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)pbWatch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbWorld).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbReply).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPlace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbExplanation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInvite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAlert).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeather).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(3, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(29, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(237, 7);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(34, 17);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "일정";
            // 
            // cbChoice
            // 
            cbChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChoice.FlatStyle = FlatStyle.Flat;
            cbChoice.FormattingEnabled = true;
            cbChoice.Items.AddRange(new object[] { "내 캘린더" });
            cbChoice.Location = new Point(41, 32);
            cbChoice.Name = "cbChoice";
            cbChoice.Size = new Size(78, 23);
            cbChoice.TabIndex = 2;
            // 
            // lbLine
            // 
            lbLine.AutoSize = true;
            lbLine.ForeColor = Color.LightGray;
            lbLine.Location = new Point(41, 83);
            lbLine.Name = "lbLine";
            lbLine.Size = new Size(427, 15);
            lbLine.TabIndex = 3;
            lbLine.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbPlan
            // 
            lbPlan.AutoSize = true;
            lbPlan.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbPlan.ForeColor = Color.Gray;
            lbPlan.Location = new Point(64, 71);
            lbPlan.Name = "lbPlan";
            lbPlan.Size = new Size(120, 17);
            lbPlan.TabIndex = 4;
            lbPlan.Text = "일정을 입력하세요.";
            // 
            // lbLine5
            // 
            lbLine5.AutoSize = true;
            lbLine5.ForeColor = Color.LightGray;
            lbLine5.Location = new Point(41, 179);
            lbLine5.Name = "lbLine5";
            lbLine5.Size = new Size(427, 15);
            lbLine5.TabIndex = 3;
            lbLine5.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbToday
            // 
            lbToday.AutoSize = true;
            lbToday.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbToday.ForeColor = Color.Gray;
            lbToday.Location = new Point(64, 106);
            lbToday.Name = "lbToday";
            lbToday.Size = new Size(31, 15);
            lbToday.TabIndex = 4;
            lbToday.Text = "종일";
            // 
            // lbStart
            // 
            lbStart.AutoSize = true;
            lbStart.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbStart.ForeColor = Color.Black;
            lbStart.Location = new Point(64, 133);
            lbStart.Name = "lbStart";
            lbStart.Size = new Size(31, 15);
            lbStart.TabIndex = 4;
            lbStart.Text = "시작";
            // 
            // lbEnd
            // 
            lbEnd.AutoSize = true;
            lbEnd.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbEnd.ForeColor = Color.Black;
            lbEnd.Location = new Point(64, 164);
            lbEnd.Name = "lbEnd";
            lbEnd.Size = new Size(31, 15);
            lbEnd.TabIndex = 4;
            lbEnd.Text = "종료";
            // 
            // pbWatch
            // 
            pbWatch.Image = (Image)resources.GetObject("pbWatch.Image");
            pbWatch.Location = new Point(44, 106);
            pbWatch.Name = "pbWatch";
            pbWatch.Size = new Size(17, 15);
            pbWatch.SizeMode = PictureBoxSizeMode.Zoom;
            pbWatch.TabIndex = 5;
            pbWatch.TabStop = false;
            // 
            // pbOff
            // 
            pbOff.Image = (Image)resources.GetObject("pbOff.Image");
            pbOff.Location = new Point(415, 106);
            pbOff.Name = "pbOff";
            pbOff.Size = new Size(35, 15);
            pbOff.SizeMode = PictureBoxSizeMode.Zoom;
            pbOff.TabIndex = 5;
            pbOff.TabStop = false;
            // 
            // pbWorld
            // 
            pbWorld.Image = (Image)resources.GetObject("pbWorld.Image");
            pbWorld.Location = new Point(44, 207);
            pbWorld.Name = "pbWorld";
            pbWorld.Size = new Size(17, 15);
            pbWorld.SizeMode = PictureBoxSizeMode.Zoom;
            pbWorld.TabIndex = 5;
            pbWorld.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(435, 202);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lbLine1
            // 
            lbLine1.AutoSize = true;
            lbLine1.ForeColor = Color.LightGray;
            lbLine1.Location = new Point(12, 228);
            lbLine1.Name = "lbLine1";
            lbLine1.Size = new Size(427, 15);
            lbLine1.TabIndex = 3;
            lbLine1.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbLine2
            // 
            lbLine2.AutoSize = true;
            lbLine2.ForeColor = Color.LightGray;
            lbLine2.Location = new Point(41, 277);
            lbLine2.Name = "lbLine2";
            lbLine2.Size = new Size(427, 15);
            lbLine2.TabIndex = 3;
            lbLine2.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbLine4
            // 
            lbLine4.AutoSize = true;
            lbLine4.ForeColor = Color.LightGray;
            lbLine4.Location = new Point(41, 328);
            lbLine4.Name = "lbLine4";
            lbLine4.Size = new Size(427, 15);
            lbLine4.TabIndex = 3;
            lbLine4.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbReply
            // 
            lbReply.AutoSize = true;
            lbReply.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbReply.ForeColor = Color.Gray;
            lbReply.Location = new Point(64, 260);
            lbReply.Name = "lbReply";
            lbReply.Size = new Size(31, 15);
            lbReply.TabIndex = 4;
            lbReply.Text = "반복";
            // 
            // lbPlace
            // 
            lbPlace.AutoSize = true;
            lbPlace.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbPlace.ForeColor = Color.Gray;
            lbPlace.Location = new Point(64, 311);
            lbPlace.Name = "lbPlace";
            lbPlace.Size = new Size(31, 15);
            lbPlace.TabIndex = 4;
            lbPlace.Text = "장소";
            // 
            // lbLine6
            // 
            lbLine6.AutoSize = true;
            lbLine6.ForeColor = Color.LightGray;
            lbLine6.Location = new Point(41, 377);
            lbLine6.Name = "lbLine6";
            lbLine6.Size = new Size(427, 15);
            lbLine6.TabIndex = 3;
            lbLine6.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbLine7
            // 
            lbLine7.AutoSize = true;
            lbLine7.ForeColor = Color.LightGray;
            lbLine7.Location = new Point(41, 428);
            lbLine7.Name = "lbLine7";
            lbLine7.Size = new Size(427, 15);
            lbLine7.TabIndex = 3;
            lbLine7.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbExplanation
            // 
            lbExplanation.AutoSize = true;
            lbExplanation.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbExplanation.ForeColor = Color.Gray;
            lbExplanation.Location = new Point(64, 360);
            lbExplanation.Name = "lbExplanation";
            lbExplanation.Size = new Size(31, 15);
            lbExplanation.TabIndex = 4;
            lbExplanation.Text = "메모";
            // 
            // lbInvite
            // 
            lbInvite.AutoSize = true;
            lbInvite.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbInvite.ForeColor = Color.Gray;
            lbInvite.Location = new Point(64, 411);
            lbInvite.Name = "lbInvite";
            lbInvite.Size = new Size(31, 15);
            lbInvite.TabIndex = 4;
            lbInvite.Text = "초대";
            // 
            // lbLine8
            // 
            lbLine8.AutoSize = true;
            lbLine8.ForeColor = Color.LightGray;
            lbLine8.Location = new Point(61, 478);
            lbLine8.Name = "lbLine8";
            lbLine8.Size = new Size(407, 15);
            lbLine8.TabIndex = 3;
            lbLine8.Text = "________________________________________________________________________________\r\n";
            // 
            // lbalert
            // 
            lbalert.AutoSize = true;
            lbalert.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbalert.ForeColor = Color.Gray;
            lbalert.Location = new Point(64, 463);
            lbalert.Name = "lbalert";
            lbalert.Size = new Size(31, 15);
            lbalert.TabIndex = 4;
            lbalert.Text = "알림";
            // 
            // lbLine9
            // 
            lbLine9.AutoSize = true;
            lbLine9.ForeColor = Color.LightGray;
            lbLine9.Location = new Point(41, 527);
            lbLine9.Name = "lbLine9";
            lbLine9.Size = new Size(427, 15);
            lbLine9.TabIndex = 3;
            lbLine9.Text = "____________________________________________________________________________________\r\n";
            // 
            // pbReply
            // 
            pbReply.Image = (Image)resources.GetObject("pbReply.Image");
            pbReply.Location = new Point(44, 260);
            pbReply.Name = "pbReply";
            pbReply.Size = new Size(17, 15);
            pbReply.SizeMode = PictureBoxSizeMode.Zoom;
            pbReply.TabIndex = 5;
            pbReply.TabStop = false;
            // 
            // pbPlace
            // 
            pbPlace.Image = (Image)resources.GetObject("pbPlace.Image");
            pbPlace.Location = new Point(44, 310);
            pbPlace.Name = "pbPlace";
            pbPlace.Size = new Size(17, 15);
            pbPlace.SizeMode = PictureBoxSizeMode.Zoom;
            pbPlace.TabIndex = 5;
            pbPlace.TabStop = false;
            // 
            // pbExplanation
            // 
            pbExplanation.Image = (Image)resources.GetObject("pbExplanation.Image");
            pbExplanation.Location = new Point(44, 360);
            pbExplanation.Name = "pbExplanation";
            pbExplanation.Size = new Size(17, 15);
            pbExplanation.SizeMode = PictureBoxSizeMode.Zoom;
            pbExplanation.TabIndex = 5;
            pbExplanation.TabStop = false;
            // 
            // pbInvite
            // 
            pbInvite.Image = (Image)resources.GetObject("pbInvite.Image");
            pbInvite.Location = new Point(42, 409);
            pbInvite.Name = "pbInvite";
            pbInvite.Size = new Size(20, 17);
            pbInvite.SizeMode = PictureBoxSizeMode.Zoom;
            pbInvite.TabIndex = 5;
            pbInvite.TabStop = false;
            // 
            // pbAlert
            // 
            pbAlert.Image = (Image)resources.GetObject("pbAlert.Image");
            pbAlert.Location = new Point(44, 463);
            pbAlert.Name = "pbAlert";
            pbAlert.Size = new Size(17, 15);
            pbAlert.SizeMode = PictureBoxSizeMode.Zoom;
            pbAlert.TabIndex = 5;
            pbAlert.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(456, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(44, 30);
            btnSave.TabIndex = 0;
            btnSave.Text = "저장";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cb
            // 
            cb.BackColor = Color.Snow;
            cb.FormattingEnabled = true;
            cb.Items.AddRange(new object[] { "알림없음", "정시", "5분 전", "10분 전", "15분 전", "30분 전", "1시간 전", "2시간 전", "3시간 전", "12시간 전", "1일(24시간) 전", "2일(48시간) 전", "1주일(168시간) 전" });
            cb.Location = new Point(61, 501);
            cb.Name = "cb";
            cb.Size = new Size(376, 23);
            cb.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.DimGray;
            btnAdd.Location = new Point(435, 448);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(29, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // pbOn
            // 
            pbOn.Image = (Image)resources.GetObject("pbOn.Image");
            pbOn.Location = new Point(415, 106);
            pbOn.Name = "pbOn";
            pbOn.Size = new Size(35, 15);
            pbOn.SizeMode = PictureBoxSizeMode.Zoom;
            pbOn.TabIndex = 5;
            pbOn.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(199, 626);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(154, 127);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(179, 23);
            dtpStartDate.TabIndex = 9;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(185, 686);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(31, 15);
            lblDesc.TabIndex = 10;
            lblDesc.Text = "desc";
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Location = new Point(121, 686);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(35, 15);
            lblTemp.TabIndex = 10;
            lblTemp.Text = "temp";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(80, 686);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(26, 15);
            lblCity.TabIndex = 10;
            lblCity.Text = "city";
            // 
            // pictureBoxWeather
            // 
            pictureBoxWeather.Location = new Point(237, 678);
            pictureBoxWeather.Name = "pictureBoxWeather";
            pictureBoxWeather.Size = new Size(37, 34);
            pictureBoxWeather.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxWeather.TabIndex = 11;
            pictureBoxWeather.TabStop = false;
            // 
            // btnGetWeather
            // 
            btnGetWeather.Location = new Point(362, 678);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(75, 23);
            btnGetWeather.TabIndex = 12;
            btnGetWeather.Text = "button1";
            btnGetWeather.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(154, 156);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(179, 23);
            dtpEndDate.TabIndex = 9;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(362, 127);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(97, 23);
            dtpStartTime.TabIndex = 9;
            // 
            // dtpEndTime
            // 
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(362, 156);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(97, 23);
            dtpEndTime.TabIndex = 9;
            // 
            // btnSelectColor
            // 
            btnSelectColor.BackColor = Color.SkyBlue;
            btnSelectColor.FlatAppearance.BorderSize = 0;
            btnSelectColor.FlatStyle = FlatStyle.Flat;
            btnSelectColor.Location = new Point(45, 70);
            btnSelectColor.Name = "btnSelectColor";
            btnSelectColor.Size = new Size(17, 17);
            btnSelectColor.TabIndex = 13;
            btnSelectColor.UseVisualStyleBackColor = false;
            btnSelectColor.Click += btnSelectColor_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(185, 68);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(274, 23);
            txtTitle.TabIndex = 14;
            // 
            // cbWorldTime
            // 
            cbWorldTime.FormattingEnabled = true;
            cbWorldTime.Location = new Point(80, 205);
            cbWorldTime.Name = "cbWorldTime";
            cbWorldTime.Size = new Size(349, 23);
            cbWorldTime.TabIndex = 15;
            cbWorldTime.SelectedIndexChanged += cbWorldTime_SelectedIndexChanged;
            // 
            // txtMemo
            // 
            txtMemo.Location = new Point(101, 357);
            txtMemo.Name = "txtMemo";
            txtMemo.Size = new Size(358, 23);
            txtMemo.TabIndex = 16;
            // 
            // lbUserid
            // 
            lbUserid.AutoSize = true;
            lbUserid.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbUserid.ForeColor = Color.Gray;
            lbUserid.Location = new Point(125, 38);
            lbUserid.Name = "lbUserid";
            lbUserid.Size = new Size(65, 17);
            lbUserid.TabIndex = 4;
            lbUserid.Text = "사용자 ID";
            // 
            // txtUserid
            // 
            txtUserid.Location = new Point(199, 32);
            txtUserid.Name = "txtUserid";
            txtUserid.Size = new Size(134, 23);
            txtUserid.TabIndex = 17;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(406, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(44, 23);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(356, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(44, 23);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "수정";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // detailPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(534, 761);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(txtUserid);
            Controls.Add(txtMemo);
            Controls.Add(cbWorldTime);
            Controls.Add(txtTitle);
            Controls.Add(btnSelectColor);
            Controls.Add(btnGetWeather);
            Controls.Add(pictureBoxWeather);
            Controls.Add(lblCity);
            Controls.Add(lblTemp);
            Controls.Add(dtpEndTime);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartTime);
            Controls.Add(lblDesc);
            Controls.Add(dtpStartDate);
            Controls.Add(btnLogin);
            Controls.Add(cb);
            Controls.Add(pbOn);
            Controls.Add(pbOff);
            Controls.Add(pictureBox2);
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
            Controls.Add(lbLine);
            Controls.Add(cbChoice);
            Controls.Add(lbTitle);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(btnClose);
            Name = "detailPopup";
            Text = "detailPopup";
            Load += detailPopup_Load;
            ((System.ComponentModel.ISupportInitialize)pbWatch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOff).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbWorld).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbReply).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPlace).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbExplanation).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInvite).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAlert).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeather).EndInit();
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
        private PictureBox pictureBox2;
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
        private ComboBox cb;
        private Button btnAdd;
        private PictureBox pbOn;
        private Button btnLogin;
        private DateTimePicker dtpStartDate;
        private Label lblDesc;
        private Label lblTemp;
        private Label lblCity;
        private PictureBox pictureBoxWeather;
        private Button btnGetWeather;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpEndTime;
        private RoundButton btnSelectColor;
        private TextBox txtTitle;
        private ComboBox cbWorldTime;
        private TextBox txtMemo;
        private Label lbUserid;
        private TextBox txtUserid;
        private Button btnDelete;
        private Button btnUpdate;
        //private RoundButton btnSelectColor;
    }
}