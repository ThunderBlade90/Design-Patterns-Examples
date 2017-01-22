using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    static class AnimalFactory
    {
        public static IAnimal CreateAnimalObject(Animals animalType)
        {
            IAnimal animal = null;
            switch (animalType)
            {
                case Animals.Cat:
                    animal = new Cat();
                    break;
                case Animals.Dog:
                    animal = new Dog();
                    break;
                case Animals.Wolf:
                    animal = new Wolf();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("animalType", "Nieznany rodzaj zwierzaka");
            }
            return animal;
        }
    }
}
