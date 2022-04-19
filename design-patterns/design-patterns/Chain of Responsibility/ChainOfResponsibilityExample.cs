using System.Collections.Generic;

namespace design_patterns.Chain_of_Responsibility
{
    
    public class ChainOfResponsibilityExample
    {
        public void example()
        {
            Handler buyItem = new BuyItem();
            Handler signOutItem = new SignOutItem();

            buyItem.setSuccessor(signOutItem);

            var item1 = new Item("test1", Operation.buy);
            var item2 = new Item("test2", Operation.signOut);

            List<Item> items = new List<Item>();
            items.Add(item1);
            items.Add(item2);

            //start the chain and only stops when find the right object to treat the case
            foreach (var item in items)
            {
                buyItem.perform(item.operation);
            }
            
        }
    }
}
