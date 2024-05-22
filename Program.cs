using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string> { "Dog", "Cat", "Snake", "Rabbit", "Bird" };

            // Filter animals at index 3 (which is "Rabbit")
            var animalQuery =
                from animal in animals
                where animals.IndexOf(animal) == 1
                select animal;

            foreach (var animal in animalQuery)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
