using System;
namespace abstract_exercise.Entities
{
	class IndividualPayer : Payer
	{
		public double HealthExpenditures { get; set; }

        public IndividualPayer(string name, double income, double healthExpenditures) : base(name, income)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            

            if (Income < 20000.00)
            {
                return (Income * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (Income * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}

