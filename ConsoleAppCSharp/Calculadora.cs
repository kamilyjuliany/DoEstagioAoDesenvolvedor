using System;

namespace ConsoleAppCSharp
{
	public class Calculadora
	{
		public bool EhPar(object expressao)
		{
			var numero = Convert.ToInt32(expressao);
			var resto = numero % 2;

			if (resto == 0)
				return true;
			return false;
		}

		public decimal CalcularTotalJurosSimples(decimal valorDaParcela, decimal taxa)
		{
			return Math.Round((valorDaParcela * taxa) / 100.0M, decimals: 2);
		}

		public int CalcularMaximoDivisorComum(int[] numeros)
		{
			var maior = ConsultarMaiorNumeroExistente(numeros);
			var mdc = 0;

			for (int n = 1; n <= maior; n++)
			{
				var divisores = 0;

				for (int i = 0; i < numeros.Length; i++)
				{
					if (numeros[i] % n == 0)
						divisores++;
				}

				if (divisores == numeros.Length)
					mdc = n;
			}

			return mdc;
		}

		private int ConsultarMaiorNumeroExistente(int[] numeros)
		{
			var maior = numeros[0];
			for (int n = 1; n < numeros.Length; n++)
			{
				if (numeros[n] > maior)
					maior = numeros[n];
			}

			return maior;
		}

		public decimal CalcularValorMontanteComJurosCompostos(decimal parcela, decimal taxa, int meses)
		{
			var resultado = parcela * (decimal)Math.Pow((double)(1M + taxa / 100M), meses);

			return Math.Round(resultado, decimals: 2);

		}

	}
}
