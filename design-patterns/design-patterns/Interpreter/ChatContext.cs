namespace design_patterns.Interpreter
{
    public class ChatContext
    {
        public string input { get; set; }
        public IAction action { get; set; }
        public ChatContext(string input)
        {
            this.input = input;
        }
    }
}
