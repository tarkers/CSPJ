using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_snake
{

    public static class TABLENAME
    {
        public static string T1A2B = "T1A2B猜數字";
        public static string TTETRIS = "俄羅斯方塊";
        public static string TBALLOON = "射氣球";
        public static string TEGG = "接蛋遊戲";
        public static string TSNAKE = "貪吃蛇";
        public static string TCAR = "賽車遊戲";
    }
    public class Record

    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Mode { get; set; }
        public int Id { get; set; }
        public Record(int score = 0, int mode = 0, string name = "user")
        {
            Name = name;
            Score = score;
            Mode = mode;
        }

    }

    static class DB
    {

        static DataSet ds = new DataSet();
        private static string connect_string = @"Data Source=csfinal.database.windows.net;Initial Catalog=csfinal;User ID=csfinal;Password=Annchen135";


        //測試獲得所有tableName
        public static void testConnect()
        {
            using (SqlConnection con = new SqlConnection(connect_string))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", con))
                {
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine((string)reader["TABLE_NAME"]);
                        }
                    }
                }
            }
        }
        //將使用者分數資料存入database
        public static void InsertScore(Record re, string table_name)
        {
            SqlConnection connection = new SqlConnection(connect_string);
            string query = $"INSERT INTO {table_name} (姓名,分數,模式) VALUES(@姓名, @分數, @模式)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@姓名", re.Name);
            command.Parameters.AddWithValue("@分數", re.Score);
            command.Parameters.AddWithValue("@模式", re.Mode);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error Generated. Details: " + ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        //獲得遊戲所有的資料 依照分數降序排列，回傳record list
        public static List<Record> GetRecords(string table_name)
        {
            Console.WriteLine(table_name);
            
            List<Record> record_list = new List<Record>();
           // return record_list;
            using (SqlConnection connection = new SqlConnection(connect_string))
            {
                string oString = $"SELECT * FROM {table_name} ORDER BY 分數 DESC;";
                SqlCommand oCmd = new SqlCommand(oString, connection);
                connection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        Record tmp = new Record
                        {
                            Id = (int)oReader["編號"],
                            Name = oReader["姓名"].ToString(),
                            Score = (int)oReader["分數"],
                            Mode = (int)oReader["模式"]
                        };
                        record_list.Add(tmp);
                        Console.WriteLine(tmp.Name + " " + tmp.Score.ToString() + " " + tmp.Mode.ToString());
                    }

                    connection.Close();
                }
            }
            return record_list;
        }

    }
}
