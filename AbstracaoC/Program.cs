using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoC
{
    class Program
    {

        //uma funcao com static pode ser acessada de qualquer local pela sua classe
        static void Main(string[] args)
        {


            Aluno a = new Aluno("matutino", "Aluno", "email@emaail.com", "123456789");

            a.Exibir();

            Console.WriteLine("=========================================================");

            Filme b = new Filme("Super Heroi", "Os Herois do mundo", 2067, "Disney");

            b.Executar();

            Console.ReadKey();
        }
    }
}
