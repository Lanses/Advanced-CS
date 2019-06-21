using System;

namespace ConsoleApplication
{
    public class Matrix
    {
        private char[,] array;

        public int RowsCount
        {
            get
            {
                return array.GetLength(0);
            }
        }

        public int ColumnsCount
        {
            get
            {
                return array.GetLength(1);
            }
        }

        public Matrix(int n, int m)
        {
            array = new char[n, m];
            Random rand = new Random();
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = Convert.ToChar(rand.Next('a', 'a' + 27));

                    { Console.Write(array[i, j] + "\t"); }

                }

                Console.WriteLine();
            }
            Console.WriteLine("Преобразование из массива символов в массив чисел: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    { Console.Write(Convert.ToInt32(array[i, j]) + "\t"); }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Cреднее арифметическое элементов матрицы: ");
            int sum = 0;
            int count = 0;
            double average = 0;


            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    sum += array[i, j];
            count = array.Length;
            average = (double)sum / count;
            Console.WriteLine("average={0:F3}", average);

        }


        public Matrix(Matrix another, int increase)
        {
            Console.WriteLine("Новая матрица элементы которой больше исходной на заданное число: ");
            array = new char[another.RowsCount, another.ColumnsCount];
            for (int i = 0; i < RowsCount; i++)
            {
                for (int j = 0; j < ColumnsCount; j++)
                {
                    array[i, j] = Convert.ToChar(another[i, j] + increase);
                    { Console.Write(array[i, j] + "\t"); }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Новая матрица элементы которой больше исходной на заданное число(ASCII): ");
            for (int i = 0; i < RowsCount; i++)
            {
                for (int j = 0; j < ColumnsCount; j++)
                {
                    { Console.Write(Convert.ToInt32(array[i, j]) + "\t"); }
                }
                Console.WriteLine();
            }

        }


        // индексатор
        public char this[int rowIndex, int columnIndex]
        {
            get
            {
                return array[rowIndex, columnIndex];
            }
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(2, 3);
            Matrix m2 = new Matrix(m1, 5);
        }
    }
}