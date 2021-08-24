using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankHerancaInterface.Funcionarios
{
    //significa que a classe funcionário não pode mais ser instanciada diretamente, pois é uma abstração
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        //o private faz com que o campo fique protegido para todas as outras classes, inclusive para as filhas
        //para habilitar para as filhas, que é o comportamento que queremos para Salario, usamos o protected

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            Salario = salario;
            CPF = cpf; //cpf obrigatório e alterável somente na classe funcionário
            //desse modo, em Program, eu preencho o cpf como parâmetro da classe na hora da criação

            TotalDeFuncionarios++;
        }

        //deste modo, quando criarmos uma classe filha, será obrigatório implementar os métodos com abstract
        public abstract void AumentarSalario();
        //{
        //    Salario *= 1.1;
        //}

        //convenção, pois existe um processamento, um cálculo
        //permitir que seja sobrescrito pela classe filha - virtual
        public abstract double GetBonificacao();
        //{
        //    return Salario * 0.10;
        //}
    }
}
