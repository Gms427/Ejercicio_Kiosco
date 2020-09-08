using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class BoardPrinter
    {

        /// <summary>
        /// Recibe el board inicial y se encara de imprimir todas las secuencias del juego
        /// </summary>
        public static void PrintBoard(Board board)
        {
            bool[,] b; //variable que representa el tablero
            int width = board.Width; //variabe que representa el ancho del tablero
            int height = board.Heigth; //variabe que representa altura del tablero

            while(true)
            {   
                b = board.BoardData;
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if (b[x, y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                //=================================================
                //Invocar método para calcular siguiente generación
                //=================================================
                board = BoardUpdater.UpdateBoard(board);

                Thread.Sleep(300);
            }
        }
    }
}
