using System;

namespace _08.StringEncryption
{
    class StringEncryption
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var currentChar = char.Parse(Console.ReadLine());
                var encrypted = Encrypt(currentChar);

                result += encrypted;
            }
            Console.WriteLine(result);
            
        }

        static string Encrypt(char currChar)
        {
            var asciiCode = (int)currChar;
            var firstDigit = GetFirstDigit(asciiCode);
            var lastDigit = GetLastDigit(asciiCode);

            var firstSymbol = (char)(asciiCode + lastDigit);
            var lastSymbol = (char)(asciiCode - firstDigit);

            var result = $"{firstSymbol}{firstDigit}{lastDigit}{lastSymbol}";
             
            return result;
        }

        private static int GetLastDigit(int asciiCode)
        {
            return asciiCode % 10;
        }

        static int GetFirstDigit(int asciiCode)
        {
            var firstDigit = asciiCode;
            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            } 

            return firstDigit;
        }
    }
}
