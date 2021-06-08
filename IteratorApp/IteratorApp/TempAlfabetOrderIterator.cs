using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorApp
{
    class TempAlfabetOrderIterator : Iterator
    {
        public WordCollection _wordCollection;

        private int _position = -1;
        public TempAlfabetOrderIterator(WordCollection wordCollection)
        {
            _wordCollection = wordCollection;
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
