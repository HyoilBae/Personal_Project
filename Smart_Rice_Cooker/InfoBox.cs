using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Rice_Cooker
{
    class InfoBox
    {
        public InfoBox()
        {

        }
        public void shape(int x, int y)
        {
            int height = 13;
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
