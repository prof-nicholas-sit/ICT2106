//
// ICT2106 Software Design - Vending machine example using the State pattern
//
// Abstract base class for all vending machine states.
//
// Author: Nicholas Sheppard
//


namespace ICT2106.VendingMachineOO
{
    abstract class VendingMachineState
    {
        // the vending machine to which this state object refers
        protected VendingMachine VM;

        // constructor
        protected VendingMachineState(VendingMachine VMIn)
        {
            // save a reference to the vending maching for later
            VM = VMIn;
        }

        // perform state entry actions
        public abstract void OnEntry();

        // insert a note or coin into the machine
        public abstract void Insert(decimal amountIn);

        // select an item (we'll just supply its cost directly, for simplicity)
        public abstract void Select(decimal cost);
    }
}
