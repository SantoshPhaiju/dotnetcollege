namespace StackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> browserHistory = new Stack<string>();
            System.Console.WriteLine($"Count: {browserHistory.Count}");
            browserHistory.Push("http://www.google.com");
            browserHistory.Push("http://www.github.com");
            browserHistory.Push("http://www.stackoverflow.com");
            
            System.Console.WriteLine("Current page: " + browserHistory.Peek());

            System.Console.WriteLine("\nBack navigation:");
            while (browserHistory.Count > 0)
            {
                System.Console.WriteLine(" Visiting: " + browserHistory.Pop());
            }

            System.Console.WriteLine("History empty: " + (browserHistory.Count == 0));
        }
    }
}