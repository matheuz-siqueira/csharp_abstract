namespace csharp_abstract.Entities;

public class LegalPerson : Person
{
    public int NumberEmployees { get; set; }

    public LegalPerson(string name, double annualIncome, int numberEmployees) 
    : base (name, annualIncome)
    {
        NumberEmployees = numberEmployees;
    }

    public override double Tax()
    {
        double tax = AnnualIncome * 0.16; 
        if(NumberEmployees >= 10)
        {
            tax = AnnualIncome * 0.14;
        }
        return tax;
    }

    public override string ToString()
    {
        return $"{Name}: {Tax().ToString("C")}";
    }
}
