namespace design_patterns.Chain_of_Responsibility
{
    public enum Operation
    {
        buy,
        signOut
    }

    public class Item
    {
        public string name { get; set; }
        public Operation operation { get; set; }

        public Item(string name, Operation operation)
        {
            this.name = name;
            this.operation = operation;
        }
    }
}
