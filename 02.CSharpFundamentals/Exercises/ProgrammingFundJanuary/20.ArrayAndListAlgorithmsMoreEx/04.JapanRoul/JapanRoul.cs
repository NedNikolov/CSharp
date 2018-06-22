using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace _04.JapanRoul
{
    class JapanRoul
    {
        static void Main(string[] args)
        {
            int[] bullets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isDead = false;

            string[] players = Console.ReadLine().Split(' ');
            int indexBullet = 0;
            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i] == 1)
                {
                    indexBullet = i;
                    break;
                }
            }

            for (int i = 0; i < players.Length; i++)
            {
                string[] tokens = players[i].Split(',');
                string direction = tokens[1];
                int power = int.Parse(tokens[0]);

                switch (direction)
                {
                    case "Right":
                        indexBullet = (indexBullet + power) % bullets.Length;
                        break;
                    case "Left":
                        if (indexBullet - power < 0)
                        {
                            indexBullet = bullets.Length - (Math.Abs((indexBullet - power) % bullets.Length));
                        }
                        else
                        {
                            indexBullet = indexBullet - power;
                        }
                        break;
                }

                if (indexBullet == 2)
                {
                    Console.WriteLine("Game over! Player {0} is dead.", i);
                    isDead = true;
                    break;
                }

                indexBullet = indexBullet + 1== bullets.Length ? 0 : indexBullet + 1;
            }
            if (!isDead)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
