using System;
using System.Globalization;
using Microsoft.VisualBasic;

namespace MembrosEstaticos
{
    class Estudos
    {
        static void Main(string[] args)
        {
            // tambem sao chamados de membros de classe, sao membros que fazem sentido sem depender de algum objeto(para serem chamados etc).. sendo chamados pelo nome da propria classe. Normalmente sao aplicados em classes utilitarias(classes que fornecem operacoes, Math.Sqrt()) e declaracoes constantes. Uma classe que possui somente membros estaticos, pode ser uma classe estatica tambem, que no caso, nao podera ser instanciada.

            double raio = 0;

            Console.WriteLine("Digite o valor de um raio:");
            raio = Convert.ToDouble(Console.ReadLine()!, CultureInfo.InvariantCulture);

            double resultado = Calculadora.Calculo(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}