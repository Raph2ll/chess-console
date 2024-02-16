using System;
using chess_console.Board;
using chess_console.Board.Enum;

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
                    if (board.Piece(l, c) == null)
                    {
                        Console.Write($"- ");
                    }
                    else
                    {
                        PrintPiece(board.Piece(l, c));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void PrintPiece(Piece piece)
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
        }
    }
}
