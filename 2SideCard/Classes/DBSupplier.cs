using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace _2SideCard
{
    internal class DBSupplier
    {
        private const string CONNECTION_FOR_ADD = "Data source = Cards.db;mode=ReadWriteCreate";
        private const string CONNECTION_FOR_READ = "Data source = Cards.db;mode=ReadOnly";
        private const string CHECK_EXPRESSION = "CREATE TABLE if not exists Cards (" +
            "id INTEGER PRIMARY KEY AUTOINCREMENT," +
            "question STRING  NOT NULL," +
            "answer   STRING NOT NULL)";
        private const string READ_EXPRESSION = "SELECT * FROM Cards";



        public static void AddToDB(string question, string answer)
        {
            using (var connection = new SqliteConnection(CONNECTION_FOR_ADD))
            {
                connection.Open();

                using (SqliteCommand command = new SqliteCommand())
                {
                    command.Connection = connection;
                    command.CommandText = CHECK_EXPRESSION;
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO Cards (question,answer) VALUES (@question,@answer)";
                    var questionParam = new SqliteParameter("@question", question);
                    var answerParam = new SqliteParameter("@answer", answer);
                    command.Parameters.Add(questionParam);
                    command.Parameters.Add(answerParam);
                    command.ExecuteNonQuery();

                }
            }

        }


        public static void ReadDB(out string questions, out string answers)
        {
            questions = "";
            answers = "";
            if (checkDB())
            {
                return;
            }
            using (var connection = new SqliteConnection(CONNECTION_FOR_READ))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(READ_EXPRESSION, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            questions += "\n" + reader.GetValue(1);
                            answers += "\n" + reader.GetValue(2);
                        }
                    }    
                }
            }
        }

        private static bool checkDB()
        {
            return !File.Exists("Cards.db");
        }
    }
}
