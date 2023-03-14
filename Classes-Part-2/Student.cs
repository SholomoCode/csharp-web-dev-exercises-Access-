using System;
namespace Classes_Part_2
{
	public class Student
	{
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public double AddGrade(int courseCredits, double grade)
        {
            double TQS = NumberOfCredits * Gpa;
            TQS += courseCredits * grade;
            NumberOfCredits += courseCredits;
            Gpa = TQS / NumberOfCredits;
            return Gpa;
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel()
        {
            if (NumberOfCredits <= 29)
            {
                return "Freshmen";
            }
            else if (NumberOfCredits <= 59)
            {
                return "Sophomore";
            }
            else if (NumberOfCredits <= 89)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override string? ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.
    }
}

