using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chess_console.Board
{
    public class Position
    {
        public int Line { get; set; }
        public int Column { get; set; }

        public Position(int line, int column) {
            Line = line;
            Column = column;
        }

        public void SetValues(int line, int column) {
            Line = line;
            Column = column;
        }

        public override string ToString() {
            return $"{Line} , {Column}";
        }
    }
}