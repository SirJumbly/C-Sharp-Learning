using System.Reflection.Metadata;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameFull = "Jimmy Jaskins";
            int age = 55;
            double weight = 175.5;
            int heightFt = 5;
            int heightInch = 11;


            Console.WriteLine("User statistics");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Name" + "                " + "Age" + "    " + "Height"+ "    " + "Weight");
            Console.WriteLine(nameFull + "      " + age + "     " + heightFt+"'"+heightInch+"\"" + "     " + weight+"lbs");

            Console.ReadLine();
            
        }
    }
}
