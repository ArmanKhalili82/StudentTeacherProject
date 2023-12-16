using StudentTeacherProject;

Console.WriteLine("Enter Your Student Or Teacher:");
var command = Console.ReadLine();

while (true)
{
    List<Student> studentadd = new List<Student>();

    if (command == "Student")
    {
        Console.WriteLine("Enter Your Student:");
        var student = Console.ReadLine();
        Console.WriteLine("Enter Your Family");
        var family = Console.ReadLine();
        Console.WriteLine("Enter Your Score");
        var studentscore = int.Parse(Console.ReadLine());
        studentadd.Add(student);
    }
}

//if (command == "Teacher")
//{

//}