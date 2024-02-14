using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public void PlacePiece(Piece piece, Position position) { 
            Pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }
    }
}