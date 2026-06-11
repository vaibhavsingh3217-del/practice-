//polymorphism example
//it is an oop concept that allows one method to have different behaviour in different classes.
//polymorphism - one interface,manyforms
using System;

namespace PolymorphismExample
{
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();

            a.Sound();

            Console.WriteLine("Press Enter to Exit...");
            Console.ReadLine();
        }
    }
}
//encapsulation example
//it means bundling the data and methods that operate on that data into a single class and restricting direct access to internal state of the object
//encapsulation - hiding data and controlling acess through it through methods and properties
//protects data from unauthorised access
using System;

class BankAccount
{
    
    private decimal balance;

    
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    
    public decimal GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.Deposit(1000);

        Console.WriteLine("Balance: " + account.GetBalance());
    }
}
// inheritance example
// inheritance is a concept where one class acquiresthe properties and methods of another class 
using System;

class BankAccount
{
    
    private decimal balance;

    
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    
    public decimal GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.Deposit(1000);

        Console.WriteLine("Balance: " + account.GetBalance());
    }
}
//abstraction example
//abstraction is the process of hiding implementation details and showing only the essentials features of an object
//abstraction = hiding data and showing only implementation details
using System;

namespace AbstractionExample
{
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Circle();

            s.Draw();

            Console.WriteLine("Press Enter to Exit...");
            Console.ReadLine();
        }
    }
}
//constructor is used to initialize object
//destructor is a special method that is called directly by garbage collector
//syntax:-
//class Myclass
//{
//   ~Myclass()
//   {
//      Console.WriteLine("Destructor called");
//   }
//}

