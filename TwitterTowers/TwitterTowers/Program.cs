using System;

namespace TwitterTowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("----Welcome to the Twitter Towers----");
            do
            {
                Console.WriteLine("Please enter 1 for a rectangle or 2 for a triangular or 3 to exit");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Please enter the height");
                        double height = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the width");
                        double width = int.Parse(Console.ReadLine());
                        Rectangle(height, width);
                         break;
                    case 2:
                        Console.WriteLine("Please enter the height");
                        double h = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the width");
                        double w = int.Parse(Console.ReadLine());
                        Triangular(h, w);
                        break;
                }
            } while (input == 1 || input == 2 || input > 3 || input < 1);
        }

        public static void Rectangle(double height, double width)
        {
            if (Math.Abs(height - width) > 5)
            {
                Console.WriteLine("The area of the rectangle is: " + height * width);
            }
            else
                Console.WriteLine("The perimeter of the rectangle is: " + (height * 2 + width * 2));
        }
        public static void Triangular(double height, double width)
        {
            int input;
            do
            {
                Console.WriteLine("Enter 1 to calculate the perimeter or 2 to print the triangular");
                input = int.Parse(Console.ReadLine());
            } while (input != 1 && input != 2);
            switch (input)
            {
                case 1:
                    Console.WriteLine("The perimeter of the triangular is: " + (height * width) / 3);
                    break;
                case 2:
                    if (width % 2 == 0 || height * 2 < width)
                        Console.WriteLine("Sorry, we are not able to print the triangular");
                    else
                        TriangularOfStars((int)height, (int)width);
                    break;
            }
        }
        public static void TriangularOfStars(int height, int width)
        {
            int middleLines = height - 2, countOddDigits = 0;
            for (int i = 3; i < width; i += 2, countOddDigits++) ;
            //print the first line
            for (int j = width / 2; j > 0; j--)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
            //print the middle lines
            if (countOddDigits != 0)   
            {
                int over = middleLines - ((middleLines / countOddDigits) * countOddDigits);
                for (int i = 0; i < over; i++)
                {
                    for (int j = (width-3) / 2; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            for (int z = 3; z < width; z += 2)
            {
                for (int k = 0; k < (middleLines / countOddDigits); k++)
                {
                    for (int i = (width-z)/2; i > 0; i--)
                    {
                        Console.Write(" ");
                    }
                    for (int i = 0; i < z; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            //print the last line
            for (int i = 0; i < width; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
