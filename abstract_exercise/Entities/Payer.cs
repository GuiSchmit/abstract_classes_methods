using System;
namespace abstract_exercise.Entities
{
    abstract class Payer
    {
        public string Name { get; set; }
        public double Income { get; set; }

        protected Payer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Taxes();
        

    }
		
}

