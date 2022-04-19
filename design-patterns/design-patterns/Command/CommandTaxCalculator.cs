namespace design_patterns.Command
{
    public class CommandTaxCalculator : Command
    {
        public CommandTaxCalculator(ExternalTaxesCalculator externalTaxCalculator) :
            base(externalTaxCalculator)
        {
        }
        public override void execute()
        {
            externalTaxesCalculator.calculateTaxes();
        }
    }
}
