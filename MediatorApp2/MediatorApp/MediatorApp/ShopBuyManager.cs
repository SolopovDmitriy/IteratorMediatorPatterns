using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorApp
{
    class ShopBuyManager : IMeadiator
    {
        //private Fisher Fisher { get; set; }
        //private Cannery Cannery { get; set; }
        //private Shop Shop { get; set; }

        private Dictionary<IColleague, List<IProduct>> _implements;
        public ShopBuyManager()
        {
            _implements = new Dictionary<IColleague, List<IProduct>>();
        }

             
        


        public void Implement(IProduct product, IColleague colleague)
        {

            if (colleague is Fisher)
            {
                Fisher fisher = colleague as Fisher; // convert IColleague to Fisher
                if (!_implements.ContainsKey(fisher))
                {
                    _implements[fisher] = new List<IProduct>();
                }               
                _implements[fisher].Add(product);
                fisher.TakeMoney(10);
                // Find Canneries and send them Fish
                foreach (IColleague colleague1 in _implements.Keys)
                {
                    if (colleague1 is Cannery)
                    {
                        Cannery cannery = colleague1 as Cannery;
                        List<IProduct> fish = _implements[fisher];
                        if (fish.Count != 0)
                        {
                            cannery.TakeFish((Fish)fish[0]);
                            fish.RemoveAt(0);
                        }
                        cannery.MakeProduct();
                    }
                }
            }
            else if (colleague is Cannery)
            {

            }
            else if (colleague is Shop)
            {

            }

        }
    }
}
