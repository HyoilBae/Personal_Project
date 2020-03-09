using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Tetris
{
    
    class Program 
    {
        static void Main(string[] args)
        {
            TetrisScreen NewSC = new TetrisScreen(10, 15);

            Block NewBlock = new Block();
            //이걸 그리기 전에 !!
            NewSC.Render();

            Console.ReadKey();

            //while (true)
            //{
            //    Console.ReadKey(); 
            //}


            //for (int y = 0; y < 3; ++y)
            //{
            //    for (int x = 0; x < 3; ++x)
            //    {
            //        NewSC.SetBlock(y, x, Tblock.Wall);
            //    }
            //}
            //NewSC.SetBlock(3, 3, Tblock.Wall);
            
            //string Str = "";
            //for (int i = 0; i < 10; i++)
            //{
            //    if (true)
            //    {
            //        Str += "* ";
            //    }
            //}
            //Console.WriteLine(Str);

            //for (int y = 0; y < 15; ++y)
            //{
            //    for (int x = 0; x < 10; ++x)
            //    {
            //        if (y == 0 || y == 14)
            //        {
            //            Console.Write("-");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.CursorLeft = 6;
            //Console.CursorTop = 6;
            //Console.Write("O");
            //Console.CursorLeft = 6;
            //Console.CursorTop = 7;
            //Console.Write("O");
            //Console.CursorLeft = 6;
            //Console.CursorTop = 8;
            //Console.Write("O");
            //Console.CursorLeft = 6;
            //Console.CursorTop = 9;
            //Console.Write("O");

        }
    }
}
