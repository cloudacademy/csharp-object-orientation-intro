using System;
using Boards;

namespace Checkerboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Rows = 5;
            board.Columns = 4;
            board.Print();
        }
    }
}
