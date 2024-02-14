using System;
using System.Drawing;
using chess_console.Board;
using chess_console.Board.Enum;

namespace chess_console.Chess
{
    public class Tower : Piece
    {
        public Tower(Colors color, BoardService board) : base(color, board) { }

        public override string ToString()
        {
            return "T";
        }
    }
}