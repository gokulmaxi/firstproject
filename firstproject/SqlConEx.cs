using Microsoft.Data.SqlClient;
using System.Transactions;

namespace firstproject
{
    internal class SqlConEx
    {
        private SqlConnection conn;
        public SqlConEx() {
            conn = new SqlConnection("Data Source=localhost;Initial Catalog=master;Integrated Security=True;Encrypt=False");
            //         InsertSQL();
            //         selectSQL();
            //         DeleteSQL();
            //         selectSQL();
            //         UpdateSQL();
            //         selectSQL();
            CallStoreProcedure();
            selectSQLEmployee();
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
        public void selectSQLEmployee()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM EmployeeLatest";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("ID " + reader.GetInt32(0) + "name:" + reader.GetString(1)+"salary:"+reader.GetString(6));
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
        public void  CallStoreProcedure()
        {
            conn.Open();
            string procedureName = "updateWithIdFromEmployeeLatest";
            using (SqlCommand cmd = new SqlCommand(procedureName, conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@emp_id",System.Data.SqlDbType.Int).Value=1;
                cmd.Parameters.Add("@salaryInp",System.Data.SqlDbType.Int).Value=900;
                cmd.ExecuteNonQuery();
            }
            conn.Close() ;
        }
    }
}
