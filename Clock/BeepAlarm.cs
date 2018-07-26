//
// ICT2106 Software Design - Clock exercise
//
// A class that beeps every time it receives a notification.
//

using System;

namespace ICT2106.Clock
{
    class BeepAlarm
    {

        // constructor
        public BeepAlarm()
        {
        }
		
		// to be invoked when the alarm is triggered
		public void Update()
		{
			Console.Beep();
		}
    }
}
