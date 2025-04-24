using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

       
        public delegate double MathOperationDelegate(double a, double b);

        class Program
        {
            
            public static double Add(double a, double b)
            {
                return a + b;
            }

            public static double Subtract(double a, double b)
            {
                return a - b;
            }

            public static double Multiply(double a, double b)
            {
                return a * b;
            }

            public static double Divide(double a, double b)
            {
                if (b == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    return double.NaN; 
                }
                return a / b;
            }

            static void Main(string[] args)
            {
               
                MathOperationDelegate addOperation = new MathOperationDelegate(Add);
                MathOperationDelegate subtractOperation = new MathOperationDelegate(Subtract);
                MathOperationDelegate multiplyOperation = new MathOperationDelegate(Multiply);
                MathOperationDelegate divideOperation = new MathOperationDelegate(Divide);

                
                double a = 10;
                double b = 5;

              
                Console.WriteLine($"Сумма: {addOperation(a, b)}");
                Console.WriteLine($"Разность: {subtractOperation(a, b)}");
                Console.WriteLine($"Произведение: {multiplyOperation(a, b)}");
                Console.WriteLine($"Деление: {divideOperation(a, b)}");

               
                Console.ReadLine();
            }
        }
}


