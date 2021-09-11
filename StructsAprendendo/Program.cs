using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoStructs
{
    // Scruts é uma forma de criar um tipo customizavel dentro do C#

    class Program
    {
        struct Produto
        {
            public  string nome;
            public  float preco;
            public  float peso;
            public  string marca;

            public Produto(string nome, float preco, float peso, string marca)
            {
                this.nome = nome;
                this.preco = preco;
                this.peso = peso;
                this.marca = marca;

                NovoProduto();

            }

           public void ExibirInfo()
            {
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Preço: R$ {preco}");
                Console.WriteLine($"Peso: {peso} KG");
                Console.WriteLine($"Marca: {marca}");
            }

            public float AdicionarCupom(float porc)
            {
                float desconto = this.preco * porc / 100f; //Como calcular porcentagem de forma basica
                return this.preco - desconto;
            }

            public void NovoProduto()
            {
                Console.WriteLine("Novo produto criado");
            }
        }

        static void Main(string[] args)
        {
            Produto bola = new Produto("Bola Quadrada", 100f, 1f, "Nike");
            Produto balde = new Produto("Balde de Plastico", 200f, 0.1f, "????");


            bola.ExibirInfo();
            Console.WriteLine("==========================");
            balde.ExibirInfo();

            bola.AdicionarCupom(50f);
            balde.AdicionarCupom(50f);

            Console.ReadKey();
        }
    }
}
