using System;


namespace ConsoleAppCSharp
{
	internal class Program
	{

		static void Main(string[] args)
		{
			Console.WriteLine("Ola, seja bem vindo(a)!");

			Console.WriteLine("Informe o valor da parcela: ");
			string v = Console.ReadLine();


			Console.WriteLine("Informe o valor da taxa: ");
			string a = Console.ReadLine();

			Console.WriteLine("Informe a quantidade de meses: ");
			string b = Console.ReadLine();


			if (decimal.TryParse(v, result: out var parcela) && decimal.TryParse(a, result: out var taxa) && int.TryParse(b, result: out var meses))
			{
				var calculador = new Calculadora();

				var Juros = calculador.CalcularValorMontanteComJurosCompostos(parcela, taxa, meses);

				Console.WriteLine("O valor total é: " + Juros);

			}
			else
			{
				Console.WriteLine("Erro! Você digitou coisas que não são números!!!");
			}
			
		}

	}
}