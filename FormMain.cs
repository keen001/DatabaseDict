using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDict
{
    public partial class FormMain : Form
    {
        private DDConfig myDDConfig = new DDConfig();
        internal List<DatabaseConfig> listDB = new List<DatabaseConfig>();
        private DBHelper myDBHelper = new DBHelper();
        BindingSource bsDBList;

        DataTable currentDataBaseTables;//当前数据库表列表
        public FormMain()
        {
            InitializeComponent();
        }

        private void InitConfit()
        {
            //DatabaseConfig db3 = new DatabaseConfig();
            //db3.ConnString = @"Database='adslfix';Data Source='127.0.0.1';port='3306';User Id='root';Password='root';charset='utf8';pooling=true";
            //db3.DatabaseName = "adslfix";
            //db3.Name = "本机adslfix";
            //db3.NameSpace = "Keen001.Portal.Areas.Portal.Models";
            //db3.Type = "MySql";
            //listDB.Add(db3);

            //DatabaseConfig db2 = new DatabaseConfig();
            //db2.ConnString = @"server=118.123.21.200,52805\SQLSERVER2005;User ID=sa;Password=doyouloveme;database=KN_Portal;";
            //db2.DatabaseName = "XKMobile";
            //db2.Name = "彩赢Portal";
            //db2.NameSpace = "Keen001.Portal.Areas.Portal.Models";
            //db2.Type = "SQLServer";
            //listDB.Add(db2);

            //DatabaseConfig db1 = new DatabaseConfig();
            //db1.ConnString = "Database='dkf';Data Source='118.123.21.200';port='52808';User Id='keen';Password='doyouloveme';charset='utf8';pooling=true";
            //db1.DatabaseName = "dkf";
            //db1.Name = "多客服";
            //db1.Type = "MySql";
            //db1.NameSpace = "keen001.dkf.model";
            //listDB.Add(db1);

            myDDConfig.LoadFromFile();
            listDB = myDDConfig.listDBConfig;

          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitConfit();

            dataGridView1.AutoGenerateColumns = false;
            bsDBList = new BindingSource();
            bsDBList.DataSource = listDB;
            comboBox_Database.DataSource = bsDBList;
            comboBox_Database.DisplayMember = "Name";

            comboBox_PrimaryKeyType.SelectedIndex = 0;


            if (listDB.Count > 0)
            {
                LoadDBTables();
                dbConfigLoaded = true;
                ShowColumns();
            }
            else
            {
                dbConfigLoaded = true;
            }
        }

        /// <summary>
        /// 加载数据库的表数据
        /// </summary>
        private void LoadDBTables()
        {
            DatabaseConfig dbConfig = (DatabaseConfig)comboBox_Database.SelectedItem;
            if (!myDBHelper.TestConn(dbConfig.Type, dbConfig.ConnString))
            {
                MessageBox.Show("数据库连接串错误，无法读取。", "提示");
                return;
            }
            DataTable dtTables = myDBHelper.GetDBTables(dbConfig);
            currentDataBaseTables = dtTables;
            listBox_Tables.DataSource = dtTables;
            listBox_Tables.DisplayMember = "name";

            if (dtTables!=null && dtTables.Rows.Count > 0)
            {
                this.ShowColumns();
            }

        }

        private Boolean dbConfigLoaded = false;
        private void comboBox_Database_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dbConfigLoaded)
            {
                LoadDBTables();
            }
        }

        private void listBox_Tables_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (listBox_Tables.Items.Count < 1) { return; }

            this.listBox_Tables.ItemHeight = 22;
            using (Graphics g = e.Graphics)
            {
                //如果该项被选择
                Brush myBrush = Brushes.Black;

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), e.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(listBox_Tables.BackColor), e.Bounds);
                }
                //画出项文本
                Font font = new Font("微软雅黑", 10);
                e.Graphics.DrawString(listBox_Tables.GetItemText(listBox_Tables.Items[e.Index]), font, myBrush, e.Bounds.X, e.Bounds.Y);
                e.DrawFocusRectangle();
            }
        }

        private void listBox_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ShowColumns();
        }


        private DataTable dtColumns = null;
        private void ShowColumns()
        {
            if (listBox_Tables.SelectedItem == null || !dbConfigLoaded) { return; }
            if (listBox_Tables.Items.Count <= 0) { return; }
            DatabaseConfig dbConfig = (DatabaseConfig)comboBox_Database.SelectedItem;
            if (!myDBHelper.TestConn(dbConfig.Type, dbConfig.ConnString))
            {
                MessageBox.Show("数据库连接串错误，无法读取。", "提示");
                return;
            }
            DataRowView dr = (DataRowView)listBox_Tables.SelectedItem;
            if (dr["name"] == null) { return; }

            String tableName = dr["name"].ToString();
            String className = "";
            if (tableName.IndexOf("_") > 0)
            {
                string[] aryClassName = tableName.Split('_');
                for (int i = 0; i < aryClassName.Length; i++)
                {
                    //需要调整
                    if (aryClassName[i].Length == 1) 
                    {
                        className += aryClassName[i].ToUpper();
                    }
                    else
                    {
                        className += aryClassName[i].Substring(0, 1).ToUpper() + aryClassName[i].Substring(1, aryClassName[i].Length - 1);
                    }
                }
            }
            else
            {
                className = this.OnlyUpperFirst(tableName);
            }
            txtClassName.Text = className;

            txtTableComment.Text = dr["comment"].ToString();
            txtNameSpace.Text = dbConfig.NameSpace;

            dtColumns = myDBHelper.GetTableColumns(dbConfig, dr["name"].ToString());
            this.dataGridView1.DataSource = dtColumns;
            this.comboBox_PrimaryKey.DataSource = dtColumns;
            this.comboBox_PrimaryKey.DisplayMember = "ColName";
            ShowColumnDetail();
        }


        private void ShowColumnDetail() {
            if (this.dataGridView1.SelectedRows.Count <= 0) { return; }
            int index = this.dataGridView1.SelectedRows[0].Index;
            if (dtColumns == null || index >= dtColumns.Rows.Count) { return; }
            DataRow dr = dtColumns.Rows[index];
            labelColumnName.Text = dr["ColName"].ToString();
            labelColumnType.Text = dr["DataType"].ToString();
            if (dr["DataType"].ToString().ToLower().Trim() == "varchar")
            {
                labelColumnType.Text += "(" + dr["MaxLength"].ToString() + ")";
            }
            else {
                if (dr["NumericPrecision"].ToString() != "")
                {
                    labelColumnType.Text += "(" + dr["NumericPrecision"].ToString() + ")";
                }
            }

            labelColumnDefault.Text = dr["DefaultValue"].ToString();
            labelColumnAuto.Text = Convert.ToInt32(dr["AutoIncrement"])==1?"自增":"非自增";
            labelColumnAllowNull.Text = dr["AllowNull"].ToString();
            txtColumnComment.Text = dr["Comment"].ToString();
        }


        public void SaveDbConfig()
        {
            //保存数据库配置到配置文件
            myDDConfig.listDBConfig = listDB;
            myDDConfig.Save();


            //刷新主界面
            bsDBList.ResetBindings(false);

            LoadDBTables();
            ShowColumns();
        }

    


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ShowColumnDetail();
        }

        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            this.CreateCode();
        }

        private bool CreateCode()
        {
            if (txtNameSpace.Text.Trim() == "") { MessageBox.Show("请输入命名空间或包名"); return false; }
            if (txtClassName.Text.Trim() == "") { MessageBox.Show("请输入类名"); return false; }
            String strNameSpace = txtNameSpace.Text.Trim();
            String strClassName = txtClassName.Text.Trim();
            DatabaseConfig dbConfig = (DatabaseConfig)comboBox_Database.SelectedItem;
            DataRowView dr = (DataRowView)listBox_Tables.SelectedItem;
            String strDBTableName = dr["name"].ToString();
            DataTable dtZeroTable = new DBHelper().GetZeroTable(dbConfig, strDBTableName);
            DataTable dtColumns = myDBHelper.GetTableColumns(dbConfig, strDBTableName);


            #region 生成C#代码
            StringBuilder b = new StringBuilder();
            b.Append("using System;");
            b.Append("\r\n" + "using System.Collections.Generic;");
            b.Append("\r\n" + "using System.Linq;");
            b.Append("\r\n" + "using System.Text;");
            b.Append("\r\n" + "using System.Threading.Tasks;");
            b.Append("\r\n" + "namespace " + strNameSpace);
            b.Append("\r\n" + "{");
            b.Append("\r\n" + "    public class " + strClassName + " : Entity<" + strClassName + ">");
            b.Append("\r\n" + "    {");
            b.Append("\r\n" + "        /// <summary>");
            b.Append("\r\n" + "        /// " + txtTableComment.Text.Trim().Replace("\r\n", "\r\n        /// "));
            b.Append("\r\n" + "        /// </summary>");
            b.Append("\r\n" + "        public " + strClassName + "()");
            b.Append("\r\n" + "        {");
            b.Append("\r\n" + "            this._DBTableName = \"" + strDBTableName + "\";");
            if (comboBox_PrimaryKeyType.Text == "自增")
            {
                b.Append("\r\n" + "            this._PrimaryKeyType = Database.PrimaryKeyType.AutoIncrease;");
            }
            else
            {
                b.Append("\r\n" + "            this._PrimaryKeyType = Database.PrimaryKeyType.GUID;");
            }
            b.Append("\r\n" + "            this._PrimaryKey = \"" + comboBox_PrimaryKey.Text + "\";");
            b.Append("\r\n" + "        }");
            for (int i = 0; i < dtZeroTable.Columns.Count; i++)
            {
                String comment = "";
                for (int j = 0; j < dtColumns.Rows.Count; j++)
                {
                    if (dtColumns.Rows[j]["ColName"].ToString().ToLower() == dtZeroTable.Columns[i].ColumnName.ToLower())
                    {
                        comment = dtColumns.Rows[j]["Comment"].ToString();
                        break;
                    }
                }
                b.Append("\r\n");
                b.Append("\r\n" + "        /// <summary>");
                b.Append("\r\n" + "        /// " + comment.Replace("\r\n", "\r\n        /// "));
                b.Append("\r\n" + "        /// </summary>");
                if (dtZeroTable.Columns[i].DataType.ToString().ToLower() == "System.String".ToLower()) 
                {
                    b.Append("\r\n" + "        public " + dtZeroTable.Columns[i].DataType.ToString() + " " + dtZeroTable.Columns[i].ColumnName + " { get; set; }");
                }
                else
                {
                    b.Append("\r\n" + "        public " + dtZeroTable.Columns[i].DataType.ToString() + "? " + dtZeroTable.Columns[i].ColumnName + " { get; set; }");
                }
            }
            b.Append("\r\n" + "    }");
            b.Append("\r\n" + "}");
            txtCodeCSharp.Text = b.ToString();
            #endregion

            #region 生成JAVA代码
             b = new StringBuilder();
             b.Append("package " + strNameSpace + ";\r\n");
             b.Append("import java.io.Serializable;\r\n");
             b.Append("import java.util.Date;\r\n");

             b.Append("import javax.persistence.GenerationType;\r\n");
             b.Append("import javax.persistence.Column;\r\n");
             b.Append("import javax.persistence.Entity;\r\n");
             b.Append("import javax.persistence.GeneratedValue;\r\n");
             b.Append("import javax.persistence.Id;\r\n");
             b.Append("import javax.persistence.Table;\r\n");
             b.Append("import org.apache.commons.lang.builder.ToStringBuilder;\r\n");
             b.Append("import org.hibernate.annotations.GenericGenerator;\r\n");
             b.Append("\r\n");
             b.Append("/**\r\n");
             b.Append(" * " + txtTableComment.Text.Trim().Replace("\r\n", "\r\n      *") + "\r\n");
             b.Append(" */\r\n");
             b.Append("@Entity\r\n");
             b.Append("@Table(name = \""+strDBTableName+"\")\r\n");
             b.Append("public class " + OnlyUpperFirst(getJavaColumnName(strClassName)) + " implements Serializable {\r\n");
             b.Append("     private static final long serialVersionUID = 1L;\r\n");
             if (comboBox_PrimaryKeyType.Text == "自增")
             {
                 b.Append("     @Id\r\n");
                 b.Append("     @GeneratedValue(strategy = GenerationType.IDENTITY)\r\n");
                 b.Append("     private Long " + comboBox_PrimaryKey.Text + ";\r\n");


                 b.Append("     public Long get" + OnlyUpperFirst(comboBox_PrimaryKey.Text) + "() {\r\n");
                 b.Append("         return " + comboBox_PrimaryKey.Text + ";\r\n");
                 b.Append("     }\r\n");
                 b.Append("     public void set" + OnlyUpperFirst(comboBox_PrimaryKey.Text) + "(Long " + comboBox_PrimaryKey.Text + ") {\r\n");
                 b.Append("         this." + comboBox_PrimaryKey.Text + " = " + comboBox_PrimaryKey.Text + ";\r\n");
                 b.Append("     }\r\n");
             }
             else
             {
                 b.Append("     @Id\r\n");
                 b.Append("     @GenericGenerator(name = \"systemUUID\", strategy = \"uuid\")\r\n");
                 b.Append("     @GeneratedValue(generator = \"systemUUID\")\r\n");
                 b.Append("     @Column(name = \"" + comboBox_PrimaryKey.Text + "\", unique = true, nullable = false)\r\n");
                 b.Append("     private String " + comboBox_PrimaryKey.Text + ";\r\n");

                 b.Append("     public String get" + OnlyUpperFirst(comboBox_PrimaryKey.Text) + "() {\r\n");
                 b.Append("         return " + comboBox_PrimaryKey.Text + ";\r\n");
                 b.Append("     }\r\n");
                 b.Append("     public void set" + OnlyUpperFirst(comboBox_PrimaryKey.Text) + "(String " + comboBox_PrimaryKey.Text + ") {\r\n");
                 b.Append("         this." + comboBox_PrimaryKey.Text + " = " + comboBox_PrimaryKey.Text + ";\r\n");
                 b.Append("     }\r\n");
             }
             for (int i = 0; i < dtZeroTable.Columns.Count; i++)
             {
                 if (dtZeroTable.Columns[i].ColumnName == comboBox_PrimaryKey.Text) { continue; }
                 String comment = "";
                 for (int j = 0; j < dtColumns.Rows.Count; j++)
                 {
                     if (dtColumns.Rows[j]["ColName"].ToString().ToLower() == dtZeroTable.Columns[i].ColumnName.ToLower())
                     {
                         comment = dtColumns.Rows[j]["Comment"].ToString();
                         break;
                     }
                 }

                 b.Append("     @Column(name = \"" + dtZeroTable.Columns[i].ColumnName + "\")\r\n");
                 string colType = getJavaColumnType(dtZeroTable.Columns[i].DataType.ToString());
                 string colName = getJavaColumnName(dtZeroTable.Columns[i].ColumnName);
                 b.Append("     private " + colType + " " + colName + ";\r\n");

                 b.Append("     /**\r\n");
                 b.Append("      *" + comment.Replace("\r\n", "\r\n      *") + "\r\n");
                 b.Append("      */\r\n");
                 b.Append("     public " + colType + " get" + OnlyUpperFirst(colName) + "() {\r\n");
                 b.Append("         return " + colName + ";\r\n");
                 b.Append("     }\r\n");


                 b.Append("     /**\r\n");
                 b.Append("      *"+comment.Replace("\r\n", "\r\n      *")+"\r\n");
                 b.Append("      */\r\n");
                 b.Append("     public void set" + OnlyUpperFirst(colName) + "(" + colType + " " + colName + ") {\r\n");
                 b.Append("         this." + colName + " = " + colName + ";\r\n");
                 b.Append("     }\r\n");
             }

             b.Append("     public " + OnlyUpperFirst(getJavaColumnName(strClassName)) + "(){}");
             b.Append("}\r\n");
             txtCodeJava.Text = b.ToString();
            #endregion



             #region 生成Mybatis代码
             b = new StringBuilder();
             b.Append("package " + strNameSpace + ";\r\n"); 
             b.Append("import java.util.Date;\r\n");
             b.Append("\r\n");
             b.Append("/**\r\n");
             b.Append(" * " + txtTableComment.Text.Trim().Replace("\r\n", "\r\n      *") + "\r\n");
             b.Append(" */\r\n");

             b.Append("public class " + OnlyUpperFirst(getJavaColumnName(strClassName)) + " {\r\n");
       
             for (int i = 0; i < dtZeroTable.Columns.Count; i++)
             {
                 //if (dtZeroTable.Columns[i].ColumnName == comboBox_PrimaryKey.Text) { continue; }
                 String comment = "";
                 for (int j = 0; j < dtColumns.Rows.Count; j++)
                 {
                     if (dtColumns.Rows[j]["ColName"].ToString().ToLower() == dtZeroTable.Columns[i].ColumnName.ToLower())
                     {
                         comment = dtColumns.Rows[j]["Comment"].ToString();
                         break;
                     }
                 }

                 //b.Append("     @Column(name = \"" + dtZeroTable.Columns[i].ColumnName + "\")\r\n");
                 string colType = getJavaColumnType(dtZeroTable.Columns[i].DataType.ToString());
                 string colName = getJavaColumnName(dtZeroTable.Columns[i].ColumnName);
                 b.Append("     private " + colType + " " + colName + ";\r\n");

                 b.Append("     /**\r\n");
                 b.Append("      *" + comment.Replace("\r\n", "\r\n      *") + "\r\n");
                 b.Append("      */\r\n");
                 b.Append("     public " + colType + " get" + OnlyUpperFirst(colName) + "() {\r\n");
                 b.Append("         return " + colName + ";\r\n");
                 b.Append("     }\r\n");


                 b.Append("     /**\r\n");
                 b.Append("      *" + comment.Replace("\r\n", "\r\n      *") + "\r\n");
                 b.Append("      */\r\n");
                 b.Append("     public void set" + OnlyUpperFirst(colName) + "(" + colType + " " + colName + ") {\r\n");
                 b.Append("         this." + colName + " = " + colName + ";\r\n");
                 b.Append("     }\r\n");
             }

             b.Append("     public " + OnlyUpperFirst(getJavaColumnName(strClassName)) + "(){}");
             b.Append("}\r\n");
             txtCodeMybatis.Text = b.ToString();
             #endregion
            return true;
        }

        private string getJavaColumnName(string name)
        {
            string[] aryName = name.Split('_');
            string tmp = "";
            for (int i = 0; i < aryName.Length; i++)
            {
                if (i == 0) { tmp += aryName[i]; }
                else {
                    tmp += UpperFirstChar(aryName[i]);
                }
            }
            return tmp;
        }
        private string getJavaColumnType(string type)
        {
            if (type == "System.String") { type = "String"; }
            if (type == "System.Int32") { type = "Integer"; }
            if (type == "System.Int64") { type = "Long"; }
            if (type == "System.DateTime") { type = "Date"; }
            return type;
        }

        private string UpperFirstChar(string str)
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(str);
        }
        private string OnlyUpperFirst(string str)
        {
            if (str.Length == 1) { return str.ToUpper(); }
            else{
            
            return str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1);
            }
        }


        private void btnCopyFile_Click(object sender, EventArgs e)
        {
            if (this.CreateCode())
            {
                string folder = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "\\models\\";
                if (!Directory.Exists(folder)) { Directory.CreateDirectory(folder); }
                String strClassName = txtClassName.Text.Trim();
                String fileName = folder + strClassName + ".cs";
                StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
                writer.Write(txtCodeCSharp.Text.Trim());
                writer.Close();

               StringCollection sc = new StringCollection();
                sc.Add(fileName);
                Clipboard.SetFileDropList(sc);
                MessageBox.Show("代码文件已经生成并复制到剪贴板", "代码生成提示");
            }
        }

        private void btnDatabaseAdd_Click(object sender, EventArgs e)
        {
            new FormDBConfig(this, null).ShowDialog();
        }

        private void btnDatabaseManage_Click(object sender, EventArgs e)
        {
            new FormDBManage(this).ShowDialog();
        }

        private void btnCopyFileJava_Click(object sender, EventArgs e)
        {
            if (this.CreateCode())
            {
                string folder = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "\\models\\";
                if (!Directory.Exists(folder)) { Directory.CreateDirectory(folder); }
                String strClassName = txtClassName.Text.Trim();
                String fileName = folder + strClassName + ".java";
                StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
                writer.Write(txtCodeJava.Text.Trim());
                writer.Close();

                StringCollection sc = new StringCollection();
                sc.Add(fileName);
                Clipboard.SetFileDropList(sc);
                MessageBox.Show("代码文件已经生成并复制到剪贴板", "代码生成提示");
            }
        }

        private void btnCopyFileMybatis_Click(object sender, EventArgs e)
        {
            if (this.CreateCode())
            {
                string folder = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "\\models\\";
                if (!Directory.Exists(folder)) { Directory.CreateDirectory(folder); }
                String strClassName = txtClassName.Text.Trim();
             
                String fileName = folder + strClassName + ".java";
                StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
                writer.Write(txtCodeMybatis.Text.Trim());
                writer.Close();

                StringCollection sc = new StringCollection();
                sc.Add(fileName);
                Clipboard.SetFileDropList(sc);
                MessageBox.Show("代码文件已经生成并复制到剪贴板", "代码生成提示");
            }
        }

        /// <summary>
        /// 搜索表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string value= this.textBox1.Text;
            if (value.Length > 0)
            {
                DataTable tempTable = new DataTable();
                tempTable.Columns.Add("name", typeof(string));
                tempTable.Columns.Add("comment", typeof(string));
                foreach (DataRow item in currentDataBaseTables.Rows)
                {
                    if (item["name"].ToString().ToUpper().IndexOf(value.ToUpper())!=-1)
                    {
                        DataRow row = tempTable.NewRow();
                        row["name"] = item["name"].ToString();
                        row["comment"] = item["comment"].ToString();
                        tempTable.Rows.Add(row);
                    }
                }

                listBox_Tables.DataSource = tempTable;
                listBox_Tables.DisplayMember = "name";
            }
            else
            {
                listBox_Tables.DataSource = currentDataBaseTables;
                listBox_Tables.DisplayMember = "name";
            }


        }
    }
}
