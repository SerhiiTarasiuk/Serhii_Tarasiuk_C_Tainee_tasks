using System;

/*  1. Составить алгоритм: если введенное число больше 7, то вывести “Привет”
    2. Составить алгоритм: если введенное имя совпадает с Вячеслав,
         то вывести “Привет, Вячеслав”, если нет, то вывести "Нет такого имени"
    3. Составить алгоритм: на входе есть числовой массив, необходимо вывести элементы массива кратные 3

*/

namespace Trainee_Tasks
{
    internal class Program
    {
        static void Task1() //"1  - Составить алгоритм: если введенное число больше 7, то вывести “Привет”\n"
        {
            int number = 0;

            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number > 7)
                Console.WriteLine("Привет");
            else
                Console.WriteLine("ERROR. Your number <= 7");
        }

        static void Task2() //"Составить алгоритм: если введенное имя совпадает с Вячеслав,
                            // то вывести “Привет, Вячеслав”, если нет, то вывести "Нет такого имени"
        {
            string name = "";

            Console.Write("Enter your name : ");
            name = Console.ReadLine();

            if (name == "Вячеслав")
                Console.WriteLine("Привет, Вячеслав");
            else
                Console.WriteLine("Нет такого имени");
        }

        static void Task3() //"Составить алгоритм: на входе есть числовой массив, необходимо вывести элементы массива кратные 3
        {
            Console.Write("Enter lenght of array : ");
            int lenghtOfArray = int.Parse(Console.ReadLine());
            if (lenghtOfArray >= 1)
            {
                int[] numbers = new int[lenghtOfArray];

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"Enter numbers {i}: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Your Array : ");
                foreach (int number in numbers)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine("\nNumbers that are multiples of 3:");
                foreach (int number in numbers)
                {
                    if (number % 3 == 0)
                    {
                        Console.Write(number + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error size!");
            };
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter:\n\n" +
                "1  - Составить алгоритм: если введенное число больше 7, то вывести “Привет”\n" +
                "2  - Составить алгоритм: если введенное имя совпадает с Вячеслав,\n        " +
                "     то вывести “Привет, Вячеслав”, если нет, то вывести \"Нет такого имени\"\n" +
                "3  - Составить алгоритм: на входе есть числовой массив, необходимо вывести элементы массива кратные 3\n\n");
            int varriant = -1;
            varriant = int.Parse(Console.ReadLine());

            switch (varriant)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
            }

        }
    }
}
