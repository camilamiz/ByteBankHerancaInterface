using ByteBankHerancaInterface.Funcionarios;
using ByteBankHerancaInterface.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankHerancaInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            //Funcionario carlos = new Funcionario(2000, "546.879.157-20");
            //carlos.Nome = "Carlos";

            //carlos.AumentarSalario();
            //Console.WriteLine("Novo salário de carlos " + carlos.Salario);

            //gerenciador.Registrar(carlos);
            //Console.WriteLine(Funcionario.TotalDeFuncionarios);

            //Diretor roberta = new Diretor("454.658.148-3");
            //roberta.Nome = "Roberta";

            //Console.WriteLine(Funcionario.TotalDeFuncionarios);
            //Funcionario robertaTeste = roberta;

            //roberta.AumentarSalario();
            //Console.WriteLine("Novo salário de roberta " + roberta.Salario);

            //Console.WriteLine("Bonificação de uma referência de Diretor: " + roberta.GetBonificacao());
            ////sem o override fica 500 e com fica 5000 a bonificação abaixo
            //Console.WriteLine("Bonificação de uma referência de Funcionario: " + robertaTeste.GetBonificacao());

            //gerenciador.Registrar(roberta);

            //Console.WriteLine(carlos.Nome);
            //Console.WriteLine(carlos.GetBonificacao());

            //Console.WriteLine(roberta.Nome);
            //Console.WriteLine(roberta.GetBonificacao());

            //Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            //CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            //podemos criar conforme abaixo também
            //Funcionario pedro2 = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("833.222.049-39");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("833.222.050-39");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("833.222.100-39");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("833.222.110-39");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine("Total de bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao());
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("833.222.049-39");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("833.222.100-39");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
            sistemaInterno.Logar(parceiro, "123456");
        }
    }
}
