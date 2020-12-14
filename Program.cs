using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
           // Classes estáticas não podem ser instanciada

           // Em que momento usamos classes estáticas?
           // Quando precisarmos de uma solução que podem servir 
           // Para qualquer tipo de aplicação

           // Em que momento não usamos classes estaticas?
           // Quando tivermos objetos/classes que são especificadas de um tipo de aplicação

           Console.WriteLine ( Math. Pow(3,7));

            Console.WriteLine("Digite um valor :");
            Conversor.valorUsuario = float.Parse( Console.ReadLine() );

           Console.WriteLine (Conversor.ConverterEuroParaReal() );

           Console.WriteLine (Conversor.ConverterRealParaEuro() );

           // este método tbm tem que ser static na sua declaração
           Testar();
        }
        static void Testar(){

        }
    }
}
