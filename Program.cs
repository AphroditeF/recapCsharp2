﻿// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit convension
            int number =123456789;
            long bigNumber=number;
            float myFloat=123.456789f;

            double myNewDouble=myFloat;

            double myDouble=123.456789;
            
            int myInt;

            //explicit convension
            //cast double to int
            myInt=(int)myDouble;

            //typeConversion
            string myString=myDouble.ToString();
            string myFloatString=myFloat.ToString();
            
            bool sunIsShining=false;
            string myBoolString=sunIsShining.ToString();

            Console.WriteLine(myBoolString);

        }
    }
}
