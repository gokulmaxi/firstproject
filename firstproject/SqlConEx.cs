using Microsoft.Data.SqlClient;
using System.Transactions;

namespace firstproject
{
    internal class SqlConEx
    {
        private SqlConnection conn;
        public SqlConEx() {
            conn = new SqlConnection("Data Source=localhost;Initial Catalog=students;Integrated Security=True;Encrypt=False");
            //   InsertSQL();
            // selectSQL();
            //DeleteSQL();
            //selectSQL();
                UpdateSQL();
                selectSQL();
        }
        public void selectSQL()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM studentData";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("ID "+ reader.GetInt32(0)+"name:"+reader.GetString(1)+"age:"+reader.GetInt32(4));
            }
            conn.Close();
        }
        public void InsertSQL()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            int id = 5;
            string name = "chand";
            string dept = "mtrs";
            string mailId = "cm@cm.com";
            int age = 23;
            cmd.CommandText = $"insert into studentData values('{id}','{name}','{dept}','{mailId}','{age}','{1}')";
            cmd.ExecuteReader().Close();
            conn.Close();
        }
        public void DeleteSQL()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            int id = 5;
            cmd.CommandText = $"DELETE FROM studentData where id = {id}";
            cmd.ExecuteReader().Close();
            conn.Close();

        }
        public void UpdateSQL()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"UPDATE studentData set age = 25 WHERE id = 3";
            cmd.ExecuteReader() ;
            conn.Close();
        }
    }
}
