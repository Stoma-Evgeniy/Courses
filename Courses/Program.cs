using System;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, a;



            Console.WriteLine("Введите сумму кредита");
            decimal sum = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите процент по кредиту");
            decimal procent = int.Parse(Console.ReadLine());

            Console.WriteLine("Каким способам расчитать платежи: дифференцированным (нажмите 1) или аннуитетным (нажмите 2)");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Выплаты по месяцам");

            if (a == 1)
                     
            for (i = 1; i <= 12; i++ )
                {
                    decimal sumdolga = sum / 12;
                    decimal sumplatega = sumdolga + (sum - (sumdolga * i)) * procent/100/12 ;
                
                    Console.WriteLine(i + " месяц " + sumplatega + " руб.");
                }
            else
                for (i = 1; i <= 12; i++)
                {
                    decimal procent2 = procent / 12;
                    decimal b = 1 + procent2;
                                      
                    decimal sumplatega = sum * (procent2 + procent2 / (b - 1));

                    Console.WriteLine(i + " месяц " + sumplatega + " руб.");


                }
        }
    }
}
