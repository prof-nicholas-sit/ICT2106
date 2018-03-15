//
// ICT2106 Software Design - Vending machine example using the State pattern
//
// A class representing a vending machine.
//
// Author: Nicholas Sheppard
//
using System;

namespace ICT2106.VendingMachineOO
{
    class VendingMachine
    {
        // the current state of the machine
        private VendingMachineState CurrentState { get; set; }

        // the amount of money inserted by the user
        public decimal Amount { get; set; }

        // constructor
        public VendingMachine()
        {
            // start in the idle state with no money inserted
            CurrentState = new IdleVendingMachineState(this);
        }

        // display a message
        public void Display(string message)
        {
            Console.WriteLine(">> " + message);
        }

        // insert money handler
        public void Insert(decimal amountIn)
        {
            CurrentState.Insert(amountIn);
        }

        // select item handler
        public void Select(decimal cost)
        {
            CurrentState.Select(cost);
        }

        // set the state of the machine
        public void EnterState(VendingMachineState newState)
        {
            CurrentState = newState;
            newState.OnEntry();
        }

    }
}
