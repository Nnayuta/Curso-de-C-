using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Gestor_de_Clientes
{
    class Program
    {
        [System.Serializable]
        struct Cliente
        {
            public string Nome;
            public string Email;
            public string CPF;
        }
        static List<Cliente> clientes = new List<Cliente>();

        enum menu { Listagem = 1, Adicionar = 2, Remover = 3, Sair = 4 }

        static void Main(string[] args)
        {
            Carregar();

            bool escolheuSair = false;

            while (!escolheuSair)
            {

                Console.WriteLine("Sistema de Clientes - Bem Vinda!");
                Console.WriteLine("1-Listagem\n2-Adicionar\n3-Remover\n4-Sair");

                int intOp = int.Parse(Console.ReadLine());

                menu opcao = (menu)intOp;

                switch (opcao)
                {
                    case menu.Adicionar:
                        Adicionar();
                        break;

                    case menu.Listagem:
                        Listagem();
                        break;

                    case menu.Remover:
                        Remover();
                        break;

                    case menu.Sair:
                        escolheuSair = true;
                        break;
                }
                Console.Clear();
            }

        }

        static void Adicionar()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Cadastro de Cliente: ");
            Console.WriteLine("Nome do cliente: ");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("Email do cliente");
            cliente.Email = Console.ReadLine();

            Console.WriteLine("CPF do cliente");
            cliente.CPF = Console.ReadLine();

            clientes.Add(cliente);
            Salvar();

            Console.WriteLine("Cadastro Concluido, Aperte enter para sair");
            Console.ReadKey();
        }

        static void Listagem()
        {
            if (clientes.Count > 0)
            {
                Console.WriteLine("Lista de clientes: ");
                int i = 0;
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine($"ID: {i}");
                    Console.WriteLine($"Nome: {cliente.Nome}");
                    Console.WriteLine($"E- mail: {cliente.Email}");
                    Console.WriteLine($"CPF: {cliente.CPF}");
                    i++;
                    Console.WriteLine("===========================");
                }

                Console.WriteLine("Aperte enter para sair");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado");
            }
        }

        static void Remover()
        {
            Listagem();
            Console.WriteLine("Digite o ID do cliente que você quer remover: ");
            int id = int.Parse(Console.ReadLine());

            if(id >= 0 && id < clientes.Count)
            {
                clientes.RemoveAt(id);
                Salvar();
            }
            else
            {
                Console.WriteLine("ID Invalido, Tente Novamente");
                Console.ReadKey();
            }

        }

        static void Salvar()
        {
            FileStream stream = new FileStream("Clients.clt", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, clientes);

            stream.Close();
        }

        static void Carregar()
        {
            FileStream stream = new FileStream("Clients.clt", FileMode.OpenOrCreate);
            try//tenta executar
            {
                BinaryFormatter encoder = new BinaryFormatter();

                clientes = (List<Cliente>)encoder.Deserialize(stream);

                if (clientes == null)
                {
                    clientes = new List<Cliente>();
                }
            }
            catch (Exception e)
            {
                clientes = new List<Cliente>();

                //caso acontecer algum erro ele ja cria uma nova lista para n receber nulo;
            }

            stream.Close();
        }

    }
}
