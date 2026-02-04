using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceLibrary.Models
{
    public class InsurancePolicy
    {
		private int PolicyId;

		public int policyId
		{
			get { return PolicyId; }
			set { PolicyId = value; }
		}

		private string PolicyHolderName;
		public string policyHolderName
        {
			get { return PolicyHolderName; }
			set { PolicyHolderName = value; }

        }
		private string PolicyType;
		public string policyType
        {
			get { return PolicyType; }
			set { 
				if(value != "Health" && value != "Life" && value != "Vehicle")
				{
					throw new ArgumentException("PolicyType must be one of the following: Health, Life, Vehicle");
                }
                PolicyType = value; }

        }
		private decimal PremiumAmount;
		public decimal premiumAmount
		{
			get { return PremiumAmount; }
			set { PremiumAmount = value; }
        }
		private int PolicyTerm;
		public int policyTerm
		{
			get { return PolicyTerm; }
			set { PolicyTerm = value; }
        }
		private bool IsActive;
		public bool isActive
		{
			get { return IsActive; }
			set { IsActive = value; }
        }
		public InsurancePolicy()
		{
        }
        public InsurancePolicy(int id,string name, string type, decimal amt, int term,bool status)
        {
            PolicyId = id;
			PolicyHolderName = name;
			policyType = type;
			PremiumAmount = amt;
			PolicyTerm = term;
			IsActive = status;
        }
        public override string ToString()
        {
            return $"|{PolicyId,-12} {PolicyHolderName,-12} {PolicyType,-14} {PremiumAmount,-14} {PolicyTerm,-15} {IsActive,4}|";
        }
    }
}

