using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class rotateMatrix
    {
        public rotateMatrix(int[,] matrix, int rotations)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] rotatedMatrix = new int[cols, rows];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    rotatedMatrix[col, rows - 1 - row] = matrix[ row,col];
                }
            }
                for(int col = 0;col < cols;col++)
            {
            for (int row = 0;row<rows;row++)
                {
                    Console.Write(rotatedMatrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
