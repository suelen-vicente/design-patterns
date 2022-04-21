namespace design_patterns.Interpreter
{
    public class ActionExpression : IExpression
    {
        public void interpret(ChatContext value)
        {
            if (value.input.ToLower().Contains("user"))
            {
                value.action = new UserAction();
            }
            else if (value.input.ToLower().Contains("item"))
            {
                value.action = new ItemAction();
            }
            else if (value.input.ToLower().Contains("payment"))
            {
                value.action = new PaymentAction();
            }
        }
    }
}
