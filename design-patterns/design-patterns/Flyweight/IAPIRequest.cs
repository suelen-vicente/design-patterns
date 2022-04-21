namespace design_patterns.Flyweight
{
    public interface IAPIRequest
    {
        string apiUrl { get; set; }

        void callAPI();
    }
}
