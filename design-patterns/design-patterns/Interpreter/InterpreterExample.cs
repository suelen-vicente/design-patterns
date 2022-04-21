namespace design_patterns.Interpreter
{
    public class InterpreterExample
    {
        public void example()
        {
            IExpression expression = new ActionExpression();
            var chat = new ChatContext("Hello! I'd like to talk about my las payment");

            expression.interpret(chat);
            
            chat.action.execute();
        }
    }
}
