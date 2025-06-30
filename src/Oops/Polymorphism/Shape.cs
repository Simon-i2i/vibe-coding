// This namespace organizes our code within the Polymorphism project.
namespace Oops.Polymorphism
{
    // This is the base class.
    // It demonstrates POLYMORPHISM.
    public class Shape
    {
        // This is a virtual method.
        // 'virtual' allows derived classes to override it.
        // This provides a default behavior.
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a generic shape.");
        }
    }

    // This is a derived class.
    public class Circle : Shape
    {
        // This method overrides the Draw method from the Shape class.
        // This is one form of polymorphism (method overriding).
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    // This is another derived class.
    public class Square : Shape
    {
        // This method also overrides the Draw method.
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }

    // And a third derived class.
    public class Triangle : Shape
    {
        // This method also overrides the Draw method.
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle.");
        }
    }
}
