using System;
using System.Drawing;
using chess_console.Board;
using chess_console.Board.Enum;

namespace chess_console.Chess
{
    public class King : Piece
    {
        public King(Colors color, BoardService board) : base(color, board) { }

        private bool CanMove(Position position)
        {
            Piece piece = Board.Piece(position);
            return piece == null || piece.Color != Color;
        }
        public override bool[,] PossibleMovements()
        {
            bool[,] mat = new bool[Board.Lines, Board.Columns];

            Position position = new Position(0, 0);
            // up
            position.SetValues(position.Line - 1, position.Column);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, Position.Column] = true;
            }
            // ne
            position.SetValues(position.Line - 1, position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, Position.Column] = true;
            }
            // right
            position.SetValues(position.Line, position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, Position.Column] = true;
            }
            // se
            position.SetValues(position.Line + 1, position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, Position.Column] = true;
            }
            // down
            position.SetValues(position.Line + 1, position.Column);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, Position.Column] = true;
            }
            // so
            position.SetValues(position.Line + 1, position.Column - 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, Position.Column] = true;
            }
            // left 
            position.SetValues(position.Line, position.Column - 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, Position.Column] = true;
            }
            // no
            position.SetValues(position.Line - 1, position.Column - 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, Position.Column] = true;
            }
        }
        public override string ToString()
        {
            return "R";
        }
    }
}