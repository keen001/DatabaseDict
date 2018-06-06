namespace DatabaseDict
{
    partial class FormDBConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDBConfig));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlDBType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConnString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModelNameSpace = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlPrimaryKeyType = new System.Windows.Forms.ComboBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 21);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "数据库类型：";
            // 
            // ddlDBType
            // 
            this.ddlDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDBType.FormattingEnabled = true;
            this.ddlDBType.Items.AddRange(new object[] {
            "SQLServer",
            "MySql"});
            this.ddlDBType.Location = new System.Drawing.Point(96, 128);
            this.ddlDBType.Name = "ddlDBType";
            this.ddlDBType.Size = new System.Drawing.Size(121, 20);
            this.ddlDBType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "连接字符串：";
            // 
            // txtConnString
            // 
            this.txtConnString.Location = new System.Drawing.Point(96, 51);
            this.txtConnString.Multiline = true;
            this.txtConnString.Name = "txtConnString";
            this.txtConnString.Size = new System.Drawing.Size(419, 64);
            this.txtConnString.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "数据库名：";
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(355, 132);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(160, 21);
            this.txtDBName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "模型命名空间：";
            // 
            // txtModelNameSpace
            // 
            this.txtModelNameSpace.Location = new System.Drawing.Point(96, 171);
            this.txtModelNameSpace.Multiline = true;
            this.txtModelNameSpace.Name = "txtModelNameSpace";
            this.txtModelNameSpace.Size = new System.Drawing.Size(419, 21);
            this.txtModelNameSpace.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(338, 232);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(440, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "主键类型：";
            // 
            // ddlPrimaryKeyType
            // 
            this.ddlPrimaryKeyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPrimaryKeyType.FormattingEnabled = true;
            this.ddlPrimaryKeyType.Items.AddRange(new object[] {
            "自增",
            "GUID"});
            this.ddlPrimaryKeyType.Location = new System.Drawing.Point(367, 15);
            this.ddlPrimaryKeyType.Name = "ddlPrimaryKeyType";
            this.ddlPrimaryKeyType.Size = new System.Drawing.Size(121, 20);
            this.ddlPrimaryKeyType.TabIndex = 2;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(15, 232);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "测试连接";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // FormDBConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 267);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtModelNameSpace);
            this.Controls.Add(this.txtConnString);
            this.Controls.Add(this.ddlPrimaryKeyType);
            this.Controls.Add(this.ddlDBType);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDBConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormDBConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlDBType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConnString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModelNameSpace;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlPrimaryKeyType;
        private System.Windows.Forms.Button btnTest;
    }
}