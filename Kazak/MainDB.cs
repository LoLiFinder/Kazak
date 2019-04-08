using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kazak
{
    class MainDB
    {

        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=main.accdb";
        private OleDbConnection connection;
        public MainDB()
        {
            connection = new OleDbConnection(connectionString);


        }



        public int authUser(string login, string password)
        {

            connection.Open();
            OleDbCommand comand = new OleDbCommand(String.Format("SELECT * FROM users WHERE login='{0}' AND pass='{1}'", login, password), connection);
            OleDbDataReader reader = comand.ExecuteReader();
            if (!reader.HasRows)
            {
                connection.Close();
                return -1;
            }

            reader.Read();
            int id_user = (int) reader[0];
            int type = (int)reader[3];
            switch (type)
            {
                case 0:
                    connection.Close();
                    reader.Close();
                    return 0;

                case 1:
                    connection.Close();
                    reader.Close();
                    logAuthuser(id_user);
                    return 1;
                default:
                    connection.Close();
                    reader.Close();
                    return -1;

            }


        }

        public void logAuthuser(int id)
        {
            connection.Open();
            OleDbCommand writeData = new OleDbCommand(String.Format("INSERT INTO log (id_users,[action]) VALUES ({0},'Вход');", id), connection);
            writeData.ExecuteNonQuery();
            connection.Close();
        }


        public void AddOil(string name)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand(String.Format("INSERT INTO oil (nameOil) VALUES ('{0}');",name),connection);
            command.ExecuteNonQuery();
            connection.Close();

        }   

        public void AddVod(string firstname,string lastname,DateTime date,string number)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand(String.Format("INSERT INTO voditel (first_name,last_name,dateB,pasport) VALUES ('{0}','{1}','{2}','{3}');",firstname,lastname,date.ToString("d"),number),connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void AddVenicle(string nameVec,int id_voditel,int id_oil,string normalOil)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand(String.Format("INSERT INTO vec (idvod,namevec,typeOil,normalOil) VALUES ('{0}','{1}','{2}','{3}');",id_voditel,nameVec,id_oil,normalOil),connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
   
