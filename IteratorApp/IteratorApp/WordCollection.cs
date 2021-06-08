using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorApp
{
    class WordCollection : IEnumerable
    {
        private List<string> _colection;
        private bool _direction = true; // true from A to Z
        public bool Direction
        {
            get { return _direction; }
            set
            {
                _direction = value;
            }
        }
        public void Reverse()
        {
            _direction = !_direction;
        }

        public List<string> getItems()
        {
            return _colection;
        }

        public WordCollection()
        {
            _colection = new List<string>();
        }
        public void AddItem(string word)
        {
            _colection.Add(word);
        }
        public IEnumerator GetEnumerator()
        {
            return new AlfabetOrderIterator(this);
        }



        // from https://refactoring.guru/ru/design-patterns/iterator
        public Iterator CreateDirectAlfabetOrderIterator()
        {
            return new DirectAlfabetOrderIterator(this);
        }

        public Iterator CreateInversedAlfabetOrderIterator()
        {
            return new InversedAlfabetOrderIterator(this);
        }

        public IEnumerator CreateStandartIterator()
        {
            return _colection.GetEnumerator();
        }
    }
}
