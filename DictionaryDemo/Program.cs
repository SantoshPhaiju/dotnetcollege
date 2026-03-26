

namespace DictionaryDemo
{
    internal class Program
    {
        public static void Main()
        {
            try
            {
                
            // Creating a dictionary
            Dictionary<int, string> sub = new Dictionary<int, string>
            {
                { 1, "C#" },
                { 2, "Javascript" },
                { 3, "Dart" },
                { 3, "Python" } // This will overwrite the previous value for key 3
            };

            // Displaying dictionary
            foreach (var ele in sub)
            {
                Console.WriteLine($"Key: {ele.Key}, Value: {ele.Value}");
            }
            } catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}