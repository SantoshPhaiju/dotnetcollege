namespace GenericIntro
{
    internal class Program
    {

        class Student<T>
        {
            public T Data;

            public Student(T new_data)
            {
                this.Data = new_data;
            }

            public void DisplayData<K>(K extraData)
            {
                System.Console.WriteLine("The data is: " + Data);
                System.Console.WriteLine("The extra data is: " + extraData);
            }

        }

        static void Main(string[] args)
        {
            Student<string> student1 = new Student<string>("Hello, I'm a string");
            System.Console.WriteLine(student1.Data);

            Student<int> student2 = new Student<int>(42);
            System.Console.WriteLine(student2.Data);

            student1.DisplayData<int>(100);
            student2.DisplayData<string>("This is extra data for student2");
        }
    }
}