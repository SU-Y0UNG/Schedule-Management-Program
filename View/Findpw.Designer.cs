namespace Project_Maver.View
{
    partial class Findpw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Findpw));
            btnFindPW = new Button();
            txtId1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            txtEmail1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnFindPW
            // 
            btnFindPW.BackColor = Color.LimeGreen;
            btnFindPW.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFindPW.Location = new Point(303, 322);
            btnFindPW.Name = "btnFindPW";
            btnFindPW.Size = new Size(198, 52);
            btnFindPW.TabIndex = 15;
            btnFindPW.Text = "임시 비밀번호 발급";
            btnFindPW.UseVisualStyleBackColor = false;
            btnFindPW.Click += btnFindPW_Click;
            // 
            // txtId1
            // 
            txtId1.Location = new Point(248, 211);
            txtId1.Name = "txtId1";
            txtId1.Size = new Size(324, 23);
            txtId1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 189);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 11;
            label3.Text = "아이디 : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 149);
            label2.Name = "label2";
            label2.Size = new Size(462, 15);
            label2.TabIndex = 8;
            label2.Text = "비밀번호는 회원가입시 입력하신 아이디와 이메일을 입력하시면 찾으실 수 있습니다.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(338, 107);
            label1.Name = "label1";
            label1.Size = new Size(146, 30);
            label1.TabIndex = 7;
            label1.Text = "비밀번호 찾기";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(248, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 249);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 11;
            label6.Text = "이메일 : ";
            // 
            // txtEmail1
            // 
            txtEmail1.Location = new Point(248, 271);
            txtEmail1.Name = "txtEmail1";
            txtEmail1.Size = new Size(324, 23);
            txtEmail1.TabIndex = 14;
            // 
            // Findpw
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFindPW);
            Controls.Add(txtEmail1);
            Controls.Add(label6);
            Controls.Add(txtId1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Findpw";
            Text = "Findpw";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFindPW;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtId1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label6;
        private TextBox txtEmail1;
    }
}