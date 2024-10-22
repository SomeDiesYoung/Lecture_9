using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;



//შექმენით კლასი Person, რომელსაც აქვს თვისებები Name და Age.
//შექმენით წარმოებული (მემკვიდრე) კლასი Student, რომელიც მემკვიდრეობას
//იღებს Person-სგან და ამატებს ახალ თვისებას StudentId.
//შექმენით მეორე წარმოებული კლასი Teacher, რომელიც მემკვიდრეობას იღებს
//Person-სგან და ამატებს ახალ თვისებას Subject.
//დაწერეთ DisplayInfo() მეთოდი, რომელიც დაბეჭდავს თითიეული კლასის
//შესახებ შესაბამის ინფორმაციას და გამოიძახეთ ეს მეთოდი
//Student და Teacher ობიექტებიდან.


namespace Task_1;

internal class Task_1
{
    static void Main()
    {
        Person person = new Person("Arthur", 2);
        person.DisplayInfo();

        Student student = new Student("Johan", 23, 3462);
        student.DisplayInfo();

        Teacher teacher = new Teacher("Marua", 63, "Psychologia");
        teacher.DisplayInfo();


        Console.ReadKey();
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


        //public virtual void DisplayInfo()
        //{
        //    Console.WriteLine($"Name :{Name} , Age : {Age}");
        //}

        public void DisplayInfo()
        {
            Console.WriteLine($"Name :{Name} , Age : {Age}");
        }
    }

    public class Student : Person
    {
        public int StudentId { get; set; }
        public Student(string name, int age, int studentID) : base(name, age)
        {
            this.StudentId = studentID;
        }

        //public override void DisplayInfo()
        //{
        //    Console.WriteLine($"Name :{Name} , Age : {Age} , StudentID : {StudentId}");
        //}       
        public  void DisplayInfo()
        {
            Console.WriteLine($"Name :{Name} , Age : {Age} , StudentID : {StudentId}");
        }

    }
    public class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher(string name, int age, string subject) : base(name, age)
        {
            this.Subject = subject;
        }
        //public override void DisplayInfo()
        //{
        //    Console.WriteLine($"Name :{Name} , Age : {Age} , Subject : {Subject}");
        //}
        public void DisplayInfo()
        {
            Console.WriteLine($"Name :{Name} , Age : {Age} , Subject : {Subject}");
        }

    }
}


