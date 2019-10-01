namespace Banco
{
    public partial class ContaCorrente
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public ContaCorrente()
        {

        }
    }
}