using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Tblock
{
    Wall,
    Void,
    Block,
}
class TetrisScreen
{
    List<List<Tblock>> BlockList = new List<List<Tblock>>();

    public void SetBlock(int _y, int _x, Tblock _Type)
    {
        BlockList[_y][_x] = _Type;
    }
    public void Render()
    {
        for (int y = 0; y < BlockList.Count; ++y)
        {
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                switch (BlockList[y][x])
                {
                    case Tblock.Wall:
                        Console.Write(" * ");
                        break;
                    case Tblock.Void:
                        Console.Write(" - ");
                        break;
                    case Tblock.Block:
                        Console.Write(" O ");
                        break;
                    default:
                        break;
                }
                //Console.Write(List[y][x]);
            }
            Console.WriteLine();
        }
    }
    public TetrisScreen(int _X, int _Y)
    {
        for (int y = 0; y < _Y; ++y)
        {
            BlockList.Add(new List<Tblock>()); //y축으로 만들어진 칼럼 공간 한하나에다가 리스트를 추가해주는 것
            for (int x = 0; x < _X; ++x)
            {
                BlockList[y].Add(Tblock.Void);
            }
        }
        for (int i = 0; i < BlockList[0].Count; i++)
        {
            BlockList[0][i] = Tblock.Wall;
        }
        for (int i = 0; i < BlockList[BlockList.Count - 1].Count; i++)
        {
            BlockList[BlockList.Count - 1][i] = Tblock.Wall;
        }
    }
}