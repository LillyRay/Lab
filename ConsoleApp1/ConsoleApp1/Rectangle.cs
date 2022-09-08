using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    public class Rectangle
    {
        private double a_;
        private double b_;
        public double Get_a() { return a_; } 
        public void Set_a(double a) 
        {
            if (a > 0)
            {
                a_ = a;
            }
            else
            {
                Console.WriteLine("Сторона може бути тiльки додатним числом.");
                Set_a(Input(1));
            }
        }


        public double Get_b() { return b_; }
        public void Set_b(double b) 
        {
            if (b > 0)
            {
                b_ = b;
            }
            else
            {
                Console.WriteLine("Сторона може бути тiльки додатним числом.");
                Set_b(Input(2));
            }
        }

        public double Input(int number)
        {
            switch(number){
                case 1: Console.WriteLine("Задайте першу сторону прямокутника:");
                    break;
                case 2:
                    Console.WriteLine("Задайте другу сторону прямокутника:");
                    break;
            }
          
            return Convert.ToDouble(Console.ReadLine());
        }

        public void Result(double a, double b) 
        {
            Console.WriteLine("Площа прямокутника:");
            Console.WriteLine(a * b);
            Console.WriteLine("Периметр прямокутника:");
            Console.WriteLine((a * 2) + (b * 2));
        }

    }
}
