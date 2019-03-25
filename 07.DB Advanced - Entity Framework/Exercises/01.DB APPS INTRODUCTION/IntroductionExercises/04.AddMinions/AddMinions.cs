﻿using System;
using System.Data.SqlClient;
using _01.InstallSetup;

namespace _04.AddMinions
{
    class AddMinions
    {
        static void Main(string[] args)
        {
            string[] minionsInfo = Console.ReadLine().Split();
            string[] villianInfo = Console.ReadLine().Split();

            string minionName = minionsInfo[1];
            int age = int.Parse(minionsInfo[2]);
            string townName = minionsInfo[3];
            string villanName = villianInfo[1];

            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();
                int townId = GetTownId(townName, connection);
                int villainId = GetVillainId(villanName, connection);
                int minionId = InsertMinionAndGetId(minionName, age, townId, connection);
                AssignMinionToVillain(villainId, minionId, connection);

                Console.WriteLine($"Successfully added {minionName} to be minion of {villanName}.");
                connection.Close();
            }
        }

        private static void AssignMinionToVillain(int villainId, int minionId, SqlConnection connection)
        {
            string insertminionVillain = "INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@minionId, @villaindId)";

            using (SqlCommand command = new SqlCommand(insertminionVillain, connection))
            {
                command.Parameters.AddWithValue("@minionId", minionId);
                command.Parameters.AddWithValue("@villainId", villainId);
                command.ExecuteNonQuery();
                
            }
        }

        private static int InsertMinionAndGetId(string minionName, int age, int townId, SqlConnection connection)
        {
            string insertMinion = "INSERT INTO Minions (Name, Age, TownId) VALUES (@name, @age, @townId)";

            using (SqlCommand command = new SqlCommand(insertMinion, connection))
            {
                command.Parameters.AddWithValue("@name", minionName);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@townId", townId);
                command.ExecuteNonQuery();
            }

            string minionsSql = "SELECT Id FROM Minions WHERE Name = @name";
            using (SqlCommand command = new SqlCommand(minionsSql, connection))
            {
                command.Parameters.AddWithValue("@name", minionName);
                return (int) command.ExecuteScalar();
            }
        }

        private static int GetVillainId(string villanName, SqlConnection connection)
        {
            string townSql = "SELECT Id FROM Villains WHERE Name = @Name";
            using (SqlCommand command = new SqlCommand(townSql, connection))
            {
                command.Parameters.AddWithValue("@Name", villanName);
                if (command.ExecuteScalar() == null)
                {
                    InsertIntoVillains(villanName, connection);
                    Console.WriteLine($"Villain {villanName} was added to the database.");
                }

                return (int)command.ExecuteScalar();
            }
        }

        private static void InsertIntoVillains(string townName, SqlConnection connection)
        {
            string insertTown = "INSERT INTO Villains (Name) VALUES (@villainName)";

            using (SqlCommand command = new SqlCommand(insertTown, connection))
            {
                command.Parameters.AddWithValue("@villainName", townName);
                command.ExecuteNonQuery();
            }
        }

        private static int GetTownId(string townName, SqlConnection connection)
        {
            string townSql = "SELECT Id FROM Towns WHERE Name = @Name";
            using (SqlCommand command = new SqlCommand(townSql,connection))
            {
                command.Parameters.AddWithValue("@Name", townName);
                if (command.ExecuteScalar() == null)
                {
                    InsertIntoTowns(townName, connection);
                    Console.WriteLine($"Town {townName} was added to the database.");
                }

                return (int) command.ExecuteScalar();
            }
        }

        private static void InsertIntoTowns(string townName, SqlConnection connection)
        {
            string insertTown = "INSERT INTO Towns (Name) VALUES (@townName)";

            using (SqlCommand command = new SqlCommand(insertTown, connection))
            {
                command.Parameters.AddWithValue("@townName", townName);
                command.ExecuteNonQuery();
            }

        }
    }
}