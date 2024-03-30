using System;
using System.Collections.Generic;

public class Student {
    private int studentID;
    private string studentName;

    public Student(int studentID, string studentName) {
        this.studentID = studentID;
        this.studentName = studentName;
        Student.studentList.Add(this);
    }

    public void PrintInfo() {
        Console.WriteLine("Student ID: " + studentID + ", Student Name: " + studentName);
    }

    public static List<Student> studentList = new List<Student>();
}

public class Program {
    public static void Main(string[] args) {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>() {
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }
        };

        if (!gradebook.ContainsKey("Tom")) {
            gradebook["Tom"] = 3.3;
        }

        double totalGPA = gradebook.Values.Sum();
        int studentCount = gradebook.Count;
        double averageGPA = totalGPA / studentCount;

        Console.WriteLine("The average GPA is: " + averageGPA);

        foreach (var student in Student.studentList) {
            if (gradebook.ContainsKey(student.studentName) && gradebook[student.studentName] > averageGPA) {
                student.PrintInfo();
            }
        }
    }
}