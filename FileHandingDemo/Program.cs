using System.IO;

namespace FileHandingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "student.txt";


            System.Console.WriteLine("========================================================");
            System.Console.WriteLine("Hello Welcome to my File Handling Console Application");
            System.Console.WriteLine("========================================================");


            while (true)
            {


                int choice;
                System.Console.WriteLine("Enter 1 to write to file: ");
                choice = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Enter 2 to read from file: ");
                choice = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Enter 3 to update the student record: ");
                choice = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Enter 4 to delete the student record: ");
                choice = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Enter 5 to exit the application: ");
                choice = int.Parse(System.Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        System.Console.WriteLine("Enter student name: ");
                        string studentName = Console.ReadLine();
                        System.Console.WriteLine("Enter student email: ");
                        string studentEmail = Console.ReadLine();
                        System.Console.WriteLine("Enter student address: ");
                        string studentAddress = Console.ReadLine();
                        System.Console.WriteLine("Enter student phone: ");
                        string studentPhone = Console.ReadLine();
                        string studentData = $"Name: {studentName} Email: {studentEmail} Address: {studentAddress} Phone: {studentPhone}\n";
                        File.WriteAllText(filePath, studentData);
                        System.Console.WriteLine("Student record written to file successfully.");
                        break;
                    case 2:
                        if (File.Exists(filePath))
                        {
                            System.Console.WriteLine("Reading student record from file...");
                            string content = File.ReadAllText(filePath);
                            System.Console.WriteLine(content);
                        }
                        else
                        {
                            System.Console.WriteLine("File does not exist. Please write to file first.");
                        }
                        break;
                    case 3:
                        System.Console.WriteLine("Enter the student email to update: ");
                        string emailToUpdate = Console.ReadLine();
                        if (File.Exists(filePath))
                        {
                            string[] lines = File.ReadAllLines(filePath);
                            for (int i = 0; i < lines.Length; i++)
                            {
                                if (lines[i].Contains(emailToUpdate))
                                {
                                    System.Console.WriteLine("Enter new student name: ");
                                    string newStudentName = Console.ReadLine();
                                    System.Console.WriteLine("Enter new student email: ");
                                    string newStudentEmail = Console.ReadLine();
                                    System.Console.WriteLine("Enter new student address: ");
                                    string newStudentAddress = Console.ReadLine();
                                    System.Console.WriteLine("Enter new student phone: ");
                                    string newStudentPhone = Console.ReadLine();
                                    lines[i] = $"Name: {newStudentName} Email: {newStudentEmail} Address: {newStudentAddress} Phone: {newStudentPhone}";
                                    File.WriteAllLines(filePath, lines);
                                    System.Console.WriteLine("Student record updated successfully.");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("File does not exist. Please write to file first.");
                            break;
                        }
                        break;
                    case 4:
                        System.Console.WriteLine("Enter the student email to delete: ");
                        string emailToDelete = Console.ReadLine();
                        if (File.Exists(filePath))
                        {
                            string[] lines = File.ReadAllLines(filePath);
                            lines = lines.Where(line => !line.Contains(emailToDelete)).ToArray();
                            File.WriteAllLines(filePath, lines);
                            System.Console.WriteLine("Student record deleted successfully.");
                        }
                        else
                        {
                            System.Console.WriteLine("File does not exist. Please write to file first.");
                            break;
                        }
                        break;
                    case 5:
                        System.Console.WriteLine("Exiting the application. Goodbye!");
                        return;
                    default:
                        System.Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }

            // if (File.Exists(filePath))
            // {
            //     System.Console.WriteLine("File already exists. Reading content...");
            //     string content = File.ReadAllText(filePath);
            //     System.Console.WriteLine(content);
            // }
            // else
            // {
            //     System.Console.WriteLine("File does not exist. Creating file and writing content...");
            //     string studentData = "Name: Ram\nEmail: ram@example.com\nAddress: Kathmandu, Nepal \nPhone: 1234567890";
            //     File.WriteAllText(filePath, studentData);
            //     System.Console.WriteLine("File created and content written successfully.");
            // }
        }
    }
}