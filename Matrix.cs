using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    public class Matrix
    {
        public int CountRows;
        public int CountColumns;
        public int[,] values;

        public Matrix() { }
        public Matrix(int CountRows, int CountColumns) //конструктор
        {
            this.CountRows = CountRows;
            this.CountColumns = CountColumns;
            this.values = new int[CountRows, CountColumns];
        }

        public void matrixFilling(Matrix matrix)  //заполнение матрицы
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.CountRows; i++)
            {
                for (int j = 0; j < matrix.CountColumns; j++)
                    matrix.values[i, j] = rnd.Next(1, 10);
            }
        }

        public int[,] matrixAddition(Matrix matrix1, Matrix matrix2)   //сложение матриц
        {
            Matrix matrix = new Matrix(matrix1.CountRows, matrix1.CountColumns);

            if (matrix1.CountRows != matrix2.CountRows || matrix1.CountColumns != matrix2.CountColumns)
            {
                throw new Exception("Разное кол-во строк/столбцов. Невозможно сложить");
            }

            for (int i = 0; i < matrix1.CountRows; i++)
            {
                for (int j = 0; j < matrix1.CountColumns; j++)
                {
                    matrix.values[i, j] = matrix1.values[i, j] + matrix2.values[i, j];
                }
            }
            return matrix.values;
        }


        public int[,] matrixSubtraction(Matrix matrix1, Matrix matrix2)  //вычитание матриц
        {
            Matrix matrix = new Matrix(matrix1.CountRows, matrix1.CountColumns);

            if (matrix1.CountRows != matrix2.CountRows || matrix1.CountColumns != matrix2.CountColumns)
            {
                throw new Exception("Разное кол-во строк/столбцов. Невозможно вычесть");
            }

            for (int i = 0; i < matrix1.CountRows; i++)
            {
                for (int j = 0; j < matrix1.CountColumns; j++)
                {
                    matrix.values[i, j] = matrix1.values[i, j] - matrix2.values[i, j];
                }
            }
            return matrix.values;
        }


        public int[,] matrixMultiply(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix = new Matrix(matrix1.CountRows, matrix2.CountColumns);

            if (matrix1.CountColumns != matrix2.CountRows || matrix1.CountRows != matrix2.CountColumns)
            {
                throw new Exception("Невозможно выполнить умножение");
            }

            for (int i = 0; i < matrix1.values.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.values.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix2.values.GetLength(0); k++)
                    {
                        matrix.values[i, j] += matrix1.values[i, k] * matrix2.values[k, j];
                    }
                }
            }
            return matrix.values;
        }

        public void matrixInfo(Matrix matrix)   //вывод информации о матрице
        {
            for (int i = 0; i < matrix.CountRows; i++)
            {
                for (int j = 0; j < matrix.CountColumns; j++)
                {
                    Console.Write(matrix.values[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
