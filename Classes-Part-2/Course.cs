using System;
using System.Xml.Linq;

namespace Classes_Part_2
{
	public class Course
	{
        public Course(string topic, Teacher instructor, List<Student> enrolledStudents)
        {
            Topic = topic;
            Instructor = instructor;
            EnrolledStudents = enrolledStudents;
        }

        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> EnrolledStudents { get; set; }


        
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override string? ToString()
        {
            return Topic + " (Teacher: " + Instructor + ", Students: " + EnrolledStudents + ")";
        }


        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
        //  just the class fields.


        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.
    }
}

