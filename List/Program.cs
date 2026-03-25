namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            System.Console.WriteLine($"Capacity: {students.Capacity}");
            students.Add("Alisha");
            students.Add("Saugat");
            students.Add("Santosh");
            students.Add("Santosh");
            students.Add("Santosh");
            students.Add("Santosh");
            System.Console.WriteLine($"Capacity: {students.Capacity}");
            foreach (string student in students)
            {
                System.Console.WriteLine(student);
            }
            System.Console.WriteLine("Total students: " + students.Count);
            System.Console.WriteLine("Is Alisha in the list? " + students.Contains("Alisha"));
            students.Remove("Saugat");
            System.Console.WriteLine("After removing Saugat:");
            foreach (string student in students)
            {
                System.Console.WriteLine(student);
            }

            System.Console.WriteLine($"Capacity: {students.Capacity}");
        }
    }
}