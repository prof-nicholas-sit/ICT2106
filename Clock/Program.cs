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
            TextAlarm alarm1 = new TextAlarm("Wake up!");
            BeepAlarm alarm2 = new BeepAlarm();

            // attach the alarms to the clock
            clock.Attach(alarm1);
            clock.Attach(alarm2);

            // run the clock for thirty seconds
            clock.Run(30);
        }
    }
}
