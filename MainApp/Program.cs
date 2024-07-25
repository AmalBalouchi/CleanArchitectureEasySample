using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Repositories;
using SimpleAnimalApp.Infrastructure.Repositories;
using System;

namespace MainApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up the application
            IAnimalRepository animalRepository = new InMemoryAnimalRepository();
            IAnimalService animalService = new AnimalService(animalRepository);

            // Add some animals
            animalService.AddAnimal(new Animal { Name = "Lion", age = 2 });
            animalService.AddAnimal(new Animal { Name = "Elephant", age = 5 });

            // Display all animals
            Console.WriteLine("All Animals:");
            foreach (var animal in animalService.GetAllAnimals())
            {
                Console.WriteLine($"Id: {animal.Id}, Name: {animal.Name}, age: {animal.age}");
            }

            // Update an animal
            var animalToUpdate = animalService.GetAnimalById(1);
            if (animalToUpdate != null)
            {
                animalToUpdate.Name = "African Lion";
                animalService.UpdateAnimal(animalToUpdate);
            }

            // Display updated animal
            var updatedAnimal = animalService.GetAnimalById(1);
            if (updatedAnimal != null)
            {
                Console.WriteLine($"Updated Animal: Id: {updatedAnimal.Id}, Name: {updatedAnimal.Name}, age: {updatedAnimal.age}");
            }

            // Delete an animal
            animalService.DeleteAnimal(2);

            // Display remaining animals
            Console.WriteLine("Remaining Animals:");
            foreach (var animal in animalService.GetAllAnimals())
            {
                Console.WriteLine($"Id: {animal.Id}, Name: {animal.Name}, age: {animal.age}");
            }
        }
    }
}
