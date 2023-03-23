// --------- Divide By Zero! ----------


static double Divide(double x, double y)
{
    if (y == 0)
    {
        throw new ArgumentOutOfRangeException("Can't divide by zero!!");
    }
    else
    {
        return x / y;
    }
}

// Test out your Divide() function here!


// --------- Test Student Labs ----------

static int CheckFileExtension(string fileName)
{
    int points = 0;
    if(fileName == null || fileName == "")
    {
        throw new ArgumentNullException("File must be valid");
    }
    else if (fileName.EndsWith(".cs"))
    {
        points++;
    }else if (!fileName.EndsWith(".cs"))
    {
        points += 0;
    }
    return points;
}


// Test out your CheckFileExtension() function here!

Dictionary<string, string> students = new Dictionary<string, string>();
students.Add("Carl", "Program.cs");
students.Add("Brad", "");
students.Add("Elizabeth", "MyCode.cs");

foreach(KeyValuePair<string, string> kvp in students)
{
    try
    {
        Console.WriteLine(kvp.Key);
        CheckFileExtension(kvp.Value);
    }
    catch(ArgumentNullException e)
    {
        Console.WriteLine(e.Message);
    }
}
