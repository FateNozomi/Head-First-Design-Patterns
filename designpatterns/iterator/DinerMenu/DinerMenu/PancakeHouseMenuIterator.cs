using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMenu
{
    public class PancakeHouseMenuIterator : IEnumerator<MenuItem>
    {
        private List<MenuItem> _items;
        private int _curIndex = -1;
        private MenuItem _curMenuItem = default(MenuItem);

        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            _items = items;
        }

        public MenuItem Current => _curMenuItem;

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            if (++_curIndex >= _items.Count)
            {
                return false;
            }
            else
            {
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
