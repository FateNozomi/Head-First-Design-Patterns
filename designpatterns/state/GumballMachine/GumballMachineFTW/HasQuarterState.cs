using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachineFTW
{
    public class HasQuarterState : IState
    {
        private GumballMachine _gumballMachine;
        private Random randomWinner = new Random(DateTime.Now.Millisecond);

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't instert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = randomWinner.Next(10);
            if ((winner == 0) && (_gumballMachine.Count > 1))
            {
                _gumballMachine.SetState(_gumballMachine.WinnerState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.SoldState);
            }
        }

        public void Refill() { }

        public override string ToString() => "waiting for turn of crank";
    }
}
