using System;

sealed class SecurityModule
{
    public void Authenticate()
    {
        Console.WriteLine("User authenticated successfully ✅");
    }
}

abstract class InsurancePolicy
{
    private double premium;

    public int PolicyNumber { get; init; }
    public string PolicyHolderName { get; set; }

    public double Premium
    {
        get { return premium; }
        set
        {
            if (value > 0) premium = value;
            else Console.WriteLine("Premium should be graeter than 0");
        }
    }

    protected InsurancePolicy(int policyNo, string holder, double premium)
    {
        PolicyNumber = policyNo;
        PolicyHolderName = holder;
        Premium = premium;
    }

    public virtual double CalculatePremium()
    {
        return Premium;
    }

    public void ShowPolicy()
    {
        Console.WriteLine("Insurance Policy");
    }
}

class LifePolicy : InsurancePolicy
{
    public LifePolicy(int policyNo, string holder, double premium) : base(policyNo, holder, premium) { }

    public override double CalculatePremium()
    {
        return Premium + 500;
    }

    public new void ShowPolicy()
    {
        Console.WriteLine("Life Insurance Policy");
    }
}

class HealthPolicy : InsurancePolicy
{
    public HealthPolicy(int policyNo, string holder, double premium) : base(policyNo, holder, premium) { }

    public sealed override double CalculatePremium()
    {
        return Premium + 1000;
    }
}

class PolicyDirectory
{
    private List<InsurancePolicy> policies = new();

    public InsurancePolicy this[int index]
    {
        get { return policies[index]; }
        set { policies.Add(value); }
    }

    public InsurancePolicy this[string holderName]
    {
        get
        {
            var policy = policies.FirstOrDefault(p => p.PolicyHolderName == holderName);
            if (policy == null)
            {
                Console.WriteLine("Policy holder not found");
                return null;
            }
            return policy;
        }
    }
}
