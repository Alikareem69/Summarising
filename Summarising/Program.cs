using System;
using System.Collections.Generic;

namespace Summarising
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var text = "This is going to be really really really really really long text";
            var summary = ProgramUtility.SummarizeText(text);
            Console.WriteLine(summary);
        }
        
    }
}
