using InsuranceLibrary.Models;
using InsuranceLibrary.Services;
namespace InsuranceConsoleApp
{
    public class Program
    {
        static List<InsurancePolicy> policies = new List<InsurancePolicy>();
        static PolicyService policyService = new PolicyService();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Insurance Policy Management System");
                Console.WriteLine("1. Add Policy");
                Console.WriteLine("2.View All Policies");
                Console.WriteLine("3.Search Policy by ID");
                Console.WriteLine("4.Update Policy");
                Console.WriteLine("5.Delete Policy");
                Console.WriteLine("6.Deactivae Policy");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddPolicy(); break;
                    case 2: ViewPolicies(); break;
                    case 3: SearchPolicy(policies); break;
                    case 4: UpdatePolicy(policies); break;
                    case 5: DeletePolicy(policies); break;
                    case 6: DeactivatePolicy(policies); break;
                    case 0: return;
                }
            }
        }
        
        static void AddPolicy()
        {
            InsurancePolicy p = new InsurancePolicy();
            Console.Write("Policy Id: ");
            p.policyId = int.Parse(Console.ReadLine());
            Console.Write("Holder Name: ");
            p.policyHolderName = Console.ReadLine();
            Console.Write("Policy Type: ");
            p.policyType = Console.ReadLine();
            Console.Write("Premium Amount: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal value))
            {
                p.premiumAmount = value;
            }
            else
            {
                Console.WriteLine("Invalid premium amount. Please enter a valid decimal value.");
                return;
            }
            policyService.AddPolicy(p);
            Console.WriteLine("Policy Added.");
        }
        static void ViewPolicies()
        {
            List<InsurancePolicy>policies=policyService.GetAllPolicies();
            Console.WriteLine($"\n| ID |++++++| Name |++++++| Type |+++++++| Premium |+++| Duration |+++| Status |");
            foreach (var policy in policies)
            {
                Console.WriteLine(policy.ToString());
            }
        }
        static void SearchPolicy(List<InsurancePolicy> policies)
        { 
            Console.Write("Enter Policy ID to search: ");
            int id = int.Parse(Console.ReadLine());
            InsurancePolicy policy = policyService.GetPolicyById(id);
            if (policy != null)
            {
                Console.WriteLine("Policy Found:");
                Console.WriteLine(policy.ToString());
            }
            else
            {
                Console.WriteLine("Policy not found.");
            }
        }
        static void UpdatePolicy(List<InsurancePolicy> policies)
        { 
            Console.Write("Enter Policy ID to search: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter new Premium Amount: ");
            decimal newPremium = decimal.Parse(Console.ReadLine());
            Console.Write("Enter new Policy Term: ");
            int newTerm = int.Parse(Console.ReadLine());
            bool updated = policyService.UpdatePolicy(id, newPremium, newTerm);
            if (updated)
            {
                Console.WriteLine("Policy Updated.");
            }
            else
            {
                Console.WriteLine("Policy not found.");
            }
        }
        static void DeletePolicy(List<InsurancePolicy> policies)
        {
           
            Console.Write("Enter Policy ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            bool deleted = policyService.DeletePolicy(id);
            if (deleted)
            {
                Console.WriteLine("Policy deleted.");
            }
            else
            {
                Console.WriteLine("Policy not found.");
            }
        }
        static void DeactivatePolicy(List<InsurancePolicy> policies)
        {
            Console.Write("Enter Policy ID to deactivate: ");
            int id = int.Parse(Console.ReadLine());
            bool deactivated = policyService.DeactivatePolicy(id);
            if (deactivated)
            {
                Console.WriteLine("Policy deactivated.");
            }
            else
            {
                Console.WriteLine("Policy not found.");
            }
        }
    }
}
