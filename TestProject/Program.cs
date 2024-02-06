using System.Globalization;

namespace TestProject;

class Program
{
    static void Main(string[] args)
    {
        int myInt = 7;
        float myFloat = 7.77F;
        bool sevenIsGreaterThanSix = true;
        string favoriteMovie = "Fantastic Mr.Fox";

        Console.WriteLine("My favorite number is " + myInt +"\n");
        Console.WriteLine("777 divided by 100 equals " + myFloat +"\n");
        Console.WriteLine("Seven is greater than six:" + sevenIsGreaterThanSix);
        Console.WriteLine("My favorite movie is " +favoriteMovie);

    }
}
