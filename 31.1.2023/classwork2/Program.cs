using System;
using System.Diagnostics;
using System.Threading;

namespace classwork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var result = Result(2, 3);
            //Console.WriteLine(result);

            //var charA = CharA("Salam");
            //Console.WriteLine(charA);

            //Console.WriteLine(LetterBool("eli"));

            //Console.WriteLine(Reverse("Salam"));

            //Console.WriteLine(CharCount("Salam",'a'));

            //int[] numbers = { 12, 5, 7, 34, 6, 2 };

            //Console.WriteLine("Ededi daxil edin:");
            //int num = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(NumFind(numbers,num));

            Console.WriteLine(FindSpace("Hello World"));
        }

        static int Result(int num,int quvvet)
        {
            var result = 1;

            for (int i = 1; i <= quvvet; i++)
            {
                result *= num;
            }
            return result;
        }

        static int CharA(string input)
        {
            char aStr = 'a';
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
              
                if (input[i] == aStr)
                {
                    count++;
                }
            }
            return count;
        }

        static bool LetterBool(string text)
        {
            bool result = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        static string Reverse(string text)
        {
            string newStr = "";

            for (int i = text.Length-1; i >=0; i--)
            {
                newStr += text[i];
            }

            return newStr;
        }

        static int CharCount(string text,char input)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == input)
                {
                    count++;
                }
            }

            return count;
        }

        static int NumFind(int[] numbers,int num)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    return i;
                }
            }

            return -1;
        }

        static string FindSpace(string text)
        {
            string newStr = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    break;
                }
                newStr += text[i];
            }

            return newStr;
        }
    }
}
