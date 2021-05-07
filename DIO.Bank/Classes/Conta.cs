namespace DIO.Bank
{
    public class Conta
    {
        private string Name 
        {
            get; set;
        }

        private double Credito 
        {
            get;
            set;
        }

        private double Saldo 
        {
            get;
            set;
        }

        private TipoConta TipoConta 
        {
            get;
            set;
        }

        public Conta(TipoConta tipoConta, double saldo, double credito, string name)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Name = name;
        }
    }
}