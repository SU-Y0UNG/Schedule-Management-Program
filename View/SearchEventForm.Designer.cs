namespace Project_Maver.View
{
    partial class SearchEventForm
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
            groupBox1 = new GroupBox();
            rbEndDate = new RadioButton();
            rbStartDate = new RadioButton();
            btnSearch = new Button();
            label3 = new Label();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            txtSearchTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvEvents = new DataGridView();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbEndDate);
            groupBox1.Controls.Add(rbStartDate);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpToDate);
            groupBox1.Controls.Add(dtpFromDate);
            groupBox1.Controls.Add(txtSearchTitle);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 83);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // rbEndDate
            // 
            rbEndDate.AutoSize = true;
            rbEndDate.Location = new Point(365, 36);
            rbEndDate.Name = "rbEndDate";
            rbEndDate.Size = new Size(73, 19);
            rbEndDate.TabIndex = 3;
            rbEndDate.TabStop = true;
            rbEndDate.Text = "종료날짜";
            rbEndDate.UseVisualStyleBackColor = true;
            // 
            // rbStartDate
            // 
            rbStartDate.AutoSize = true;
            rbStartDate.Location = new Point(286, 36);
            rbStartDate.Name = "rbStartDate";
            rbStartDate.Size = new Size(73, 19);
            rbStartDate.TabIndex = 3;
            rbStartDate.TabStop = true;
            rbStartDate.Text = "시작날짜";
            rbStartDate.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(696, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "검색";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(554, 35);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 3;
            label3.Text = "~";
            // 
            // dtpToDate
            // 
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(569, 32);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(108, 23);
            dtpToDate.TabIndex = 2;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(444, 32);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(108, 23);
            dtpFromDate.TabIndex = 2;
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(55, 32);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(153, 23);
            txtSearchTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 36);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 0;
            label2.Text = "날짜";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "일정명";
            // 
            // dgvEvents
            // 
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Location = new Point(12, 118);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.RowTemplate.Height = 25;
            dgvEvents.Size = new Size(803, 511);
            dgvEvents.TabIndex = 1;
            dgvEvents.CellDoubleClick += dgvEvents_CellDoubleClick;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(368, 638);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(101, 31);
            btnClose.TabIndex = 2;
            btnClose.Text = "닫기";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // SearchEventForm
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 678);
            Controls.Add(btnClose);
            Controls.Add(dgvEvents);
            Controls.Add(groupBox1);
            Name = "SearchEventForm";
            Text = "SearchEventForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFromDate;
        private TextBox txtSearchTitle;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView dgvEvents;
        private Button btnSearch;
        private Button btnClose;
        private RadioButton rbEndDate;
        private RadioButton rbStartDate;
    }
}