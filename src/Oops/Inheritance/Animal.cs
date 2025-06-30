// This namespace organizes our code within the Inheritance project.
namespace Oops.Inheritance
{
    // This is the base class, also known as the parent class.
    // It demonstrates INHERITANCE.
    public class Animal
    {
        // This property is common to all animals.
        // 'protected set' means the property can be set by this class or any class that inherits from it.
        public string Name { get; protected set; }

        // This is the constructor for the Animal class.
        public Animal(string name)
        {
            // We initialize the Name property.
            Name = name;
        }

        // This is a method that is common to all animals.
        // 'virtual' means that this method can be overridden by derived classes.
        public virtual void MakeSound()
        {
            // A generic animal sound.
            Console.WriteLine("The animal makes a sound.");
        }

        // This is another common method.
        public void Eat()
        {
            // All animals eat.
            Console.WriteLine($"{Name} is eating.");
        }
    }

    // This is a derived class, also known as a child class.
    // It inherits from the Animal class.
    public class Dog : Animal
    {
        // The Dog class gets the Name property and the Eat() method from Animal.
        // The constructor for the Dog class.
        // ': base(name)' calls the constructor of the base class (Animal).
        public Dog(string name) : base(name)
        {
        }

        // This method overrides the MakeSound method from the Animal class.
        // The 'override' keyword is used here.
        public override void MakeSound()
        {
            // A dog-specific sound.
            Console.WriteLine($"{Name} says: Woof!");
        }

        // This is a method specific to the Dog class.
        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching a ball.");
        }
    }

    // This is another derived class.
    public class Cat : Animal
    {
        // The Cat class also inherits from Animal.
        // The constructor for the Cat class.
        public Cat(string name) : base(name)
        {
        }

        // This method overrides the MakeSound method from the Animal class.
        public override void MakeSound()
        {
            // A cat-specific sound.
            Console.WriteLine($"{Name} says: Meow!");
        }

        // This is a method specific to the Cat class.
        public void Purr()
        {
            Console.WriteLine($"{Name} is purring.");
        }
    }
}
