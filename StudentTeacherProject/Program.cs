using StudentTeacherProject;

Console.WriteLine("Enter Your Student Or Teacher:");
var command = Console.ReadLine();

while (true)
{
    if (command == "Student")
    {
        Console.WriteLine("Enter Your Student:");
        var student = Console.ReadLine();
        Console.WriteLine("Enter Your Family");
        var family = Console.ReadLine();
        Console.WriteLine("Enter Your Score");
        var studentscore = int.Parse(Console.ReadLine()); 
        List<Student> studentadd = new List<Student>();
        var st = studentadd.Where(s => s.Name == student).FirstOrDefault();
    }
}

//if (command == "Teacher")
//{

//}