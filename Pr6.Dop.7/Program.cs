using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2; //присвоение локальным переменным num1,num2 целого типа int.
            float f1, f2; //присвоение локальным переменным f1,f2 вещественного типа float.

            num1 = 13 / 3; // ариметический оператор "деление".
            num2 = 13 % 3; // арифметическая оператор "отстаток от деления"

            f1 = 13.0f / 3.0f; // вычисление результата деления
            f2 = 13.0f % 3.0f; // вычисление резельтата отстатка от деления

            Console.WriteLine("Результат и остаток от деления 13 на 3: {0} __ {1}", num1, num2); // вывод строки "..." с полученными данными на экран
            Console.WriteLine("Результат деления 13.0 на 3.0: {0:#.###} {1}", f1, f2); // вывод строки "..." с полученными данными на экран

            Console.ReadLine(); //считывание данных.
        }
    }
}
