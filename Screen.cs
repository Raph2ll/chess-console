using System;
using chess_console.Board;

namespace chess_console
{
    public class Screen
    {
        public static void printBoard(BoardService board)
        {
            for (int l = 0; l < board.Lines; l++)
            {
                for (int c = 0; c < board.Lines; c++)
                {
                    if (board.Piece(l, c) == null)
                    {
                        Console.Write($"- ");
                    }
                    else
                    {
                        Console.Write($"{board.Piece(l, c)}  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
