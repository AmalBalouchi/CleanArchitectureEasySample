using Domain.Models;

namespace Application.Interfaces
{

    public interface IAnimalService
    {
        IEnumerable<Animal> GetAllAnimals();
        Animal GetAnimalById(int id);
        void AddAnimal(Animal animal);
        void UpdateAnimal(Animal animal);
        void DeleteAnimal(int id);
    }
}
