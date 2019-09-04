using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                string numInput3 = "";
                string result = "";

                Console.Write("Введите коефициент а :");
                numInput1 = Console.ReadLine();


                double cleanNum1 = 0;
                int i = Convert.ToInt32(numInput1);
                while ((!double.TryParse(numInput1, out cleanNum1)) || (i == 0))
                {
                    Console.Write("Ошибка ввода или a=0 \n");
                    Console.Write("Введите коефициент а :");
                    numInput1 = Console.ReadLine();

                }
                Console.Write("Введите коефициент b:");
                numInput2 = Console.ReadLine();
                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Ошибка ввода \n");
                    Console.Write("Введите коефициент b:");
                    numInput2 = Console.ReadLine();
                }
                Console.Write("Введите коефициент c:");
                numInput2 = Console.ReadLine();
                double cleanNum3 = 0;
                while (!double.TryParse(numInput2, out cleanNum3))
                {
                    Console.Write("Ошибка ввода \n");
                    Console.Write("Введите коефициент с:");
                    numInput3 = Console.ReadLine();
                }

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, cleanNum3);

                    Console.WriteLine("Результат:" + result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("------------------------\n");


                Console.Write("Нажмите q для закрытия приложения " + "Для продолжения нажмите Enter");
                if (Console.ReadLine() == "q") endApp = true;

                Console.WriteLine("\n");
            }
            return;






        }
    }
}

