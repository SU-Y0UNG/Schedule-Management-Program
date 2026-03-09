namespace Maver_켈린더
{
    partial class Calendar
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            TreeNode treeNode1 = new TreeNode("개인 캘린더");
            TreeNode treeNode2 = new TreeNode("개인", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("공용");
            TreeNode treeNode4 = new TreeNode("캘린더", new TreeNode[] { treeNode2, treeNode3 });
            imageList1 = new ImageList(components);
            pnlMain = new Panel();
            pictureBox2 = new PictureBox();
            pnlCategori = new Panel();
            treeView1 = new TreeView();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pnlHead = new Panel();
            pictureBox1 = new PictureBox();
            lbID = new Label();
            label9 = new Label();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label10 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlCategori.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "menu_open.png");
            imageList1.Images.SetKeyName(1, "menu_close.png");
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pictureBox2);
            pnlMain.Controls.Add(pnlCategori);
            pnlMain.Controls.Add(tableLayoutPanel1);
            pnlMain.Controls.Add(pnlHead);
            pnlMain.Controls.Add(flowLayoutPanel1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1493, 899);
            pnlMain.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pnlCategori
            // 
            pnlCategori.Controls.Add(treeView1);
            pnlCategori.Location = new Point(-300, 0);
            pnlCategori.Name = "pnlCategori";
            pnlCategori.Size = new Size(300, 862);
            pnlCategori.TabIndex = 1;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.WhiteSmoke;
            treeView1.Dock = DockStyle.Fill;
            treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.Checked = true;
            treeNode1.Name = "ndPrivate1";
            treeNode1.Text = "개인 캘린더";
            treeNode2.Name = "ndPrivate";
            treeNode2.NodeFont = new Font("함초롬돋움", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            treeNode2.Text = "개인";
            treeNode3.Name = "ndPublic";
            treeNode3.NodeFont = new Font("함초롬돋움", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            treeNode3.Text = "공용";
            treeNode4.BackColor = Color.White;
            treeNode4.Name = "ndMain";
            treeNode4.NodeFont = new Font("함초롬돋움", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            treeNode4.Text = "캘린더";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode4 });
            treeView1.Size = new Size(300, 862);
            treeView1.TabIndex = 0;
            treeView1.DrawNode += cdMain_DrawNode;
            treeView1.BeforeSelect += cdMain_BeforeSelect;
            treeView1.AfterSelect += cdMain_AfterSelect;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2881613F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(label5, 3, 0);
            tableLayoutPanel1.Controls.Add(label6, 4, 0);
            tableLayoutPanel1.Controls.Add(label7, 5, 0);
            tableLayoutPanel1.Controls.Add(label8, 6, 0);
            tableLayoutPanel1.Location = new Point(3, 182);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1487, 30);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("함초롬돋움", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(206, 30);
            label2.TabIndex = 0;
            label2.Text = "일요일";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("함초롬돋움", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(215, 0);
            label3.Name = "label3";
            label3.Size = new Size(206, 30);
            label3.TabIndex = 1;
            label3.Text = "월요일";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("함초롬돋움", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(427, 0);
            label4.Name = "label4";
            label4.Size = new Size(206, 30);
            label4.TabIndex = 1;
            label4.Text = "화요일";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("함초롬돋움", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(639, 0);
            label5.Name = "label5";
            label5.Size = new Size(206, 30);
            label5.TabIndex = 1;
            label5.Text = "수요일";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("함초롬돋움", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(851, 0);
            label6.Name = "label6";
            label6.Size = new Size(206, 30);
            label6.TabIndex = 1;
            label6.Text = "목요일";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("함초롬돋움", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(1063, 0);
            label7.Name = "label7";
            label7.Size = new Size(206, 30);
            label7.TabIndex = 1;
            label7.Text = "금요일";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("함초롬돋움", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(1275, 0);
            label8.Name = "label8";
            label8.Size = new Size(209, 30);
            label8.TabIndex = 1;
            label8.Text = "토요일";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHead
            // 
            pnlHead.Anchor = AnchorStyles.Top;
            pnlHead.Controls.Add(pictureBox1);
            pnlHead.Controls.Add(lbID);
            pnlHead.Controls.Add(label9);
            pnlHead.Controls.Add(button4);
            pnlHead.Controls.Add(button2);
            pnlHead.Controls.Add(button1);
            pnlHead.Controls.Add(label10);
            pnlHead.Controls.Add(label1);
            pnlHead.Location = new Point(45, 0);
            pnlHead.Name = "pnlHead";
            pnlHead.Size = new Size(1436, 64);
            pnlHead.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1222, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(1269, 9);
            lbID.Name = "lbID";
            lbID.Size = new Size(46, 15);
            lbID.TabIndex = 5;
            lbID.Text = "label11";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("함초롬돋움", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(710, 12);
            label9.Name = "label9";
            label9.Size = new Size(33, 52);
            label9.TabIndex = 4;
            label9.Text = ".";
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("맑은 고딕", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(1321, 3);
            button4.Name = "button4";
            button4.Size = new Size(53, 25);
            button4.TabIndex = 3;
            button4.Text = "로그인";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("함초롬돋움", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(514, 4);
            button2.Name = "button2";
            button2.Size = new Size(37, 59);
            button2.TabIndex = 1;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("함초롬돋움", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(855, 4);
            button1.Name = "button1";
            button1.Size = new Size(37, 59);
            button1.TabIndex = 1;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("함초롬돋움", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(731, 4);
            label10.Name = "label10";
            label10.Size = new Size(79, 62);
            label10.TabIndex = 0;
            label10.Text = "03";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("함초롬돋움", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(594, 4);
            label1.Name = "label1";
            label1.Size = new Size(131, 62);
            label1.TabIndex = 0;
            label1.Text = "2026";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 215);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1487, 680);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1493, 899);
            Controls.Add(pnlMain);
            Name = "Calendar";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Calendar_Load;
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlCategori.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlHead.ResumeLayout(false);
            pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private Panel pnlMain;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlCategori;
        private Panel pnlHead;
        private Label label1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
        private Label label9;
        private Label label10;
        private Label lbID;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TreeView treeView1;
    }
}
