using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Classes
{ // agilidade, scrum, cloud computing
    public class Operacoes
    {

        public List<Conta> contas { get; set; }
        public int NumeroConta { get; set; }
        public Operacoes()
        {
            Console.WriteLine("Digite o número da conta: ");
            var numeroConta = int.Parse(Console.ReadLine());

            NumeroConta = numeroConta;
        }

        public Conta BuscaConta(int numeroConta)
        {
            return contas.Find(item => item.Numero == numeroConta);
        }

        public void EscolherOperacao(Conta conta)
        {

            Console.WriteLine("Digite o tipo de operação: ");
            Console.WriteLine("1- Saque\n2- Depósito\n3- Transferência");
            var operacao = int.Parse(Console.ReadLine());
            var valor = 0;
            int contaTransferir;
            switch (operacao)
            {
                case 1:
                    Console.WriteLine("Digite o valor: ");
                    valor = int.Parse(Console.ReadLine());
                    conta.Sacar(valor);
                    Console.WriteLine(conta.Mensagem);
                    break;
                case 2:
                    Console.WriteLine("Digite o valor: ");
                    valor = int.Parse(Console.ReadLine());
                    conta.Depositar(valor);
                    Console.WriteLine(conta.Mensagem);
                    break;
                case 3:
                    Console.WriteLine("Digite o valor: ");
                    valor = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a conta a receber a tranferência: ");
                    contaTransferir = int.Parse(Console.ReadLine());

                    conta.Transferir(BuscaConta(contaTransferir), valor);
                    Console.WriteLine(conta.MensagemTransferencia);
                    break;
            }
        }
    }
}
