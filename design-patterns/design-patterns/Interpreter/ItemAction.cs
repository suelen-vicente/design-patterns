using System;
namespace design_patterns.Interpreter
{
    public class ItemAction : IAction
    {
        public void execute()
        {
            Console.WriteLine("Do you want to talk about Item?");
        }
    }
}
