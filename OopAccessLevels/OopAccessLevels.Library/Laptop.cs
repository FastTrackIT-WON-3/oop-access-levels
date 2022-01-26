using System;

namespace OopAccessLevels.Library
{
    public class Laptop
    {
        private string processorName = "Intel i7";
        protected int processorFrequency = 1700;

        public void PrintSpecifications()
        {
            Console.WriteLine("Specs:");
            Console.WriteLine($"   - Processor: {processorName}");
            Console.WriteLine($"   - Processor frequency: {processorFrequency}");
        }

        internal void PlugIn()
        {
            Console.WriteLine("Plugging in the laptop");
        }
    }
}
