using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_6
{
    class Program
    {
        delegate string Del1 (int a, string c); //объявление делегата
        //Func<string, int, string> Del2; //использование обобщенного делегата

        static string Met1(int a, string str) //метод, соотв 1 делегату
        {
            string result = a.ToString() + ". " + str; 
            return (result);
        }

        static string Met2(string str, int a) //метод, соотв 2 делегату
        {
            string result = a.ToString() + ". " + str;
            return (result);
        }


        static void HiMethod1 (int n1, Del1 Met1) //превращает строку в строку-с-циферкой-впереди
        {
            Console.WriteLine("Введите строку: ");
            string str1 = Console.ReadLine();
            Console.WriteLine(Met1(n1, str1));//вызвали функцию с точкой
        }


        static void HiMethod2(int n1, Func<string, int, string> Met2)
        {
            Console.WriteLine("Введите строку: ");
            string str1 = Console.ReadLine();
            Console.WriteLine(Met2(str1, n1));
        }


        static void Main(string[] args)
        {
           Console.WriteLine("Метод с делегатом");
           HiMethod1(1, Met1); //передали метод, ставящий точку

            Console.WriteLine("Метод с лямбда-выражением");
            HiMethod1(2, //второй вариант с лямбда-выражением, ставящим скобочку
                (b, str2) => (b.ToString() + ") " + str2) //сокращенный вариант: что дано и что вернуть
            );

            Console.WriteLine("Метод с обобщённым делегатом");
            HiMethod2(3, Met2);

            Console.WriteLine("Метод с обобщенным делегатом и лямбда-выражением");
            HiMethod2(4,
                (str2, b) => (b.ToString() + ") " + str2)
            );

            Console.ReadLine();
        }
    }
}
