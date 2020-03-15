using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;

namespace RiceCookerPractice
{
    enum CookerProcess { None, AddingRice, WaterIn, WashingRice, Draining, CookingRice, RiceReady, KeepWarming }

    struct RiceCookerInfo
    {
        public bool CoverOpenClose;
        public bool PowerOnOff;
        public CookerProcess state;
        public int RiceQty;
        public int WaterQty;
        public int NumberOfPeople;

        public RiceCookerInfo(int rice, int water) //RiceCookerInfo Constructor??
        {
            CoverOpenClose = false;
            PowerOnOff = false;
            state = CookerProcess.None;
            RiceQty = rice;
            WaterQty = water;
            NumberOfPeople = 0;
        }
    }
    class Program
    {
        public static int MainMenuIndex = 0;
        static void Menu(int x, int y, string[] MenuItem)
        {
            ConsoleKeyInfo InputKey;

            while (true)
            {
                for (int i = 0; i < MenuItem.Length; i++)
                {
                    if (MainMenuIndex == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(x, y + i);
                        Console.Write(MenuItem[i]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.SetCursorPosition(x, y + i);
                        Console.Write(MenuItem[i]);
                    }
                }

                InputKey = Console.ReadKey(true);
                if (InputKey.Key == ConsoleKey.Enter)
                    break;
                else if (InputKey.Key == ConsoleKey.UpArrow)
                {
                    MainMenuIndex--;
                    if (MainMenuIndex < 0)
                        MainMenuIndex = 0;
                }
                else if (InputKey.Key == ConsoleKey.DownArrow)
                {
                    MainMenuIndex++;
                    if (MainMenuIndex == MenuItem.Length)
                        MainMenuIndex = MenuItem.Length - 1;
                }
            }
        }
        static void Main(string[] args)
        {   
            string[] menuItem = { " Power ", " Lid ", " Cooking ", " Warm ", " Cancel ", " How Many People ", " Rice ", " Water " };
            //Out Frame
            Console.SetWindowSize(100, 40);
            Shape shape = new Shape();
            WaterRiceHeight waterRiceHeight = new WaterRiceHeight();
           
            SoundPlayer sound = new SoundPlayer();
            shape.RiceCookerBox();
            shape.RiceCooker(7, 11);
            shape.riceBox(48, 0);
            
            shape.waterBox(72, 0);
            
            shape.infoBox(0, 21);

            MenuFunc menufunc = new MenuFunc();
            shape.menuBox(48, 21);
            
            //shape.messageBox(50, 25, "Test Test Test Test");

            RiceCookerInfo rcInfo = new RiceCookerInfo(10000, 5000);
            RiceInfoFunc riceInfoFunc = new RiceInfoFunc();

            PowerLine powerLine = new PowerLine();


            while (true)
            {
                riceInfoFunc.riceInfo(rcInfo);
                powerLine.onOrOff(rcInfo.PowerOnOff);
                shape.coverStatus(rcInfo.CoverOpenClose);
                waterRiceHeight.riceHeight(49, 2, rcInfo.RiceQty);
                waterRiceHeight.waterHeight(73, 2, rcInfo.WaterQty);

                Menu(65, 25, menuItem);
                if (MainMenuIndex == 9)
                    break;

               
                switch (MainMenuIndex)
                {
                    case 0: //Power
                        rcInfo.PowerOnOff = !rcInfo.PowerOnOff;
                        if (rcInfo.PowerOnOff)
                        {
                            //sound.SoundLocation = "power_on.wav";
                        }
                        else
                        {
                            //sound.SoundLocation = "power_off.wav";
                        }
                        //sound.Load();
                        //sound.PlaySync();
                        break;
                    case 1: //Lid can't be opened while cooking or warming
                        if (rcInfo.state == CookerProcess.CookingRice)
                        {
                            shape.messageBox(50, 22, "Lid can't be opened while cooking rice");
                        }
                        else
                        {
                            rcInfo.CoverOpenClose = !rcInfo.CoverOpenClose;
                            if (rcInfo.CoverOpenClose)
                            {
                                //sound.SoundLocation = "cover_open.wav";
                            }
                            else
                            {
                                //sound.SoundLocation = "cover_close.wav";
                            }
                            //sound.Load();
                            //sound.PlaySync();
                        }
                        break;
                    case 2: //Cooking rice
                        if (!rcInfo.PowerOnOff)
                        {
                            shape.messageBox(50, 22, "Rice Cooker is off");
                            Console.ReadKey(true);
                            break;
                        }
                        if (rcInfo.CoverOpenClose)
                        {
                            shape.messageBox(50, 22, "Lid is Open");
                            Console.ReadKey(true);
                            break;
                        }
                        if (rcInfo.NumberOfPeople == 0)
                        {
                            shape.messageBox(50, 22, "What's the number of people for?");
                            Console.ReadKey(true);
                            break;
                        }
                        int rice = rcInfo.RiceQty - (rcInfo.NumberOfPeople * 160);
                        if (rice < 0)
                        {
                            shape.messageBox(50, 22, "Add some more rice");
                            //sound.SoundLocation = "adding_rice.wav";
                            //sound.Load();
                            //sound.Play();
                            Console.ReadKey(true);
                            break;
                        }
                        int water;
                        water = rcInfo.WaterQty - (rcInfo.NumberOfPeople * 170) * 5;
                        if (water < 0)
                        {
                            shape.messageBox(50, 22, "Adding more water");
                            //sound.SoundLocation = "Adding_Water.wav";
                            //sound.Load();
                            //sound.Play();
                            Console.ReadKey(true);
                            break;
                        }

                        rcInfo.state = CookerProcess.AddingRice;
                        riceInfoFunc.riceInfo(rcInfo);
                        //Sound.SoundLocation = "쌀넣기.WAV";
                        //Sound.Load();
                        //Sound.Play();

                        Console.SetCursorPosition(24, 12);
                        Console.Write("Putting rice");
                        Console.SetCursorPosition(18, 13);
                        Console.Write("* * * * * * *");
                        Console.SetCursorPosition(18, 14);
                        Console.Write("* * * * * * *");
                        Console.SetCursorPosition(18, 15);
                        Console.Write("* * * * * * *");
                        Console.SetCursorPosition(18, 16);
                        Console.Write("* * * * * * *");
                        Console.SetCursorPosition(18, 17);
                        Console.Write("* * * * * * *");
                        rcInfo.RiceQty = rcInfo.RiceQty - (rcInfo.NumberOfPeople * 160); // per person 160g
                        waterRiceHeight.riceHeight(50, 2, rcInfo.RiceQty);
                        Thread.Sleep(3000); //3 sec
                        for (int i = 0; i < 2; i++)
                        {
                            //Adding Water
                            rcInfo.state = CookerProcess.WaterIn;
                            rcInfo.WaterQty = rcInfo.WaterQty - (rcInfo.NumberOfPeople * 170 * 2);
                            riceInfoFunc.riceInfo(rcInfo);
                            //sound.SoundLocation = "water_in.WAV";
                            //sound.Load();
                            //sound.Play();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(24, 12);
                            Console.Write("Watering");
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(18, 13);
                            Console.Write("* * * * * * *");
                            Console.SetCursorPosition(18, 14);
                            Console.Write("* * * * * * *");
                            Console.SetCursorPosition(18, 15);
                            Console.Write("* * * * * * *");
                            Console.SetCursorPosition(18, 16);
                            Console.Write("* * * * * * *");
                            Console.SetCursorPosition(18, 17);
                            Console.Write("* * * * * * *");
                            waterRiceHeight.waterHeight(74, 2, rcInfo.WaterQty);
                            Thread.Sleep(3000);

                            // Note: 쌀 씻기 
                            //Sound.SoundLocation = "쌀씻기.wav";
                            //Sound.Load();
                            //Sound.Play();
                            rcInfo.state = CookerProcess.WashingRice;
                            riceInfoFunc.riceInfo(rcInfo);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(24, 12);
                            Console.Write("Washing rice");
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(8, 13);
                            Console.Write("~ ~ ~ ~ ~ ~ ~ ~ ~");
                            Console.SetCursorPosition(8, 14);
                            Console.Write("* * * * * * * * * * *");
                            Console.SetCursorPosition(10, 15);
                            Console.Write("~ ~ ~ ~ ~ ~ ~ ");
                            Console.SetCursorPosition(18, 16);
                            Console.Write("* * * * * * *");
                            Console.SetCursorPosition(18, 17);
                            Console.Write("~ ~ ~ ~ ~ ~ ~ ");
                            Thread.Sleep(3000); // 3초 정도

                            // Note: 물 배수 
                            rcInfo.state = CookerProcess.Draining;
                            riceInfoFunc.riceInfo(rcInfo);

                            //Sound.SoundLocation = "water_out.WAV";
                            //Sound.Load();
                            //Sound.Play();

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(24, 12);
                            Console.Write(" Draining ");
                            for (int j = 0; j < 5; j++)
                            {
                                // 지우기
                                Console.BackgroundColor = ConsoleColor.Black;
                                for (int k = 0; k < j; k++)
                                {
                                    Console.SetCursorPosition(18, 13 + k);
                                    Console.Write("* * * * * * *");
                                }

                                // 물 출력
                                Console.BackgroundColor = ConsoleColor.Blue;
                                for (int k = j; k < 5; k++)
                                {
                                    Console.SetCursorPosition(18, 13 + k);
                                    Console.Write("* * * * * * *");
                                }
                                Thread.Sleep(700);
                            }
                        }
                        // Note: 취사용 물 공급
                        rcInfo.WaterQty = rcInfo.WaterQty - (rcInfo.NumberOfPeople * 170);
                        waterRiceHeight.waterHeight(74, 2, rcInfo.WaterQty);
                        riceInfoFunc.riceInfo(rcInfo);

                        // Note: 취사 시작
                        rcInfo.state = CookerProcess.CookingRice;
                        riceInfoFunc.riceInfo(rcInfo);

                        //Sound.SoundLocation = "rice.wav";
                        //Sound.Load();
                        //Sound.Play();

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(24, 12);
                        Console.Write("Cooking rice");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(18, 13);
                        Console.Write("* * * * * * *");
                        Console.SetCursorPosition(18, 14);
                        Console.Write("* * * * * * *");
                        Console.SetCursorPosition(18, 15);
                        Console.Write("* * * * * * *");
                        Console.SetCursorPosition(18, 16);
                        Console.Write("* * * * * * *");
                        Console.SetCursorPosition(18, 17);
                        Console.Write("* * * * * * *");
                        Thread.Sleep(7000); // 7초 정도

                        // Note: 완료 , 사운드 삐리릭...
                        rcInfo.state = CookerProcess.RiceReady;
                        riceInfoFunc.riceInfo(rcInfo);
                        //Sound.SoundLocation = "Ring10.wav";
                        //Sound.Load();
                        //Sound.Play();
                        Thread.Sleep(7000); // 3초 정도

                        //SoundLocation = "밥완료.wav";
                        //Sound.Load();
                        //Sound.Play();

                        Console.SetCursorPosition(24, 12);
                        Console.Write("Rice is Ready");
                        Thread.Sleep(3000); // 3초 정도

                        // Note: 보온
                        rcInfo.state = CookerProcess.KeepWarming;
                        riceInfoFunc.riceInfo(rcInfo);

                        //Sound.SoundLocation = "맛있게드세요.wav";
                        //Sound.Load();
                        //Sound.Play();

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(24, 12);
                        Console.Write("Warming  ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(18, 13);
                        Console.Write("* * * * * * *");
                        Console.SetCursorPosition(18, 14);
                        Console.Write("* * * * * * *");
                        Console.SetCursorPosition(18, 15);
                        Console.Write("* * * * * * *");
                        Console.SetCursorPosition(18, 16);
                        Console.Write("* * * * * * *");
                        Console.SetCursorPosition(18, 17);
                        Console.Write("* * * * * * *");
                        Thread.Sleep(3000); // 3초 정도
                        Console.ForegroundColor = ConsoleColor.White;

                        rcInfo.NumberOfPeople = 0; // Note: 인원수 초기화
                        break;

                    case 3: //Warming
                        if (!rcInfo.PowerOnOff)
                        {
                            // 밧데리로 일부 메시지 전달
                            shape.messageBox(50, 22, "Power is off");
                            Console.ReadKey(true);
                            break;
                        }

                        rcInfo.state = CookerProcess.KeepWarming;
                        riceInfoFunc.riceInfo(rcInfo);
                        break;
                    case 4: // 취소
                        rcInfo.state = CookerProcess.None;
                        riceInfoFunc.riceInfo(rcInfo);
                        break;
                    case 5: // 인원수
                        if (!rcInfo.PowerOnOff)
                        {
                            // 밧데리로 일부 메시지 전달
                            shape.messageBox(51, 27, "Power is off");
                            Console.ReadKey(true);
                            break;
                        }

                        shape.messageBox(50, 22, " How many people are eating? : ");
                        try
                        {
                            rcInfo.NumberOfPeople = int.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            rcInfo.NumberOfPeople = 0;
                        }
                        break;
                    case 6: // 쌀통 설정
                        {
                            string Message = "Current Rice Qty(kg) : " + (rcInfo.RiceQty / 1000);
                            shape.messageBox(50, 22, Message);
                            Console.SetCursorPosition(53, 24);
                            Console.Write("Adding Rice Qty(kg) : ");
                            string Amount = Console.ReadLine();
                            try
                            {
                                rcInfo.RiceQty += int.Parse(Amount) * 1000; // kg 단위
                                if (rcInfo.RiceQty > 18000) // 18kg 최대
                                {
                                    rcInfo.RiceQty -= int.Parse(Amount) * 1000;
                                    shape.messageBox(50, 22, "Too Much !!!!");
                                    Console.ReadKey(true);
                                    break;
                                }
                            }
                            catch (Exception e)
                            {
                                break;
                            }
                        }
                        break;
                    case 7: // 뭍통 설정
                        {
                            string Message = "Current Water Qty(리터) : " + (rcInfo.WaterQty / 1000);
                            shape.messageBox(50, 22, Message);
                            string Amount = string.Empty;
                            Console.SetCursorPosition(53, 24);
                            Console.Write("Adding Water Qty(L) : ");
                            Amount = Console.ReadLine();
                            try
                            {
                                rcInfo.WaterQty += int.Parse(Amount) * 1000; // 리터를 밀리리터로 
                                if (rcInfo.WaterQty > 18000)
                                {
                                    rcInfo.WaterQty -= int.Parse(Amount) * 1000;
                                    shape.messageBox(50, 22, "Too Much !!!!!");
                                    Console.ReadKey(true);
                                    break;
                                }
                            }
                            catch (Exception e)
                            {
                                break;
                            }
                        }
                        break;
                }
            }

        }


    }
}
