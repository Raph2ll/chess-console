using System;
using chess_console.Board.Enum;

namespace chess_console.Board
{
    public class Piece
    {
        public Position Position { get; set; }
        public Colors Color { get; protected set; }
        public int QtyMovements { get; protected set; }
        public BoardService Board { get; protected set; }

        public Piece(Position position, Colors color, BoardService board)
        {
            Position = position;
            Color = color;
            Board = board;
        }
    }
}