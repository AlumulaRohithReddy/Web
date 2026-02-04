using InsuranceLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceLibrary.Services
{
    public class PolicyService
    {
        List<InsurancePolicy> policies = new List<InsurancePolicy>() {
            new InsurancePolicy(1, "John Doe", "Health", 5000, 12, true),
            new InsurancePolicy(2, "Jane Smith", "Life", 10000, 24, true),
        };
        public void AddPolicy(InsurancePolicy policy)
        {
            if (policies.Any(p => p.policyId == policy.policyId))
            {
                throw new ArgumentException("Policy with the same ID already exists.");
            }
            InsurancePolicy p = new InsurancePolicy();
            p.policyId = policy.policyId;
            p.policyHolderName = policy.policyHolderName;
            p.policyType = policy.policyType;
            p.premiumAmount = policy.premiumAmount;
            p.policyTerm = policy.policyTerm;
            p.isActive = true;
            policies.Add(p);
        }
        public List<InsurancePolicy> GetAllPolicies()
        {
            return policies;
        }
        public InsurancePolicy GetPolicyById(int id)
        {
            return policies.Find(p => p.policyId == id);
        }
        public bool UpdatePolicy(int id, decimal newPremium, int newTerm)
        {
            InsurancePolicy policy = GetPolicyById(id);
            if (policy != null)
            {
                policy.premiumAmount = newPremium;
                policy.policyTerm = newTerm;
                return true;
            }
            return false;
        }
        public bool DeletePolicy(int id)
        {
            InsurancePolicy policy = GetPolicyById(id);
            if (policy != null)
            {
                policies.Remove(policy);
                return true;
            }
            return false;

        }
        public bool DeactivatePolicy(int id)
        {
            InsurancePolicy policy = GetPolicyById(id);
            if (policy != null)
            {
                policy.isActive = false;
                return true;
            }
            return false;
        }
    }
}
