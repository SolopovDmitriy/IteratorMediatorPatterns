using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorApp
{
    class AlfabetOrderIterator : Iterator
    {
        // 4 6 1 3 9 2
        // 1 6 4 3 9 2
        // 1 2 6 3 9 6

        public WordCollection _wordCollection;

        private int _position = -1;
        
        public AlfabetOrderIterator(WordCollection wordCollection)
        {
            _wordCollection = wordCollection;
            //_wordCollection.getItems().Sort
            //    (
            //       (string x, string y) =>
            //       {
            //           if (_wordCollection.Direction)
            //           {
            //                return x.CompareTo(y);
            //           }
            //           return - x.CompareTo(y);
            //       }
            //    );
            _wordCollection.getItems().Sort
                (
                    delegate (string x, string y)
                    {
                        if (_wordCollection.Direction)
                        {
                            return x.CompareTo(y); // 
                        }
                        //return -x.CompareTo(y);
                        return y.CompareTo(x);
                    }
                );
        }
        
        public override object Current()
        {
            return _wordCollection.getItems()[_position];
        }
        
        public override bool MoveNext()
        {
            _position++;
            if (_position < _wordCollection.getItems().Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public override void Reset()
        {
            _position = -1;
        }
    }
}
