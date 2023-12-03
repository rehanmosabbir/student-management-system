using Library;
using Library.Enums;
using StudentManagementSystem;

StudentManager studentManager = new StudentManager();

studentManager.LoadStudentsFromJson();

while (true)
{
    Console.Clear();
    Console.WriteLine("** Welcome to Student Management System **");
    Console.WriteLine();
    Console.WriteLine("1. Add New Student");
    Console.WriteLine("2. View Student Details");
    Console.WriteLine("3. Delete a Student");
    Console.WriteLine("4. Add New Semester");
    Console.WriteLine("5. Exit");
    Console.WriteLine();
    Console.WriteLine("Select an option among (1-5)");
    int option = int.Parse(Console.ReadLine());

    if(option == 1)
    {
        Console.Clear();
        studentManager.AddNewStudent();
        Console.WriteLine();
        Console.WriteLine("Press 0 to continue...");
        int con = int.Parse(Console.ReadLine());
        if (con == 0) continue;
    }
    if (option == 2)
    {
        Console.Clear();
        Console.WriteLine("Please provide Student Id to view details: ");
        string? studentId = Console.ReadLine();
        studentManager.ViewStudentDetails(studentId);
        Console.WriteLine();
        Console.WriteLine("Press 0 to continue...");
        int con = int.Parse(Console.ReadLine());
        if (con == 0) continue; 
       
    }
    if (option == 3)
    {
        Console.Clear();
        Console.WriteLine("Provide Student Id to delete: ");
        string? studentId = Console.ReadLine();
        studentManager.DeleteStudent(studentId);
        Console.WriteLine();
        Console.WriteLine("Press 0 to continue...");
        int con = int.Parse(Console.ReadLine());
        if (con == 0) continue;
    }
    if (option == 4)
    {
        Console.Clear();
        Console.WriteLine("Please provide Student Id to add semester : ");
        string? studentId = Console.ReadLine();
        studentManager.AddSemester(studentId);
        Console.WriteLine();
        Console.WriteLine("Press 0 to continue...");
        int con = int.Parse(Console.ReadLine());
        if (con == 0) continue;
    }
    if (option == 5)
    {
        break;
    }

}







