using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Modulo para manipulação de arquivos

namespace AprendendoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria um Arquivo que sempre se atualiza e deleta o anterior
            // StreamWriter escritor = new StreamWriter("teste.txt");

            //Adiciona texto a uma arquivo sem remover os anterioroes
            StreamWriter escritor = File.AppendText("Teste.txt");

            escritor.WriteLine("Nayuta");
            escritor.WriteLine("Beatriz");

            escritor.Close();


            // Ler arquivo de texto
            StreamReader leitor = new StreamReader("teste.txt");

            // string conteudo = leitor.ReadToEnd(); // ler todo o arquivo e salva em uma string

            string linha = "";
            while (linha != null)
            {
                linha = leitor.ReadLine();
                if (linha != null)
                {
                    Console.WriteLine(linha);
                }
            }


            Console.WriteLine("Arquivo Gerado");

            Console.ReadKey();
        }
    }
}
