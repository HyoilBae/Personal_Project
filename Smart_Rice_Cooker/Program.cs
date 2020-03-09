using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace Smart_Rice_Cooker
{
    enum CookerProcess { None, PuttingRice, WaterIn, WashingRice, WaterOut, CookingRice, RiceReady, KeepWarming }

    struct RiceCookerInfo
    {
        public bool CoverOpenClose;
        public bool PowerOnOff;
        public CookerProcess State;
        public int RiceQty;
        public int WaterQty;
        public int NumberOfPeople;

        public RiceCookerInfo(int rice, int water)
        {
            RiceQty = rice;
            WaterQty = water;
            State = CookerProcess.None;
            CoverOpenClose = false;
            PowerOnOff = false;
            NumberOfPeople = 0;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            OutFrame();

            SoundPlayer sound = new SoundPlayer();

            RiceCookerInfo rcInfo = new RiceCookerInfo(10000, 5000);

            RiceInfo(rcInfo);

            while (true)
            {
                
            }
        }

        static void OutFrame()
        {
            Console.SetWindowSize(100, 40);
            //Rice Cooker Box
            RiceCookerBox riceCookerBox = new RiceCookerBox();
            riceCookerBox.shape();
            Console.SetCursorPosition(13, 0);
            Console.Write("Smart Rice Cooker\n");

            //Rice Cooker
            RiceCooker riceCooker = new RiceCooker();
            riceCooker.shape(7, 11);

            //RiceCooker cover
            RiceCookerCover riceCookerCover = new RiceCookerCover();
            riceCookerCover.coverStatus(true);

            //Rice Box & Water Box
            RiceBox riceBox = new RiceBox();
            riceBox.shape(48, 0);
            riceBox.riceHeight(49, 2, rcInfo.RiceQty);
            Console.SetCursorPosition(55, 0);
            Console.Write("Rice Box\n");

            WaterBox waterBox = new WaterBox();
            waterBox.shape(72, 0);
            waterBox.waterHeight(73, 2, rcInfo.WaterQty);
            Console.SetCursorPosition(78, 0);
            Console.Write("Water Box\n");

            //Info or Menu Box
            InfoBox infoBox = new InfoBox();
            infoBox.shape(0, 21);
            Console.SetCursorPosition(11, 21);
            Console.Write("Rice Cooker Status");

            MenuBox menuBox = new MenuBox();
            menuBox.shape(48, 21);
            Console.SetCursorPosition(63, 21);
            Console.Write("Rice Cooker Menu\n");

            MessageBox messageBox = new MessageBox();
            messageBox.message(50, 25, "You can't open the lid while cooking");

        }

        static void RiceInfo(RiceCookerInfo Info)
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
            switch (Info.State)
            {
                case CookerProcess.None:
                    Console.Write("Status : Stand By  ");
                    break;
                case CookerProcess.PuttingRice:
                    Console.Write("Status : Putting Rice  ");
                    break;
                case CookerProcess.WaterIn:
                    Console.Write("Status : Water In  ");
                    break;
                case CookerProcess.WashingRice:
                    Console.Write("Status : Washing Rice  ");
                    break;
                case CookerProcess.WaterOut:
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

