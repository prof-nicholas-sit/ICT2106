//
// ICT2106 Software Design - Vending machine example using switch statements
//
// Main program.
//
// Author: Nicholas Sheppard
//
using System;

namespace ICT2106.VendingMachineSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            // print instructions
            Console.WriteLine("Commands:");
            Console.WriteLine("   insert <value> - insert coins worth <value> into the machine");
            Console.WriteLine("   select <value> - select an item worth <value>");
            Console.WriteLine("   quit - end the program");
            Console.WriteLine();

            // create a vending machine
            VendingMachine vm = new VendingMachine();

            bool done = false;
            do
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input.Length > 0)
                {

                    // convert the second token into a decimal number, if it exists
                    decimal value = 0.00M;
                    if (input.Length > 1)
                    {
                        try
                        {
                            value = Convert.ToDecimal(input[1]);
                        }
                        catch (FormatException)
                        {
                            value = 0.00M;
                        }
                    }

                    // take action according to the command
                    if (String.Compare(input[0], "insert", true) == 0)
                    {
                        if (input.Length > 1 && value > 0.00M)
                        {
                            vm.Insert(value);
                        }
                        else
                        {
                            Console.WriteLine("Insert what?");
                        }
                    }
                    else if (String.Compare(input[0], "select", true) == 0)
                    {
                        if (input.Length > 1 && value > 0.00M)
                        {
                            vm.Select(value);
                        }
                        else
                        {
                            Console.WriteLine("Select what?");
                        }
                    }
                    else if (String.Compare(input[0], "quit", true) == 0)
                    {
                        done = true;
                    }
                    else
                    {
                        Console.WriteLine("Please insert coins, select an item, or quit.");
                    }
                }
            } while (!done);
        }
    }
}
