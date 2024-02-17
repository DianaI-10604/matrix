using System.Net.Http.Headers;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Матрица 1: ");
            int CountRows;
            int CountColumns;

            rowsColumnsInput(out CountRows, out CountColumns);
            Matrix matrix1 = new Matrix(CountRows, CountColumns); //конструктор

            Console.WriteLine("Матрица 2: ");
            rowsColumnsInput(out CountRows, out CountColumns);
            Matrix matrix2 = new Matrix(CountRows, CountColumns); //конструктор

            matrix1.matrixFilling(matrix1);  //заполнение матрицы
            matrix1.matrixFilling(matrix2);  //заполнение матрицы

            Console.WriteLine("\nМатрица 1: ");
            matrix1.matrixInfo(matrix1); //вывод матриц

            Console.WriteLine("\nМатрица 2: ");
            matrix2.matrixInfo(matrix2);

            Console.WriteLine("\nРезультат сложения: ");
            int[,] matr = matrix1.matrixAddition(matrix1, matrix2);


        }

        static void rowsColumnsInput(out int CountRows, out int CountColumns)
        {
            Console.Write("Введите кол-во строк: ");
            CountRows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите кол-во столбцов: ");
            CountColumns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
        }
    }
}


