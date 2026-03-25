namespace delegates
{
    internal class Program
    {
        delegate void GetDetails(String name);
        
        class DivyaGyanCollege
        {
            public static void FirstSemester(String name)
            {
                System.Console.WriteLine("Welcome to the first semester of Divya Gyan College, " + name + "!");
            }

            public static void SecondSemester(String name)
            {
                System.Console.WriteLine("Welcome to the second semester of Divya Gyan College, " + name + "!");
            }

            public static void ThirdSemester(String name)
            {
                System.Console.WriteLine("Welcome to the third semester of Divya Gyan College, " + name + "!");
            }
        }

        static void Main(string[] args)
        {
            GetDetails detailsDelegate;

            detailsDelegate = DivyaGyanCollege.FirstSemester;
            detailsDelegate("Alisha");

            detailsDelegate = DivyaGyanCollege.SecondSemester;
            detailsDelegate("Saugat");

            detailsDelegate = DivyaGyanCollege.ThirdSemester;
            detailsDelegate("Santosh");
        }
    }
}