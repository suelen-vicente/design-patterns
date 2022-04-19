namespace design_patterns.Command
{
    public class CommandExample
    {
        public void example()
        {
            // Receiver
            ExternalTaxesCalculator externalTaxCalculator = new ExternalTaxesCalculator();
            // Command
            Command command = new CommandTaxCalculator(externalTaxCalculator);
            // Invoker
            ExternalTaxCalculatorCaller invoker = new ExternalTaxCalculatorCaller(command);
            // Execute command
            invoker.executeCommand();
        }
    }
}
