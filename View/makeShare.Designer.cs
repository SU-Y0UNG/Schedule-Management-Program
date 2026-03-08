namespace Project_Maver.View
{
    partial class makeShare
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
            components = new System.ComponentModel.Container();
            txtCalName = new TextBox();
            label1 = new Label();
            _panel = new Panel();
            label2 = new Label();
            txtShareUser = new TextBox();
            lvShareUser = new ListView();
            contextMenuStripDelete = new ContextMenuStrip(components);
            제거ToolStripMenuItem = new ToolStripMenuItem();
            btnUserPlus = new Button();
            rbColor = new Project_Maver.Common.RoundButton();
            btnSharePlus = new Button();
            contextMenuStripDelete.SuspendLayout();
            SuspendLayout();
            // 
            // txtCalName
            // 
            txtCalName.BackColor = Color.White;
            txtCalName.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCalName.Location = new Point(12, 46);
            txtCalName.Multiline = true;
            txtCalName.Name = "txtCalName";
            txtCalName.PlaceholderText = "캘린더명을 입력하세요";
            txtCalName.Size = new Size(510, 42);
            txtCalName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("함초롬돋움", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(106, 24);
            label1.TabIndex = 1;
            label1.Text = "캘린더 색상";
            // 
            // _panel
            // 
            _panel.BackColor = Color.Silver;
            _panel.Location = new Point(12, 151);
            _panel.Name = "_panel";
            _panel.Size = new Size(510, 1);
            _panel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("함초롬돋움", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 174);
            label2.Name = "label2";
            label2.Size = new Size(88, 24);
            label2.TabIndex = 1;
            label2.Text = "유저 추가";
            // 
            // txtShareUser
            // 
            txtShareUser.Location = new Point(127, 179);
            txtShareUser.Name = "txtShareUser";
            txtShareUser.Size = new Size(308, 23);
            txtShareUser.TabIndex = 3;
            // 
            // lvShareUser
            // 
            lvShareUser.ContextMenuStrip = contextMenuStripDelete;
            lvShareUser.Location = new Point(127, 208);
            lvShareUser.Name = "lvShareUser";
            lvShareUser.Size = new Size(308, 60);
            lvShareUser.TabIndex = 4;
            lvShareUser.UseCompatibleStateImageBehavior = false;
            lvShareUser.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStripDelete
            // 
            contextMenuStripDelete.Items.AddRange(new ToolStripItem[] { 제거ToolStripMenuItem });
            contextMenuStripDelete.Name = "contextMenuStrip1";
            contextMenuStripDelete.Size = new Size(99, 26);
            // 
            // 제거ToolStripMenuItem
            // 
            제거ToolStripMenuItem.Name = "제거ToolStripMenuItem";
            제거ToolStripMenuItem.Size = new Size(98, 22);
            제거ToolStripMenuItem.Text = "제거";
            // 
            // btnUserPlus
            // 
            btnUserPlus.BackColor = Color.Transparent;
            btnUserPlus.FlatAppearance.BorderSize = 0;
            btnUserPlus.FlatStyle = FlatStyle.Flat;
            btnUserPlus.Font = new Font("함초롬돋움", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnUserPlus.ForeColor = Color.DimGray;
            btnUserPlus.Location = new Point(439, 164);
            btnUserPlus.Name = "btnUserPlus";
            btnUserPlus.Size = new Size(32, 50);
            btnUserPlus.TabIndex = 5;
            btnUserPlus.Text = "+";
            btnUserPlus.TextAlign = ContentAlignment.BottomCenter;
            btnUserPlus.UseVisualStyleBackColor = false;
            // 
            // rbColor
            // 
            rbColor.BackColor = Color.RosyBrown;
            rbColor.FlatAppearance.BorderSize = 0;
            rbColor.FlatStyle = FlatStyle.Flat;
            rbColor.Location = new Point(467, 111);
            rbColor.Name = "rbColor";
            rbColor.Size = new Size(25, 25);
            rbColor.TabIndex = 6;
            rbColor.UseVisualStyleBackColor = false;
            // 
            // btnSharePlus
            // 
            btnSharePlus.BackColor = Color.DimGray;
            btnSharePlus.FlatAppearance.BorderSize = 0;
            btnSharePlus.FlatStyle = FlatStyle.Flat;
            btnSharePlus.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSharePlus.ForeColor = Color.Snow;
            btnSharePlus.Location = new Point(207, 575);
            btnSharePlus.Name = "btnSharePlus";
            btnSharePlus.Size = new Size(118, 36);
            btnSharePlus.TabIndex = 7;
            btnSharePlus.Text = "생성하기";
            btnSharePlus.UseVisualStyleBackColor = false;
            // 
            // makeShare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(534, 761);
            Controls.Add(btnSharePlus);
            Controls.Add(rbColor);
            Controls.Add(btnUserPlus);
            Controls.Add(lvShareUser);
            Controls.Add(txtShareUser);
            Controls.Add(_panel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCalName);
            Name = "makeShare";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "공유 캘린더";
            contextMenuStripDelete.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCalName;
        private Label label1;
        private Panel _panel;
        private Label label2;
        private TextBox txtShareUser;
        private ListView lvShareUser;
        private Button btnUserPlus;
        private ContextMenuStrip contextMenuStripDelete;
        private ToolStripMenuItem 제거ToolStripMenuItem;
        private Common.RoundButton rbColor;
        private Button btnSharePlus;
    }
}