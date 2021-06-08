using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorApp
{
    class Shop : IColleague
    {
        private IMeadiator _meadiator;
        public IMeadiator Meadiator
        {
            get { return _meadiator; }
            set { _meadiator = value; }
        }
        public void IssueDelivery(IProduct product)
        {
            Console.WriteLine("shop receive canned food and give money to manager");
            _meadiator.Implement(new Money { Value = 20 }, this);
        }
        public void SellProduct()
        {
            Console.WriteLine("shop Sell Product and give money to manager");
        }
    }
}
