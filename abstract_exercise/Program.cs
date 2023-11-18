using abstract_exercise.Entities;
using System.Collections.Generic;
using System.Globalization;

//Criar lista para armazenar dados
List<Payer> list = new List<Payer>();

//Captura variável para controle de repetições
Console.Write("Enter the number of tax payers: ");
int x = int.Parse(Console.ReadLine());


//Cria os objetos e armazena na lista
for (int i = 0; i < x; i++)
{
    Console.WriteLine($"Tax payer #{i+1} data:");
    Console.Write("Individual or company (i/c)? ");
    char ch = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double income = double.Parse(Console.ReadLine());


    //Testa o tipo do objeto
    if (ch == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new IndividualPayer(name, income, healthExpenditures));
    }
    else
    {
        Console.Write("Number of employees: ");
        int employeesNumber = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new CompanyPayer(name, income, employeesNumber));
    }
}


//Exibe os dados coletados
Console.WriteLine("");
Console.WriteLine("Taxes paid:");

foreach (Payer payer in list)
{
    Console.WriteLine(
        payer.Name
        + ": $"
        + payer.Taxes().ToString("F2", CultureInfo.InvariantCulture)
        );
}

//Exibe a soma de alguns dados coletados
double sum = 0.0;

foreach (Payer payer in list)
{
    sum += payer.Taxes();
}

Console.WriteLine("Total taxes: " + sum.ToString("F2", CultureInfo.InvariantCulture));