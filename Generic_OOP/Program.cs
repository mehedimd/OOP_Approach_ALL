using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_OOP
{
    public enum AnimalType
    {
        Harvivore,
        Carnivore,
        Omnivore
    }
    public enum Gender
    {
        Female, Male
    }
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Sex { get; set; }
        public AnimalType Type { get; set; }
    }
    public interface IGenericBehavior<T>
    {
        string GetGenericBehavior(T obj);
    }
    public interface ITypeSpecificBehavior<T>
    {
        string GetTypeSpecificBehavior<T>(T data) where T : Animal;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal { Name = "Cow", Age = 3, Type = AnimalType.Harvivore, Sex = Gender.Female };
            GenericAnimal<Animal> animal = new GenericAnimal<Animal>();
            Console.WriteLine(animal.GetGenericBehavior(cow));
            Animal bear = new Animal { Name = "Grizzly", Age = 4, Type = AnimalType.Omnivore, Sex = Gender.Male };
            TypeSpecificAnimal<Animal> obj2 = new TypeSpecificAnimal<Animal>();
            Console.WriteLine(obj2.GetTypeSpecificBehavior(bear));
            Console.ReadKey();

        }
    }
}
