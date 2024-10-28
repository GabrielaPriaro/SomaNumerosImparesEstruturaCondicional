//Obs: Utilizando Estrutura Condicional Para:
//Problema "soma_impares" (adaptado de URI 1071)
//Leia 2 valores inteiros X e Y (em qualquer ordem). A seguir, calcule e mostre a soma dos números impares entre eles. 

namespace SomaNumerosImparesEstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, troca, somaImpares;

            somaImpares = 0;

            Console.WriteLine("Digite dois numeros:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y) 
            {
                troca = x;
                x = y;
                y = troca;
            }

            for (int i = x + 1; i < y; i++)
            {
                if (i % 2 != 0)
                {
                    somaImpares = somaImpares + i;
                }
            }
            Console.WriteLine($"SOMA DOS IMPARES = {somaImpares}");
        }
    }
}
