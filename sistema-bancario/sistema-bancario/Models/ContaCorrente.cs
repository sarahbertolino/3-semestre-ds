namespace sistema_bancario.Models;

public class ContaCorrente : Conta
{
    private const decimal Limite = 200;
    
    
    public ContaCorrente(string titular, decimal saldoInicial) : base(titular, saldoInicial)
    {
    }

    public override void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor do saque precisa ser positivo.");
        }

        if (valor > Saldo + Limite)
        {
            throw new InvalidOperationException("Saldo e limite insuficientes.");
        }

        Saldo -= valor;
    }

    public override void Transferir(decimal valor)
    {
        
        
    }
}