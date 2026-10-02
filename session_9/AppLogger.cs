using System;
using System.Collections.Generic;
using System.Text;

namespace Session09_Assignment
{
    internal class AppLogger
    {
        private static AppLogger instance=null;
        private AppLogger() { 
        
        }

        public static AppLogger GetLogger()
        {
            if(instance is null)
                instance = new AppLogger();
            return instance;
        }
    }
}
