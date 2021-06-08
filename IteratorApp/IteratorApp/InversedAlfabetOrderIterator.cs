using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorApp
{
    class InversedAlfabetOrderIterator : Iterator
    {
        private List<string> _colectionCopy;
        private int _position = -1;
        
        public InversedAlfabetOrderIterator(WordCollection wordCollection)
        {
             _colectionCopy = new List<string>(wordCollection.getItems());
            // _colectionCopy = wordCollection.getItems().ToList();
            // _colectionCopy = wordCollection.getItems(); -- this is not a copy
            _colectionCopy.Sort((x, y)  => y.CompareTo(x));
        }
        
        public override object Current()
        {
            return _colectionCopy[_position];
        }
        
        public override bool MoveNext()
        {
            _position++;
            if (_position < _colectionCopy.Count)
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
