using System;
using System.Collections.Generic;
using ConsoleAppCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleAppCSharpTests
{
	[TestClass]
	public class CalculadoraTest
	{
		[TestMethod]
		public void AoVerificarSeUmNumeroEhParDeveRetornarVerdadeiro()
		{
			// Causa/Cenário DEVE Efeito/Resultado

			var calculadora = new Calculadora();
			var par = calculadora.EhPar(2);
			if (par == false)
			{
				throw new Exception("O número dois é Par meu amigo!");

			}
		}

		[TestMethod]

		public void AoVerificarSeUmNumeroEhImparDeveRetornarFalso()
		{
			var calculadora = new Calculadora();
			var impar = calculadora.EhPar(3) == false;

			if (impar == false)
			{
				throw new Exception("O número três é ímpar meu amigo!");
			}
		}

		[TestMethod]

		public void AoVerificarSeUmTextoEhParDeveRetornarVerdadeiro()
		{
			var calculadora = new Calculadora();
			var par = calculadora.EhPar("123456");

			if (par == false)
			{
				throw new Exception("O número 123456 é Par meu amigo!");
			}
		}

		[TestMethod]

		public void AoCalcularJurosSimplesDeUmaParcelaDeveInformarValorCorreto()
		{
			var parcela = 562.3M;
			var taxa = 2.5M;

			var calculadora = new Calculadora();
			var totalDoJuros = calculadora.CalcularTotalJurosSimples(parcela, taxa);

			if (totalDoJuros != 14.06M)
			{
				throw new Exception("Favor calcular corretamente o valor do juros!");
			}

			parcela = 255.18M;
			taxa = 1.78M;

			totalDoJuros = calculadora.CalcularTotalJurosSimples(parcela, taxa);
			if (totalDoJuros != 4.54M)
			{
				throw new Exception("Favor calcular corretamente o valor do juros!");
			}
		}

		[TestMethod]
		public void AoCalcularOMaximoDivisorComumDeVariosNumerosDeveEncontrarOResultadoCorreto()
		{
			var numeros = new int[] { 21, 54, 69, 15, 27, 18 };
			var calculadora = new Calculadora();

			var mdc = calculadora.CalcularMaximoDivisorComum(numeros);


			if (mdc != 3)
			{
				throw new Exception("O MDC dos números [21, 54, 69, 15, 27, 18] deve ser 3, porem, foi encontrado " + mdc.ToString());
			}

			numeros = new int[] { 15, 15, 15, 30, 45, 60 };
			mdc = calculadora.CalcularMaximoDivisorComum(numeros);

			if (mdc != 15)
			{
				throw new Exception("O MDC dos números [ 15, 15, 15, 30, 45, 60 ] deve ser 15, porém, foi encontrado " + mdc.ToString());
			}
		}

		[TestMethod]
		public void AoCalcularJurosCompostosDeUmaParcelaDeveRetornarValorCorreto()
		{
			var calculadora = new Calculadora();
			var parcela = 562.3M;
			var taxa = 1.5M;
			var meses = 3;

			var montante = calculadora.CalcularValorMontanteComJurosCompostos(parcela, taxa, meses);

			if (montante != 587.98M)
			{
				throw new Exception("O valor da parcela não foi calculado corretamente: " + montante.ToString());
			}
		}
	}
}
