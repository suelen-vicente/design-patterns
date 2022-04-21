using System;
namespace design_patterns.Interpreter
{
    public class UserAction : IAction
    {
        public void execute()
        {
            Console.WriteLine("Do you want to talk about User?");
        }
    }
}
