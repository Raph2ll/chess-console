using System;
using System.Drawing;
using chess_console.Board;
using chess_console.Board.Enum;

namespace chess_console.Chess
{
    public class King : Piece
    {
        public King(Colors color, BoardService board) : base(color, board) { }

        public override string ToString()
        {
            return "R";
        }
    }
}