using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.WriteLine("Введите целое число!");
            
            try 
            {
               int a = Convert.ToInt32(Console.ReadLine());
                            }
            catch (System.FormatException)
            { Console.WriteLine("Ошибка! Входная строка имела неверный формат."); }
            Console.WriteLine("Введите целое число!");
            try
            {
                int b = Convert.ToInt32(Console.ReadLine());
            }
            catch { Console.WriteLine("Ошибка! Входная строка имела неверный формат."); }
            Console.WriteLine("Введите код операции:\r\n          1-сложение\r\n          2-вычитание\r\n          3-произведение\r\n          4-частное");
            try
            {
                int c = Convert.ToInt32(Console.ReadLine());
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка! {a"  );
            }
            Console.ReadKey();
        }
    }
}
