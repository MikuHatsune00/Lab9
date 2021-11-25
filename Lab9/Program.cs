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
            
            
            try
            {
                Console.WriteLine("Введите целое число!");
                int a = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Введите целое число!");
                int b = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Введите код операции:\r\n          1-сложение\r\n          2-вычитание\r\n          3-произведение\r\n          4-частное");
                float c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1: { Console.WriteLine(a + b); break; }
                    case 2: { Console.WriteLine(a - b); break; }
                    case 3: { Console.WriteLine(a * b); break; }
                    case 4: { Console.WriteLine(a / b); break; }
                    default: { Console.WriteLine("Ошибка! Нет операции с указанным номером"); break; }
                }
            }
            catch (System.FormatException)
            { Console.WriteLine("Ошибка! Входная строка имела неверный формат."); }
             
            Console.ReadKey();
            
        
                
                

            //static int arrValue(Array myArray, int i)
           // { Array.Sort(myArray);
              //  return (int)myArray.GetValue(i); }
        }
    }
}