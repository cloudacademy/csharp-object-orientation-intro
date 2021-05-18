using System;

namespace Boards
{
    class Chessboard: Board
    {
        public new int Rows { get { return 8;} set {}}
        public new int Columns { get { return 8;} set {}}
        public Chessboard():base(8, 8)
        {
        }
    }
}