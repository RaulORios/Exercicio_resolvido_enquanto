using System;
using System.Globalization;

namespace Exercicio_resolvido_enquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double soma = 0;
            int cont = 0;

            while (idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            if (cont == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double media = soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }                                 
            
        }
    }
}



