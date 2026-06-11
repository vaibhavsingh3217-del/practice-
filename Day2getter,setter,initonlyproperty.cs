//getter returns a value
//setter stores a value
//initonly allows assignment only during object creation
//GETTER
using System;

namespace GetterExample
{
    class Student
    {
        private string name;

        
        public string Name
        {
            get
            {
                return name; 
            }
            set
            {
                name = value; 
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            
            student.Name = "John";

            
            Console.WriteLine("Student Name: " + student.Name);

            Console.ReadLine();
        }
    }
}
//output - Student Name ; john
//SETTER
using System;

class Student
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value; \
        }
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        // Calls the setter
        student.Name = "John";

        Console.WriteLine("Name: " + student.Name);
    }
}
//output= Name: john
//initonly property
using System;
class Student
{
    public string Name { get; init; }
}
class Program
{
    static void Main()
    {
        Student student = new Student
        {
            Name = "John"
        };
        Console.WriteLine(student.Name);
        Console.ReadLine();
    }
}
//Output=John
