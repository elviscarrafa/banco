using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public partial class ContaPoupanca : Conta
    {
        
        public override void Saca(double valor)
        {
            this.valorFinal -= valor;
            this.Saldo-=(valor-0.10);
            
        }

        public override void Deposita (double valor)
        {
            this.Saldo += (valor-0.20);
         
        }
        public override void ValorFinal(double valor)
        {
            this.valorFinal += valor;
            
        }

        
    }
}
