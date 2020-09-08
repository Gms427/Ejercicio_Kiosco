using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class Board
    {
        public int Width { get; set; }
        public int Heigth { get; set; }
        public bool[,] BoardData { get; set; }
        
        public Board(string[] lines)
        {

            bool[,] board = new bool[lines.Length, lines[0].Length];

            for (int  y=0; y<lines.Length;y++)
            {
                for (int x=0; x<lines[y].Length; x++)
                {
                    if(lines[y][x]=='1')
                    {
                        board[x,y]=true;
                    }
                }
            }

            this.Width = board.GetLength(0);
            this.Heigth = board.GetLength(1);
            this.BoardData = board;
        }

        public Board(bool[,] boardData)
        {
            this.BoardData = boardData;
        }
    }
}
