namespace sistema_bancario.Models;

public class ContaPoupanca : Conta
{

    public ContaPoupanca(string titular, decimal saldoInicial) : base(titular, saldoInicial)
    {
        
    }
public override bool Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Erro: O valor do saque deve ser maior que zero.");
                return false;
            }

            if (valor > Saldo)
            {
                Console.WriteLine("Erro: Saldo insuficiente");
                Saldo -= valor;
            }

            // Regra: Apenas o Saldo disponível
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"[Conta Poupança] Saque de R$ {valor:F2} realizado. Saldo atual: R$ {Saldo:F2}");
                return true;
            }

            Console.WriteLine("Erro: Saldo insuficiente na Conta Poupança.");
            return false;
        }
    public override void Transferir(decimal valor)
    {
    }
}