using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDict
{
    public partial class FormDBConfig : Form
    {
        private DatabaseConfig DBConfig = null;
        private FormMain FormMain;
        public FormDBConfig(FormMain formMain,DatabaseConfig dbConfig)
        {
            FormMain = formMain;
            DBConfig = dbConfig;
            InitializeComponent();
        }

        private void FormDBConfig_Load(object sender, EventArgs e)
        {
            this.Text = DBConfig == null ? "新增数据库配置" : "修改数据库配置";
            
            ddlDBType.SelectedIndex = 0;
            ddlPrimaryKeyType.SelectedIndex = 0;

            if (this.DBConfig != null)
            {
                txtName.Text = DBConfig.Name;
                ddlPrimaryKeyType.Text = DBConfig.PrimaryKeyType;
                txtConnString.Text = DBConfig.ConnString;
                ddlDBType.Text = DBConfig.Type;
                txtDBName.Text = DBConfig.DatabaseName;
                txtModelNameSpace.Text = DBConfig.NameSpace;
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("请输入名称", "提示");
                return;
            }
            if (txtConnString.Text.Trim() == "")
            {
                MessageBox.Show("请输入连接字符串", "提示");
                return;
            }
            if (txtDBName.Text.Trim() == "")
            {
                MessageBox.Show("请输入库名", "提示");
                return;
            }

            bool isEdit = DBConfig != null;
            if (!isEdit) { DBConfig = new DatabaseConfig(); }
            DBConfig.Name = txtName.Text.Trim();
            DBConfig.PrimaryKeyType = ddlPrimaryKeyType.Text;
            DBConfig.ConnString = txtConnString.Text.Trim();
            DBConfig.Type = ddlDBType.Text;
            DBConfig.DatabaseName = txtDBName.Text.Trim();
            DBConfig.NameSpace = txtModelNameSpace.Text.Trim();

            if (!isEdit) 
            {
                this.FormMain.listDB.Add(DBConfig);
            }

            this.FormMain.SaveDbConfig();
            this.Close();

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (txtConnString.Text.Trim() == "")
            {
                MessageBox.Show("请输入连接字符串", "提示");
                return;
            }
            if (new DBHelper().TestConn(ddlDBType.Text, txtConnString.Text.Trim()))
            {
                MessageBox.Show("连接测试成功");
            }
            else
            {
                MessageBox.Show("连接测试失败");
            }
        }

    

    }
}
