using System.Text;

namespace Demo6
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(" ");
            sb.Append("World");
            Console.WriteLine(sb.ToString());
            int age = 21;
            string name = "Rohith";
            Console.WriteLine(string.Format("Name: {0}, Age: {1}", name, age));
            Console.WriteLine($"Name: {name}, Age: {age}");
            }
        }
    }
