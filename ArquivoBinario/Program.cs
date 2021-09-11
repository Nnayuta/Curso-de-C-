using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; //Modulo para trabalhar com formatador

namespace AprendendoArquivoBinario
{
    class Program
    {
        [System.Serializable]
        struct Produto
        {
            public string nome;
            public float preco;

            public Produto(string nome, float preco)
            {
                this.nome = nome;
                this.preco = preco;
            }
        }

        static void Main(string[] args)
        {
            List<string> langs = new List<string>();

            langs.Add("C#");
            langs.Add("JavaScript");
            langs.Add("PhP");

            FileStream stream = new FileStream("meuarquivo.nayuta", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            Produto Banana = new Produto("Banana", 1f);
            /*
             encoder.Serialize(stream, langs); // Como escrever
             encoder.Serialize(stream, Banana);
             */

            //Como ler uma lista em binario
            List<string> listaDoArquivo = (List<string>)encoder.Deserialize(stream);

            //Como ler um struc em binario
            Produto proud = (Produto)encoder.Deserialize(stream);

            /* É muito importante eu saber exatamente a 
             * ordem que as variaveis foram salvas dentro
             * de um arquivo binario para que ele seja 
             * descompilado corretamente e não ter nenhum erro */

            Console.WriteLine(listaDoArquivo[0]);
            Console.WriteLine(proud.nome);

            stream.Close();


            Console.ReadKey();


        }
    }
}
