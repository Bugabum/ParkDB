using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Park2
{
    class DB
    {
        public DataSet sqlq(string sql)
        {
            NpgsqlConnection connection = CreateConnection();
            DataSet dataSet = new DataSet();
            try
            {
                connection.Open();
            }
            catch (Exception Ex)
            {
                throw;
            }
            try
            {
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection);
                add.Fill(dataSet);
            }
            catch (Exception Ex)
            {
                sqltest(Ex.Message);
            }
            connection.Close();
            return dataSet;
        }
        public int lastid(string table, string attribute)
        {
            NpgsqlConnection connection = CreateConnection();
            try
            {
                connection.Open();
            }
            catch (Exception Ex)
            {
                throw;
            }
            string sql = "SELECT \"" + attribute + "\" FROM public.\"" + table + "\" ORDER BY \"" + attribute + "\" DESC LIMIT 1";
            int id=0;
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Int32.Parse(reader[0].ToString());
                }
                reader.Close();

            }
            connection.Close();
            return id;
        }

        public int getidfromindex(string table,string idattribute, int index)
        {
            NpgsqlConnection connection = CreateConnection();
            try
            {
                connection.Open();
            }
            catch (Exception Ex)
            {
                throw;
            }
            string sql = ("SELECT \""+ idattribute +"\" FROM public.\"" + table + "\" ORDER BY \"" + idattribute + "\" ASC LIMIT 1 OFFSET "+ index);
            int id = 0;
            using(NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Int32.Parse(reader[0].ToString());
                }
                reader.Close();

            }
            connection.Close();
            return id;
        }
        public int exsqli(string sql)
        {
            NpgsqlConnection connection = CreateConnection();
            try
            {
                connection.Open();
            }
            catch (Exception Ex)
            {
                throw;
            }
            int id = 0;
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Int32.Parse(reader[0].ToString());
                }
                reader.Close();

            }
            connection.Close();
            return id;
        }
        public string exsqls(string sql)
        {
            NpgsqlConnection connection = CreateConnection();
            try
            {
                connection.Open();
            }
            catch (Exception Ex)
            {
                throw;
            }
            string value = "";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                try
                {
                    NpgsqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        value = reader[0].ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    return "";
                }
            }
            return value;
        }
        public int sqlupdate(string table, string attribute, string idattribute, int id, string value)
        {
            NpgsqlConnection connection = CreateConnection();
            int count=0;
            try
            {
                connection.Open();
            }
            catch (Exception Ex)
            {
                throw;
            }
            string sql = "UPDATE public.\"" + table + "\" SET \"" + attribute + "\"=\'" + value + "\' WHERE \"" + idattribute + "\" = " + id;
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                try
                {
                    count =command.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                    return count;
                }
            }
            return count;

        }
        public string getvaluefromid(string table, string idattribute, int id, string attribute)
        {
            NpgsqlConnection connection = CreateConnection();
            try
            {
                connection.Open();
            }
            catch (Exception Ex)
            {
                throw;
            }
            string sql = ("SELECT \""+ attribute +"\" FROM public.\"" + table + "\" WHERE \""+ idattribute + "\" = "+ id +" LIMIT 1");
            string value="";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                try
                {
                    NpgsqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                    value = reader[0].ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    return "";
                }
            }
            return value;
        }
        public int getidfromvalue(string table, string idattribute, string attribute, string value)
        {
            NpgsqlConnection connection = CreateConnection();
            try
            {
                connection.Open();
            }
            catch (Exception Ex)
            {
                throw;
            }
            string sql = ("SELECT \""+ idattribute + "\" FROM public.\"" + table + "\" WHERE \"" + attribute + "\" = \'" + value + "\' ORDER BY \"" + idattribute + "\" DESC LIMIT 1");
             int id = -1;
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Int32.Parse(reader[0].ToString());
                }
                reader.Close();

            }
            connection.Close();
            return id;
        }
        public NpgsqlConnection CreateConnection()
        {
            return new NpgsqlConnection("Server = localhost; Port=5432; Database=Park; User Id=postgres; Password = 123;");
        }
        public void sqltest(String sql)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0}", sql);
            MessageBox.Show(messageBoxCS.ToString(), "Hata");
        }
        public Boolean checkforid(string table, string idattribute, int id)
        {
            NpgsqlConnection connection = CreateConnection();
            try
            {
                connection.Open();
            }
            catch (Exception Ex)
            {
                throw;
            }
            string sql = ("SELECT \"" + idattribute + "\" FROM public.\"" + table + "\" WHERE \""+ idattribute +"\" = " + id + " LIMIT 1");
            int number=-1;
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    number = Int32.Parse(reader[0].ToString());
                    
                }
                reader.Close();

            }
            connection.Close();
            if (number == -1)
                return false;
            return true;
        }
        
    }
}
