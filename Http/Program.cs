using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Http
{
    class Program
    {
        enum Menu {ListaCompleta = 1 , Unico}
        static void Main(string[] args)
        {
            Console.WriteLine("Menu\n1- Lista completa \n2- Lista unica");
            int opt = int.Parse(Console.ReadLine());

            Menu menu = (Menu)opt;

            switch (menu)
            {
                case Menu.ListaCompleta:
                    ReqList();
                    break;

                case Menu.Unico:
                    ReqUnica();
                    break;
            }

            Console.ReadLine();

        }

        static void ReqList()
        {
            var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/");
            requisicao.Method = "GET";

            var resposta = requisicao.GetResponse();

            using (resposta)
            {

                var stream = resposta.GetResponseStream();
                StreamReader leitor = new StreamReader(stream);
                object dados = leitor.ReadToEnd();

                List<Tarefa> tarefas = JsonConvert.DeserializeObject<List<Tarefa>>(dados.ToString());

                foreach (Tarefa tarefa in tarefas)
                {
                    tarefa.Exibir();
                }

                stream.Close();
                resposta.Close();

            }
        }

        static void ReqUnica()
        {
            Console.WriteLine("Digite qual tarefa você deseja usar");
            int id = int.Parse(Console.ReadLine());

            var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/" + id);
            requisicao.Method = "GET";

            var resposta = requisicao.GetResponse();

            using (resposta)
            {

                var stream = resposta.GetResponseStream();
                StreamReader leitor = new StreamReader(stream);
                object dados = leitor.ReadToEnd();

                Tarefa tarefa = JsonConvert.DeserializeObject<Tarefa>(dados.ToString());

                tarefa.Exibir();

                stream.Close();
                resposta.Close();

            }
        }
    }
}
