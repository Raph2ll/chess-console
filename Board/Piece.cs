using System;
using chess_console.Board.Enum;

namespace chess_console.Board
{
    abstract class Piece
    {
        public Position Position { get; set; }
        public Colors Color { get; protected set; }
        public int QtyMovements { get; protected set; }
        public BoardService Board { get; protected set; }

        public Piece(Colors color, BoardService board)
        {
            Position = null;
            Color = color;
            Board = board;
            QtyMovements = 0;
        }
        public abstract bool[,] PossibleMovements();
        public void MovimentQtyIncrement()
        {
            QtyMovements++;
        }
    }
}