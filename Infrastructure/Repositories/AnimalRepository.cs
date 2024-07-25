using Domain.Models;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
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
