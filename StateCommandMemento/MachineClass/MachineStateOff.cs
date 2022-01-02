using System;

namespace Assignment2.StateCommandMemento.MachineClass
{
    internal class MachineStateOff : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Machine OFF");
        }
        public void Print(string text)
        {
            Console.WriteLine("Can't print when machine is OFF");
        }
    }
}