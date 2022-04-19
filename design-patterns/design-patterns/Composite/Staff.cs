using System;
namespace design_patterns.Composite
{
    public class Staff : User
    {
        private string fullName;
        private long id;

        public Staff(long id, string fullName)
        {
            this.id = id;
            this.fullName = fullName;
        }

        public void display()
        {
            Console.WriteLine(id + " - " + fullName);
        }
    }
}
