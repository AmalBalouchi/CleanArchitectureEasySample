using Application.Interfaces;
using Domain.Models;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public IEnumerable<Animal> GetAllAnimals()
        {
            return _animalRepository.GetAll();
        }

        public Animal GetAnimalById(int id)
        {
            return _animalRepository.GetById(id);
        }

        public void AddAnimal(Animal animal)
        {
            _animalRepository.Add(animal);
        }

        public void UpdateAnimal(Animal animal)
        {
            _animalRepository.Update(animal);
        }

        public void DeleteAnimal(int id)
        {
            _animalRepository.Delete(id);
        }
    }
}

