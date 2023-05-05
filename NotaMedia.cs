using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotaMedia
{
    public class NotaMedia
    {
        public double V1 { get; private set; }
        public double V2 { get; private set; }
        public double V3 { get; private set; }
        public string Nome { get; private set; }
        public string Disciplina { get; private set; }

        public NotaMedia(double v1, double v2, double v3, string nome, string disciplina)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            Nome = nome;
            Disciplina = disciplina;
        }

        public double CalculaNota(double v1, double v2, double v3)
        {
            double result, notaArredondada;

            result = (v1 + v2 + v3) / 3;
            notaArredondada = Math.Round(result, 2);

            return notaArredondada;

        }

        public string ValidaAprovacaoAluno(string nome, string disciplina, double calculaNota)
        {
            string mensagem = "";
            string resultado;

            switch (calculaNota)
            {
                case > 60:
                    mensagem = $"Parabéns {nome}!!! Você foi aprovado(a) em {disciplina}!";
                    break;
                case 60:
                    mensagem = $"Parabéns {nome}!!! Você foi aprovado(a) em {disciplina}, porém na média, cuidado!";
                    break;
                case < 60:
                    mensagem = $"{nome}, infelizmente você foi reprovado(a) em {disciplina}!";
                    break;
            }

            resultado = $"{nome}, sua nota foi: {calculaNota}.";

            string texto = resultado + "\n" + mensagem;

            return texto;
        }

    }
}