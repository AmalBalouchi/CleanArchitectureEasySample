using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// <summary>
    /// moving IAnimalRepository to the domain layer, we ensure that the application layer 
    /// only depends on domain abstractions. This adheres to Clean Architecture principles 
    /// by maintaining separation of concerns and ensuring that high-level modules depend 
    /// only on abstractions, not on concrete implementations.
    /// </summary>
    public interface IAnimalRepository
    {
        IEnumerable<Animal> GetAll();
        Animal GetById(int id);
        void Add(Animal animal);
        void Update(Animal animal);
        void Delete(int id);
    }
}
