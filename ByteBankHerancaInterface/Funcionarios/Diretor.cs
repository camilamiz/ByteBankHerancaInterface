using ByteBankHerancaInterface.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankHerancaInterface.Funcionarios
{
    //primeiro herda a classe e depois a interface
    //não existe herança múltipla em C#
    public class Diretor : FuncionarioAutenticavel
    {
        //necessário colocar desta maneira, pois estamos colocando o cpf como obrigatório no
        //construtor da classe base Funcionario
        //podemos presumir que todos os diretores começam com 5000
        public Diretor(string cpf) : base(5000, cpf)
        {
            //conseguimos ver que o construtor da classe base é chamado primeiro e depois o da classe filha
            Console.WriteLine("Criando DIRETOR");
        }

        public override void AumentarSalario()
        {
            //acessível por conta do protected em Funcionário
            //se usássemos private lá, o código não compilaria, pois Salario não estaria acessível para a clase Diretor
            Salario *= 1.15;
        }

        //override - preciso dizer que o método abaixo está sobrescrevendo o método da classe pai
        public override double GetBonificacao()
        {
            //chamando o GetBonificacao da classe Funcionario
            return Salario * 0.5;
        }
    }
}
