namespace maverCalender
{
    partial class logIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logIn));
            pictureBox1 = new PictureBox();
            txtIdEmail2 = new TextBox();
            txtPassword2 = new TextBox();
            btnLogin = new Button();
            rbSave = new RadioButton();
            lklId = new LinkLabel();
            lklPW = new LinkLabel();
            lklMember = new LinkLabel();
            pbGoogle = new PictureBox();
            btnGoogle = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGoogle).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(287, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtIdEmail2
            // 
            txtIdEmail2.Font = new Font("Noto Sans KR", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdEmail2.Location = new Point(252, 144);
            txtIdEmail2.Name = "txtIdEmail2";
            txtIdEmail2.PlaceholderText = "아이디 또는 이메일";
            txtIdEmail2.Size = new Size(252, 26);
            txtIdEmail2.TabIndex = 0;
            txtIdEmail2.KeyDown += txtIdEmail2_KeyDown;
            // 
            // txtPassword2
            // 
            txtPassword2.Font = new Font("Noto Sans KR", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword2.Location = new Point(252, 173);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.PasswordChar = '*';
            txtPassword2.PlaceholderText = "비밀번호";
            txtPassword2.Size = new Size(252, 26);
            txtPassword2.TabIndex = 1;
            txtPassword2.KeyDown += txtPassword2_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Silver;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Noto Sans KR", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(242, 202);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(274, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // rbSave
            // 
            rbSave.AutoSize = true;
            rbSave.Font = new Font("Noto Sans KR", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbSave.Location = new Point(244, 257);
            rbSave.Name = "rbSave";
            rbSave.Size = new Size(119, 23);
            rbSave.TabIndex = 3;
            rbSave.TabStop = true;
            rbSave.Text = "로그인 정보 저장";
            rbSave.UseVisualStyleBackColor = true;
            // 
            // lklId
            // 
            lklId.ActiveLinkColor = Color.Black;
            lklId.AutoSize = true;
            lklId.DisabledLinkColor = Color.Black;
            lklId.Font = new Font("Noto Sans KR", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lklId.LinkColor = Color.DarkGray;
            lklId.Location = new Point(269, 294);
            lklId.Name = "lklId";
            lklId.Size = new Size(73, 19);
            lklId.TabIndex = 4;
            lklId.TabStop = true;
            lklId.Text = "아이디 찾기";
            lklId.VisitedLinkColor = Color.DarkGray;
            lklId.LinkClicked += lklId_LinkClicked;
            // 
            // lklPW
            // 
            lklPW.ActiveLinkColor = Color.Black;
            lklPW.AutoSize = true;
            lklPW.DisabledLinkColor = Color.Black;
            lklPW.Font = new Font("Noto Sans KR", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lklPW.LinkColor = Color.DarkGray;
            lklPW.Location = new Point(346, 294);
            lklPW.Name = "lklPW";
            lklPW.Size = new Size(85, 19);
            lklPW.TabIndex = 5;
            lklPW.TabStop = true;
            lklPW.Text = "비밀번호 찾기";
            lklPW.VisitedLinkColor = Color.DarkGray;
            lklPW.LinkClicked += lklPW_LinkClicked;
            // 
            // lklMember
            // 
            lklMember.ActiveLinkColor = Color.Black;
            lklMember.AutoSize = true;
            lklMember.DisabledLinkColor = Color.Black;
            lklMember.Font = new Font("Noto Sans KR", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lklMember.LinkColor = Color.DarkGray;
            lklMember.Location = new Point(435, 294);
            lklMember.Name = "lklMember";
            lklMember.Size = new Size(57, 19);
            lklMember.TabIndex = 5;
            lklMember.TabStop = true;
            lklMember.Text = "회원가입";
            lklMember.VisitedLinkColor = Color.DarkGray;
            lklMember.LinkClicked += lklMember_LinkClicked;
            // 
            // pbGoogle
            // 
            pbGoogle.Image = (Image)resources.GetObject("pbGoogle.Image");
            pbGoogle.Location = new Point(250, 333);
            pbGoogle.Name = "pbGoogle";
            pbGoogle.Size = new Size(32, 21);
            pbGoogle.SizeMode = PictureBoxSizeMode.Zoom;
            pbGoogle.TabIndex = 10;
            pbGoogle.TabStop = false;
            // 
            // btnGoogle
            // 
            btnGoogle.FlatAppearance.BorderColor = Color.Silver;
            btnGoogle.FlatStyle = FlatStyle.System;
            btnGoogle.Font = new Font("Noto Sans KR Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoogle.Location = new Point(242, 326);
            btnGoogle.Name = "btnGoogle";
            btnGoogle.Size = new Size(274, 35);
            btnGoogle.TabIndex = 11;
            btnGoogle.Text = "구글 로그인";
            btnGoogle.UseVisualStyleBackColor = true;
            btnGoogle.Click += btnGoogle_Click;
            // 
            // logIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 450);
            Controls.Add(pbGoogle);
            Controls.Add(lklMember);
            Controls.Add(lklPW);
            Controls.Add(lklId);
            Controls.Add(rbSave);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword2);
            Controls.Add(txtIdEmail2);
            Controls.Add(pictureBox1);
            Controls.Add(btnGoogle);
            Name = "logIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGoogle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtIdEmail2;
        private TextBox txtPassword2;
        private Button btnLogin;
        private RadioButton rbSave;
        private LinkLabel lklId;
        private LinkLabel lklPW;
        private LinkLabel lklMember;
        private Button btnGoogle;
        private PictureBox pbGoogle;
    }
}
