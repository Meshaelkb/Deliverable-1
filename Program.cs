using System.Reflection.Metadata;
using System.Transactions;

namespace Hello_world
{
    internal class Program
    {
        private static object conConsole;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            String stg = "Hello, World! (2)";
            Console.WriteLine(stg);

            Console.WriteLine("User Name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter User's age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Username is:" + userName + "and the age is: " + age);
        } 
    }
}