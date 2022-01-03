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
        public static string TT1A2B = "1A2B猜數字";
        public static string TETRIS = "俄羅斯方塊";
        public static string TBALLOON = "射氣球";
        public static string TEGG = "接蛋遊戲";
        public static string TSNAKE = "貪吃蛇";
    }
    public class Record

    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Mode { get; set; }
    }

    static class DB
    {

        static DataSet ds = new DataSet();
        private static string connect_string = @"Data Source=csfinal.database.windows.net;Initial Catalog=csfinal;User ID=csfinal;Password=Annchen135";

       
        //測試獲得所有tableName
        public static void  testConnect()
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
        public static void InsertScore(Record re, string table_name )
        {
            SqlConnection connection = new SqlConnection(connect_string);
            string query = $"INSERT INTO {table_name} (Name, Score) VALUES(@Name, @Score)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", re.Name);
            command.Parameters.AddWithValue("@Score", re.Score);
            command.Parameters.AddWithValue("@Score", re.Mode);
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
            List<Record> record_list = new List<Record>();
            using (SqlConnection connection = new SqlConnection(connect_string))
            {
                string oString = $"SELECT * FROM {table_name} ORDER BY Score DESC;";
                SqlCommand oCmd = new SqlCommand(oString, connection);
                connection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        Record tmp = new Record
                        {
                            Name = oReader["Name"].ToString(),
                            Score = (int)oReader["Score"],
                            Mode = (int)oReader["Mode"]
                        };
                        record_list.Add(tmp);                     
                       Console.WriteLine(tmp.Name + " " + tmp.Score.ToString());
                    }

                    connection.Close();
                }
            }
            return record_list;
        }

    }
}
