//
// ICT2106 Software Design - Vending machine example using the State pattern
//
// Class representing a vending machine in the "make change" state
//
// Author: Nicholas Sheppard
//

namespace ICT2106.VendingMachineOO
{
    class MakeChangeVendingMachineState : VendingMachineState
    {
        // constructor
        public MakeChangeVendingMachineState(VendingMachine VM) : base(VM)
        {
        }

        // enter state handler
        public override void OnEntry()
        {
            // display a message and reset the amount of money in the machine
            VM.Display("Returning change of $" + VM.Amount);
            VM.Amount = 0.0M;

            // return to the idle state
            VM.EnterState(new IdleVendingMachineState(VM));
        }

        // insert money handler
        public override void Insert(decimal amountIn)
        {
            VM.Display("Please wait until your change has been returned.");
        }

        // select item handler
        public override void Select(decimal cost)
        {
            VM.Display("Please wait until your change has been returned.");
        }
    }
}
