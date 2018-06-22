using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RegisterUsers
{
    class RegisterUsers
    {
        static string user;
        static DateTime date;
        static Dictionary<string, DateTime> userCollection;

        static void Main(string[] args)
        {
            userCollection = new Dictionary<string, DateTime>();
            var enteredUserWithDate = Console.ReadLine();

            while (enteredUserWithDate != "end")
            {
                ParseInputLine(enteredUserWithDate);

                AddUserDataToUserCollection(user, date);

                enteredUserWithDate = Console.ReadLine();
            }
            PrintFirstFiveRegisteredUsers();
        }

        private static void PrintFirstFiveRegisteredUsers()
        {
            var result = userCollection
                .Reverse()
                .OrderBy(user => user.Value)
                .Take(5)
                .OrderByDescending(user => user.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var user in result)
            {
                Console.WriteLine(user.Key);
            }
        }

        private static void AddUserDataToUserCollection(string user, DateTime date)
        {
            if (!userCollection.ContainsKey(user))
            {
                userCollection[user] = new DateTime();
            }
            userCollection[user] = date;
        }

        static void ParseInputLine(string enteredUserWithDate)
        {
            var splitedUserWithDate = enteredUserWithDate.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            user = splitedUserWithDate[0];
            date = DateTime.ParseExact(splitedUserWithDate[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }
    }
}
