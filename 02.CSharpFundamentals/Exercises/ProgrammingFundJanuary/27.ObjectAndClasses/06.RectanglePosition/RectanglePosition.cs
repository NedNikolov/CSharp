using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.RectanglePosition
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            int[] firstRectArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] seecondRectArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Rectangle firstRectangle = new Rectangle
            {
                Left = firstRectArgs[0],
                Top = firstRectArgs[1],
                Width = firstRectArgs[2],
                Height = firstRectArgs[3],
            };

            Rectangle secondRectangle = new Rectangle
            {
                Left = seecondRectArgs[0],
                Top = seecondRectArgs[1],
                Width = seecondRectArgs[2],
                Height = seecondRectArgs[3],
            };

            if (firstRectangle.IsInside(secondRectangle))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }

        }

        class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public int Bottom
            {
                get
                {
                    return Top + Height;
                }
            }

            public int Right
            {
                get { return Left + Width; }
            }

            int CalcArea()
            {
                return Width * Height;
            }

            public bool IsInside(Rectangle other)
            {
                return Top >= other.Top &&
                       Left >= other.Left &&
                       Bottom <= other.Bottom &&
                       Right <= other.Right;
            }
        }
    }
}
