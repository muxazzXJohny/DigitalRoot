using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            string input = Console.ReadLine();

            if (long.TryParse(input, out long number) && number > 0)
            {
                int digitalRoot = CalculateDigitalRoot(number);
                Console.WriteLine($"Цифровой корень числа {number} равен: {digitalRoot}");
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное натуральное число.");
            }
            
            Console.ReadKey();

        }

        static int CalculateDigitalRoot(long number)
        {
            while (number >= 10) // Продолжаем, пока число не станет однозначным
            {
                number = SumOfDigits(number); // Суммируем цифры
            }
            return (int)number; // Возвращаем одноцифровое число

        }
        
        public static int DigitalRootNumber2(int number)
        {
            return (number - 1) % 9 + 1;
        }
        static long SumOfDigits(long number)
        {
            long sum = 0;
            while (number > 0)
            {
                sum += number % 10; // Добавляем последнюю цифру к сумме
                number /= 10; // Убираем последнюю цифру
            }
            return sum; // Возвращаем сумму цифр
        }
    }
}




