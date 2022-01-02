using Assignment2.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory2
{
    public class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på ett sträng argument
        
        public void Run()
        {

            var cat = Factory2.GetFactory("Cat");
            var cat1 = cat.CreateAnimal("Kiwi");
            var dog = Factory2.GetFactory("Dog");
            var dog1 = dog.CreateAnimal("Lexie");
            Console.WriteLine(cat1.Name + " " + dog1.Name);
        }
    }
}
