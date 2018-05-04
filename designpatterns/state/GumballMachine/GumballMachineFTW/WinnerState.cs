using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachineFTW
{
    public class WinnerState : IState
    {
        private GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.ReleaseBall();
                Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");
            }

            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.SetState(_gumballMachine.NoQuarterState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public void Refill() { }

        public override string ToString() => "dispensing a gumball";
    }
}
