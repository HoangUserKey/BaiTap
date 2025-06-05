using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C25_02
{
    internal class Bai6
    {

        public static void bai1()
        {
            Random rnd = new Random();
            int[] x = new int[10];
          
            for (int i = 0; i < x.Length ; i++) {

                x[0] = rnd.Next(-4, 10);
            }

            for (int i = 0; i < x.Length; i++)
            {

                Console.Write(x[i]+"  ");
            }
            Console.WriteLine();

            int y = 4;
            int ind = 0;
            int max = Math.Abs(x[0] - y);
            for (int i = 1; i < x.Length; i++)
            {
                if ( max < Math.Abs(x[0] - y))
                {
                    max = Math.Abs(x[0] -y);
                    ind = 1;                }
            }
            Console.WriteLine(ind);
        }


        public static void bai2() {
         
            int[,] x = new int[2,3] ;
            
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Nhap gia tri cho hang {0} cot {1}: ", i, j);
                    x[i,j] = int.Parse(Console.ReadLine());
                }
            // hien thi mang dang ma tran
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(x[i, j] + "  ");
                }
                Console.WriteLine() ;

            }


        }
        public static void bai342()
        {
            double[,] matrix = {
            { 1.2, 3.4, 2.1 },
            { 4.5, 6.7, 5.3 },
            { 7.8, 8.9, 6.4 }
        };

            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);
            int peakCount = 0;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (IsPeak(matrix, i, j, rowCount, colCount))
                    {
                        peakCount++;
                    }
                }
            }

            Console.WriteLine($"so lung phan tu cuc dai la: {peakCount}");

        }
        static bool IsPeak(double[,] matrix, int i, int j, int rowCount, int colCount)
        {
            double current = matrix[i, j];
            int[] dx = { -1, 1, 0, 0, -1, -1, 1, 1 };
            int[] dy = { 0, 0, -1, 1, -1, 1, -1, 1 };

            for (int k = 0; k < dx.Length; k++)
            {
                int ni = i + dx[k];
                int nj = j + dy[k];

                if (ni >= 0 && ni < rowCount && nj >= 0 && nj < colCount)
                {
                    if (matrix[ni, nj] >= current)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static void bai343()
        {
            double[,] matrix = {
            { 1.2, 3.4, 2.1 },
            { 4.5, 6.7, 5.3 },
            { 7.8, 8.9, 6.4 }
        };

            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);
            int extremeCount = 0;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (IsExtreme(matrix, i, j, rowCount, colCount))
                    {
                        extremeCount++;
                    }
                }
            }

            Console.WriteLine("So luong phan tu cuc tri: "+ extremeCount);

        }


        static bool IsExtreme(double[,] matrix, int i, int j, int rowCount, int colCount)
        {
            double current = matrix[i, j];
            int[] dx = { -1, 1, 0, 0, -1, -1, 1, 1 };
            int[] dy = { 0, 0, -1, 1, -1, 1, -1, 1 };

            bool isMax = true;
            bool isMin = true;

            for (int k = 0; k < dx.Length; k++)
            {
                int ni = i + dx[k];
                int nj = j + dy[k];

                if (ni >= 0 && ni < rowCount && nj >= 0 && nj < colCount)
                {
                    if (matrix[ni, nj] >= current) isMax = false;
                    if (matrix[ni, nj] <= current) isMin = false;
                }
            }

            return isMax || isMin;
        }

        public static void bai344()
        {
            double[,] matrix = {
            { 1.2, 3.4, 2.1 },
            { 4.5, 6.7, 5.3 },
            { 7.8, 8.9, 2.1 }
        };

            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);

            HashSet<double> uniqueValues = new HashSet<double>();

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    uniqueValues.Add(matrix[i, j]);
                }
            }

            Console.WriteLine($"So luong gia tri duy nhat trong ma tran la: {uniqueValues.Count}");
        }

        public static void bai345() {
            double[,] matrix = {
            { 1.2, 3.4, 2.1 },
            { 4.5, 6.7, 5.3 },
            { 7.8, 8.9, 6.4 }
        };

            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);
            double extremeSum = 0;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (IsExtremee(matrix, i, j, rowCount, colCount))
                    {
                        extremeSum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine("Tong cac phan tu cuc tri: "+ extremeSum);

        }

        static bool IsExtremee(double[,] matrix, int i, int j, int rowCount, int colCount)
        {
            double current = matrix[i, j];
            int[] dx = { -1, 1, 0, 0, -1, -1, 1, 1 };
            int[] dy = { 0, 0, -1, 1, -1, 1, -1, 1 };

            bool isMax = true;
            bool isMin = true;

            for (int k = 0; k < dx.Length; k++)
            {
                int ni = i + dx[k];
                int nj = j + dy[k];

                if (ni >= 0 && ni < rowCount && nj >= 0 && nj < colCount)
                {
                    if (matrix[ni, nj] >= current) isMax = false;
                    if (matrix[ni, nj] <= current) isMin = false;
                }
            }

            return isMax || isMin;
        }

        public static void bai346() {
            double[,] matrix = {
            { 1.2, 3.4, 2.1 },
            { 4.5, 6.7, 5.3 },
            { 7.8, 8.9, 6.4 }
        };

            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);
            int queenCount = 0;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (IsQueen(matrix, i, j, rowCount, colCount))
                    {
                        queenCount++;
                    }
                }
            }

            Console.WriteLine($"So luong phan tu hoang hau: {queenCount}");

        }


        static bool IsQueen(double[,] matrix, int i, int j, int rowCount, int colCount)
        {
            double current = matrix[i, j];

            // Kiểm tra hàng và cột
            for (int x = 0; x < rowCount; x++)
            {
                if (x != i && matrix[x, j] >= current) return false;
            }
            for (int y = 0; y < colCount; y++)
            {
                if (y != j && matrix[i, y] >= current) return false;
            }

            // Kiểm tra đường chéo chính (\)
            for (int d = -Math.Min(i, j); d <= Math.Min(rowCount - 1 - i, colCount - 1 - j); d++)
            {
                if (d != 0 && matrix[i + d, j + d] >= current) return false;
            }

            // Kiểm tra đường chéo phụ (/)
            for (int d = -Math.Min(i, colCount - 1 - j); d <= Math.Min(rowCount - 1 - i, j); d++)
            {
                if (d != 0 && matrix[i + d, j - d] >= current) return false;
            }

            return true;
        }

    }
}

