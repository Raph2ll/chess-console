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

    }
}