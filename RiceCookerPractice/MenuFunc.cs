using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiceCookerPractice
{
    class MenuFunc
    {
        public static int MainMenuIndex = 0;
        //string[] menuItem = { " Power ", " Lid ", " Cooking ", " Warm ", " Cancel ", " How Many People ", " Rice ", " Water " };
        public MenuFunc()
        {
            //Default
        }
        //public void Menu(int x, int y, string[] MenuItem)
        //{
        //    ConsoleKeyInfo InputKey;

        //    while (true)
        //    {
        //        for (int i = 0; i < MenuItem.Length; i++)
        //        {
        //            if (MainMenuIndex == i)
        //            {
        //                Console.BackgroundColor = ConsoleColor.Yellow;
        //                Console.ForegroundColor = ConsoleColor.Black;
        //                Console.SetCursorPosition(x, y + i);
        //                Console.Write(MenuItem[i]);
        //                Console.BackgroundColor = ConsoleColor.Black;
        //                Console.ForegroundColor = ConsoleColor.White;
        //            }
        //            else
        //            {
        //                Console.SetCursorPosition(x, y + i);
        //                Console.Write(MenuItem[i]);
        //            }
        //        }

        //        InputKey = Console.ReadKey(true);
        //        if (InputKey.Key == ConsoleKey.Enter)
        //            break;
        //        else if (InputKey.Key == ConsoleKey.UpArrow)
        //        {
        //            MainMenuIndex--;
        //            if (MainMenuIndex < 0)
        //                MainMenuIndex = 0;
        //        }
        //        else if (InputKey.Key == ConsoleKey.DownArrow)
        //        {
        //            MainMenuIndex++;
        //            if (MainMenuIndex == MenuItem.Length)
        //                MainMenuIndex = MenuItem.Length - 1;
        //        }
        //    }
        //}
    }
}
