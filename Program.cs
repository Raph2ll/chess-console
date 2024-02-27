using System;
using chess_console.Board.Exceptions;
using chess_console.Board;
using chess_console.Chess;

namespace chess_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessMatch match = new ChessMatch();
                while (!match.Finished)
                {
                    Console.Clear();
                    Screen.printBoard(match.Board);

                    Console.WriteLine("Origin: ");
                    Position origin = Screen.ReadChessPosition().ToPosition();

                    Console.WriteLine("Destiny: ");
                    Position destiny = Screen.ReadChessPosition().ToPosition();


                    match.PerformMovement(origin, destiny);
                }
            }
            catch (BoardException e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}