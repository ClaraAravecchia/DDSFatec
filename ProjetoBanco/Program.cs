using ProjetoBanco.Classes;
using System;

namespace ProjetoBanco
{
    class Program
    {
        static void Main()
        {            
            try
            {
                var ana = Cliente.CreateCliente("Ana", "Rua dos Alfeneiros número 4", 16999222999, "999.999.999-99", new DateTime(2000, 02, 17));
                var clara = Cliente.CreateCliente("Clara", "Rua dos Alfeneiros número 4", 16999456999, "999.999.999-99", new DateTime(1997, 11, 20));
                Console.WriteLine(ana.ToString());

                var contaPoupanca = new Poupanca(ana, 12345, 1000);
                var contaCorrente = new ContaCorrente(clara, 54321, 1000);

                //Console.WriteLine("Cliente: " + contaPoupanca.Cliente.Nome + " - Saldo: " + contaPoupanca.Saldo);
                //Console.WriteLine(contaPoupanca.Mensagem);

                //contaPoupanca.Depositar(1000);
                //Console.WriteLine("Cliente: " + contaPoupanca.Cliente.Nome + " - Saldo: " + contaPoupanca.Saldo);
                //Console.WriteLine(contaPoupanca.Mensagem);

                //contaPoupanca.Sacar(500);
                //Console.WriteLine("Cliente: " + contaPoupanca.Cliente.Nome + " - Saldo: " + contaPoupanca.Saldo);
                //Console.WriteLine(contaPoupanca.Mensagem);

                /// -------------------------------------

                //Console.WriteLine("Cliente: " + contaCorrente.Cliente.Nome + " - Saldo: " + contaCorrente.Saldo);

                //contaCorrente.Depositar(1000);
                //Console.WriteLine("Cliente: " + contaCorrente.Cliente.Nome + " - Saldo: " + contaCorrente.Saldo);
                //Console.WriteLine(contaCorrente.Mensagem);

                //contaPoupanca.Sacar(200);
                //Console.WriteLine("Cliente: " + contaCorrente.Cliente.Nome + " - Saldo: " + contaCorrente.Saldo);
                //Console.WriteLine(contaCorrente.Mensagem);

                Console.WriteLine("Cliente: " + contaCorrente.Cliente.Nome + " - Saldo: " + contaPoupanca.Saldo);
                Console.WriteLine("Cliente: " + contaPoupanca.Cliente.Nome + " - Saldo: " + contaPoupanca.Saldo);

                Console.WriteLine("----------------------------------------------------------------------------");

                contaPoupanca.Transferir(contaCorrente, 200);    // de ana pra clara
                Console.WriteLine("Cliente: " + contaCorrente.Cliente.Nome + " - Saldo: " + contaCorrente.Saldo);
                Console.WriteLine("Cliente: " + contaPoupanca.Cliente.Nome + " - Saldo: " + contaPoupanca.Saldo);
                Console.WriteLine(contaPoupanca.Mensagem);



            }            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }
    }
}