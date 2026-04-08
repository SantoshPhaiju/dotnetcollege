using Microsoft.Data.Sqlite;

// using var connection = new SqliteConnection("Data Source=mydatabase.db");
using var connection = new SqliteConnection("Data Source=mydatabase.sqlite3");

connection.Open();
var createTableCmd = connection.CreateCommand();

createTableCmd.CommandText = @"
CREATE TABLE IF NOT EXISTS users (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL,
    email TEXT NOT NULL UNIQUE,
    address TEXT NOT NULL
)
";

createTableCmd.ExecuteNonQuery();



var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/users", () =>
{
    var users = new List<string> { "Alice", "Bob", "Charlie" };
    return users;
});

app.MapPost("/create-user", (HttpRequest request) =>
{
    var form = request.Form;
    var name = form["name"];
    var email = form["email"];
    var address = form["address"];

    System.Console.WriteLine($"Received user: Name={name}, Email={email}, Address={address}");
});




app.Run();
