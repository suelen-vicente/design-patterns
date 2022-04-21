namespace design_patterns.Flyweight
{
    public class FlyweightExample
    {
        public void example()
        {
            //This will return a new instance or the same instance for calling Payment API.
            IAPIRequest api = APIFactory.getApi("Payment");
        }
    }
}
