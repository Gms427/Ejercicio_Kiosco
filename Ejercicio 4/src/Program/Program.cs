using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leo el contenido del archivo
            string [] fileContent = FileReader.ReadFile("../../assets/board.txt");

            // Armo el board con lo que leí del archivo
            Board board = new Board(fileContent);

            // Comienzo a imprimir las secuencias 
            BoardPrinter.PrintBoard(board);
        }
    }
}
