using System;

namespace Lab11_5B
{
    class Program
    {
        private const int hDim = 3, wDim = 4;

        private static float[,] matrix;

        private static void Main()
        {
            matrix = Matrix();

            GaussMethod(matrix);
        }
        private static float[,] Matrix()
        {
           return matrix = new float[,]
            {
                { 2, 3, 1, -5 },
                { 3, -4, -5, 5 },
                { 2, 2, 3, 2 }
            };
        }
            private static void GaussMethod(float[,] matrix)
            {

                int i, j, k = 0, c;

                for (i = 0; i < hDim; i++)
                {
                   if (matrix[i, i] == 0)
                   {
                      c = 1;

                      while ((i + c) < wDim && matrix[i + c, i] == 0)
                        c++;
                    
                      for (j = i, k = 0; k <= wDim; k++)
                      {
                         float temp = matrix[j, k];

                         matrix[j, k] = matrix[j + c, k];
                        
                         matrix[j + c, k] = temp;

                        Console.WriteLine("\n matrix after: " + k + " iteration of line swaping \n");
                        PrintMatrix(matrix);
                    }
                }

                for (j = 0; j < hDim; j++)
                {
                    if (i != j)
                    {
                        float p = matrix[j, i] / matrix[i, i];

                        for (k = 0; k <= hDim; k++)
                        {
                            matrix[j, k] = matrix[j, k] - (matrix[i, k]) * p;

                            Console.WriteLine("\n matrix after: " + k + " iteration of line subtraction \n");
                            PrintMatrix(matrix);
                        }
                    }
                }          
            }
            Console.WriteLine("\n result matrix: \n ");

            PrintMatrix(matrix);
        }
        private static void PrintMatrix(float[,] rMatrix)
        {
            for (int i = 0; i < hDim; i++)
            {
                for (int j = 0; j < wDim; j++)
                    Console.Write(rMatrix[i, j] + " ");

                Console.WriteLine();
            }
        }
    }
}

    
