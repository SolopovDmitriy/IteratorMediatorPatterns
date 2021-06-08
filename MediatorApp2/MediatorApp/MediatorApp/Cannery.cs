using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorApp
{
    class Cannery : IColleague
    {
        private IMeadiator _meadiator;
        private List<Fish> fishList = new List<Fish>();
        public IMeadiator Meadiator
        {
            get { return _meadiator; }
            set { _meadiator = value; }
        }
        public void MakeProduct()
        {
            Console.WriteLine("Cannery try to make Canned Food");
            if(fishList.Count == 0)
            {
                Console.WriteLine("I does not have fish");
            }
            else
            {
                Console.WriteLine("cannery give Canned food to manager");
                fishList.RemoveAt(0);
                _meadiator.Implement(new CannedFood(), this);
            }
            
        }
        public void TakeFish(Fish fish)
        {
            fishList.Add(fish);
        }

    }
}
