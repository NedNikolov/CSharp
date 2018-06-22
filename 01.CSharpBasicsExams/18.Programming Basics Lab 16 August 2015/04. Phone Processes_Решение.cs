namespace PhoneProcesses
{
    using System;

    class PhoneProcesses
    {
        static void Main()
        {
            string initialPowerString = Console.ReadLine();
            initialPowerString = initialPowerString.Replace("%", "");
            int initialPower = int.Parse(initialPowerString);

            string command = Console.ReadLine();
            bool phoneOff = initialPower == 0;
            bool connectCharger = initialPower <= 15;
            
            int remaining = 0;
            while (command.ToLower() != "end")
            {
                var consumedPower = int.Parse(command.Substring(command.Length - 3, 2));

                if (connectCharger || phoneOff)
                {
                    remaining++;
                }
                else
                {
                    initialPower -= consumedPower;
                    phoneOff = initialPower <= 0;
                    connectCharger = !phoneOff && initialPower <= 15;
                }

                command = Console.ReadLine();
            }

            if (phoneOff)
            {
                Console.WriteLine("Phone Off");
            }
            else if (connectCharger)
            {
                Console.WriteLine("Connect charger -> {0}%", initialPower);
                Console.WriteLine("Programs left -> {0}", remaining);
            }
            else
            {
                Console.WriteLine("Successful complete -> {0}%", initialPower);
            }
        }
    }
}
