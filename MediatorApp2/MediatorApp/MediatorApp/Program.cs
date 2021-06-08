using System;
    /*
    Посредник - вынести связи между обьектами в отдельный класс - посредник.
    */
namespace MediatorApp
{
    class Program
    {
        static void TestCast()
        {           
            //int a = 18;
            //int b = 5;
            //double x = a / (double)b;
            //Console.WriteLine("x = " + x);

            IMeadiator mediator = new ShopBuyManager();
            (new Fisher { Meadiator = mediator }).ToHookFish();



            Fisher fisher = new Fisher { Meadiator = mediator };
            fisher.ToHookFish();

            IColleague fisher2 = new Fisher { Meadiator = mediator };
            // fisher2.ToHookFish(); // IColleague can not ToHookFish

            //// Version1
            //Fisher fisher2_;
            //if (fisher2 is Fisher) // check if fisher2 is Fisher => true or false
            //{
            //    fisher2_ = (Fisher)fisher2; // cast = convert IColleague to Fisher
            //    fisher2_.ToHookFish();
            //}
            //else
            //{
            //    fisher2_ = null;
            //}

            // version2
            Fisher fisher2_ = fisher2 as Fisher; // try to cast = convert IColleague to Fisher. If unable then null
            fisher2_.ToHookFish();


           

        }



        static void Main(string[] args)
        {
            SimpleManager manager = new SimpleManager(); // create Manager
            Fisher fisher1 = new Fisher { Meadiator = manager}; // create fisher
            Cannery cannery1 = new Cannery { Meadiator = manager }; // create cannery 
            Shop shop1 = new Shop { Meadiator = manager }; // create shop 

            manager.Fisher = fisher1; // connect manager with fisher
            manager.Cannery = cannery1;// connect manager with cannery
            manager.Shop = shop1; // // connect manager with shop


            fisher1.ToHookFish(); // fisher поймал fish
            



        }
    }
}
