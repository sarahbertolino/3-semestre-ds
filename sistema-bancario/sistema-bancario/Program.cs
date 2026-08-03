// See https://aka.ms/new-console-template for more information
using System;
using sistema_bancario.Models;
using sistema_bancario Services;
namespace SeuProjeto
{

    Banco banco = new();

    banco.Adicionar(NewsStyleUriParser Conta.Corrente("Samuel", 54000));
    banco.Adicionar(NewsStyleUriParser ContaPoupanca("Laura", 25000));

    banco.ProcessarMovimentaçõoes()
    // class Program
    // {
//         static void Main(string[] args)
//         {
//             Console.WriteLine(" BEM-VINDO AO SISTEMA BANCÁRIO ");

//             Console.Write("Insira o titular da conta: ");
//             string titular = Console.ReadLine();

//             Console.Write("Insira a senha da conta: ");
//             string senhaCadastrada = Console.ReadLine();

//             Console.WriteLine("\nQual tipo de conta você deseja acessar?");
//             Console.WriteLine("1]Conta Corrente");
//             Console.WriteLine("2]Conta Poupança");
            
//             Console.Write("Opção: ");
//             string tipoConta = Console.ReadLine();

//             Console.Write("Qual é o valor do seu saldo inicial? ");
//             decimal.TryParse(Console.ReadLine(), out decimal saldoInicial);

//             Conta conta;

//             // Instancia a conta de acordo com a opção escolhida
//             if (tipoConta == "1")
//             {
//                 Console.Write("Qual o valor do limite do cheque especial? R$ ");
//                 decimal.TryParse(Console.ReadLine(), out decimal limite);
//                 conta = new ContaCorrente(titular, saldoInicial, limite);
//             }
//             else
//             {
//                 conta = new ContaPoupanca(titular, saldoInicial);
//             }

//             bool continuar = true;

//             // 2. Loop do Menu Principal
//             while (continuar)
//             {
//                 Console.WriteLine("\n========================================");
//                 Console.WriteLine($"Titular: {conta.Titular} | Saldo Atual: R$ {conta.Saldo:F2}");
//                 Console.WriteLine("========================================");
//                 Console.WriteLine("O que você deseja fazer?");
//                 Console.WriteLine("1 - Depositar");
//                 Console.WriteLine("2 - Sacar");
//                 Console.WriteLine("3 - Sair");
//                 Console.Write("Escolha uma opção: ");
//                 string opcao = Console.ReadLine();

//                 if (opcao == "3")
//                 {
//                     Console.WriteLine("\nObrigado por utilizar nosso sistema. Até logo!");
//                     break;
//                 }

//                 if (opcao == "1" || opcao == "2")
//                 {
//                     // Validação da senha criada
//                     Console.Write("Insira sua senha para confirmar a operação: ");
//                     string senhaDigitada = Console.ReadLine();

//                     if (senhaDigitada != senhaCadastrada)
//                     {
//                         Console.WriteLine("❌ Senha incorreta! Operação cancelada.");
//                     }
//                     else
//                     {
//                         if (opcao == "1") // Depósito
//                         {
//                             Console.Write("Quanto você quer depositar? R$ ");
//                             if (decimal.TryParse(Console.ReadLine(), out decimal valorDeposito))
//                             {
//                                 conta.Depositar(valorDeposito);
//                             }
//                             else
//                             {
//                                 Console.WriteLine("❌ Valor inválido!");
//                             }
//                         }
//                         else if (opcao == "2") // Saque
//                         {
//                             Console.Write("Quanto você quer sacar? R$ ");
//                             if (decimal.TryParse(Console.ReadLine(), out decimal valorSaque))
//                             {
//                                 conta.Sacar(valorSaque);
//                             }
//                             else
//                             {
//                                 Console.WriteLine("❌ Valor inválido!");
//                             }
//                         }
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine("❌ Opção inválida!");
//                 }

//                 // 3. Pergunta se deseja continuar ou sair
//                 Console.Write("\nQuer continuar ou sair? (Digite 'C' para continuar ou 'S' para sair): ");
//                 string resposta = Console.ReadLine()?.Trim().ToUpper();

//                 if (resposta == "S" || resposta == "SAIR")
//                 {
//                     continuar = false;
//                     Console.WriteLine("\nSessão encerrada com sucesso. Até mais!");
//                 }
//             }
//         }
//     }
}