using System;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дан массив целых чисел, содержащий n элементов. 
            Для тестирования предусмотреть возможность задавать элементы массива различным образом: 
            - при описании с инициализацией, 
            - присвоением значений (в том числе случайных), 
            - или вводом необходимых значений.
            */

            int[] mass1 = { 1, 4, 3, 6, 8, 9, 3, 3, 8, 4, 8, 5, 2, 6, 7 };
            for (int i = 0; i < mass1.Length; i++)
            {
                Console.Write(mass1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("how many elements do you want?");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] mass2;
            mass2 = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                mass2[i] = rnd.Next(1, 10);
                Console.Write(mass2[i] + " ");
            }

            int[] mass3;
            mass3 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter {i}  element: ");
                mass3[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(mass3[i] + " ");
            }

            /* 1. Получить без повторений элементы, 
              встречающиеся в массиве более одного раза.
            */

            Array.Sort(mass1);
            for (int i = 0; i < mass1.Length; i++)
            {
                Console.Write(mass1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < mass1.Length - 1; i++)
            {
                if ((mass1[i]) == (mass1[i + 1]) && mass1[i] != mass1[i - 1])
                {
                    Console.WriteLine(mass1[i]);
                }
            }

            /* 2. Найти в целочисленном массиве за один 
             просмотр 5 наибольших элементов.
            */

            for (int i = mass1.Length - 5; i < mass1.Length; i++)
            {
                Console.Write(mass1[i] + " ");
            }
        }

        static void Main2(string[] args)
        {
            /* 6.Введите с клавиатуры строку произвольной длины и подсчитайте 
             процент вхождения гласных букв латинского алфавита в строку 
             (не различая регистры).
            */
            Console.WriteLine("Enter a string:");

            string str = Console.ReadLine();
            string glas = "euioaEUIOA";
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < glas.Length; j++)
                {
                    if (str[i] == glas[j])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Glasnih: " + count);

            double share;
            share = ((double)count / (double)str.Length) * 100;
            Console.WriteLine("The proportion of vowels in the string: " + share);
        }
        static void Main3(string[] args)
        {
            /* 7.Определите, присутствует ли в тексте, заданном в виде строки, 
             некоторое слово (различие регистра игнорируйте).
            */
            string str = "Hello World!";
            string str2 = "world";

            Console.WriteLine(str);
            if (str.ToLower().Contains(str2.ToLower()))
            {
                Console.WriteLine("Yes!");
            }
        }
    }
}
