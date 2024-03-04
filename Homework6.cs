using System;

namespace Homework6
{
    public class Professor
    {
        private string name;
        private string classTeach;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ClassTeach
        {
            get { return classTeach; }
            set { classTeach = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Professor(string name, string classTeach, double salary)
        {
            this.name = name;
            this.classTeach = classTeach;
            this.salary = salary;
        }
    }

    public class Student
    {
        private string name;
        private string classEnroll;
        private double grade;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ClassEnroll
        {
            get { return classEnroll; }
            set { classEnroll = value; }
        }

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Student(string name, string classEnroll, double grade)
        {
            this.name = name;
            this.classEnroll = classEnroll;
            this.grade = grade;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Professor alice = new Professor("Alice", "Java", 9000);
            Professor bob = new Professor("Bob", "Math", 8000);
            Student lisa = new Student("Lisa", "Java", 90);
            Student tom = new Student("Tom", "Math", 80);

            Console.WriteLine("Professor " + alice.Name + " teaches " + alice.ClassTeach + ", and the salary is: " + alice.Salary);
            Console.WriteLine("Professor " + bob.Name + " teaches " + bob.ClassTeach + ", and the salary is: " + bob.Salary);
            Console.WriteLine("Student " + lisa.Name + " enrolls " + lisa.ClassEnroll + ", and the grade is: " + lisa.Grade);
            Console.WriteLine("Student " + tom.Name + " enrolls " + tom.ClassEnroll + ", and the grade is: " + tom.Grade);

            double salaryDifference = alice.Salary - bob.Salary;
            Console.WriteLine("The salary difference between " + alice.Name + " and " + bob.Name + " is: " + salaryDifference);

            double totalGrade = lisa.Grade + tom.Grade;
            Console.WriteLine("The total grade of " + lisa.Name + " and " + tom.Name + " is: " + totalGrade);
        }
    }
}