namespace Project_Maver.View
{
    partial class FindId
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindId));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            btnFindID = new Button();
            label5 = new Label();
            txtPhone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(218, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(308, 107);
            label1.Name = "label1";
            label1.Size = new Size(125, 30);
            label1.TabIndex = 1;
            label1.Text = "아이디 찾기";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 151);
            label2.Name = "label2";
            label2.Size = new Size(402, 15);
            label2.TabIndex = 2;
            label2.Text = "아이디는 회원가입시 입력하신 이름과 이메일을 통해 찾으실 수 있습니다.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 189);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "이름 : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 241);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "이메일 : ";
            // 
            // txtName
            // 
            txtName.Location = new Point(218, 211);
            txtName.Name = "txtName";
            txtName.Size = new Size(324, 23);
            txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(218, 263);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(324, 23);
            txtEmail.TabIndex = 4;
            // 
            // btnFindID
            // 
            btnFindID.BackColor = Color.LimeGreen;
            btnFindID.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFindID.Location = new Point(266, 386);
            btnFindID.Name = "btnFindID";
            btnFindID.Size = new Size(181, 52);
            btnFindID.TabIndex = 5;
            btnFindID.Text = "아이디 찾기";
            btnFindID.UseVisualStyleBackColor = false;
            btnFindID.Click += btnFindID_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 293);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 3;
            label5.Text = "전화번호 : ";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(218, 315);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(324, 23);
            txtPhone.TabIndex = 4;
            // 
            // FindId
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFindID);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FindId";
            Text = "FindId";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtEmail;
        private Button btnFindID;
        private Label label5;
        private TextBox txtPhone;
    }
}