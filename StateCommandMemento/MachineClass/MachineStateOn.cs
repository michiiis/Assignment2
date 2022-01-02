using System;

namespace Assignment2.StateCommandMemento.MachineClass
{
    internal class MachineStateOn : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Machine ON");
        }
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}