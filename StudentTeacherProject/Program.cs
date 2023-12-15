using StudentTeacherProject;

var db = new ApplicationDbContext();

Console.WriteLine("Enter Your Student Name:");
var studnetname = Console.ReadLine();

Console.WriteLine("Enter Your Student Family:");
var studnetfamily = Console.ReadLine();

Console.WriteLine("Enter Your Score");
var score = int.Parse(Console.ReadLine());

var student = new Student();
student.ShowName(studnetname);
student.ShowName(studnetfamily);
student.ShowName(studnetname + " " + score);
var st = db.Persons.Where(s => s.Name == studnetname).FirstOrDefault();
db.Students.Add((Student)st);
db.SaveChanges();

Console.WriteLine("Enter Your Teacher:");
var teachername = Console.ReadLine();

Console.WriteLine("Enter Your Course:");
var course = Console.ReadLine();

var teacher = new Teacher();
teacher.ShowName(teachername);
teacher.ShowName(course);
var te = db.Persons.Where(t => t.Name == teachername).FirstOrDefault();
db.Teachers.Add((Teacher)te);
db.SaveChanges();