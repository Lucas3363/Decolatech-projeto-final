using System;

namespace Desafio.Decola.Tech
{
    public class Series : classebase
    {

        private Genero Genero {get; set;}

        private string nome {get; set;}

        private string descricao{get; set;}

        private int ano {get; set;}

        public Series(int chave , Genero Genero, string nome, string descricao, int ano)
        {

            this.chave = chave;
            this.Genero = Genero;
            this.nome = nome;
            this.descricao = descricao;
            this.ano = ano;

        }

        public override string ToString()
        {
            string retorno = "";

            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Nome: " + this.nome + Environment.NewLine;
            retorno += "Descricao: " + this.descricao + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.ano + Environment.NewLine;

            return retorno;
        }

        public string RetornaNome()
        {
            return this.nome;
        }
        
        public int RetornaChave()
        {
            return this.chave;
        }

    }
}