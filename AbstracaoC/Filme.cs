using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoC
{
    class Filme
    {
        public string nome;
        public string desc;
        public int ano;
        public string studio;
        private List<string> Atores = new List<String>();

        //Construtor
        public Filme(string nome, string desc, int ano, string studio)
        {
            this.nome = nome;
            this.desc = desc;
            this.studio = studio;
            this.ano = ano;
            this.studio = studio;
        }

        public void Executar()
        {
            Console.WriteLine("Rodando filme: " + nome);
        }

        public void Pausar()
        {
            Console.WriteLine("||");
        }

        public void AddAtor(string ator)
        {
            if (ator != null)
            {
                Atores.Add(ator);
            }
        }
        public void ExibirAtor()
        {
            foreach(string ator in Atores)
            {
                Console.WriteLine("Nome do Ator: " + ator);
            }
        }
    }
}
