using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace NewApp.Pages;

public class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }

}

public class IndexModel : PageModel
{
    private readonly IConfiguration _config;
    public IndexModel(IConfiguration config)
    {
        _config = config;
        // create a table if not exists Students

        using var conn = new SqliteConnection(_config.GetConnectionString("DefaultConnection"));
        conn.Open();
        var cmd = conn.CreateCommand();
        cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Students (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Name TEXT,
            Email TEXT,
            Address TEXT
        )";
        cmd.ExecuteNonQuery();

    }

    public List<Student> Students { get; set; } = new List<Student>();

    public Student? Student { get; set; }

    public void OnGet()
    {
        LoadData();
    }


    public IActionResult OnPostSave()
    {
        using var conn = new SqliteConnection(_config.GetConnectionString("DefaultConnection"));
        conn.Open();

        // INSERT
        var cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO Students (Name, Email, Address) VALUES (@Name,@Email,@Address)";
        cmd.Parameters.AddWithValue("@Name", Student.Name);
        cmd.Parameters.AddWithValue("@Email", Student.Email);
        cmd.Parameters.AddWithValue("@Address", Student.Address);
        cmd.ExecuteNonQuery();
        return RedirectToPage();
    }

    private void LoadData()
    {
        using var con = new SqliteConnection(_config.GetConnectionString("DefaultConnection"));
        con.Open();

        var cmd = con.CreateCommand();
        cmd.CommandText = "SELECT * FROM Students";

        using var reader = cmd.ExecuteReader();
        Students.Clear();

        while (reader.Read())
        {
            Students.Add(new Student
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Email = reader.GetString(2),
                Address = reader.GetString(3)
            });
        }
    }


}
