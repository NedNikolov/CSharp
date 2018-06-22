using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniBeerPong
{
    class SoftUniBeerPong
    {
        static int score = 0;
        static string team = string.Empty;
        static string player = string.Empty;

        static Dictionary<string, Dictionary<string, int>> teams =
            new Dictionary<string, Dictionary<string, int>>();

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "stop the game")
            {
                var splitedTeamData = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                player = splitedTeamData[0];
                team = splitedTeamData[1];
                score = Convert.ToInt32(splitedTeamData[2]);

                if (areEnougthPlayers())
                {
                    
                }
                else
                {
                    if (!teams.ContainsKey(team))
                    {
                        teams[team] = new Dictionary<string, int>();
                    }
                    if (!teams[team].ContainsKey(player))
                    {
                        teams[team][player] = 0;
                    }
                    teams[team][player] = score;
                }
                input = Console.ReadLine();
            }

            var teamCounter = 1;
            foreach (var pair in teams
                .OrderByDescending(x => x.Value.Values.Sum())
                .Where(x => x.Value.Count > 2))
            {
                Console.WriteLine("{0}. {1}; Players:", teamCounter, pair.Key);
                foreach (var pairs in pair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("###{0}: {1}", pairs.Key, pairs.Value);
                }
                teamCounter++;
            }
        }
        static bool areEnougthPlayers()
        {
            if (teams.ContainsKey(team))
            {
                return teams[team].Values.Count == 3;
            }
            else return false;
        }
    }
}
