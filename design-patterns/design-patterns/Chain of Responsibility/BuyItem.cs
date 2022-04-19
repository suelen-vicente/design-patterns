namespace design_patterns.Chain_of_Responsibility
{
    public class BuyItem : Handler
    {
        public override void perform(Operation operation)
        {
            if (operation == Operation.buy)
            {
                //performs buy processes
            }
            else if(successor != null) {
                successor.perform(operation);
            }
        }
    }
}
