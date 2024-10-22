namespace Task_2;

internal class Task_2
{
    static void Main()
    {
        Person person = new Person();
        person.Describe();

        Student student = new Student();
        student.Describe();

        Teacher teacher = new Teacher();
        teacher.Describe();


        Console.ReadKey();
    }

    public class Person
    {

        public virtual void Describe()
        {
            Console.WriteLine("I am a Person");
        }


    }

    public class Student : Person
    {

        public override void Describe()
        {
            Console.WriteLine("I am a Student");
        }


    }
    public class Teacher : Person
    {

        public override void Describe()
        {
            Console.WriteLine("I am a Teacher");
        }


    }
}

