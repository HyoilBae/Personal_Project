using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Rice_Cooker
{
    class RiceCookerBox
    {
        public RiceCookerBox()
        {
           
        }

        public void shape(int x = 0, int y = 0)
        {
            int height = 20;
            Console.SetCursorPosition(x, y);
            Console.Write("┌────────────────────────────────────────┐");
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("│                                        │");
            }
            Console.SetCursorPosition(x, y + height);
            Console.Write("└────────────────────────────────────────┘");
        }
    }
}
