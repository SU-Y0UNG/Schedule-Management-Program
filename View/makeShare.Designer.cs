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
            textBox1 = new TextBox();
            listView1 = new ListView();
            contextMenuStripDelete = new ContextMenuStrip(components);
            제거ToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(127, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.ContextMenuStrip = contextMenuStripDelete;
            listView1.Location = new Point(354, 179);
            listView1.Name = "listView1";
            listView1.Size = new Size(154, 106);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
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
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(316, 179);
            button1.Name = "button1";
            button1.Size = new Size(20, 25);
            button1.TabIndex = 5;
            button1.Text = "+";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // makeShare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(534, 761);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(_panel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCalName);
            Name = "makeShare";
            Text = "makeShare";
            contextMenuStripDelete.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCalName;
        private Label label1;
        private Panel _panel;
        private Label label2;
        private TextBox textBox1;
        private ListView listView1;
        private Button button1;
        private ContextMenuStrip contextMenuStripDelete;
        private ToolStripMenuItem 제거ToolStripMenuItem;
    }
}