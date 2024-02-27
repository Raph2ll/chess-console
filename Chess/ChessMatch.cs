using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using chess_console.Board;
using chess_console.Board.Enum;

namespace chess_console.Chess
{
    public class ChessMatch
    {
        public BoardService Board { get; private set; }
        private int Shift;
        private Colors CurrentPlayer;
        public bool Finished {get; private set;}
        public ChessMatch()
        {
            Board = new BoardService(8, 8);
            Shift = 1;
            CurrentPlayer = Colors.White;
            Finished = false;
            PlacePieces();
        }

        public void PerformMovement(Position origin, Position destiny)
        {
            Piece p = Board.RemovePiece(origin);
            p.MovimentQtyIncrement();
            Piece PieceCaptured = Board.RemovePiece(destiny);
            Board.PlacePiece(p, destiny);
        }

        private void PlacePieces()
        {
            Board.PlacePiece(new Tower(Colors.White, Board), new ChessPosition('c', 1).ToPosition());
            Board.PlacePiece(new Tower(Colors.White, Board), new ChessPosition('c', 2).ToPosition());
            Board.PlacePiece(new King(Colors.White, Board), new ChessPosition('d', 1).ToPosition());
            Board.PlacePiece(new Tower(Colors.White, Board), new ChessPosition('d', 2).ToPosition());
            Board.PlacePiece(new Tower(Colors.White, Board), new ChessPosition('e', 1).ToPosition());
            Board.PlacePiece(new Tower(Colors.White, Board), new ChessPosition('e', 2).ToPosition());

            Board.PlacePiece(new Tower(Colors.Black, Board), new ChessPosition('c', 7).ToPosition());
            Board.PlacePiece(new Tower(Colors.Black, Board), new ChessPosition('c', 8).ToPosition());
            Board.PlacePiece(new King(Colors.Black, Board), new ChessPosition('d', 8).ToPosition());
            Board.PlacePiece(new Tower(Colors.Black, Board), new ChessPosition('d', 7).ToPosition());
            Board.PlacePiece(new Tower(Colors.Black, Board), new ChessPosition('e', 7).ToPosition());
            Board.PlacePiece(new Tower(Colors.Black, Board), new ChessPosition('e', 8).ToPosition());


        }
    }
}