using System;

namespace exercícios_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2;
            nota1 = Convert.ToDouble(Console.ReadLine());
            nota2 = Convert.ToDouble(Console.ReadLine());
            double resultado = (nota1 + nota2) / 2;
            if (resultado == 10)
            {
                Console.WriteLine("aprovado com dinstinção");
            }
            else if (resultado > 7)
            {




                Console.WriteLine("aprovado");
            }



            else
            {
                Console.WriteLine("reprovado");
            }




        }

    }
}