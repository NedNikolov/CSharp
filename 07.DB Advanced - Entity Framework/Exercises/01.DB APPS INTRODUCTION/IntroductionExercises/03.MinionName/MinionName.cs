using System;
using System.Data.SqlClient;
using _01.InstallSetup;

public class MinionName
{
    public static void Main()
    {
        int villianId = int.Parse(Console.ReadLine());
        using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
        {
            connection.Open();

            string villianName = GetVillianName(villianId, connection);

            if (villianName == null)
            {
                Console.WriteLine($"No villain with ID {villianId} exists in the database.");
            }
            else
            {
                Console.WriteLine($"Villain: {villianName}");
                PrintNames(villianId, connection);
            }

            connection.Close();
        }
    }

    private static void PrintNames(int villianId, SqlConnection connection)
    {
        string minionsSql =
            "SELECT Name, Age FROM Minions AS m JOIN MinionsVillains AS mv ON mv.MinionId = m.Id WHERE mv.VillainId = @Id";

        using (SqlCommand command = new SqlCommand(minionsSql, connection))
        {
            command.Parameters.AddWithValue("Id", villianId);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    Console.WriteLine("(no minions)");
                }
                else
                {
                    int row = 1;
                    while (reader.Read())
                    {
                        Console.WriteLine($"{row++}. {reader[0]} {reader[1]}");
                    }
                }
            }
        }
    }

    private static string GetVillianName(int villianId, SqlConnection connection)
    {
        string name = "SELECT Name FROM Villains WHERE Id = @id";
        using (SqlCommand command = new SqlCommand(name, connection))
        {
            command.Parameters.AddWithValue("@id", villianId);
            return (string)command.ExecuteScalar();
        }
    }
}

