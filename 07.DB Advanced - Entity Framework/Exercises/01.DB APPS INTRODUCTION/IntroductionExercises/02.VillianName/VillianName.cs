using System;
using System.Data.SqlClient;
using _01.InstallSetup;

public class VillianName
    {
        public static void Main()
        {
            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();
                string villianInfo = @"SELECT v.Name, COUNT(mv.MinionId) AS MinionsCount FROM Villains AS v
                JOIN MinionsVillains AS mv ON mv.MinionId = v.Id
                GROUP BY v.Name
                    HAVING COUNT(mv.MinionId) >= 3
                ORDER BY MinionsCount DESC";

                using (SqlCommand command = new SqlCommand(villianInfo, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader[0]} -> {reader[1]}");
                        }
                    }
                }
                connection.Close();
            }
        }
    }

