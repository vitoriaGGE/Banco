using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Banco
{
    internal class ContaBancaria
    {

        public int Conta;
        public string Titular;
        public double Saldo;

        public ContaBancaria(int conta, string titular) {
            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(int conta, string titular, double depositoInicial) : this (conta, titular) {
            Deposito(depositoInicial);
        }
        
        public void Deposito(double dinheiro) {
            Saldo += dinheiro;
        }

        public void Saque(double dinheiro) { 
            Saldo -= dinheiro;
            Saldo -= 5.0;
        }

        public override string ToString() {
            return "Conta: "
                + Conta
                + ", Titular: "
                + Titular
                + ", R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
