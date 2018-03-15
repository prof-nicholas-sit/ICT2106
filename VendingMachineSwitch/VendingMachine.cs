//
// ICT2106 Software Design- Vending machine example using switch statements
//
// A class representing a vending machine.
//
// Author: Nicholas Sheppard
//
using System;

namespace ICT2106.VendingMachineSwitch
{
    class VendingMachine
    {
        // the possible states of the machine
        public enum VendingMachineState
        {
            IDLE = 0, ACCUMULATE = 1, VEND = 2, MAKE_CHANGE = 3
        }

        // the current state of the machine
        public VendingMachineState CurrentState { get; set; }

        // the amount of money in the machine
        private decimal Amount;

        // constructor
        public VendingMachine()
        {
            // start in the idle state with no money inserted
            ChangeState(VendingMachineState.IDLE);
            Amount = 0;
        }

        // change the state of the machine
        private void ChangeState(VendingMachineState stateIn)
        {
            // if any of the states had exit actions, we'd deal with them here...

            // change the state
            CurrentState = stateIn;

            // perform the entry action of each state
            switch (CurrentState)
            {
                case VendingMachineState.IDLE:
                    // display a greeting
                    Display("Welcome to the ICT2106 vending machine!");
                    break;

                case VendingMachineState.ACCUMULATE:
                    // display the amount of money inserted
                    Display("$" + Amount);
                    break;

                case VendingMachineState.VEND:
                    // move to the next state right away
                    if (Amount > 0.0M)
                    {
                        // need to give change
                        ChangeState(VendingMachineState.MAKE_CHANGE);
                    }
                    else
                    {
                        // no change required; go back to idle
                        ChangeState(VendingMachineState.IDLE);
                    }
                    break;

                case VendingMachineState.MAKE_CHANGE:
                    // display a message, reset the amount of money in the machine, then return to idle
                    Display("Returning change of $" + Amount);
                    Amount = 0.0M;
                    ChangeState(VendingMachineState.IDLE);
                    break;
            }
        }

        // display a message
        public void Display(string message)
        {
            Console.WriteLine(">> " + message);
        }

        // insert money handler
        public void Insert(decimal amountIn)
        {
            switch (CurrentState)
            {

                case VendingMachineState.IDLE:
                    // add the amount and move the 'accumulate' state
                    Amount = amountIn;
                    ChangeState(VendingMachineState.ACCUMULATE);
                    break;

                case VendingMachineState.ACCUMULATE:
                    // add the amount and stay  in 'accumulate' state
                    Amount += amountIn;
                    Display("$" + Amount);
                    break;

                case VendingMachineState.VEND:
                    // not allowed
                    Display("Please wait until the current item has been dispensed.");
                    break;

                case VendingMachineState.MAKE_CHANGE:
                    // not allowed
                    Display("Please wait until your change has been returned.");
                    break;

            }
        }

        // select item handler
        public void Select(decimal cost)
        {
            switch (CurrentState)
            {
                case VendingMachineState.IDLE:
                    // display the cost of the item and stay in the 'idle' state
                    Console.WriteLine("The item costs $" + cost + ".");
                    break;

                case VendingMachineState.ACCUMULATE:
                    if (Amount >= cost)
                    {
                        // deduct the item cost and change to the 'vend' state
						Display("Vending an item worth $" + cost);
                        Amount -= cost;
                        ChangeState(VendingMachineState.VEND);
                    }
                    else
                    {
                        Display("Please insert more money.");
                    }
                    break;

                case VendingMachineState.VEND:
                    // not allowed
                    Display("Please wait until the current item has been dispensed.");
                    break;

                case VendingMachineState.MAKE_CHANGE:
                    // not allowed
                    Display("Please wait until your change has been returned.");
                    break;

            }
        }

    }
}
