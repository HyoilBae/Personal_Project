using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Rice_Cooker
{
    class MessageBox
    {
        public MessageBox()
        {

        }

        public void message(int x, int y, string Message)
        {
            int height = 3;
            Console.SetCursorPosition(x, y);
            Console.Write("┌────────────────────────────────────────┐");
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("│                                        │");
            }

            Console.SetCursorPosition(x, y + height);
            Console.Write("└────────────────────────────────────────┘");
            Console.SetCursorPosition(x+1 , y + 1);
            Console.Write(Message);
        }
    }
}
