using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CuentaBancaria.Clases
{
    public class CuentaBancaria
    {
        private short numCuenta;

        private string titular;

        private short saldo;

        private short numero;

        private short pin;

        public CuentaBancaria(short _numCuenta, string _titular, short _saldo, short _numero, short _pin)
        {
            this.numCuenta = _numCuenta;
            this.titular = _titular;
            this.saldo = _saldo;
            this.numero = _numero;
            this.pin = _pin;
        }

        public void SetnumCuenta(short valornumCuenta)
        {
            this.numCuenta = valornumCuenta;
        }

        public short GetnumCuenta()
        {
            return this.numCuenta;
        }

        public void Settitualr(string valortitular)
        {
            this.titular = valortitular;
        }

        public string Gettitular()
        {
            return this.titular;
        }

        public void Setsaldo(short valorsaldo)
        {
            this.saldo= valorsaldo;
        }

        public short Getsaldo()
        {
            return this.saldo;
        }
        public void Setnumero(short valornumero)
        {
            this.numero = valornumero;
        }
        public short Getnumero()
        {

            return this.numero;
        }
        public void Setpin(short valorpin)
        {
            this.pin = valorpin;
        }
        public short Getpin()
        {
            return this.pin;
        }


    }

}
