using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMenu
{
    public class DinerMenuIterator : IEnumerator<MenuItem>
    {
        private MenuItem[] _items;
        private int _curIndex = -1;
        private MenuItem _curMenuItem = default(MenuItem);

        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }

        public MenuItem Current => _items[_curIndex];

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            // Avoids going beyond the end of the collection.
            // Check if next item is null because the MenuItem array was
            // allocated with a max size.
            if (++_curIndex >= _items.Length || _items[_curIndex] == null)
            {
                return false;
            }
            else
            {
                // Set current box to next item in collection.
                _curMenuItem = _items[_curIndex];
                return true;
            }
        }

        public void Reset()
        {
            _curIndex = -1;
        }
    }
}
