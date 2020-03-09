using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//위에서 부터 블럭이 떨어지는걸 만들고 싶당
enum BlockType
{
    BT_I, //짝대기
    BT_L, //갈고리 오른쪽
    BT_J, //갈고리 왼쪽
    BT_Z, 
    BT_S,
    BT_T, //티자
    BT_O, //네모
}
class Block
{
    int X = 0;
    int Y = 0;

    public void Move()
    {
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.A:
                break;
            case ConsoleKey.D:
                break;
            case ConsoleKey.S:
                break;


            default:
                break;
        }
        Console.ReadKey();
    }
    //protected BlockType Type;
}

////상속으로 한다?
//class StickBlock
//{

//}

