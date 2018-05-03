using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMenu
{
    public class Menu : MenuComponent
    {
        private string _name;
        private string _description;
        private List<MenuComponent> _menuComponents = new List<MenuComponent>();
        private IEnumerator<MenuComponent> _enumerator = null;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override string GetName() => _name;

        public override string GetDescription() => _description;

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return _menuComponents[i];
        }

        public override void Print()
        {
            Console.Write($"\n{_name}");
            Console.WriteLine($", {_description}");
            Console.WriteLine("--------------------");

            IEnumerator<MenuComponent> enumerator = _menuComponents.GetEnumerator();
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = enumerator.Current;
                menuComponent.Print();
            }
        }

        public override IEnumerator<MenuComponent> GetEnumerator()
        {
            if (_enumerator == null)
            {
                _enumerator = new CompositeIterator(_menuComponents.GetEnumerator());
            }

            return _enumerator;
        }
    }
}
