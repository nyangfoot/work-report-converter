namespace WorkReportConverter
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnConvert = new Button();
            btnClear = new Button();
            versionLabel = new Label();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            mdPanel = new Panel();
            mdForm = new RichTextBox();
            reportPanel = new Panel();
            reportForm = new RichTextBox();
            dataGrid = new DataGridView();
            WriteDate = new DataGridViewTextBoxColumn();
            MenuName = new DataGridViewTextBoxColumn();
            CompleteDate = new DataGridViewTextBoxColumn();
            Contents = new DataGridViewTextBoxColumn();
            Progress = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            panel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            mdPanel.SuspendLayout();
            reportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Controls.Add(tableLayoutPanel1);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(10);
            panel.Size = new Size(1782, 1499);
            panel.TabIndex = 0;
            panel.Paint += panel1_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Controls.Add(dataGrid, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Size = new Size(1762, 1479);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.Controls.Add(btnConvert, 3, 0);
            tableLayoutPanel2.Controls.Add(btnClear, 2, 0);
            tableLayoutPanel2.Controls.Add(versionLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1756, 67);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnConvert
            // 
            btnConvert.Dock = DockStyle.Fill;
            btnConvert.Font = new Font("함초롬돋움", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnConvert.Location = new Point(1634, 3);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(119, 61);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "변환";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Font = new Font("함초롬돋움", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnClear.Location = new Point(1512, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 61);
            btnClear.TabIndex = 0;
            btnClear.Text = "초기화";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Dock = DockStyle.Fill;
            versionLabel.Font = new Font("함초롬돋움", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            versionLabel.Location = new Point(3, 0);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(345, 67);
            versionLabel.TabIndex = 2;
            versionLabel.Text = "ver 1.0.251230-01";
            versionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("함초롬돋움", 9.899999F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 129);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(354, 0);
            label3.Name = "label3";
            label3.Size = new Size(1152, 67);
            label3.TabIndex = 3;
            label3.Text = "* 진행도, 고객사 컬럼에 마우스 오버 시 설명 표기";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.9387741F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.122449F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.9387741F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(label1, 2, 0);
            tableLayoutPanel3.Controls.Add(mdPanel, 2, 1);
            tableLayoutPanel3.Controls.Add(reportPanel, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 814);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel3.Size = new Size(1756, 662);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("함초롬돋움", 9.899999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(818, 66);
            label2.TabIndex = 1;
            label2.Text = "<업무 보고 양식>";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("함초롬돋움", 9.899999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(934, 0);
            label1.Name = "label1";
            label1.Size = new Size(819, 66);
            label1.TabIndex = 0;
            label1.Text = "<MD 양식>";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mdPanel
            // 
            mdPanel.BackColor = Color.LightSlateGray;
            mdPanel.Controls.Add(mdForm);
            mdPanel.Dock = DockStyle.Fill;
            mdPanel.Location = new Point(934, 69);
            mdPanel.Name = "mdPanel";
            mdPanel.Padding = new Padding(3);
            mdPanel.Size = new Size(819, 590);
            mdPanel.TabIndex = 3;
            // 
            // mdForm
            // 
            mdForm.BorderStyle = BorderStyle.None;
            mdForm.Dock = DockStyle.Fill;
            mdForm.Font = new Font("함초롬돋움", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            mdForm.Location = new Point(3, 3);
            mdForm.Name = "mdForm";
            mdForm.Size = new Size(813, 584);
            mdForm.TabIndex = 0;
            mdForm.Text = "";
            // 
            // reportPanel
            // 
            reportPanel.BackColor = Color.LightSlateGray;
            reportPanel.Controls.Add(reportForm);
            reportPanel.Dock = DockStyle.Fill;
            reportPanel.Location = new Point(3, 69);
            reportPanel.Name = "reportPanel";
            reportPanel.Padding = new Padding(3);
            reportPanel.Size = new Size(818, 590);
            reportPanel.TabIndex = 4;
            // 
            // reportForm
            // 
            reportForm.BorderStyle = BorderStyle.None;
            reportForm.Dock = DockStyle.Fill;
            reportForm.Font = new Font("함초롬돋움", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            reportForm.Location = new Point(3, 3);
            reportForm.Name = "reportForm";
            reportForm.Size = new Size(812, 584);
            reportForm.TabIndex = 0;
            reportForm.Text = "";
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("함초롬돋움", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { WriteDate, MenuName, CompleteDate, Contents, Progress, Customer });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("함초롬돋움", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Location = new Point(3, 76);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 102;
            dataGrid.Size = new Size(1756, 659);
            dataGrid.TabIndex = 2;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            dataGrid.KeyDown += dataGrid_Keydown;
            // 
            // WriteDate
            // 
            WriteDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WriteDate.FillWeight = 10F;
            WriteDate.HeaderText = "작성일";
            WriteDate.MinimumWidth = 12;
            WriteDate.Name = "WriteDate";
            // 
            // MenuName
            // 
            MenuName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MenuName.FillWeight = 20F;
            MenuName.HeaderText = "메뉴";
            MenuName.MinimumWidth = 12;
            MenuName.Name = "MenuName";
            // 
            // CompleteDate
            // 
            CompleteDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CompleteDate.FillWeight = 10F;
            CompleteDate.HeaderText = "완료일";
            CompleteDate.MinimumWidth = 12;
            CompleteDate.Name = "CompleteDate";
            // 
            // Contents
            // 
            Contents.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Contents.FillWeight = 30F;
            Contents.HeaderText = "내용";
            Contents.MinimumWidth = 12;
            Contents.Name = "Contents";
            // 
            // Progress
            // 
            Progress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Progress.FillWeight = 10F;
            Progress.HeaderText = "진행도(%)";
            Progress.MinimumWidth = 12;
            Progress.Name = "Progress";
            Progress.ToolTipText = "100: 완료, 0또는 빈값: 익일, 숫자만 입력";
            // 
            // Customer
            // 
            Customer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Customer.FillWeight = 20F;
            Customer.HeaderText = "고객사";
            Customer.MinimumWidth = 12;
            Customer.Name = "Customer";
            Customer.ToolTipText = "빈값은 패키지로 인식";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47F));
            tableLayoutPanel4.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 741);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel4.Size = new Size(1756, 67);
            tableLayoutPanel4.TabIndex = 3;
            tableLayoutPanel4.Paint += tableLayoutPanel4_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.arrow_down;
            pictureBox1.Location = new Point(828, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(240F, 240F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1782, 1499);
            Controls.Add(panel);
            Font = new Font("함초롬돋움", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "업무 보고 변환";
            Load += Form1_Load;
            panel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            mdPanel.ResumeLayout(false);
            reportPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnClear;
        private Label label2;
        private Label label1;
        private DataGridView dataGrid;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBox1;
        private Panel mdPanel;
        private RichTextBox mdForm;
        private Panel reportPanel;
        private RichTextBox reportForm;
        private Label versionLabel;
        private DataGridViewTextBoxColumn WriteDate;
        private DataGridViewTextBoxColumn MenuName;
        private DataGridViewTextBoxColumn CompleteDate;
        private DataGridViewTextBoxColumn Contents;
        private DataGridViewTextBoxColumn Progress;
        private DataGridViewTextBoxColumn Customer;
        private Label label3;
        private Button btnConvert;
    }
}
