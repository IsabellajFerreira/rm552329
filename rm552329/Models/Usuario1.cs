﻿namespace rm552329.Models
{
    public class Usuario1
    {
        private string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public int Codigo { get; set; }

        public DateTime DataNascimento { get; set; }



        public void SetNome(string nome)
        {

            if (nome == "")

            {
                throw new ArgumentException("O nome está vazio");
            }

            //ArgumentNullException.ThrowIfNull(nome);
            Nome = nome;
        }

        public string GetNome()
        {
            return $"O nome do aluno é {Nome} ";
        }
    }
}
    