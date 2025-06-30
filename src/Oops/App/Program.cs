// We need to import the namespaces from our new projects
// to access the classes defined within them.
using Oops.Encapsulation;
using Oops.Abstraction;
using Oops.Inheritance;
using Oops.Polymorphism;

// This is the main entry point of our application.
Console.WriteLine("--- Encapsulation Example: BankAccount ---");

// We create a new instance of the BankAccount class.
// We provide an initial balance of 1000.
var account = new BankAccount(1000m); // The 'm' suffix indicates a decimal literal.

// We get the initial balance using the public GetBalance() method.
// We cannot access the 'balance' field directly because it is private.
Console.WriteLine($"Initial balance is: {account.GetBalance():C}"); // The ':C' formats the output as currency.

// We deposit 500 into the account.
account.Deposit(500m);
// We check the balance again.
Console.WriteLine($"Balance after deposit is: {account.GetBalance():C}");

// We withdraw 200 from the account.
account.Withdraw(200m);
// We check the balance again.
Console.WriteLine($"Balance after withdrawal is: {account.GetBalance():C}");

// We try to withdraw more money than is in the account.
account.Withdraw(2000m);
// We check the balance again.
Console.WriteLine($"Final balance is: {account.GetBalance():C}");

// We try to deposit a negative amount.
account.Deposit(-100m);

Console.WriteLine("\n--- Abstraction Example: Television Remote ---");

// We create an instance of our Television.
// We are interacting with it via the simple RemoteControl interface.
RemoteControl myTv = new Television();

// We use the simple methods, abstracting away the complex inner workings.
myTv.TurnOn();
myTv.VolumeUp();
myTv.ChangeChannel(5);
myTv.ShowMenu();
myTv.TurnOff();

// Note that you cannot create an instance of an abstract class:
// RemoteControl myRemote = new RemoteControl(); // This would cause a compile error.

Console.WriteLine("\n--- Inheritance Example: Animal ---");

// We create a new instance of the Dog class.
Dog myDog = new Dog("Buddy");
// We call the Eat method, which is inherited from the Animal class.
myDog.Eat();
// We call the MakeSound method, which is overridden in the Dog class.
myDog.MakeSound();
// We call the Fetch method, which is specific to the Dog class.
myDog.Fetch();

Console.WriteLine(); // Add a blank line for readability.

// We create a new instance of the Cat class.
Cat myCat = new Cat("Whiskers");
// We call the Eat method, inherited from Animal.
myCat.Eat();
// We call the MakeSound method, overridden in the Cat class.
myCat.MakeSound();
// We call the Purr method, specific to the Cat class.
myCat.Purr();

Console.WriteLine("\n--- Polymorphism Example: Shape ---");

// We create a list of Shape objects.
// This list can hold any object that inherits from Shape.
var shapes = new List<Shape>
{
    // We add a new Circle object to the list.
    new Circle(),
    // We add a new Square object.
    new Square(),
    // We add a new Triangle object.
    new Triangle(),
    // We can even add a base Shape object.
    new Shape()
};

// We loop through each shape in the list.
// The 'shape' variable is of type Shape.
foreach (var shape in shapes)
{
    // We call the Draw method on each shape.
    // The program determines at runtime which Draw method to call
    // based on the actual type of the object. This is polymorphism.
    shape.Draw();
}
