using System.Xml.Linq;
using System;

namespace Task_3;

//დაამატეთ კონსტრუქტორი Person კლასში, რომელიც იღებს პარამეტრებს name და age.
//Student და Teacher კლასებში გამოიყენეთ base რათა გამოიძახოთ Person კონსტრუქტორი და გადასცეთ პარამეტრები.
//შექმენით Student და Teacher ობიექტები და შეამოწმეთ საბაზისო კლასის კონსტრუქტორის გამოძახება.

    internal class Task_3
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


            public virtual void DisplayInfo()
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

            public override void DisplayInfo()
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
            public override void DisplayInfo()
            {
                Console.WriteLine($"Name :{Name} , Age : {Age} , Subject : {Subject}");
            }


        }
    }



