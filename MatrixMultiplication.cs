using System;
using System.Globalization;

class MatrixMultiplication
{
    public static void Main()
    {
        int[,] matrixA = GetInputMatrix("Enter the elements of Matrix A ? ");
        int[,] matrixB = GetInputMatrix("Enter the elements of Matrix B ? ");

        // Console.WriteLine("Enter the elements of matrix A: ");

        // for(int i=0;i<2;i++)
        // {
        //     for(int j=0;j<2;j++)
        //     {
        //         matrixA[i,j]= int.Parse(Console.ReadLine());
        //     }
        // }


        Console.WriteLine("Matrix A:");
        DisplayMatrix(matrixA);

        Console.WriteLine("\nMatrix B:");
        DisplayMatrix(matrixB);

        int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);

        Console.WriteLine("\nMatrix A * B (Result):");
        DisplayMatrix(resultMatrix);
    }

    static int[,] GetInputMatrix(string prompt)
    {

        Console.WriteLine("Enter the no. of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the no of cols: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{prompt}");
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return matrix;
    }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0);
        int colsB = matrixB.GetLength(1);

        if (rowsA != colsB)
        {
            throw new InvalidOperationException("Multiplication is not possible.");
        }

        int[,] result = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsA; j++)
            {
                int sum = 0;
                for (int k = 0; k < colsB; k++)
                {
                    sum += (matrixA[i, k] * matrixB[k, j]);
                }
                result[i, j] = sum;
            }
        }
        return result;

    }


    static void DisplayMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }

    }

}