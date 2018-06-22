using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ProgrammerDNA
{
    class ProgrammerDNA
    {
        static void Main()
        {


            int n = int.Parse(Console.ReadLine());
            char letter = char.Parse(Console.ReadLine());
            int toIncrease = 0;


            for (int i = 1; i <= 3; i++)
            {
                int charCount = i*2 - 1;
                int dotCount = (7 - charCount) /2;
                Console.Write(new string('.', dotCount ));
                for (int j = 0; j < charCount; j++)
                {
                    
                    Console.Write((char)(letter + toIncrease) );
                    if ( (char)(letter + toIncrease) == 'G')
                    {
                        toIncrease = -1;
                        letter = 'A';
                    }
                    toIncrease++;
                }
                Console.Write(new string('.',dotCount));
                Console.WriteLine();
            }

            for (int j = 0; j < 7; j++)
            {

                Console.Write((char)(letter + toIncrease));
                if ((char)(letter + toIncrease) == 'G')
                {
                    toIncrease = -1;
                    letter = 'A';
                }
                toIncrease++;
            }
            Console.WriteLine();

            for (int i = 3; i >= 1; i--)
            {
                int charCount = 2 * i - 1;
                int dotCount = (7 - charCount)/2;
                Console.Write(new string('.', dotCount));
                for (int j = 0; j < charCount; j++)
                {

                    Console.Write((char)(letter + toIncrease));
                    if ((char)(letter + toIncrease) == 'G')
                    {
                        toIncrease = -1;
                        letter = 'A';
                    }
                    toIncrease++;
                }
                Console.Write(new string('.', dotCount));
                Console.WriteLine();
            }


            //int totalLength = int.Parse(Console.ReadLine());
            //char printChar = char.Parse(Console.ReadLine());

            //char spaceChar = '.';

            //int blockSize = 7;
            //int midPoint = blockSize / 2;
            //int diff = 0;
            //int diffCounter = 0;

            //for (int counter = 0; counter < totalLength; counter++)
            //{
            //    // Print Block
            //    for (int i = 0; i < blockSize; i++)
            //    {
            //        if (i >= midPoint - diff && i <= midPoint + diff)
            //        {
            //            Console.Write(printChar);

            //            // Change Letter
            //            if (printChar == 'G')
            //            {
            //                printChar = 'A';
            //            }
            //            else
            //            {
            //                printChar++;
            //            }
            //        }
            //        else
            //        {
            //            Console.Write(spaceChar);
            //        }
            //    }

            //    if (diffCounter >= midPoint)
            //    {
            //        diff--;
            //    }
            //    else
            //    {
            //        diff++;
            //    }

            //    diffCounter++;

            //    if (diffCounter == blockSize)
            //    {
            //        diffCounter = 0;
            //        diff++;
            //    }

            //    Console.WriteLine();
            //}
        }
    }
}
