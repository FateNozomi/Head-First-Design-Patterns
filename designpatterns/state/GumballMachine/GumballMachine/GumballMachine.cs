using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachine
{
    public class GumballMachine
    {
        public GumballMachine(int numberOfGumballs)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);

            Count = numberOfGumballs;

            if (numberOfGumballs > 0)
            {
                State = NoQuarterState;
            }
            else
            {
                State = SoldOutState;
            }
        }

        public IState SoldOutState { get; private set; }

        public IState NoQuarterState { get; private set; }

        public IState HasQuarterState { get; private set; }

        public IState SoldState { get; private set; }

        public IState State { get; private set; }

        public int Count { get; private set; }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count > 0)
            {
                Count--;
            }
        }

        public void SetState(IState state)
        {
            State = state;
        }

        public void Refill(int count)
        {
            Count += count;
            Console.WriteLine(
                "The gumball machine was just refilled;" +
                $" it's new count is: {Count}");
            State.Refill();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nMighty Gumball, Inc.");
            sb.Append("\nC#-enabled Standing gumball Model #2020");
            sb.Append($"\nInventory: {Count} gumball");
            if (Count > 1)
            {
                sb.Append("s");
            }

            sb.Append("\n");
            sb.Append($"Machine is {State}\n");

            return sb.ToString();
        }
    }
}
