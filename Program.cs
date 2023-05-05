using System;

namespace NotaMedia
{
    class Program
    {
        static void Main()
        {
            double calculaNota;
            string nome, validaAprovacaoAluno, disciplina;

            Console.Write("Digite o Nome do Aluno(a): ");
            nome = Console.ReadLine()!;

            Console.Write("Digite a Disciplina do Aluno(a): ");
            disciplina = Console.ReadLine()!;

            Console.Write("Digite a primeira nota: ");
            double v1 = int.Parse(Console.ReadLine()!);
            Console.Write("Digite a segunda nota: ");
            double v2 = int.Parse(Console.ReadLine()!);
            Console.Write("Digite a terceira nota: ");
            double v3 = int.Parse(Console.ReadLine()!);

            NotaMedia nm = new NotaMedia(v1, v2, v3, nome, disciplina);

            calculaNota = nm.CalculaNota(v1, v2, v3);
            validaAprovacaoAluno = nm.ValidaAprovacaoAluno(nome, disciplina, calculaNota);

            Console.WriteLine(validaAprovacaoAluno);

        }


    }
}
