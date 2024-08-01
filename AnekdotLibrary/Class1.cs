using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnekdotLibrary
{
    public class Class1
    {
        public static int chetno_nechetno(int value)
        {          
            Console.Write("Введите многоуважаемое число: ");
            if (value % 2 == 0) //Проверка на чётность последней цифры
            {
                Console.WriteLine("Выходит, что цифра чётная");
            }
            else //Если цифра чётная
            {
                Console.WriteLine("Выходит, что цифра НЕчётная");
            }
            return value;
        }
        public static int four_seven_test(int value)
        {
            Console.Write("Введите многоуважемое число: ");
            if (value % 10 == 7 || value % 10 == 4 || value / 10 == 7 ||  value / 10 == 4) //Проверка на наличие цифр 4 и 7
            {
                Console.WriteLine("Циферки 4 и 7 в наличии");
            }
            else //Если цифр 4 и 7 нет
            {
                Console.WriteLine("Циферок 4 и 7 нема");
            }
            return value;
        }
    }
}
