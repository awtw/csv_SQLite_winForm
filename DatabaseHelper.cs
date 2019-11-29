using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace SpliteHelper
{
    public class DatabaseHelper
    {
        public static string DatabasePath { get; set; }

        public static void Insert(List<TemperatureRecord> temperatureRecords)
        {
            var query = "INSERT INTO temperature " +
                        "(ID,時間,第1段溫度顯示值,第2段溫度顯示值,第3段溫度顯示值,第4段溫度顯示值,第5段溫度顯示值,第6段溫度顯示值) " +
                        "VALUES (@ID,@時間,@第1段溫度顯示值,@第2段溫度顯示值,@第3段溫度顯示值,@第4段溫度顯示值,@第5段溫度顯示值,@第6段溫度顯示值)";

            using (var cn = new SQLiteConnection($"Data Source = {DatabasePath}"))
            {
                cn.Open();
                try
                {
                    using (var trans = cn.BeginTransaction())
                    {
                        if (temperatureRecords != null)
                        {
                            foreach (var item in temperatureRecords)
                            {
                                //var key = Guid.NewGuid().ToString();
                                if(item == null) continue;
                                var affectedRows = cn.Execute(query, new
                                {
                                    ID = item.ID,
                                    時間 = item.時間,
                                    第1段溫度顯示值 = item.第1段溫度顯示值,
                                    第2段溫度顯示值 = item.第2段溫度顯示值,
                                    第3段溫度顯示值 = item.第3段溫度顯示值,
                                    第4段溫度顯示值 = item.第4段溫度顯示值,
                                    第5段溫度顯示值 = item.第5段溫度顯示值,
                                    第6段溫度顯示值 = item.第6段溫度顯示值,
                                });
                            }
                            trans.Commit();
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public static List<TemperatureRecord> Get()
        {
            using (var cn  = new SQLiteConnection($"Data Source = {DatabasePath}"))
            {
                var list = cn.Query<TemperatureRecord>("select * from temperature");
                return list.ToList();
            }
        }

        public static List<TemperatureRecord> Get(DateTime from, DateTime to,string selectBox)
        {
            using (var cn = new SQLiteConnection($"Data Source = {DatabasePath}"))
            {
                var txtFrom = from.ToString("yyyy-MM-dd HH:mm:ss");
                var txtTo = to.ToString("yyyy-MM-dd HH:mm:ss");
                var query = $"select * from temperature where 時間 >= '{txtFrom}' and 時間 <= '{txtTo}' ";
                //MessageBox.Show(query);
                return cn.Query<TemperatureRecord>(query).ToList();
            }
        }

        public static List<TemperatureRecord> Get(string rowName,string txtFrom, string txtTo)
        {
            using (var cn = new SQLiteConnection($"Data Source = {DatabasePath}"))
            {
                var query = $"select * from temperature where {rowName} >= '{txtFrom}' and {rowName} <= '{txtTo}' ";
                return cn.Query<TemperatureRecord>(query).ToList();
            }
        }

        public static void Update(TemperatureRecord record)
        {
            using (var cn = new SQLiteConnection($"Data Source = {DatabasePath}"))
            {
                cn.Open();
                try
                {
                    var query = "UPDATE temperature SET 時間 =" +
                                " @時間,第1段溫度顯示值 = @第1段溫度顯示值," +
                                "第2段溫度顯示值 = @第2段溫度顯示值," +
                                "第3段溫度顯示值 = @第3段溫度顯示值," +
                                "第4段溫度顯示值 = @第4段溫度顯示值," +
                                "第5段溫度顯示值 = @第5段溫度顯示值," +
                                "第6段溫度顯示值 = @第6段溫度顯示值 " +
                                "WHERE ID = @ID ";
                    var results = cn.Execute(query, record);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public static void Delete( string guid)
        {
            using (var cn = new SQLiteConnection($"Data Source = {DatabasePath}"))
            {
                cn.Open();
                try
                {
                    var query = $"DELETE FROM temperature WHERE ID = '{guid}'";
                    var results = cn.Execute(query);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
    }
}
