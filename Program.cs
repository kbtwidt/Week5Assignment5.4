using System.Drawing;

namespace Week5Assignment5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");
            Console.Write("Input a whole number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write($"The digits in number {num} are: ");
            DisplayDigits(Math.Abs(num));

            Console.WriteLine("\n\nPart 2");
            Console.Write("Input the size of the square matrix: ");
            int size = int.Parse(Console.ReadLine());
            int[,] sqMatrix;
            CreateMatrix(size, out sqMatrix);
            Console.Write($"The sum of the right diagonal is: {SumMatrix(sqMatrix)}");
        }

        static void DisplayDigits(int num)
        {

            if (num < 10)
            {
                Console.Write(num + " ");
                return;
            }
            DisplayDigits(num / 10);
            Console.Write((num % 10) + " ");
        }

        static void CreateMatrix(int size, out int[,] sqMatrix)
        {
            sqMatrix = new int[size, size];

            Console.WriteLine("Input elements in the first matrix: ");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write($"Element [{row + 1}],[{col + 1}]: ");
                    sqMatrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThe matrix is: ");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(sqMatrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        static int SumMatrix(int[,] sqMatrix)
        {
            int sum = 0;

            for (int row = 0; row < sqMatrix.GetLength(0); row++)
            {
                sum += sqMatrix[row, row];
            }
            return sum;
        }
    }
}
