using System;
using System.Collections;
using System.Text;

namespace IteratorApp
{
    class Program
    {

        static void TestStrings()
        {
            //string s = " ";

            //for (int i = 0; i < 10000; i++)
            //{
            //    s += "Hello world ";
            //}
            ////Console.WriteLine(s);
            //Console.WriteLine("End");
            //string s2 = "hello";

            //string s3 = "hello";
            //s3 += " world";

            //Console.WriteLine(Object.ReferenceEquals(s2, s3));

            StringBuilder sb = new StringBuilder("", 12000);
            for (int i = 0; i < 1000; i++)
            {
                sb.Append("Hello world "); 
            }
            Console.WriteLine(sb.ToString());

        }

        static void TestCompareTo()
        {
            string s1 = "Hello";
            string s2 = "Ok";
            string s3 = "Ok";
            string s4 = "Albert";

            // Console.WriteLine(s1.CompareTo(s2)); // -1  if s1 before s2 
            // abcdefghijklmnoprstuwvxyz
            // h < o

            // Console.WriteLine(s2.CompareTo(s3)); // 0 if s2 equal s3

            Console.WriteLine(s1.CompareTo(s4)); // 1  if s1 after s4
        }

        static void TestThreeIteratorsInWhile()
        {

            // отдельные итераторы могли обходить одну и ту же коллекцию независимо. 
            WordCollection wordCollection = new WordCollection();
            wordCollection.AddItem("Олег");
            wordCollection.AddItem("Сергей");
            wordCollection.AddItem("Мария");
            wordCollection.AddItem("Лариса");
            wordCollection.AddItem("Маклауд");

            IEnumerator inversedIterator = wordCollection.CreateInversedAlfabetOrderIterator();
            IEnumerator directIterator = wordCollection.CreateDirectAlfabetOrderIterator();
            IEnumerator standartIterator = wordCollection.CreateStandartIterator();

            bool hasNext = inversedIterator.MoveNext();
            directIterator.MoveNext();
            standartIterator.MoveNext();
            while (hasNext)
            {
                Console.WriteLine(inversedIterator.Current + "\t" + 
                                  directIterator.Current + "\t" + 
                                  standartIterator.Current);
                hasNext = inversedIterator.MoveNext();
                directIterator.MoveNext();
                standartIterator.MoveNext();
            }
        }

        static void TestOneIteratorInWhile()
        {
            WordCollection wordCollection = new WordCollection();
            wordCollection.AddItem("Олег");
            wordCollection.AddItem("Сергей");
            wordCollection.AddItem("Мария");
            wordCollection.AddItem("Лариса");
            wordCollection.AddItem("Маклауд");

            IEnumerator iterator = wordCollection.GetEnumerator();

            // version1
            //while (iterator.MoveNext())
            //{               
            //    Console.WriteLine(iterator.Current);
            //}

            // version2
            bool hasNext = iterator.MoveNext();
            while (hasNext)
            {
                Console.WriteLine(iterator.Current);
                hasNext = iterator.MoveNext();
            }

        }
               
        static void TestOneIteratorInForeach()
        {
            WordCollection wordCollection = new WordCollection();
            wordCollection.AddItem("Олег");
            wordCollection.AddItem("Сергей");
            wordCollection.AddItem("Мария");
            wordCollection.AddItem("Лариса");
            wordCollection.AddItem("Маклауд");

            foreach (var item in wordCollection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("After reverse:");
            wordCollection.Reverse();

            foreach (var item in wordCollection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("After second reverse:");
            wordCollection.Reverse();

            foreach (var item in wordCollection)
            {
                Console.WriteLine(item);
            }
        }


        /*
                Iterator - позволяет, дает возможность последовательно обходить элементы составных обьектов. 
            */
        static void Main(string[] args)
        {
            // TestCompareTo();

            //TestOneIteratorInWhile();

             TestThreeIteratorsInWhile();

           //  TestStrings();



        }
    }
}
