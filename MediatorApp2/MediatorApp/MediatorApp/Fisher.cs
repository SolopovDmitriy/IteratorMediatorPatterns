using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorApp
{
    class Fisher : IColleague
    {
        private IMeadiator _meadiator;
        public double Money { get; private set; }
        public IMeadiator Meadiator
        {
            get { return _meadiator; }
            set { _meadiator = value; }
        }

        public void ToHookFish()
        {
            Console.WriteLine("Fisher give fish to manager");
            _meadiator.Implement(new Fish(), this);  // Implement(IProduct product, IColleague colleague)
        }

        public void TakeMoney(double money)
        {
            Money += money;
        }

    }
}
