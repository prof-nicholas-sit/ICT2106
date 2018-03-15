//
// ICT2106 Software Design - Vending machine example using the State pattern
//
// Class representing a vending machine in the "idle" state.
//
// Author: Nicholas Sheppard
//

namespace ICT2106.VendingMachineOO
{
    class IdleVendingMachineState : VendingMachineState
    {
        // constructor
        public IdleVendingMachineState(VendingMachine vmIn) : base(vmIn)
        {
        }

        // enter state handler
        public override void OnEntry()
        {
            // display the greeting
            VM.Display("Welcome to the ICT2106 vending machine!");
        }

        // insert money handler
        public override void Insert(decimal amountIn)
        {
            // increment the amount of money in the machine
            VM.Amount += amountIn;

            // change to the 'accumulate' state
            VM.EnterState(new AccumulateVendingMachineState(VM, amountIn));
        }

        // select item handler
        public override void Select(decimal cost)
        {
            // display the cost of the item
            VM.Display("The item costs $" + cost + ".");
        }
    }
}
