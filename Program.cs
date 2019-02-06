using System;
using System.Globalization;

namespace Veri_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal1, sal2, sal3, med;

            Console.WriteLine("digite o valor do salários: ");
            sal1 = double.Parse(Console.ReadLine());
            sal2 = double.Parse(Console.ReadLine());
            sal3 = double.Parse(Console.ReadLine());

            if (sal1 > sal2 && sal1 > sal3)
            {
                Console.WriteLine("O 1 salário é o maior!");
            }
            else if (sal2 > sal1 && sal2 > sal3)
            {
                Console.WriteLine("O 2 salário é o maior!");
            }
            else if (sal3 > sal1 && sal3 > sal2)
            {
                Console.WriteLine("O 3 salário é o maior!");
            }
            else
            {
                Console.WriteLine("salários iguais");
            }
            

            med = (sal1 + sal2 + sal3) / 3;
            Console.WriteLine("A média dos salários é: "+med.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey(true);
        }
    }
}
