using System;
using System.Net.NetworkInformation;
using chess_console.Board;
using chess_console.Board.Enum;
using chess_console.Chess;

namespace chess_console
{
    public class Screen
    {
        public static void printBoard(BoardService board)
        {
            for (int l = 0; l < board.Lines; l++)
            {
                Console.Write($"{8 - l} ");
                for (int c = 0; c < board.Columns; c++)
                {
                    PrintPiece(board.Piece(l, c));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }
        public static ChessPosition ReadChessPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int line = int.Parse($"{s[1]} ");

            return new ChessPosition(column, line);
        }
        public static void PrintPiece(Piece piece)
        {
            if (piece == null)
            {
                Console.Write($"- ");
            }
            else
            {
                if (piece.Color == Colors.White)
                {
                    Console.Write(piece);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(piece);
                    Console.ForegroundColor = aux;

                }
                Console.Write(" ");
            }
        }
    }
}
