using System;

namespace NOD
{
    class Program
    {
        static void Main()
        {
            int val1, val2;
            Console.WriteLine("Находим НОД 2 чисел");
            {
                Console.WriteLine("Введите 1 число");
                int.TryParse(Console.ReadLine(), out val1);
                Console.WriteLine("Введите 2 число");
               int.TryParse(Console.ReadLine(), out val2);
                if (val1 < 0 || val2<0) 
                {
                    Console.WriteLine(" Ошибка: введено отрицательное число");
                }
                while ((val1 != 0) && (val2 != 0))
                {
                    if (val1 > val2)
                        val1 %= val2;
                    else
                        val2 %= val1;
                }
                Console.WriteLine("Наибольший общий делитель равен");
                Console.WriteLine(val1 + +val2);
            }



        }
    }
}
