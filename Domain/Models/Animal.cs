namespace Domain.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public Animal() { }
        public Animal(string name, int age)
        {
            Name = name;
            this.age = age;

        }
    }
}
