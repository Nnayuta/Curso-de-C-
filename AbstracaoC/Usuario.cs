using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoC
{
    class Usuario
    {
        public string nome;
        public string email;
        public string senha;

        //protected pode ser usado por classes filho
        //protected string teste;

        public Usuario(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        public void Logar()
        {
            Console.WriteLine("Logando....");
        }

        //virtual diz para o C# que o metodo pode ser sobescrito
        public virtual void Exibir()
        {
            Console.WriteLine($"Nome: {nome} \nEmail: {email} \nSenha: {senha}");
        }
    }
    //Herança a classe so pode ter um pai
    class Aluno : Usuario
    {
        public List<string> turmas = new List<string>();
        public string turno = "";

        //base pega a "informacao" da classe pai
        public Aluno(string turno, string nome, string email, string senha) : base(nome, email, senha)
        {
            this.turno = turno;
        }
        //override ele serve pra subescrever o metodo exibir da classe pai(usuario)
        public override void Exibir()
        {
            Console.WriteLine("Dados do Aluno: ");
            base.Exibir(); // Base.exibir(); e a classe pai
            Console.WriteLine($"Turno: {turno}");

        }
    }
}
