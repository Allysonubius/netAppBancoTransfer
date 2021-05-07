using System;
namespace DIO.Bank
{
    public class Conta
    {
        private string Name {get;set;}
        private double Credito {get;set;}
        private double Saldo {get;set;}
        private TipoConta TipoConta {get;set;}
        public Conta(TipoConta tipoConta, double saldo, double credito, string name)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Name = name;
        }
        public bool Sacar(double valorSaque)
        {
            if (this.Saldo - valorSaque < (this.Credito * -1)) // Validação de saque com saldo insuficiente.
            {
                Console.WriteLine("Saldo insuficiente !");
                return false;
            }
            this.Saldo -= valorSaque; // this.Saldo = this.Saldo + valorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é {1}",this.Name, this.Saldo); // https://docs.microsoft.com/pt-br/dotnet/standard/base-types/composite-formatting
            return true;
        }
        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito; // this.Saldo = this.Saldo + valorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} é {1}",this.Name,this.Saldo); // https://docs.microsoft.com/pt-br/dotnet/standard/base-types/composite-formatting
        }
        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if(this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Tipo conta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Name + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Credito " + this.Credito + " | "; 
            return retorno; 
        }
    }
}