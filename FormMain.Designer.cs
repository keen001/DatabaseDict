namespace DatabaseDict
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Bottom = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl_TableInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateColumnComment = new System.Windows.Forms.Button();
            this.txtColumnComment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelColumnDefault = new System.Windows.Forms.Label();
            this.labelColumnAuto = new System.Windows.Forms.Label();
            this.labelColumnAllowNull = new System.Windows.Forms.Label();
            this.labelColumnType = new System.Windows.Forms.Label();
            this.labelColumnName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateTableComment = new System.Windows.Forms.Button();
            this.txtTableComment = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Code = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl_Code = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.txtCodeCSharp = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.txtCodeJava = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.txtCodeMybatis = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCopyFileMybatis = new System.Windows.Forms.Button();
            this.btnCopyFileJava = new System.Windows.Forms.Button();
            this.btnCopyFile = new System.Windows.Forms.Button();
            this.btnCreateCode = new System.Windows.Forms.Button();
            this.comboBox_PrimaryKeyType = new System.Windows.Forms.ComboBox();
            this.comboBox_PrimaryKey = new System.Windows.Forms.ComboBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl_DBInfo = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox_Tables = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDatabaseAdd = new System.Windows.Forms.Button();
            this.btnDatabaseManage = new System.Windows.Forms.Button();
            this.comboBox_Database = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.tableLayoutPanel_Bottom.SuspendLayout();
            this.tabControl_TableInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel_Code.SuspendLayout();
            this.tabControl_Code.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl_DBInfo.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_Bottom, 0, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 2;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(1344, 911);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // tableLayoutPanel_Bottom
            // 
            this.tableLayoutPanel_Bottom.ColumnCount = 2;
            this.tableLayoutPanel_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Bottom.Controls.Add(this.tabControl_TableInfo, 1, 0);
            this.tableLayoutPanel_Bottom.Controls.Add(this.tabControl_DBInfo, 0, 0);
            this.tableLayoutPanel_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Bottom.Location = new System.Drawing.Point(4, 79);
            this.tableLayoutPanel_Bottom.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_Bottom.Name = "tableLayoutPanel_Bottom";
            this.tableLayoutPanel_Bottom.RowCount = 1;
            this.tableLayoutPanel_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Bottom.Size = new System.Drawing.Size(1336, 829);
            this.tableLayoutPanel_Bottom.TabIndex = 0;
            // 
            // tabControl_TableInfo
            // 
            this.tabControl_TableInfo.Controls.Add(this.tabPage1);
            this.tabControl_TableInfo.Controls.Add(this.tabPage2);
            this.tabControl_TableInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_TableInfo.Location = new System.Drawing.Point(271, 4);
            this.tabControl_TableInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_TableInfo.Name = "tabControl_TableInfo";
            this.tabControl_TableInfo.SelectedIndex = 0;
            this.tabControl_TableInfo.Size = new System.Drawing.Size(1061, 821);
            this.tabControl_TableInfo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1053, 792);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "字段";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1045, 784);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 440F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 104);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1037, 676);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeight = 24;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Name,
            this.col_Comment});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(432, 668);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // col_Name
            // 
            this.col_Name.DataPropertyName = "ColName";
            this.col_Name.HeaderText = "名称";
            this.col_Name.Name = "col_Name";
            this.col_Name.ReadOnly = true;
            // 
            // col_Comment
            // 
            this.col_Comment.DataPropertyName = "Comment";
            this.col_Comment.HeaderText = "备注";
            this.col_Comment.Name = "col_Comment";
            this.col_Comment.ReadOnly = true;
            this.col_Comment.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdateColumnComment);
            this.panel2.Controls.Add(this.txtColumnComment);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelColumnDefault);
            this.panel2.Controls.Add(this.labelColumnAuto);
            this.panel2.Controls.Add(this.labelColumnAllowNull);
            this.panel2.Controls.Add(this.labelColumnType);
            this.panel2.Controls.Add(this.labelColumnName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(444, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 668);
            this.panel2.TabIndex = 4;
            // 
            // btnUpdateColumnComment
            // 
            this.btnUpdateColumnComment.Location = new System.Drawing.Point(463, 591);
            this.btnUpdateColumnComment.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateColumnComment.Name = "btnUpdateColumnComment";
            this.btnUpdateColumnComment.Size = new System.Drawing.Size(100, 29);
            this.btnUpdateColumnComment.TabIndex = 2;
            this.btnUpdateColumnComment.Text = "更新字段备注";
            this.btnUpdateColumnComment.UseVisualStyleBackColor = true;
            // 
            // txtColumnComment
            // 
            this.txtColumnComment.Location = new System.Drawing.Point(40, 266);
            this.txtColumnComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtColumnComment.Multiline = true;
            this.txtColumnComment.Name = "txtColumnComment";
            this.txtColumnComment.Size = new System.Drawing.Size(521, 285);
            this.txtColumnComment.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "　　备注：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "　默认值：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "是否自增：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "允许为空：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "字段类型：";
            // 
            // labelColumnDefault
            // 
            this.labelColumnDefault.AutoSize = true;
            this.labelColumnDefault.Location = new System.Drawing.Point(132, 191);
            this.labelColumnDefault.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColumnDefault.Name = "labelColumnDefault";
            this.labelColumnDefault.Size = new System.Drawing.Size(0, 15);
            this.labelColumnDefault.TabIndex = 0;
            // 
            // labelColumnAuto
            // 
            this.labelColumnAuto.AutoSize = true;
            this.labelColumnAuto.Location = new System.Drawing.Point(132, 151);
            this.labelColumnAuto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColumnAuto.Name = "labelColumnAuto";
            this.labelColumnAuto.Size = new System.Drawing.Size(0, 15);
            this.labelColumnAuto.TabIndex = 0;
            // 
            // labelColumnAllowNull
            // 
            this.labelColumnAllowNull.AutoSize = true;
            this.labelColumnAllowNull.Location = new System.Drawing.Point(132, 110);
            this.labelColumnAllowNull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColumnAllowNull.Name = "labelColumnAllowNull";
            this.labelColumnAllowNull.Size = new System.Drawing.Size(0, 15);
            this.labelColumnAllowNull.TabIndex = 0;
            // 
            // labelColumnType
            // 
            this.labelColumnType.AutoSize = true;
            this.labelColumnType.Location = new System.Drawing.Point(132, 70);
            this.labelColumnType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColumnType.Name = "labelColumnType";
            this.labelColumnType.Size = new System.Drawing.Size(0, 15);
            this.labelColumnType.TabIndex = 0;
            // 
            // labelColumnName
            // 
            this.labelColumnName.AutoSize = true;
            this.labelColumnName.Location = new System.Drawing.Point(132, 36);
            this.labelColumnName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColumnName.Name = "labelColumnName";
            this.labelColumnName.Size = new System.Drawing.Size(0, 15);
            this.labelColumnName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "字段名称：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateTableComment);
            this.panel1.Controls.Add(this.txtTableComment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 92);
            this.panel1.TabIndex = 1;
            // 
            // btnUpdateTableComment
            // 
            this.btnUpdateTableComment.Location = new System.Drawing.Point(916, 32);
            this.btnUpdateTableComment.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateTableComment.Name = "btnUpdateTableComment";
            this.btnUpdateTableComment.Size = new System.Drawing.Size(100, 29);
            this.btnUpdateTableComment.TabIndex = 1;
            this.btnUpdateTableComment.Text = "更新表备注";
            this.btnUpdateTableComment.UseVisualStyleBackColor = true;
            // 
            // txtTableComment
            // 
            this.txtTableComment.Location = new System.Drawing.Point(16, 5);
            this.txtTableComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtTableComment.Multiline = true;
            this.txtTableComment.Name = "txtTableComment";
            this.txtTableComment.Size = new System.Drawing.Size(872, 83);
            this.txtTableComment.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel_Code);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1053, 792);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "代码生成";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Code
            // 
            this.tableLayoutPanel_Code.ColumnCount = 1;
            this.tableLayoutPanel_Code.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Code.Controls.Add(this.tabControl_Code, 0, 1);
            this.tableLayoutPanel_Code.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel_Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Code.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_Code.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_Code.Name = "tableLayoutPanel_Code";
            this.tableLayoutPanel_Code.RowCount = 2;
            this.tableLayoutPanel_Code.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_Code.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Code.Size = new System.Drawing.Size(1045, 784);
            this.tableLayoutPanel_Code.TabIndex = 0;
            // 
            // tabControl_Code
            // 
            this.tabControl_Code.Controls.Add(this.tabPage7);
            this.tabControl_Code.Controls.Add(this.tabPage8);
            this.tabControl_Code.Controls.Add(this.tabPage9);
            this.tabControl_Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Code.Location = new System.Drawing.Point(4, 104);
            this.tabControl_Code.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_Code.Name = "tabControl_Code";
            this.tabControl_Code.SelectedIndex = 0;
            this.tabControl_Code.Size = new System.Drawing.Size(1037, 781);
            this.tabControl_Code.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.txtCodeCSharp);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage7.Size = new System.Drawing.Size(1029, 752);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "C#";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // txtCodeCSharp
            // 
            this.txtCodeCSharp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodeCSharp.Location = new System.Drawing.Point(4, 4);
            this.txtCodeCSharp.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeCSharp.Multiline = true;
            this.txtCodeCSharp.Name = "txtCodeCSharp";
            this.txtCodeCSharp.Size = new System.Drawing.Size(1021, 744);
            this.txtCodeCSharp.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.txtCodeJava);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage8.Size = new System.Drawing.Size(1029, 752);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Hibernate";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // txtCodeJava
            // 
            this.txtCodeJava.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodeJava.Location = new System.Drawing.Point(4, 4);
            this.txtCodeJava.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeJava.Multiline = true;
            this.txtCodeJava.Name = "txtCodeJava";
            this.txtCodeJava.Size = new System.Drawing.Size(1021, 744);
            this.txtCodeJava.TabIndex = 1;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.txtCodeMybatis);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(1029, 752);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "Mybatis";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // txtCodeMybatis
            // 
            this.txtCodeMybatis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodeMybatis.Location = new System.Drawing.Point(0, 0);
            this.txtCodeMybatis.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeMybatis.Multiline = true;
            this.txtCodeMybatis.Name = "txtCodeMybatis";
            this.txtCodeMybatis.Size = new System.Drawing.Size(1029, 752);
            this.txtCodeMybatis.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCopyFileMybatis);
            this.panel3.Controls.Add(this.btnCopyFileJava);
            this.panel3.Controls.Add(this.btnCopyFile);
            this.panel3.Controls.Add(this.btnCreateCode);
            this.panel3.Controls.Add(this.comboBox_PrimaryKeyType);
            this.panel3.Controls.Add(this.comboBox_PrimaryKey);
            this.panel3.Controls.Add(this.txtClassName);
            this.panel3.Controls.Add(this.txtNameSpace);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1037, 92);
            this.panel3.TabIndex = 0;
            // 
            // btnCopyFileMybatis
            // 
            this.btnCopyFileMybatis.Location = new System.Drawing.Point(895, 52);
            this.btnCopyFileMybatis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyFileMybatis.Name = "btnCopyFileMybatis";
            this.btnCopyFileMybatis.Size = new System.Drawing.Size(138, 29);
            this.btnCopyFileMybatis.TabIndex = 2;
            this.btnCopyFileMybatis.Text = "复制Mybatis文件";
            this.btnCopyFileMybatis.UseVisualStyleBackColor = true;
            this.btnCopyFileMybatis.Click += new System.EventHandler(this.btnCopyFileMybatis_Click);
            // 
            // btnCopyFileJava
            // 
            this.btnCopyFileJava.Location = new System.Drawing.Point(784, 52);
            this.btnCopyFileJava.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyFileJava.Name = "btnCopyFileJava";
            this.btnCopyFileJava.Size = new System.Drawing.Size(101, 29);
            this.btnCopyFileJava.TabIndex = 2;
            this.btnCopyFileJava.Text = "复制Hib文件";
            this.btnCopyFileJava.UseVisualStyleBackColor = true;
            this.btnCopyFileJava.Click += new System.EventHandler(this.btnCopyFileJava_Click);
            // 
            // btnCopyFile
            // 
            this.btnCopyFile.Location = new System.Drawing.Point(664, 52);
            this.btnCopyFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyFile.Name = "btnCopyFile";
            this.btnCopyFile.Size = new System.Drawing.Size(100, 29);
            this.btnCopyFile.TabIndex = 2;
            this.btnCopyFile.Text = "复制C#文件";
            this.btnCopyFile.UseVisualStyleBackColor = true;
            this.btnCopyFile.Click += new System.EventHandler(this.btnCopyFile_Click);
            // 
            // btnCreateCode
            // 
            this.btnCreateCode.Location = new System.Drawing.Point(461, 52);
            this.btnCreateCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateCode.Name = "btnCreateCode";
            this.btnCreateCode.Size = new System.Drawing.Size(128, 29);
            this.btnCreateCode.TabIndex = 2;
            this.btnCreateCode.Text = "生成代码";
            this.btnCreateCode.UseVisualStyleBackColor = true;
            this.btnCreateCode.Click += new System.EventHandler(this.btnCreateCode_Click);
            // 
            // comboBox_PrimaryKeyType
            // 
            this.comboBox_PrimaryKeyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PrimaryKeyType.FormattingEnabled = true;
            this.comboBox_PrimaryKeyType.Items.AddRange(new object[] {
            "自增",
            "GUID"});
            this.comboBox_PrimaryKeyType.Location = new System.Drawing.Point(319, 54);
            this.comboBox_PrimaryKeyType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_PrimaryKeyType.Name = "comboBox_PrimaryKeyType";
            this.comboBox_PrimaryKeyType.Size = new System.Drawing.Size(127, 23);
            this.comboBox_PrimaryKeyType.TabIndex = 0;
            // 
            // comboBox_PrimaryKey
            // 
            this.comboBox_PrimaryKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PrimaryKey.FormattingEnabled = true;
            this.comboBox_PrimaryKey.Location = new System.Drawing.Point(897, 12);
            this.comboBox_PrimaryKey.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_PrimaryKey.Name = "comboBox_PrimaryKey";
            this.comboBox_PrimaryKey.Size = new System.Drawing.Size(127, 23);
            this.comboBox_PrimaryKey.TabIndex = 0;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(76, 55);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(132, 25);
            this.txtClassName.TabIndex = 1;
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(168, 12);
            this.txtNameSpace.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(625, 25);
            this.txtNameSpace.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "主键类型：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(803, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "主键字段：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "类名：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "命名空间（包名）：";
            // 
            // tabControl_DBInfo
            // 
            this.tabControl_DBInfo.Controls.Add(this.tabPage3);
            this.tabControl_DBInfo.Controls.Add(this.tabPage4);
            this.tabControl_DBInfo.Controls.Add(this.tabPage6);
            this.tabControl_DBInfo.Controls.Add(this.tabPage5);
            this.tabControl_DBInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_DBInfo.Location = new System.Drawing.Point(4, 4);
            this.tabControl_DBInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_DBInfo.Name = "tabControl_DBInfo";
            this.tabControl_DBInfo.SelectedIndex = 0;
            this.tabControl_DBInfo.Size = new System.Drawing.Size(259, 821);
            this.tabControl_DBInfo.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(251, 792);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "数据表";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox_Tables
            // 
            this.listBox_Tables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Tables.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox_Tables.FormattingEnabled = true;
            this.listBox_Tables.ItemHeight = 12;
            this.listBox_Tables.Location = new System.Drawing.Point(4, 39);
            this.listBox_Tables.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Tables.Name = "listBox_Tables";
            this.listBox_Tables.Size = new System.Drawing.Size(235, 741);
            this.listBox_Tables.TabIndex = 0;
            this.listBox_Tables.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_Tables_DrawItem);
            this.listBox_Tables.SelectedIndexChanged += new System.EventHandler(this.listBox_Tables_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(251, 792);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "视图";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(251, 792);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "存储过程";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(251, 792);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "函数";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDatabaseAdd);
            this.groupBox1.Controls.Add(this.btnDatabaseManage);
            this.groupBox1.Controls.Add(this.comboBox_Database);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1336, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库";
            // 
            // btnDatabaseAdd
            // 
            this.btnDatabaseAdd.Location = new System.Drawing.Point(427, 25);
            this.btnDatabaseAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatabaseAdd.Name = "btnDatabaseAdd";
            this.btnDatabaseAdd.Size = new System.Drawing.Size(100, 29);
            this.btnDatabaseAdd.TabIndex = 1;
            this.btnDatabaseAdd.Text = "增加数据库";
            this.btnDatabaseAdd.UseVisualStyleBackColor = true;
            this.btnDatabaseAdd.Click += new System.EventHandler(this.btnDatabaseAdd_Click);
            // 
            // btnDatabaseManage
            // 
            this.btnDatabaseManage.Location = new System.Drawing.Point(300, 25);
            this.btnDatabaseManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatabaseManage.Name = "btnDatabaseManage";
            this.btnDatabaseManage.Size = new System.Drawing.Size(100, 29);
            this.btnDatabaseManage.TabIndex = 1;
            this.btnDatabaseManage.Text = "数据库管理";
            this.btnDatabaseManage.UseVisualStyleBackColor = true;
            this.btnDatabaseManage.Click += new System.EventHandler(this.btnDatabaseManage_Click);
            // 
            // comboBox_Database
            // 
            this.comboBox_Database.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Database.FormattingEnabled = true;
            this.comboBox_Database.Location = new System.Drawing.Point(13, 26);
            this.comboBox_Database.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Database.Name = "comboBox_Database";
            this.comboBox_Database.Size = new System.Drawing.Size(248, 23);
            this.comboBox_Database.TabIndex = 0;
            this.comboBox_Database.SelectedIndexChanged += new System.EventHandler(this.comboBox_Database_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.listBox_Tables, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(243, 784);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 911);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据字典查看器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.tableLayoutPanel_Bottom.ResumeLayout(false);
            this.tabControl_TableInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel_Code.ResumeLayout(false);
            this.tabControl_Code.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl_DBInfo.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Bottom;
        private System.Windows.Forms.TabControl tabControl_TableInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl_DBInfo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox listBox_Tables;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDatabaseAdd;
        private System.Windows.Forms.Button btnDatabaseManage;
        private System.Windows.Forms.ComboBox comboBox_Database;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Comment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdateTableComment;
        private System.Windows.Forms.TextBox txtTableComment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtColumnComment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateColumnComment;
        private System.Windows.Forms.Label labelColumnDefault;
        private System.Windows.Forms.Label labelColumnAuto;
        private System.Windows.Forms.Label labelColumnAllowNull;
        private System.Windows.Forms.Label labelColumnType;
        private System.Windows.Forms.Label labelColumnName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Code;
        private System.Windows.Forms.TabControl tabControl_Code;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox txtCodeCSharp;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox txtCodeJava;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCreateCode;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCopyFile;
        private System.Windows.Forms.ComboBox comboBox_PrimaryKey;
        private System.Windows.Forms.ComboBox comboBox_PrimaryKeyType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCopyFileJava;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TextBox txtCodeMybatis;
        private System.Windows.Forms.Button btnCopyFileMybatis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

