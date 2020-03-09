//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Smart_Rice_Cooker
//{
//    class CookingOperation
//    {
//        while (true)
//        {
//            OutFrame();
//        RiceBox(16, 11);
//        Cover(RCInfo.CoverOpenClose);
//        RiceInfo(RCInfo);
//        PowerLine(RCInfo.Power);
//        RiceHeight(50, 2, RCInfo.Rice);
//        WaterHeight(74, 2, RCInfo.Water);

//        Menu(65, 25, MenuItem);
//            if (MainMenuIndex == 9)
//                break;

//            switch (MainMenuIndex)
//            {
//                case 0: // Power
//                    RCInfo.Power = !RCInfo.Power;
//                    if (RCInfo.Power)
//                    {
//                        Sound.SoundLocation = "power_on.wav";
//                    }
//                    else
//                    {
//                        Sound.SoundLocation = "power_off.wav";
//                    }
//Sound.Load();
//                    Sound.PlaySync();
//                    break;
//                case 1: // Lid can't be opened while cooking or warming
//                    if (RCInfo.State == CookerProcess.Cooking)
//                    {
//                        MessageBox(51, 27, " Lid can't be open while cooking rice");
//Console.ReadKey(true);
//                    }
//                    else
//                    {
//                        RCInfo.CoverOpenClose = !RCInfo.CoverOpenClose;
//                        if (RCInfo.CoverOpenClose)
//                            Sound.SoundLocation = "cover_open.wav";
//                        else
//                            Sound.SoundLocation = "cover_close.wav";
//                        Sound.Load();
//                        Sound.Play();
//                    }
//                    break;
//                case 2: // Cooking
//                    if (!RCInfo.Power)
//                    {
//                        //
//                        MessageBox(51, 27, "Rice Cooker is off");
//Console.ReadKey(true);
//                        break;
//                    }

//                    if (RCInfo.CoverOpenClose)
//                    {
//                        // 
//                        MessageBox(51, 27, "Lid is Open");
//Console.ReadKey(true);
//                        break;
//                    }

//                    if (RCInfo.Number == 0)
//                    {
//                        // 
//                        MessageBox(51, 27, "How many people?");
//Console.ReadKey(true);
//                        break;
//                    }

//                    // 일정한 시간 간격으로 쌀 넣기 -> 물 넣기 -> 쌀 씻기 -> 배수 -> 2 번 반복, 물 넣기부터 
//                    //                     취사 -> 완료 -> 보온                       
//                    // 필요한 쌀과 물의 공급이 되어 있는지를 체크한다.
//                    int Rice = RCInfo.Rice - (RCInfo.Number * 160); // per person 160g
//                    if (Rice< 0)
//                    {
//                        MessageBox(51, 27, "  Need more rice");
////Sound.SoundLocation = "쌀을보충해주세요.WAV";
//Sound.Load();
//                        Sound.Play();
//                        Console.ReadKey(true);
//                        break;
//                    }

//                    //  물통에서 물 빼기 (대략 인원수 x 170 ml ) * 5; //물로 씻는 거 2번 취사 1번 총 3번 양이 필요
//                    //  씻을 때는 1인분 물 170의 두 배 사용, 필요한 물은 씻기 2번(170*4 ml) 취사 1 번(170 ml)
//                    int Water;
//Water = RCInfo.Water - (RCInfo.Number* 170) * 5;
//                    if (Water< 0)
//                    {
//                        MessageBox(51, 27, "  Need more water");
////Sound.SoundLocation = "물보충.WAV";
//Sound.Load();
//                        Sound.Play();
//                        Console.ReadKey(true);
//                        break;
//                    }

//                    // Note: 취사 시작 부분, 쌀 넣기 -> 물 넣기 -> 쌀 씻기 -> 배수 -> 취사 -> 보온
//                    RCInfo.State = CookerProcess.Riceing;
//                    RiceInfo(RCInfo);

////Sound.SoundLocation = "쌀넣기.WAV";
////Sound.Load();
////Sound.Play();

//Console.SetCursorPosition(24, 12);
//                    Console.Write("Putting rice");
//                    Console.SetCursorPosition(18, 13);
//                    Console.Write("* * * * * * *");
//                    Console.SetCursorPosition(18, 14);
//                    Console.Write("* * * * * * *");
//                    Console.SetCursorPosition(18, 15);
//                    Console.Write("* * * * * * *");
//                    Console.SetCursorPosition(18, 16);
//                    Console.Write("* * * * * * *");
//                    Console.SetCursorPosition(18, 17);
//                    Console.Write("* * * * * * *");
//                    RCInfo.Rice = RCInfo.Rice - (RCInfo.Number* 160); // per person 160g
//                    RiceHeight(50, 2, RCInfo.Rice);
//Thread.Sleep(3000); // 3초 정도                            

//                    for (int i = 0; i< 2; i++)
//                    {
//                        // Note: 물 넣기 --> 파란 색 보여 주기
//                        RCInfo.State = CookerProcess.Watering;
//                        RCInfo.Water = RCInfo.Water - (RCInfo.Number* 170 * 2);
//                        RiceInfo(RCInfo);

//Sound.SoundLocation = "water_in.WAV";
//                        Sound.Load();
//                        Sound.Play();

//                        Console.BackgroundColor = ConsoleColor.Black;
//                        Console.SetCursorPosition(24, 12);
//                        Console.Write("Watering");
//                        Console.BackgroundColor = ConsoleColor.Blue;
//                        Console.SetCursorPosition(18, 13);
//                         Console.Write("* * * * * * *");
//                        Console.SetCursorPosition(18, 14);
//                         Console.Write("* * * * * * *");
//                        Console.SetCursorPosition(18, 15);
//                         Console.Write("* * * * * * *");
//                        Console.SetCursorPosition(18, 16);
//                         Console.Write("* * * * * * *");
//                        Console.SetCursorPosition(18, 17);
//                         Console.Write("* * * * * * *");
//                        WaterHeight(74, 2, RCInfo.Water);
//Thread.Sleep(3000); // 3초 정도

//                        // Note: 쌀 씻기 
//                        //Sound.SoundLocation = "쌀씻기.wav";
//                        //Sound.Load();
//                        //Sound.Play();
//                        RCInfo.State = CookerProcess.Washing;
//                        RiceInfo(RCInfo);

//Console.BackgroundColor = ConsoleColor.Black;
//                        Console.SetCursorPosition(24, 12);
//                        Console.Write("Washing rice");
//                        Console.BackgroundColor = ConsoleColor.Blue;
//                        Console.ForegroundColor = ConsoleColor.White;
//                        Console.SetCursorPosition(18, 13);
//                        Console.Write("~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
//                        Console.SetCursorPosition(18, 14);
//                         Console.Write("* * * * * * *");
//                        Console.SetCursorPosition(18, 15);
//                        Console.Write("~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
//                        Console.SetCursorPosition(18, 16);
//                         Console.Write("* * * * * * *");
//                        Console.SetCursorPosition(18, 17);
//                        Console.Write("~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
//                        Thread.Sleep(3000); // 3초 정도

//                        // Note: 물 배수 
//                        RCInfo.State = CookerProcess.Droping;
//                        RiceInfo(RCInfo);

////Sound.SoundLocation = "water_out.WAV";
////Sound.Load();
////Sound.Play();

//Console.BackgroundColor = ConsoleColor.Black;
//                        Console.SetCursorPosition(24, 12);
//                        Console.Write(" Draining ");
//                        for (int j = 0; j< 5; j++)
//                        {
//                            // 지우기
//                            Console.BackgroundColor = ConsoleColor.Black;
//                            for (int k = 0; k<j; k++)
//                            {
//                                Console.SetCursorPosition(18, 13 + k);
//                                 Console.Write("* * * * * * *");
//                            }

//                            // 물 출력
//                            Console.BackgroundColor = ConsoleColor.Blue;
//                            for (int k = j; k< 5; k++)
//                            {
//                                Console.SetCursorPosition(18, 13 + k);
//                                 Console.Write("* * * * * * *");
//                            }
//                            Thread.Sleep(700);
//                        }

//                    }

//                    // Note: 취사용 물 공급
//                    RCInfo.Water = RCInfo.Water - (RCInfo.Number* 170);
//                    WaterHeight(74, 2, RCInfo.Water);
//RiceInfo(RCInfo);

//// Note: 취사 시작
//RCInfo.State = CookerProcess.Cooking;
//                    RiceInfo(RCInfo);

////Sound.SoundLocation = "rice.wav";
////Sound.Load();
////Sound.Play();

//Console.BackgroundColor = ConsoleColor.Black;
//                    Console.SetCursorPosition(24, 12);
//                    Console.Write("Cooking rice");
//                    Console.BackgroundColor = ConsoleColor.Red;
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.SetCursorPosition(18, 13);
//                     Console.Write("* * * * * * *");
//                    Console.SetCursorPosition(18, 14);
//                     Console.Write("* * * * * * *");
//                    Console.SetCursorPosition(18, 15);
//                     Console.Write("* * * * * * *");
//                    Console.SetCursorPosition(18, 16);
//                     Console.Write("* * * * * * *");
//                    Console.SetCursorPosition(18, 17);
//                     Console.Write("* * * * * * *");
//                    Thread.Sleep(7000); // 7초 정도

//                    // Note: 완료 , 사운드 삐리릭...
//                    RCInfo.State = CookerProcess.Completion;
//                    RiceInfo(RCInfo);
//Sound.SoundLocation = "Ring10.wav";
//                    Sound.Load();
//                    Sound.Play();
//                    Thread.Sleep(7000); // 3초 정도

//                    //SoundLocation = "밥완료.wav";
//                    //Sound.Load();
//                    //Sound.Play();

//                    Console.SetCursorPosition(24, 12);
//                    Console.Write("Rice is Completed");
//                    Thread.Sleep(3000); // 3초 정도

//                    // Note: 보온
//                    RCInfo.State = CookerProcess.Keeping;
//                    RiceInfo(RCInfo);

////Sound.SoundLocation = "맛있게드세요.wav";
////Sound.Load();
////Sound.Play();

//Console.BackgroundColor = ConsoleColor.Black;
//                    Console.SetCursorPosition(24, 12);
//                    Console.Write("Warming  ");
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.SetCursorPosition(18, 13);
//                     Console.Write("* * * * * * *");
//                    Console.SetCursorPosition(18, 14);
//                     Console.Write("* * * * * * *");
//                    Console.SetCursorPosition(18, 15);
//                     Console.Write("* * * * * * *");
//                    Console.SetCursorPosition(18, 16);
//                     Console.Write("* * * * * * *");
//                    Console.SetCursorPosition(18, 17);
//                     Console.Write("* * * * * * *");
//                    Thread.Sleep(3000); // 3초 정도
//                    Console.ForegroundColor = ConsoleColor.White;

//                    RCInfo.Number = 0; // Note: 인원수 초기화
//                    break;
//                case 3: // Note:보온
//                    if (!RCInfo.Power)
//                    {
//                        // 밧데리로 일부 메시지 전달
//                        MessageBox(51, 27, "Power is off");
//Console.ReadKey(true);
//                        break;
//                    }

//                    RCInfo.State = CookerProcess.Keeping;
//                    RiceInfo(RCInfo);
//                    break;
//                case 4: // 취소
//                    RCInfo.State = CookerProcess.None;
//                    RiceInfo(RCInfo);
//                    break;
//                case 5: // 인원수
//                    if (!RCInfo.Power)
//                    {
//                        // 밧데리로 일부 메시지 전달
//                        MessageBox(51, 27, "Power is off");
//Console.ReadKey(true);
//                        break;
//                    }

//                    MessageBox(51, 27, " How many people are eating? : ");
//                    try
//                    {
//                        RCInfo.Number = int.Parse(Console.ReadLine());
//                    }
//                    catch (Exception e)
//                    {
//                        RCInfo.Number = 0;
//                    }
//                    break;

//                case 6: // 쌀통 설정
//                    {
//                        string Message = "Current Rice Qty(kg) : " + (RCInfo.Rice / 1000);
//MessageBox(51, 27, Message);
//Console.SetCursorPosition(63, 29);
//                        Console.Write("Adding Rice Qty(kg) : ");
//                        string Amount = Console.ReadLine();
//                        try
//                        {
//                            RCInfo.Rice += int.Parse(Amount) * 1000; // kg 단위
//                            if (RCInfo.Rice > 18000) // 18kg 최대
//                            {
//                                RCInfo.Rice -= int.Parse(Amount) * 1000;
//                                MessageBox(51, 27, "Too Much !!!!");
//Console.ReadKey(true);
//                                break;
//                            }
//                        }
//                        catch (Exception e)
//                        {
//                            break;
//                        }
//                    }
//                    break;
//                case 7: // 뭍통 설정
//                    {
//                        string Message = "Current Water Qty(리터) : " + (rcInfo.WaterQty / 1000);
//MessageBox(51, 27, Message);
//string Amount = string.Empty;
//Console.SetCursorPosition(63, 29);
//                        Console.Write("Adding Water Qty(L) : ");
//                        Amount = Console.ReadLine();
//                        try
//                        {
//                            rcInfo.WaterQty += int.Parse(Amount) * 1000; // 리터를 밀리리터로 
//                            if (rcInfo.WaterQty > 18000)
//                            {
//                                rcInfo.WaterQty -= int.Parse(Amount) * 1000;
//                                Message(51, 27, "Too Much !!!!!");
//Console.ReadKey(true);
//                                break;
//                            }
//                        }
//                        catch (Exception e)
//                        {
//                            break;
//                        }
//                    }
//                    break;
//            }
//        }
//    }
//}
