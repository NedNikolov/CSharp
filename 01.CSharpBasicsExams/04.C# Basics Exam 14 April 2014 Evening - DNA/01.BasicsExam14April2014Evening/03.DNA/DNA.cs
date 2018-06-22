using System;

namespace DNA
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            // Четем от конзолата входните данни
            int dnaHeight = int.Parse(Console.ReadLine());
            char startingLetter = char.Parse(Console.ReadLine());

            // Добавям в масив буквите, за да мога да ги достъпвам по индекс, също така точката(празното място като 3, защото 3 е максималния размер;
            int dots = 3;
            char[] arrayOfLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };

            // Взимаме позицията на въведената буква от масива
            int positionOnLetterInArray = 0;
            for (int i = 0; i < arrayOfLetters.Length; i++)
            {
                if (arrayOfLetters[i] == startingLetter)
                {
                    positionOnLetterInArray = i;
                    break;
                }
            }

            // Инициализираме променливи, които ще използваме за допълнителни ограничения и проверки
            // Колко букви трябва да има на реда
            int wordsCounter = 1;
            // С колко увеличаваме/намаляваме буквите на реда
            int wordsIncreaseDecrease = 2;
            // С колко увеличаваме/намаляваме точките на реда
            int dotsIncreaseDecrease = -1;

            // Цикъл с размер височината на ДНК-то
            for (int i = 1; i <= dnaHeight; i++)
            {
                // Рисуваме началните точки ако има такива
                Console.Write(new String('.', dots));

                // С този цикъл рисуваме буквите, ако стигнем края на масива, даваме стойност 0 и започваме отначало
                for (int m = 0; m < wordsCounter; m++)
                {
                    if (positionOnLetterInArray == arrayOfLetters.Length)
                    {
                        positionOnLetterInArray = 0;
                    }

                    Console.Write(new String(arrayOfLetters[positionOnLetterInArray], 1));
                    positionOnLetterInArray++;
                }

                // Рисуваме останалите точки след буквите ако има такива, те винаги са равни на първите
                Console.Write(new String('.', dots));

                // Проверяваме кога сме в реда, в който има само букви и започваме намалянето на буквите увеличаване на точките
                if (wordsCounter == 7)
                {
                    dotsIncreaseDecrease *= -1;
                    dots = 1;
                    wordsIncreaseDecrease *= -1;
                    wordsCounter = 5;
                }
                // Проверяваме кога сме в края на ДНК-то, за да нулираме стойностите и да започнем увеличаване на буквите намаляване на точките
                else if (wordsCounter == 1 && i % 7 == 0)
                {
                    wordsIncreaseDecrease *= -1;
                    dotsIncreaseDecrease *= -1;
                }
                // увеличаваме/намаляваме стойностите на буквите-точките
                else
                {
                    wordsCounter += wordsIncreaseDecrease;
                    dots += dotsIncreaseDecrease;
                }

                // минаваме на нов ред
                Console.WriteLine();
            }
        }
    }
}
