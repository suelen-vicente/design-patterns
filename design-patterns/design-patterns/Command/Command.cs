namespace design_patterns.Command
{
    public abstract class Command
    {
        protected ExternalTaxesCalculator externalTaxesCalculator;
        public Command(ExternalTaxesCalculator externalTaxesCalculator)
        {
            this.externalTaxesCalculator = externalTaxesCalculator;
        }
        public abstract void execute();
    }
}
