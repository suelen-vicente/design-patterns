namespace design_patterns.Chain_of_Responsibility
{
    public class SignOutItem : Handler
    {
        public override void perform(Operation operation)
        {
            if (operation == Operation.signOut)
            {
                //performs sign out processes
            }
            else if (successor != null)
            {
                successor.perform(operation);
            }
        }
    }
}
