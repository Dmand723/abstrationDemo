namespace abractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();

            dog.MakeSound();
            cat.MakeSound();
        }
    }
    public interface IAnimal
    {
        string? Name { get; set; }

        void MakeSound();
    }
    public abstract class Animal : IAnimal
    {
        public string? Name { get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine("Sound!");
        }
    
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

   
    public class Cat : Animal 
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}