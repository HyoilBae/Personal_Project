using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Rice_Cooker
{
    class RiceCooker
    {
        public RiceCooker()
        {
            

        }
        public void shape(int x, int y)
        {
            int height = 7;
            Console.SetCursorPosition(x, y);
            Console.Write("┌──────────────────────────┐");
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("│                          │");
            }

            Console.SetCursorPosition(x, y + height);
            Console.Write("└──────────────────────────┘");
            Console.SetCursorPosition(x+8, 11);
            Console.Write("Rice Cooker");
            Console.SetCursorPosition(6, y + 6);
            Console.Write("─┤"); // 전원 부분
        }
    }
}
