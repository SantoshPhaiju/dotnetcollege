

using System.Collections;

namespace ArraylistDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList students = new ArrayList();
            System.Console.WriteLine($"Capacity: {students.Capacity}");
            students.Add("Alisha");
            students.Add("Saugat");
            students.Add("Santosh");
            students.Add("Alice");
            students.Add("Bob");
            students.Add("Proctor");
            // students.Add(123); // Adding an integer to demonstrate ArrayList's ability to hold different types
            System.Console.WriteLine($"Capacity: {students.Capacity}");
            foreach (object student in students)
            {
                System.Console.WriteLine(student);
            }
            students.Sort();
            System.Console.WriteLine("After sorting:");
            foreach (object student in students)
            {
                System.Console.WriteLine(student);
            }
            System.Console.WriteLine("Total students: " + students.Count);
            System.Console.WriteLine("Is Alisha in the list? " + students.Contains("Alisha"));
            students.Remove("Saugat");
            System.Console.WriteLine("After removing Saugat:");
            foreach (object student in students)
            {
                System.Console.WriteLine(student);
            }

            System.Console.WriteLine($"Capacity: {students.Capacity}");
        }
    }
}