using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Вычислить значение функции для целых аргументов двумя способами (1-й способ: полный условный оператор; 2-й способ: тернарная операция):
            //1-й способ: полный условный оператор
            Console.WriteLine("Введите значение x:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                double y = Math.Pow(Math.Sin(x),2);
                //Выводим значение функции
                Console.WriteLine("Значение функции y = " + y);
            }
            else
            {
                double y = 1 - 2 * Math.Sin(Math.Pow(x, 2));
                //Выводим значение функции
                Console.WriteLine("Значение функции y = " + y);
            }
            Console.Read();
            //2-й способ: тернарная операция
            Console.WriteLine("Введите значение x:");
            int x = Convert.ToInt32(Console.ReadLine());
            double y = x > 0 ? Math.Pow(Math.Sin(x), 2) : 1 - 2 * Math.Sin(Math.Pow(x, 2));
            //Выводим значение функции
            Console.WriteLine("Значение функции y = " + y);
            Console.Read();
            */


            /*2.Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.
            Random rnd = new Random();
            int x = rnd.Next(10, 99);
            Console.WriteLine("Случайное число: " + x);
            string y = x % 2 == 0 ? "Четное" : "Нечетное";
            Console.WriteLine("Число " + y);
            Console.Read();
            */


            /*3. Даны три целых положительных числа. Если все они четные, каждое число увеличить на 1; если хотя бы одно из них четное, уменьшить на 1; если четных чисел нет, каждое число увеличить в 2 раза.
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
            {
                a++;
                b++;
                c++;
                Console.WriteLine("Все числа четные, каждое число увеличено на 1");
            }
            else if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
            {
                a--;
                b--;
                c--;
                Console.WriteLine("Хотя бы одно число четное, каждое число уменьшено на 1");
               
            }
            else
            {
                a *= 2;
                b *= 2;
                c *= 2;
                Console.WriteLine("Четных чисел нет, каждое число увеличено в 2 раза");
            }
            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);
            Console.Read();
            */




            /*4.По введенному номеру месяца выводится название поры года(зима, весна, лето, осень) и сообщение: сессия, каникулы, 1 семестр, 2 семестр
            Console.WriteLine("Введите номер месяца:");
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("Зима");
                    Console.WriteLine("Каникулы");
                    Console.WriteLine("2 семестр"); break;
                case 2:
                    Console.WriteLine("Зима");
                    Console.WriteLine("2 семестр"); break;
                case 12:
                    Console.WriteLine("Зима");
                    Console.WriteLine("Сессия");
                    Console.WriteLine("1 семестр");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    Console.WriteLine("2 семестр");
                    break;
                case 6:
                    Console.WriteLine("Лето");
                    Console.WriteLine("Сессия"); break;
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    Console.WriteLine("Каникулы");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень");
                    Console.WriteLine("1 семестр");
                    break;
                default:
                    Console.WriteLine("Неверный номер месяца");
                    break;
            }
            Console.Read();
            */


        }
    }
}
