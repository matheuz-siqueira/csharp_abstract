namespace csharp_abstract.Entities;

public class PhysicalPerson : Person 
{
    public double HealthExpenses { get; set; }

    public PhysicalPerson(string name, double annualIncome, double healthExpenses)
    : base (name, annualIncome)
    {
        HealthExpenses = healthExpenses;
    }

    public override double Tax()
    {
        double taxReduction = 0.0;
        double tax = 0.0; 
        if(HealthExpenses != 0.0) 
        {
            taxReduction = HealthExpenses / 2.0; 
        }
        
        if(AnnualIncome < 20000)
        {
            tax = AnnualIncome * 0.15 - taxReduction; 
        }else
        {
            tax = AnnualIncome * 0.25 - taxReduction;
        }
        return tax; 

    }

    public override string ToString()
    {
        return $"{Name}: {Tax().ToString("C")}";
    }
}
