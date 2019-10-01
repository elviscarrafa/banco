using System;

namespace Banco
{
    public partial class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set; }
        public double valorFinal { get; protected set; }
        public double Tributo { get; protected set; }

        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public virtual void Saca(double valor)
        {
            this.Saldo -= valor;
           
        }
        public virtual void ValorFinal(double valor)
        {
            this.valorFinal += valor;


        }
        public virtual void CalculaTributo()
        {
            this.Tributo = Math.Sqrt(Saldo);
        }



    }
}