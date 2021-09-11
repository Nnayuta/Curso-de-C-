using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_estoque
{
    [System.Serializable]
    class ProdutoFisico : Produto, IEstoque
    {
        public float Frete;
        private int estoque;
        
        public ProdutoFisico(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.Frete = frete;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar Entrada do produto {nome}");
            Console.WriteLine("Digite a Qtd. Que você quer dar entrada: ");

            int entrada = int.Parse(Console.ReadLine());

            estoque += entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();

        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar Saida do produto {nome}");
            Console.WriteLine("Digite a Qtd. Que você quer dar baixa: ");

            int entrada = int.Parse(Console.ReadLine());

            estoque -= entrada;
            Console.WriteLine("saida registrada");
            Console.ReadLine();
        }
        enum Edit { nome= 1, preço, frete}
        public void Editar()
        {
            Console.WriteLine($"Editando Produto {nome}");

            Console.WriteLine("Oque você deseja editar no produto");
            Console.WriteLine("1-Nome\n2-Preco\n3-Frete");

            int opt = int.Parse(Console.ReadLine());
            Edit escolha = (Edit)opt;

            switch (escolha)
            {
                case Edit.nome:
                    editarNome();
                    break;
                case Edit.preço:
                    editarPreco();
                    break;
                case Edit.frete:
                    editarfrete();
                    break;
            }
        }

        void editarNome()
        {
            Console.WriteLine($"Digite o novo nome para o produto {nome}");
            string novoNome = Console.ReadLine();
            nome = novoNome;
            Console.WriteLine("Novo nome cadastrado com sucesso");
            Console.ReadLine();
        }
        void editarPreco()
        {
            Console.WriteLine($"Digite o novo preço para o produto {nome}");
            float novopreco = float.Parse(Console.ReadLine());
            preco = novopreco;
            Console.WriteLine("Novo preço cadastrado com sucesso");
            Console.ReadLine();
        }
        void editarfrete()
        {
            Console.WriteLine($"Digite o novo frete para o produto {nome}");
            float novofrete = float.Parse(Console.ReadLine());
            Frete = novofrete;
            Console.WriteLine("Novo frete cadastrado com sucesso");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine("Produto Fisico");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Frete: {Frete}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine("-===================-");
        }
    }
}
