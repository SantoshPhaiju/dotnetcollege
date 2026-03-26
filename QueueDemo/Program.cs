namespace QueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> browserHistory = new Queue<string>();
            System.Console.WriteLine($"Count: {browserHistory.Count}");
            browserHistory.Enqueue("http://www.google.com");
            browserHistory.Enqueue("http://www.github.com");
            browserHistory.Enqueue("http://www.stackoverflow.com");
            
            System.Console.WriteLine("Current page: " + browserHistory.Peek());

            System.Console.WriteLine("\nBack navigation:");
            while (browserHistory.Count > 0)
            {
                System.Console.WriteLine(" Visiting: " + browserHistory.Dequeue());
            }

            System.Console.WriteLine("History empty: " + (browserHistory.Count == 0));
        }
    }
}