using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumarable
{
    class Program
    {
        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach (Dog dog in shelter)
            {
                if(!dog.isNaugtyDog) { dog.GiveTreat(2); }
                else { dog.GiveTreat(1); };
            }
        }
    }


    class Dog
    {
        public string name { get; set; }
        public bool isNaugtyDog { get; set; }

        public Dog(string aName, bool aIsNaughtyDog)
        {
            this.name = aName;
            this.isNaugtyDog = aIsNaughtyDog;
        }

        public void GiveTreat(int aNumberOfTreats)
        {
            Console.WriteLine("Dog {0} said wuff {1} times.", name, aNumberOfTreats);
        }
    }
    class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> dogs;

        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Oreo", false),
                new Dog("Pixel", false),
            };

        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
