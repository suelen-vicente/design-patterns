namespace design_patterns.Chain_of_Responsibility
{
    public abstract class Handler
    {
        protected Handler successor;

        public void setSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void perform(Operation operation);
    }
}
