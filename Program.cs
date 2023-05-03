using System;

namespace NotaMedia
{
	class Program
	{
		static void Main()
		{
			double v1, v2, v3, calculaNota;
			string nome, validaAprovacaoAluno;

			Console.Write("Digite o Nome do Aluno(a): ");
			nome = Console.ReadLine();

			Console.Write("Digite a primeira nota: ");
			v1 = int.Parse(Console.ReadLine());
			Console.Write("Digite a segunda nota: ");
			v2 = int.Parse(Console.ReadLine());
			Console.Write("Digite a terceira nota: ");
			v3 = int.Parse(Console.ReadLine());
			
			calculaNota = CalculaNota(v1, v2, v3);
			validaAprovacaoAluno = ValidaAprovacaoAluno(nome, calculaNota);

			Console.WriteLine(validaAprovacaoAluno);
			
		}

		static double CalculaNota(double v1, double v2, double v3)
		{
			double result, notaArredondada;

			result = (v1 + v2 + v3)/3;
			notaArredondada = Math.Round(result, 2);

			return notaArredondada;
			
		}

		static string ValidaAprovacaoAluno(string nome, double calculaNota)
		{
			string mensagem = "";
			string resultado;

			switch(calculaNota)
			{
				case > 60:
					mensagem = $"Parabéns {nome}!!! Você foi aprovado(a)!";
					break;
				case 60:
					mensagem = $"Parabéns {nome}!!! Você foi aprovado(a), porém na média, cuidado!";
					break;
				case < 60:
					mensagem = $"{nome}, infelizmente você foi reprovado(a)!";
					break;
			}

			resultado = $"{nome}, sua nota foi: {calculaNota}.";

			string texto = resultado + "\n" + mensagem;

			return texto;
		}
	}
}
