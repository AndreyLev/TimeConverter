using System;
using System.Collections.Generic;

namespace HackerRankSolution
{
    class Program
    {

        static void Main(string[] args)
        {
            ITimeConverter timeConverter = new TimeConverter();
            string newTime = timeConverter.ConvertTime("12:40:22AM");
            Console.WriteLine(newTime);

        }
    }
}
