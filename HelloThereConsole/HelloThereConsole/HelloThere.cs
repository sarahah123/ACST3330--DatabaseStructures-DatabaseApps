using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Course:          ACST 3330
 * Section:         1
 * Name:            Sarah Hansberry
 * Professor:       Nagappan
 * Assignment #:    Lab 1
 */

namespace HelloThereConsole
{
    class HelloThere
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There");
            Console.WriteLine("What's your name?");
            String name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            Console.ReadKey();
        }
    }
}
