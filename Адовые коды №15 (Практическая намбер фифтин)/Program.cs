using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnekdotLibrary;
//Бирюков Георгий, ИСП-23, 17.02.2022
//Ввести натуральное число:
//а)Верно ли, что оно заканчивается нечётной цифрой
//б)Верно ли, что оно заканчивается чётной цифрой
//в)Входят ли в него цифры 4 и 7
namespace Адовые_коды__15__Практическая_намбер_фифтин_
{
    class Program
    {
        static void Main(string[] args)
        {
            int value, chetno_nechetno, four_seven_test; //Ввод значений
            Console.WriteLine("Введите многоуважаемое число: ");
            value = Convert.ToInt32(Console.ReadLine());
            if (0 < value) //Проверка на натуральность
            {
                chetno_nechetno = Class1.chetno_nechetno(value); //Библиотека чётности иль НЕчётности
                four_seven_test = Class1.four_seven_test(value); //Библиотека с тестом на наличие цифр 4 и 7
            }
            else
            {
                Console.WriteLine("Число не является натуралом");
            }
            Console.ReadKey(); //Пауза
        }
    }
}
