namespace Task_4;

internal class Program
{
    static void Main()
    {
        //ცარიელი კონსტრუქტორი იმიტომ დავამატე რადგან ნათლად ჩანდეს რისი გამოტანა გვინდოდა ტასკში
        Student student = new Student();
        Console.WriteLine(student.GetOccupation()); 
        
        Teacher teacher = new Teacher();
        Console.WriteLine(teacher.GetOccupation());

        Console.ReadKey();
    }


    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public abstract string GetOccupation();
    }

    public class Student : Person
    {
        public int StudentID { get; set; }
        public Student() { }

        public Student(string name , int age , int studentId) : base(name,age)
        {
            this.StudentID=studentId;
        }

        public override string GetOccupation() => "Student";

    }
    public class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher() { }

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            this.Subject = subject;
        }
        public override string GetOccupation() => "Teacher";
    }
}