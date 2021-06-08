using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorApp
{
    class SimpleManager : IMeadiator
    {
        public Fisher Fisher { get; set; }
        public Cannery Cannery { get; set; }
        public Shop Shop { get; set; }
        public Money Money { get; set; } = new Money { Value=0};


        public SimpleManager()
        {
            
        }


        public void Implement(IProduct product, IColleague colleague)
        {
            if (colleague is Fisher)
            {
                Fisher fisher = colleague as Fisher; // convert IColleague to Fisher  
                Money.Value -= 10;
                fisher.TakeMoney(10);                
                Cannery.TakeFish((Fish)product); // Send Fish to Cannery 
                Cannery.MakeProduct();                 
            }
            else if (colleague is Cannery)
            {
                Shop.IssueDelivery(product);
                Shop.SellProduct();
            }
            else if (colleague is Shop)
            {
                Money moneyFromShop = (Money)product;
                Money.Value += moneyFromShop.Value;
                Console.WriteLine("manager receive money from shop");
            }


        }
    }
}
