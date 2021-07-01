using System;
using System.Globalization;

namespace Conta_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cliente = new ContaBancaria();

            Console.Write(" Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            cliente.GetNumero(numeroConta);
           
            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();
            cliente.GetTitular(titularConta);

            Console.Write("Haverá depósito inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine());
            double saldo = 0.0;
            if (opcao == 's' )
            {
                Console.Write("Entre o valor de depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cliente.Deposito(saldo);
            }
            else
            {
                Console.WriteLine("Nenhum deposito informado! ");
            }
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(cliente);

            Console.WriteLine("Entre um valor para depósito: ");
            saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.Deposito(saldo);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cliente);
            
            Console.WriteLine("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cliente);


            Console.ReadLine();
        }
    }
}
