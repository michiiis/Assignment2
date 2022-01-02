using Assignment2.StateCommandMemento.MachineClass;
using Assignment2.StateCommandMemento.MementoClass;
using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */
        public Memento Memento { get; set; }
        public void Run()
        {
            Console.WriteLine("Press ENTER to turn on / turn off Machine");
            Console.WriteLine("Press P to enter in your text");
            Console.WriteLine("Press S to Save Machine as is now");
            Console.WriteLine("Press L to Load Machine Memento");
            Machine machine = new();

            while (true)
            {
                var userInput = Console.ReadKey(true).Key;
                switch (userInput)
                {
                    case ConsoleKey.Enter:
                        machine.PowerSwitch();
                        break;
                    case ConsoleKey.P:
                        Console.WriteLine("Enter the text you want to Print: ");
                        string userText = Console.ReadLine();
                        machine.Print(userText);
                        break;
                    case ConsoleKey.S:
                        Memento = machine.CreateMemento();
                        Console.WriteLine("Saved");
                        break;
                    case ConsoleKey.L:
                        Memento.LoadMemento();
                        Console.WriteLine("Loaded");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}