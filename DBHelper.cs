using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDict
{
    public class DBHelper
    {
        public DBHelper() { }

        public DataTable GetDBTables(DatabaseConfig dbc) {
            DataTable dt = null;
            if (dbc.Type == "MySql")
            {
                String sql = "SELECT table_name as name, table_comment as comment FROM Information_schema.tables WHERE table_schema='"+dbc.DatabaseName+"' AND table_type='BASE TABLE' order by name asc";
                dt = Keen001.KNF.Database.MySqlHelper.GetDataSet(dbc.ConnString, CommandType.Text, sql, null).Tables[0];
            }
            if (dbc.Type == "SQLServer")
            {
                String sql = "select t.name, p.value as comment from sysobjects as t left outer join sys.extended_properties as p on p.major_id=t.id and p.minor_id=0 and p.name='remark' where t.xtype='U' order by t.Name Asc";

               dt = Keen001.KNF.Database.SqlHelper.ExecuteDataTable(dbc.ConnString, CommandType.Text, sql,  null);
            }

            return dt;
        }

        public DataTable GetTableColumns(DatabaseConfig dbc, String tableName)
        {
            DataTable dt = null;
            if (dbc.Type == "MySql")
            {
                String sql = "SELECT column_name AS ColName, data_type AS DataType, " //字段名称
                         + "character_maximum_length AS `MaxLength`," //字符串最大长度
                         + "numeric_precision AS `NumericPrecision`," //数字长度
                         + "numeric_scale AS `NumericScale`," //小数位数
                         + "is_nullable AS `AllowNull`," // 是否允许非空
                         + "CASE WHEN extra = 'auto_increment' THEN 1 ELSE 0 END AS `AutoIncrement`," //是否自增
                         + "column_default AS `DefaultValue`," //默认值
                         + "column_comment AS `Comment`" //备注
                         + "FROM Information_schema.columns WHERE  table_schema='" + dbc.DatabaseName + "' and table_Name='" + tableName + "'";
                Keen001.KNF.Core.KLoger.Instance.Debug("sql:" + sql);
                dt = Keen001.KNF.Database.MySqlHelper.GetDataSet(dbc.ConnString, CommandType.Text, sql, null).Tables[0];
            }
            if (dbc.Type == "SQLServer")
            {
                String sql = ""
                       + "\r\n select sys.columns.name as ColName, sys.types.name as DataType, sys.columns.max_length as MaxLength, sys.columns.is_nullable as AllowNull, "
                       + " null as NumericPrecision, null as NumericScale, null as DefaultValue, 0 as AutoIncrement,"
                       + "\r\n (select count(*) from sys.identity_columns where sys.identity_columns.object_id = sys.columns.object_id and sys.columns.column_id = sys.identity_columns.column_id) as is_identity ,"
                       + "\r\n (select value from sys.extended_properties where sys.extended_properties.major_id = sys.columns.object_id and sys.extended_properties.minor_id = sys.columns.column_id) as Comment"
                       + "\r\n  from sys.columns, sys.tables, sys.types where sys.columns.object_id = sys.tables.object_id and sys.columns.system_type_id=sys.types.system_type_id and sys.tables.name='" + tableName + "' order by sys.columns.column_id"
                       + " ";
                Keen001.KNF.Core.KLoger.Instance.Debug("sql:" + sql);
                dt = Keen001.KNF.Database.SqlHelper.ExecuteDataTable(dbc.ConnString, CommandType.Text, sql, null);
            }

            return dt;
        }

        public DataTable GetZeroTable(DatabaseConfig dbc, String tableName)
        {
            DataTable dt = null;
            String sql = "";
            if (dbc.Type == "MySql")
            {
                sql = "SELECT * from " + tableName + " limit 0";
                dt = Keen001.KNF.Database.MySqlHelper.GetDataSet(dbc.ConnString, CommandType.Text, sql, null).Tables[0];
            }
            if (dbc.Type == "SQLServer")
            {
                sql = "select top 0 * from " + tableName;

                dt = Keen001.KNF.Database.SqlHelper.ExecuteDataTable(dbc.ConnString, CommandType.Text, sql, null);
            }
            Keen001.KNF.Core.KLoger.Instance.Debug("GetZeroTable:sql:" + sql);
            return dt;
        }


        public bool TestConn(String dbType, String connString)
        {
            bool ret = false;
            try
            {
            if (dbType == "SQLServer")
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                conn.Close();
                ret = true;
            }
            if (dbType == "MySql")
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                conn.Close();
                ret = true;
            }
            }
            catch { ret = false; }
            return ret;
        }
    }
}
