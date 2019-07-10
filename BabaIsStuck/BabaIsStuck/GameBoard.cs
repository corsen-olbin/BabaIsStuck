using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabaIsStuck
{
    public class GameBoard
    {
        public int Width;
        public int Height;

        public Word[,] Board;

        public static GameBoard Create(int width, int height)
        {
            var board = new GameBoard();

            board.Width = width;
            board.Height = height;
            board.Board = new Word[height, width];

            return board;
        }


    }
}
