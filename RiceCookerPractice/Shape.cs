using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiceCookerPractice
{
    class Shape
    {
        public Shape()
        {
            //Default Constructor
        }

        public void RiceCookerBox(int x = 0, int y = 0)
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
            Console.SetCursorPosition(13, 0);
            Console.Write("Smart Rice Cooker\n");
        }

        public void RiceCooker(int x, int y)
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
            Console.SetCursorPosition(6, y + 6);
            Console.Write("─┤"); // 전원 부분
            Console.SetCursorPosition(x + 8, 11);
            Console.Write("Rice Cooker");
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

        public void riceBox(int x, int y)
        {
            int height = 20;
            Console.SetCursorPosition(x, y);
            Console.Write("┌────────────────────┐");
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("│                    │");
            }

            Console.SetCursorPosition(x, y + height);
            Console.Write("└────────────────────┘");
            Console.SetCursorPosition(55, 0);
            Console.Write("Rice Box");
        }

        public void waterBox(int x, int y)
        {
            int height = 20;
            Console.SetCursorPosition(x, y);
            Console.Write("┌────────────────────┐");
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("│                    │");
            }

            Console.SetCursorPosition(x, y + height);
            Console.Write("└────────────────────┘");
            Console.SetCursorPosition(78, 0);
            Console.Write("Water Box");
        }

        public void infoBox(int x, int y)
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
            Console.SetCursorPosition(11, 21);
            Console.Write("Rice Cooker Status");
        }


        public void menuBox(int x, int y)
        {
            int height = 13;
            Console.SetCursorPosition(x, y);
            Console.Write("┌────────────────────────────────────────────┐");
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("│                                            │");


                Console.SetCursorPosition(x, y + height);
                Console.Write("└────────────────────────────────────────────┘");
                Console.SetCursorPosition(63, 21);
                Console.Write("Rice Cooker Menu\n");
            }
        }
        public void messageBox(int x, int y, string Message)
        {
            int height = 2;
            Console.SetCursorPosition(x, y);
            Console.Write("┌────────────────────────────────────────┐");
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("│                                        │");
            }

            Console.SetCursorPosition(x, y + height);
            Console.Write("└────────────────────────────────────────┘");
            Console.SetCursorPosition(x + 1, y + 1);
            Console.Write(Message);
            
        }
    }
}
