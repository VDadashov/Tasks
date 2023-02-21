using Practice.Generic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null);// nulls are allowed for reference type list

            //adding elements using collection-initializer syntax
            var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };



            Console.WriteLine("=======================");

            var numbers = new List<int>() { 10, 20, 30, 40, 10 };

            numbers.Remove(10); // removes the first 10 from a list

            numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

            //numbers.RemoveAt(10); //throws ArgumentOutOfRangeException



            Console.WriteLine("============ShortList=============");

            SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {5, "Five"},
                                        {1, "One"}
                                    };

            Console.WriteLine("---Initial key-values--");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            numberNames.Add(6, "Six");
            numberNames.Add(2, "Two");
            numberNames.Add(4, "Four");

            Console.WriteLine("---After adding new key-values--");

            foreach (var kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);


            Console.WriteLine("----------------------");


            Console.WriteLine("==============Dictionary==============");

            IDictionary<int, string> numberNames1 = new Dictionary<int, string>();
            numberNames1.Add(1, "One"); //adding a key/value using the Add() method
            numberNames1.Add(2, "Two");
            numberNames1.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //creating a dictionary using collection-initializer syntax
            var cities1 = new Dictionary<string, string>(){
                     {"UK", "London, Manchester, Birmingham"},
                     {"USA", "Chicago, New York, Washington"},
                     {"India", "Mumbai, New Delhi, Pune"}
                                       };

            foreach (var kvp in cities1)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

        }
    }
}
