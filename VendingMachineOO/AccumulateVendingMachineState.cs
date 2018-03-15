//
// ICT2106 Software Design - Vending machine example using the State pattern
//
// Class representing a vending machine in the "accumulate" state
//
// Author: Nicholas Sheppard
//

namespace ICT2106.VendingMachineOO
{
    class AccumulateVendingMachineState : VendingMachineState
    {

        // constructor
        public AccumulateVendingMachineState(VendingMachine VMIn, decimal amountIn) : base (VMIn)
        {
        }

        // enter state handler
        public override void OnEntry()
        {
            VM.Display("$" + VM.Amount);
        }

        // insert money handler
        public override void Insert(decimal amountIn)
        {
            // increase the amount of money in the machine and display the new total
            VM.Amount += amountIn;
            VM.Display("$" + VM.Amount);
        }

        // select item handler
        public override void Select(decimal cost)
        {
            if (VM.Amount >= cost)
            {
                // change to the 'vend' state
                VM.EnterState(new VendVendingMachineState(VM, cost));
            }
            else
            {
                VM.Display("Please insert more money.");
            }
        }
    }
}
