using ByteBankHerancaInterface.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankHerancaInterface
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        //o C# permite dois métodos com o mesmo nome, mas que recebem cargas diferentes
        //diferentes sobrecargas do método registrar
        //public void Registrar(Diretor diretor)
        //{
        //    _totalBonificacao += diretor.GetBonificacao();
        //}

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
