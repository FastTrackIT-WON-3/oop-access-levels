using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopAccessLevels.Library;

namespace OopAccessLevels.Consumer
{
    public class ConvertibleLaptop : Laptop
    {
        public void DetachScreen()
        {
            // can't be accessed because we're not in the same assembly
            // PlugIn();
            processorFrequency = 1000;
            Console.WriteLine("Working with the screen as a tablet");
        }

        public void AttachScreen()
        {
            processorFrequency = 1700;
            Console.WriteLine("Working again like a laptop");
        }
    }
}
