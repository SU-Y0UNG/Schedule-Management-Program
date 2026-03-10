namespace Maver_켈린더
{
    partial class JoinMembership
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinMembership));
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtPassWord = new TextBox();
            txtPwCheck = new TextBox();
            chkInfo = new CheckBox();
            btnJoin = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            txtId = new TextBox();
            label8 = new Label();
            cbMonth = new ComboBox();
            cbYear = new ComboBox();
            cbDay = new ComboBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            txtPhone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(20, 138);
            label1.Name = "label1";
            label1.Size = new Size(224, 37);
            label1.TabIndex = 0;
            label1.Text = "회원 가입을 위해";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(20, 175);
            label2.Name = "label2";
            label2.Size = new Size(269, 37);
            label2.TabIndex = 1;
            label2.Text = "정보를 입력해주세요";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 311);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 2;
            label4.Text = "* 이름";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 443);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 2;
            label5.Text = "* 비밀번호";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 515);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 2;
            label6.Text = "* 비밀번호 확인";
            // 
            // txtName
            // 
            txtName.Location = new Point(35, 343);
            txtName.Name = "txtName";
            txtName.Size = new Size(280, 23);
            txtName.TabIndex = 3;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(35, 475);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(280, 23);
            txtPassWord.TabIndex = 3;
            txtPassWord.UseSystemPasswordChar = true;
            // 
            // txtPwCheck
            // 
            txtPwCheck.Location = new Point(35, 547);
            txtPwCheck.Name = "txtPwCheck";
            txtPwCheck.PasswordChar = '*';
            txtPwCheck.Size = new Size(280, 23);
            txtPwCheck.TabIndex = 3;
            txtPwCheck.UseSystemPasswordChar = true;
            // 
            // chkInfo
            // 
            chkInfo.Location = new Point(20, 721);
            chkInfo.Name = "chkInfo";
            chkInfo.Size = new Size(305, 40);
            chkInfo.TabIndex = 5;
            chkInfo.Text = "이용약관 개인정보 수집 및 이용, 마케팅 활용 선택에 모두 동의합니다.";
            chkInfo.UseVisualStyleBackColor = true;
            // 
            // btnJoin
            // 
            btnJoin.BackColor = Color.MediumSeaGreen;
            btnJoin.FlatStyle = FlatStyle.Flat;
            btnJoin.ForeColor = Color.White;
            btnJoin.Location = new Point(20, 769);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(280, 50);
            btnJoin.TabIndex = 6;
            btnJoin.Text = "가입하기";
            btnJoin.UseVisualStyleBackColor = false;
            btnJoin.Click += btnJoin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 241);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 2;
            label7.Text = "* 아이디";
            // 
            // txtId
            // 
            txtId.Location = new Point(35, 272);
            txtId.Name = "txtId";
            txtId.Size = new Size(280, 23);
            txtId.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 590);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 8;
            label8.Text = "* 생년월일";
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Items.AddRange(new object[] { "1월", "2월", "3월", "4월", "5월", "6월", "7월", "8월", "9월", "10월", "11월", "12월" });
            cbMonth.Location = new Point(139, 617);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(71, 23);
            cbMonth.TabIndex = 10;
            cbMonth.SelectedIndexChanged += cbMonth_SelectedIndexChanged;
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(35, 617);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(72, 23);
            cbYear.TabIndex = 13;
            cbYear.SelectedIndexChanged += cbYear_SelectedIndexChanged;
            // 
            // cbDay
            // 
            cbDay.FormattingEnabled = true;
            cbDay.Location = new Point(244, 617);
            cbDay.Name = "cbDay";
            cbDay.Size = new Size(71, 23);
            cbDay.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 385);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "* 이메일";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(35, 417);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 23);
            txtEmail.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 658);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 2;
            label9.Text = "* 핸드폰";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(35, 690);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(280, 23);
            txtPhone.TabIndex = 3;
            // 
            // JoinMembership
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(372, 835);
            Controls.Add(cbDay);
            Controls.Add(cbYear);
            Controls.Add(cbMonth);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(btnJoin);
            Controls.Add(chkInfo);
            Controls.Add(txtPwCheck);
            Controls.Add(txtPassWord);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "JoinMembership";
            Text = "JoinMembership";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtPassWord;
        private TextBox txtPwCheck;
        private CheckBox chkInfo;
        private Button btnJoin;
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox txtId;
        private Label label8;
        private ComboBox cbMonth;
        private TextBox txtDay;
        private ComboBox cbYear;
        private ComboBox cbDay;
        private Label label3;
        private TextBox txtEmail;
        private Label label9;
        private TextBox txtPhone;
    }
}