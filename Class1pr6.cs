using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Menu
    {


        public static int Show(int min, int max)
        {
            int pos = 4;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos != min)
                    pos--;
                else if (key.Key == ConsoleKey.DownArrow & pos != max)
                    pos++;
                else if (key.Key == ConsoleKey.Escape)
                    return -1;
            } while (key.Key != ConsoleKey.Enter);
            Console.Clear();
            return pos;
        }

    }
}
