using System.Globalization;
namespace abstract_exercise.Entities
{
	class CompanyPayer : Payer
	{
		public int EmployeesQuantity { get; set; }

        public CompanyPayer(string name, double income, int employeesQuantity) : base (name, income)
        {
            EmployeesQuantity = employeesQuantity;
        }


        public override double Taxes()
        {
            if (EmployeesQuantity >= 10)
            {
                return Income * 0.14;
            }
            else
            {
                return Income * 0.16;
            }
        }
    }
}

