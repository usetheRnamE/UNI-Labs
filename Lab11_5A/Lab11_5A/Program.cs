using System;

namespace Lab11_5A
{
    public class Program
    {
        private static int  Dimension = 3;
        private static int[,] aMatrix = new int[Dimension, Dimension], bMatrix = new int[Dimension, Dimension];

        private static void Main()
        {
            Console.WriteLine("Matrix calculator \n Do you wanna use A custom matrix ? \n Write Y or N psz ");

            if (Console.ReadKey().Key == ConsoleKey.Y)
                aMatrix = MatrixCustomize(aMatrix);
            else Console.WriteLine(" Ok, we use default A matrix instead ");

            Console.WriteLine(" \n Do you wanna use B custom matrix ? \n Write Y or N psz ");

            if (Console.ReadKey().Key == ConsoleKey.Y)
                bMatrix = MatrixCustomize(bMatrix);
            else Console.WriteLine(" Ok, we use default B matrix instead ");

            DefaultMatrixSet();
            ResultCalculate();
        }

        private static int[,] MatrixCustomize(int[,] matrix)
        {
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matrix;
        }

        private static void DefaultMatrixSet()
        {
            aMatrix = new int[,] {
                { -5, 3, 1 },
                { 0, 2, -4 },
                { -1, 0, 3 }
            };

            bMatrix = new int[,] {
                { -6, 0, 4 },
                { 2, 3, 7 },
                { 2, -1, 3 }
            };
        }


        private static void ResultCalculate()
        {
            int[,] fCompMatrix = MatrixAdd(aMatrix, bMatrix, 1);
            int[,] sCompMatrix = MatrixAdd(aMatrix, bMatrix, -1);
            int[,] tCompMatrix = MatrixMultiplied(aMatrix, aMatrix);
            int[,] fouCompMatrix = MatrixMultiplied(bMatrix, bMatrix);
            int[,] fivCompMatrix = MatrixAdd(MatrixMultiplied(fCompMatrix, sCompMatrix), tCompMatrix, 1);
            int[,] result = MatrixAdd(fivCompMatrix, fouCompMatrix, 1);

            Console.WriteLine(" \n matrix addition: \n");
            ResultWrite(fCompMatrix);
            Console.WriteLine(" \n matrix subtraction:  \n");
            ResultWrite(sCompMatrix);
            Console.WriteLine(" \n 1th matrix to sqrt:  \n");
            ResultWrite(tCompMatrix);
            Console.WriteLine(" \n 2th matrix to sqrt:  \n");
            ResultWrite(fouCompMatrix);
            Console.WriteLine(" \n 1th and 2th matrix multiplication & addition with 1th sqrt matrix:  \n");
            ResultWrite(fivCompMatrix);


            Console.WriteLine(" \n The result is:  \n");
            ResultWrite(result);
        }

       private static void ResultWrite(int[,] resultMatrix)
        {
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    Console.Write(" " + resultMatrix[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] MatrixAdd(int[,] fMatrix, int[,] sMatrix, sbyte sign)
        {
            int[,] sumMatrix = new int[Dimension, Dimension];

            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    sumMatrix[i, j] = fMatrix[i, j] + sign * sMatrix[i, j];
                }
            }
            return sumMatrix;
        }
        private static int[,] MatrixMultiplied(int[,] fMatrix, int[,] sMatrix)
        {
            int[,] mulMatrix = new int[Dimension, Dimension];

            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    int sum = 0;

                    for (int k = 0; k < Dimension; ++k)                    
                        sum = sum + fMatrix[i,k] * sMatrix[k,j];

                    mulMatrix[i,j] = sum;                  
                }
            }

            return mulMatrix;
        }
    }
}
