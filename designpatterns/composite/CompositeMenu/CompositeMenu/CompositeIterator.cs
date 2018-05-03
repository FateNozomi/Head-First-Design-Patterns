using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMenu
{
    public class CompositeIterator : IEnumerator<MenuComponent>
    {
        Stack<IEnumerator<MenuComponent>> stack = new Stack<IEnumerator<MenuComponent>>();
        MenuComponent _curComponent = default(MenuComponent);

        public CompositeIterator(IEnumerator<MenuComponent> enumerator)
        {
            stack.Push(enumerator);
        }

        public MenuComponent Current
        {
            get
            {
                return _curComponent;
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            if (stack.Any())
            {
                IEnumerator<MenuComponent> enumerator = stack.Peek();
                if (enumerator.MoveNext())
                {
                    _curComponent = enumerator.Current;
                    stack.Push(_curComponent.GetEnumerator());
                    return true;
                }
                else
                {
                    stack.Pop();
                    return MoveNext();
                }
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            throw new InvalidOperationException();
        }
    }
}
