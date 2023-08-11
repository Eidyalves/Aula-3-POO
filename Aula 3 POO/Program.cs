List<Conta> contas = new List<Conta>();
while (true)
{
    Console.WriteLine("Digite 1 para cadastrar uma conta e 2 para listar todos");

    int controlador = Convert.ToInt32(Console.ReadLine());
    if (controlador == 1)
    {
        Console.WriteLine("Informe o nome, agencia, conta e o saldo");
        string titular = Console.ReadLine();
        string agencia = Console.ReadLine();
        string conta = Console.ReadLine();
        double saldo = Convert.ToDouble(Console.ReadLine());
        Conta c = new Conta(titular, agencia, conta, saldo);
        contas.Add(c);
    }else if (controlador == 2)
    {
        foreach (Conta conta in contas)
        {
            Console.WriteLine($"Titular: {conta.nomeTitular}, saldo: R$ {conta.saldoConta}");
        }
    }
    else
    {
        break;
    }
}