using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chess_console.Board.Exceptions
{
    public class BoardException : Exception
    {
        public BoardException(string msg) : base(msg)
        {

        }
    }
}