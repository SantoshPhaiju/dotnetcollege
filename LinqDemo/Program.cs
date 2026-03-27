namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = new List<dynamic>()
            {
                new { Id = 1, Name = "Ram", Age = 24, gender = "male", status = true },
                new { Id = 2, Name = "Alisha", Age = 20, gender = "female", status = true},
                new { Id = 3, Name = "Santosh", Age = 21, gender = "male", status = true},
                new { Id = 4, Name = "Saugat", Age = 19, gender = "male", status = false},
                new { Id = 5, Name = "Dhan Sir", Age = 44, gender = "male", status = true},
                new { Id = 6, Name = "Raju", Age = 16, gender = "male", status = true},
                new { Id = 7, Name = "Anju", Age = 13, gender = "female", status = true},
                new { Id = 8, Name = "Arju", Age = 2, gender = "female", status = false},
            };

            var total_users = users.Count();
            System.Console.WriteLine($"Total users: {total_users}");
            var total_male = users.Where(u => u.gender == "male").Count();
            System.Console.WriteLine($"Total male users: {total_male}");
            var total_female = users.Where(u => u.gender == "female").Count();
            System.Console.WriteLine($"Total female users: {total_female}");
            var total_active_male = users.Where(u => u.gender == "male" && u.status == true).Count();
            System.Console.WriteLine($"Total active male users: {total_active_male}");
            var total_active_female = users.Where(u => u.gender == "female" && u.status == true).Count();
            System.Console.WriteLine($"Total active female users: {total_active_female}");
            var total_inactive_male = users.Where(u => u.gender == "male" && u.status == false).Count();
            System.Console.WriteLine($"Total inactive male users: {total_inactive_male}");
            var total_inactive_female = users.Where(u => u.gender == "female" && u.status == false).Count();
            System.Console.WriteLine($"Total inactive female users: {total_inactive_female}");

            var adults = users.Where(u => u.Age > 20);
            foreach (var adult in adults)
            {
                System.Console.WriteLine(adult);
            }

            System.Console.WriteLine("\n");
            var sortedUsers = users.OrderBy(u => u.Name);
            foreach (var user in sortedUsers)
            {
                System.Console.WriteLine(user);
            }

        }
    }
}