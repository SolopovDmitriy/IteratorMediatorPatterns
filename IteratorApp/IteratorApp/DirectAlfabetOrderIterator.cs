using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorApp
{
    class DirectAlfabetOrderIterator : Iterator
    {
        // 4 6 1 3 9 2
        // 1 6 4 3 9 2
        // 1 2 6 3 9 6


        private List<string> _colectionCopy;
        private int _position = -1;
        
        public DirectAlfabetOrderIterator(WordCollection wordCollection)
        {
            _colectionCopy = new List<string>(wordCollection.getItems());
            _colectionCopy.Sort((x, y) => x.CompareTo(y));
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
