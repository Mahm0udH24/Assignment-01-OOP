using System;

namespace Assignment_01_OOP
{
  
    public class ClassStudent
    {
        public string? Name;
    }
    public struct StructStudent
    {
        public string Name;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
      
            ClassStudent c1 = new ClassStudent { Name = "Ahmed" };
            ClassStudent c2 = c1; 
            c2.Name = "Sara";     

            Console.WriteLine($"Class Case: c1.Name = {c1.Name}");

            Console.WriteLine("--------------------------");

            StructStudent s1 = new StructStudent { Name = "Ahmed" };
            StructStudent s2 = s1; 
            s2.Name = "Sara";     

            Console.WriteLine($"Struct Case: s1.Name = {s1.Name}");
            
        }
    }
    /*
     
    A Class is a Reference Type, meaning it stores a reference (address) to the data on the Heap.
      Class instance to another, both variables point to the same memory address; changing one affects the other. When you assign one
      Classes fully support Object-Oriented features like Inheritance, allowing one class to derive from another.
      Classes are managed by the Garbage Collector (GC), which can add overhead to your application.

    A Struct is a Value Type, meaning it stores the actual data directly on the Stack.
       Struct instance to another, a complete copy of the data is created; changing the copy does not affect the original.
       Structs do not support inheritance (they cannot inherit from other structs or classes and cannot be base classes).
       Structs are deallocated immediately when they go out of scope, making them more efficient for small, short-lived data.
     
     */

}


