//
// ICT2106 Software Design - Clock exercise
//
// Main program.
//

namespace ICT2106.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a clock
            Clock clock = new Clock();

            // create some alarms
            ConsoleAlarm alarm1 = new ConsoleAlarm("Wake up!");
            ConsoleAlarm alarm2 = new ConsoleAlarm("Dinner's ready!");

            // attach the alarms to the clock
            clock.Attach(alarm1);
            clock.Attach(alarm2);

            // run the clock for thirty seconds
            clock.Run(30);
        }
    }
}
