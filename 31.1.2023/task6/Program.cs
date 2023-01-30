using System;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Num();
            int num2 = Num();
            int num3 = Num();


            MaxNum(num1,num2,num3);
        }

        // Verilmiş 3 ədəddən ən böyüyünü tapan proqram

        static void MaxNum(int num1,int num2,int num3) 
        {
            if (num1 > num2) 
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"En boyuk eded {num1}'dir");
                }
                else
                {
                    Console.WriteLine($"En boyuk eded {num3}'dir");
                }
            }
            else if(num2 > num3)
            {
                Console.WriteLine($"En boyuk eded {num2}'dir");
            }
            else
            {
                Console.WriteLine($"En boyuk eded {num3}'dir");
            }
            
        }
        
        static int Num()
        {
            Console.WriteLine("ededi daxil edin");
            string numStr = Console.ReadLine();
            int num = Convert.ToInt32(numStr);

            return num;
        }
    }
}
