using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema_bancario.Models;

namespace sistema_bancario.Services
{
    //camada de serviço
    // banco contém várias contas
    // vamos estabelecer a lógica que coorderna os objetos
    public class Banco
    {
        private readonly List<Conta> _contas = [];

        public void Adicionar (Conta conta)
        {
            _contas.Add(conta);
        }
    }

    public void ProcessarMovimentaçõoes()
        foreach (var Conta c in _contas)
        {
            try
            {
                c.Depositar(50);
                c.Sacar(120);
                Console.WriteLine(c.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            Console.WriteLine();
        }
}