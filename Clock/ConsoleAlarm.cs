//
// ICT2106 Software Design - Clock exercise
//
// A class that prints a message to the screen every time it receives a notification.
//

namespace ICT2106.Clock
{
    class ConsoleAlarm
    {
        // the message to be printed
        private string message;

        // constructor
        public ConsoleAlarm(string messageIn)
        {
            // save the message for later
            message = messageIn;
        }
    }
}
