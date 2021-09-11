using System;
using System.Collections.Generic; //Modulo Necessario para usar uma lista
using System.Linq; // Modulo necessario para manipular lista
using System.Text;
using System.Threading.Tasks;

namespace AprendendoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> clientes = new List<string>();

            clientes.Add("Nayuta");
            clientes.Add("Beatriz");

            string pessoas = "José";

            clientes.Add(pessoas);

            foreach (string client in clientes)
            {
                Console.WriteLine(client);
            }
            Console.WriteLine("-===================-");

            // Remover com predicado // Essa forma e mais pesada por que ela passa por cada elemento da lista
            //  clientes.RemoveAll(clientee => clientee == "José");

            //Remover por id
            //clientes.RemoveAt(2);

            string busca = clientes.Find(Clienteee => Clienteee.Length < 5);
            // string.Lenght - Mostra o tamanho do texto da string
            Console.WriteLine(busca);

            Console.WriteLine("-===================-");

            //Busca Todos os dados dentro de uma lista

            List<string> filtrado = clientes.FindAll(Clienteee => Clienteee.Length <= 7);

            foreach (string client in filtrado)
            {
                Console.WriteLine(client);
            }

            Console.WriteLine("-===================-");

            Console.ReadKey();
        }
    }
}
