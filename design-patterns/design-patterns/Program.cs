using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using design_patterns.Interpreter;

namespace design_patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InterpreterExample example = new InterpreterExample();
            example.example();
            Console.ReadLine();
        }
    }
}
