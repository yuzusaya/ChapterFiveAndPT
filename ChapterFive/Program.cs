using ChapterFive;

var obj = new Student();
obj.SetStudentDetail("A Student a","id a","ic a",0); 
obj.SetStudentDetail("B Student b", "id b", "ic b", 20);
obj.SetStudentDetail("C Student a", "id c", "ic c", 40);
obj.SetStudentDetail("D Student a", "id d", "ic da", 60);
obj.SetStudentDetail("E Student a", "id e", "ic ea", 100);
obj.DisplayAllStudentDetails();
obj.DisplayAllStudentRanking();

/*
var firstDigit = 5;
var secondDigit = 0;

try
{
    Sample sample = new Sample();
    sample.Test();
    if (secondDigit == 0)
    {
        throw new InvalidDataException();
    }
    var ans = firstDigit / secondDigit;
    Console.WriteLine("Continue the program");
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}
catch (InvalidDataException e)
{
    Console.WriteLine("Please input digit other than zero");
}
catch (Exception ex)
{
    Console.WriteLine("An exception has occurred");
}
finally
{
    Console.WriteLine("final block");
}
*/
Console.ReadLine();