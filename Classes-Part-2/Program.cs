//Classes part 2 exercises

// TODO: Test your exercise solutions with print statements here.
using Classes_Part_2;

Teacher Gerard = new Teacher("Gerard", "Daris", "Math", 30);

Student willow = new Student("Willow", 1, 67, 3.23);
Student thisbe = new Student("Thisbe", 2, 19, 2.09);
Student alyce = new Student("Alyce", 3, 98, 3.01);
List<Student> list = new List<Student> { willow, thisbe, alyce};
Course Math = new Course("Math", Gerard, list);
//testing with multiple examples
Console.WriteLine(Math.ToString());

Console.WriteLine(willow.GetGradeLevel());
Console.WriteLine(willow.AddGrade(4, 2.9));
Console.WriteLine(willow.ToString() + "\n");

Console.WriteLine(thisbe.GetGradeLevel());
Console.WriteLine(thisbe.AddGrade(3, 4.0));
Console.WriteLine(thisbe.ToString() + "\n");

Console.WriteLine(alyce.GetGradeLevel());
Console.WriteLine(alyce.AddGrade(2, 3.5));
Console.WriteLine(alyce.ToString() + "\n");

//testing the Equals method
Console.WriteLine(willow.Equals == thisbe.Equals);
Console.WriteLine(willow.Equals == willow.Equals);


