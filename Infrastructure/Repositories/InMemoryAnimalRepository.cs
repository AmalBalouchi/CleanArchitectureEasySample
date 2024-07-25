using Domain.Models;
using Domain.Interfaces; // Updated namespace
using System.Collections.Generic;
using System.Linq;

namespace SimpleAnimalApp.Infrastructure.Repositories
{
    public class InMemoryAnimalRepository : IAnimalRepository
    {
        /// <summary>
        // The concrete implementation (InMemoryAnimalRepository) is instantiated in the
        // console application and passed to the service, adhering to the dependency inversion principle.
        //This setup ensures that the application layer depends only on the domain layer,
        //and the infrastructure layer implements the domain abstractions.
        /// </summary>

        private static List<Animal> _animals = new List<Animal>();
        private static int _nextId = 1;

        public IEnumerable<Animal> GetAll()
        {
            return _animals;
        }

        public Animal GetById(int id)
        {
            return _animals.FirstOrDefault(a => a.Id == id);
        }

        public void Add(Animal animal)
        {
            animal.Id = _nextId++;
            _animals.Add(animal);
        }

        public void Update(Animal animal)
        {
            var existing = _animals.FirstOrDefault(a => a.Id == animal.Id);
            if (existing != null)
            {
                existing.Name = animal.Name;
                existing.age = animal.age;
            }
        }

        public void Delete(int id)
        {
            var animal = _animals.FirstOrDefault(a => a.Id == id);
            if (animal != null)
            {
                _animals.Remove(animal);
            }
        }
    }
}
