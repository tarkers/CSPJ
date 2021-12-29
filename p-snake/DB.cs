using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_snake
{

    class DB
    {
        DataSet ds = new DataSet();

        private string connect_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bigsh\source\repos\Snake\Snake\record.mdf;Integrated Security=True";
        public class Record

        {
            public string Name { get; set; }
            public int Score { get; set; }
            public int Mode { get; set; }
        }
        public void InsertScore(Record re, string table_name = "Snake")
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
        public void GetRecords(string table_name = "Snake")
        {
            List<Record> ranklist = new List<Record>();
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
                        ranklist.Add(tmp);
                        Console.WriteLine(tmp.Name + " " + tmp.Score.ToString());
                    }

                    connection.Close();
                }
            }
        }

    }
}
