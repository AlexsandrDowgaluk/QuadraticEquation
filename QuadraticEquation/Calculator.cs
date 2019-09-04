using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Calculator
    {

        public static string DoOperation(double num1, double num2, double num3)
        {

            string result = "";
            double a;
            double x = 0;
            double x1 = 0;
            double x2 = 0;
            a = (num2 * num2) - (4 * num1 * num3);
            if (a < 0) {
                result = "Дискриминант равен " + a.ToString() + "\n"+"Квадратное уравнение не имеет корней";
            }
            else if (a == 0) {

                x = -num2 / 2 * num1;

                result = "Дискриминант равен " + a.ToString() + "\n" + "Квадратное уравнение имеет один корень" + x.ToString();
            }
            else if (a > 0) {
                x1 = (-num2 + Math.Sqrt(a)) / (2 * num1);
                x2 = (-num2 - Math.Sqrt(a)) / (2 * num1);
                result = "Дискриминант равен " + a  + "\n" + "Kвадратное уравнение имеет два корня \n" + "x1 =" + x1 + "\n" + "x2 = " + x2 + "\n" ;
            }


            return result;






        }
    }



}
