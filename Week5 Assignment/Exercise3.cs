using SalaryCalculator;
namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter name:");
                string name = Console.ReadLine();
                Console.Write("Enter id");
                int empId = int.Parse(Console.ReadLine());
                Console.Write("Basic Salary: ");
                double basicSalary = double.Parse(Console.ReadLine());
                double netSalary = Class1.CalculateNetSalary(basicSalary);
                Console.WriteLine("Employee ID   : " + empId);
                Console.WriteLine("Employee Name : " + name);
                Console.WriteLine("Basic Salary  : " + basicSalary);
                Console.WriteLine("Net Salary    : " + netSalary);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
