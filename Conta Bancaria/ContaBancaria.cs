using System;
using System.Globalization;
namespace Conta_Bancaria
{
    class ContaBancaria
    {
        private int _numero;
        private string _titular;
        private double _saldo;

        public ContaBancaria()
        {

        }
     
        public void GetNumero(int numero)
        {
            _numero = numero;
        }
        public void GetTitular(string titular)
        {
            _titular = titular;
        }
        public void GetSaldo(double saldo)
        {
            _saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            _saldo = _saldo + quantia;
        }
               
        public void Saque(double quantia)
        {
            _saldo = _saldo - quantia - 5.0;

        }
        public override string ToString()
        {
            return "Conta "
                +_numero 
                + ", " 
                + "Titular: " 
                + _titular + ", " 
                + "Saldo: $ " 
                + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
