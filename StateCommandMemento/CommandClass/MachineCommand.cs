﻿using Assignment2.StateCommandMemento.MachineClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.CommandClass
{
    class MachineCommand : ICommand
    {
        public string Text { get; set; }
        public Machine Machine { get; set; }

        public MachineCommand(string inputText, Machine machine)
        {
            Text = inputText;
            Machine = machine;
        }

        public MachineCommand(Machine machine, string text)
        {
            this.Machine = machine;
            Text = text;
        }

        public void Go()
        {
            Machine.Print(Text);
        }
    }
}
