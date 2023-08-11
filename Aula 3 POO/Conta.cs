
public class Conta
{
    public string nomeTitular;
    public string agenciaTitular;
    public string contaTitular;
    public double saldoConta;

    public Conta(string nomeTitular, string agenciaTitular, string contaTitular, double saldoConta)
    {
        this.nomeTitular = nomeTitular;
        this.agenciaTitular = agenciaTitular;
        this.contaTitular = contaTitular;
        this.saldoConta = saldoConta;
    }

    public double Depositar(double valorDeposito)
    {
        if (valorDeposito > 0)
        {
            this.saldoConta += valorDeposito;
            return saldoConta;
        }
        else
        {
            Console.WriteLine("Valor inválido");
            return 0;
        }
    }
    public double Sacar(double valorSaque)
    {
        if(valorSaque <= this.saldoConta && valorSaque > 0)
        {
            this.saldoConta -= valorSaque;
            
        }
        else
        {
            Console.WriteLine("Saldo Insuficiente");
        }
        return this.saldoConta;
    }
}