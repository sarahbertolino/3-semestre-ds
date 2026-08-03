namespace sistema_bancario.Models;

public abstract class Conta
{
    // Propriedades - Titular e Saldo
    
    // Encapsulamento
    
    // Propriedades
    public required string Titular { get; set; }
    public decimal Saldo { get; protected set; }

    // Método Construtor
    protected Conta(string titular, decimal saldo)
    {
        Titular = titular;
        Saldo = saldo;
    }
    
    // Metódos
public virtual bool Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso.");
                return true;
            }
            Console.WriteLine("Erro: O valor do depósito deve ser maior que zero.");
            return false;
        }

    public virtual void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor do saque precisa ser positivo.");
        }

        if (valor > Saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }

        Saldo -= valor;
    }

    public abstract void Transferir(decimal valor);

    if (contaDestino == null)
        {
            Console.WriteLine("Erro: Conta de destino inválida.");
            return false;
        }

        // Tenta sacar da conta de origem (reaproveita as regras de Sacar)
        if (this.Sacar(valor))
        {
            // Se o saque deu certo, deposita na conta de destino
            contaDestino.Depositar(valor);
            Console.WriteLine($"✅ Transferência de R$ {valor:F2} para {contaDestino.Titular} concluída com sucesso!");
            return true;
        }

        Console.WriteLine("❌ Falha na transferência: Saldo/limite insuficiente.");
        return false;
}