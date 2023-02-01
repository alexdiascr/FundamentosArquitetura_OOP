using System;

namespace OOP
{
    public class Pessoa
    {
        //Propriedades - Estados
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        //Comportamento - Geração de nova informação através da própria classe. Pode também alterar o estado da classe
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
    }
}