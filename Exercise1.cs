using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sitech_ProgrammingExercise
{
    public partial class  MainWindow 
    {
        private DateTime? _StartTime=null;
        // this method will be called periodically.
        // make the method return a string that contains the number of seconds
        // from the first time the method is called to the current time
        // example: 
        // 1 Second, 2 Seconds, 3 Seconds ect.
        public string Exercise1()
        {
            int totalSeconds;
            if (_StartTime ==null )
            {
                _StartTime = DateTime.Now;
            }

            totalSeconds = (int)DateTime.Now.Subtract(_StartTime.Value).TotalSeconds;
            if (totalSeconds < 2)
                return totalSeconds + " Second";
            else
                return totalSeconds + " Seconds";
        }
    }
}
