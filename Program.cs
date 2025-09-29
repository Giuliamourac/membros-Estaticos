using System;
using System.Globalization;
using Microsoft.VisualBasic;

namespace MembrosEstaticos
{
    class Estudos
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            // tambem sao chamados de membros de classe, sao membros que fazem sentido sem depender de algum objeto(para serem chamados etc).. sendo chamados pelo nome da propria classe. Normalmente sao aplicados em classes utilitarias(classes que fornecem operacoes, Math.Sqrt()) e declaracoes constantes. Uma classe que possui somente membros estaticos, pode ser uma classe estatica tambem, que no caso, nao podera ser instanciada.

            double raio = 0;

            Console.WriteLine("Digite o valor de um raio:");
            raio = Convert.ToDouble(Console.ReadLine()!, CultureInfo.InvariantCulture);

            double resultado = Calculo(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Calculo(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
        }
    }
}