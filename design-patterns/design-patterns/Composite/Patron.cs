using System;
namespace design_patterns.Composite
{
    public class Patron : User
    {
        private string fullName;
        private long id;

        public Patron(long id, string fullName)
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
