using System;
using System.ComponentModel.DataAnnotations;

namespace classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(FindSpace("Hello World"));
            //Console.WriteLine(CountChar("Hello World",'l'));

            //int[] numbers = { 12, 5, 8, 3 };

            //int[] newArr = FindArray(numbers, 10);

            //for (int i = 0; i < newArr.Length; i++)
            //{
            //    Console.WriteLine(newArr[i]);
            //}

            int num = 12;
            Make(ref num);
            Console.WriteLine(num);

            string input = "Hello World";
            NotSpace1(ref input);
            Console.WriteLine(input);
            

            


        }
        static int FindSpace(string text)
        {

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    return i;
            }
            return -1;

        }

        static int CountChar(string text, char cr)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == cr)
                {
                    count++;
                }
            }
            return count;
        }

        static int[] FindArray(int[] array,int num)
        {
            int count = array.Length+1;

            int[] newArr = new int[count];

            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                newArr[j] = array[i];
                j++;
                
            }

            newArr[array.Length] = num;

            return newArr;
        }
        static void Make(ref int num1)
        {
            num1 *= -1;

        }

        static string NotSpace(string text)
        {
            string newStr = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    newStr += text[i];
                }
            }

             text = newStr;

            return text;
        }

        static void NotSpace1(ref string text)
        {
            string newStr = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    newStr += text[i];
                }
            }

            text = newStr;

        }
    }
    

}
