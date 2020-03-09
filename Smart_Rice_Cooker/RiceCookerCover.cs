using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Rice_Cooker
{
    class RiceCookerCover
    {
        public RiceCookerCover()
        {

        }
        public void coverStatus(bool bOpen)
        {
            const int x = 7;
            if (bOpen)
            {
                Console.SetCursorPosition(x, 3);
                Console.Write("┌┐");
                for (int i = 0; i < 7; i++)
                {
                    Console.SetCursorPosition(x, 4 + i);
                    Console.Write("││");
                }
                Console.SetCursorPosition(x, 10);
                Console.Write("└┘");
            }
            else
            {
                Console.SetCursorPosition(x, 9);
                Console.Write("┌──────────────────────────┐");
                Console.SetCursorPosition(x, 10);
                Console.Write("└──────────────────────────┘");
            }
        }
    }
}
