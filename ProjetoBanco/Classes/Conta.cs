using System;

namespace ProjetoBanco.Classes
{
    public abstract class Conta
    {
        public Conta(Cliente cliente, int numero, decimal saldo)
        {
            if (!cliente.EhMaiorIDade)
                throw new Exception("O cliente não possúi a idade mínima para criação da conta!");

            if (numero.ToString().Length > 5)
                throw new Exception("Número da conta inválido!");

            Cliente = cliente;
            Numero = numero;
            Saldo = saldo;
        }

        private decimal _saldo;

        public int Numero { get; private set; }

        public Cliente Cliente { get; private set; }
        public string Mensagem { get; protected set; }
        public string MensagemTransferencia { get; protected set; }

        public decimal Saldo
        {
            get { return _saldo; }
            protected set
            {
                if (value >= 0)
                    _saldo = value;
                else
                    _saldo = 0;
            }
        }

        abstract public bool Sacar(decimal valorSaque);
        abstract public bool Depositar(decimal valorDeposito);
        public bool Transferir(Conta destino, decimal valor)
        {
            if (valor <= 0m)
            {
                Mensagem = "Valor Inválido";
                return false;
            }
            if (valor > Saldo)
            {
                Mensagem = "Saldo Insuficiente";
                return false;
            }

            Saldo -= valor;
            MensagemTransferencia = $"Valor de {valor} transferido. Total: {Saldo}";
            destino.Depositar(valor);
            return true;
        }
    }
}