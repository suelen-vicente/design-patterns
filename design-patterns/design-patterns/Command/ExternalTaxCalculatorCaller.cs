namespace design_patterns.Command
{
    public class ExternalTaxCalculatorCaller
    {
        Command command;
        public ExternalTaxCalculatorCaller(Command command)
        {
            this.command = command;
        }
        public void executeCommand()
        {
            command.execute();
        }
    }
}
