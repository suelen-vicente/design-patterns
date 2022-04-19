using System.Collections.Generic;
namespace design_patterns.Composite
{
    public class UserHierarchy : User
    {
        private List<User> users = new List<User>();

        public void display()
        {
            foreach (var user in users)
                user.display();
        }

        public void add(User user)
        {
            users.Add(user);
        }

        public void remove(User user)
        {
            users.Remove(user);
        }
    }
}
