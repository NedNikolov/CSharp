using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MirrorImage
{
    class MirrorImage
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ');

            while (true)
            {
                string position = Console.ReadLine();
                if (position == "Print")
                {
                    break;
                }

                int index = int.Parse(position);

                for (int i = 0; i < index / 2; i++)
                {
                    string temp = elements[i];
                    elements[i] = elements[index - i - 1];
                    elements[index - i - 1] = temp;
                }
                Array.Reverse(elements);
                for (int i = 0; i < (elements.Length - 1 - index) / 2; i++)
                {
                    string temp = elements[i];
                    elements[i] = elements[elements.Length - 2 - index - i];
                    elements[elements.Length - 2 - index - i] = temp;
                }

                Array.Reverse(elements);

            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
