using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chess_console.Board.Exceptions;

namespace chess_console.Board
{
    public class BoardService
    {
        public int Lines { get; set; }
        public int Columns { get; set; }

        public Piece[,] Pieces;
        public BoardService(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Pieces = new Piece[lines, columns];
        }
        public Piece Piece(int line, int column)
        {
            return Pieces[line, column];
        }
        public Piece Piece(Position position)
        {
            return Pieces[position.Line, position.Column];
        }
        public void PlacePiece(Piece piece, Position position)
        {
            if (ExistPiece(position))
            {
                throw new BoardException("There is already a piece in that position");
            }
            Pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }
        public Piece RemovePiece(Position position)
        {
            if (Piece(position) == null) { return null; }
            Piece aux = Piece(position);
            aux.Position = null;

            Pieces[position.Line, position.Column] = null;

            return aux;
        }
        public bool ValidPosition(Position position)
        {
            if (position.Line < 0 || position.Line >= Lines || position.Column < 0 || position.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position position)
        {
            if (!ValidPosition(position))
            {
                throw new BoardException("Invalid position");
            }
        }

        public bool ExistPiece(Position position)
        {
            ValidatePosition(position);
            return Piece(position) != null;
        }
    }
}