using StrategyApp.Context;
using StrategyApp.Strategy;
using System;

namespace StrategyApp
{
    class Program
    {
        /// <summary>
        /// strategy design pattern kind of factory design pattern
        /// In factory pattern,factory class decide which object will be create based on parameter
        /// but in strategy pattern, from main method send  context class constractor which class should be create
        /// mainly this context class name is strategy class. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


            CalculateClient minusClient = new CalculateClient(new Minus());
            Console.WriteLine("Minus: " + minusClient.Calculate(7, 1).ToString());

            CalculateClient plusClient = new CalculateClient(new Plus());
            Console.WriteLine("Plus: " + minusClient.Calculate(7, 1).ToString());

        }
    }
}
