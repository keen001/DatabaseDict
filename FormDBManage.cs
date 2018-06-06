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
    public partial class FormDBManage : Form
    {
        private FormMain FormMain = null;
        public FormDBManage(FormMain formMain)
        {
            this.FormMain = formMain;
            InitializeComponent();
        }

        private void FormDBManage_Load(object sender, EventArgs e)
        {
            
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = this.FormMain.listDB;

        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择需要操作的数据", "提示");
                return;
            }

            int index = this.dataGridView1.SelectedRows[0].Index;
            new FormDBConfig(this.FormMain, this.FormMain.listDB[index]).ShowDialog();
            this.Close();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择需要操作的数据", "提示");
                return;
            }
                int index = this.dataGridView1.SelectedRows[0].Index;
                if (MessageBox.Show("是否确认删除数据库[" + this.FormMain.listDB[index].Name + "]",  "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {

                    this.FormMain.listDB.RemoveAt(index);
                    this.FormMain.SaveDbConfig();
                    this.Close();
                }

        }

  

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    dataGridView1.Rows[e.RowIndex].Selected = true;  
                }
            }
        }
    }
}
