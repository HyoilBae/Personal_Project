using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiceCookerPractice
{
    class RiceInfoFunc
    {
        public RiceInfoFunc()
        {

        }
        public void riceInfo(RiceCookerInfo Info)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(7, 22);
            if (Info.PowerOnOff)
                Console.Write("Power : ON");
            else
                Console.Write("Power : OFF");

            Console.SetCursorPosition(7, 24);
            if (Info.CoverOpenClose)
                Console.Write("Rice Cooker Lid : Open");
            else
                Console.Write("Rice Cooker Lid : Close");

            Console.SetCursorPosition(7, 26);
            switch (Info.state)
            {
                case CookerProcess.None:
                    Console.Write("Status : Stand By  ");
                    break;
                case CookerProcess.AddingRice:
                    Console.Write("Status : Putting Rice  ");
                    break;
                case CookerProcess.WaterIn:
                    Console.Write("Status : Water In  ");
                    break;
                case CookerProcess.WashingRice:
                    Console.Write("Status : Washing Rice  ");
                    break;
                case CookerProcess.Draining:
                    Console.Write("Status : Water Out  ");
                    break;
                case CookerProcess.CookingRice:
                    Console.Write("Status : Cooking  ");
                    break;
                case CookerProcess.RiceReady:
                    Console.Write("Status : Complete");
                    break;
                case CookerProcess.KeepWarming:
                    Console.Write("Status : Warming  ");
                    break;
            }

            Console.SetCursorPosition(7, 28);
            Console.Write("How Many People : {0}", Info.NumberOfPeople);
            Console.SetCursorPosition(7, 30);
            Console.Write("Rice Qty : {0:f1} Kg", Info.RiceQty / 1000.0f);
            Console.SetCursorPosition(7, 32);
            Console.Write("Water Qty : {0:f1} L\n", Info.WaterQty / 1000.0f);
        }
    }
}

