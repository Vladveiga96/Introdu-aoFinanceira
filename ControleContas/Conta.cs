using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas
{
    public class Conta

    {
        public Conta(long numero)
        {
            this.Numero = numero;
        }

        public Conta()
        {
            _numero = new Random().Next(1000000000,999999999);

        }
        public decimal _saldo;

        public decimal Saldo
        {
            get
            {
                return _saldo;
            }
            private set
            {
                _saldo = value;
            }

        }

        private long _numero;
        public long Numero
        {
            get
            {
                return _numero;
            }
            private set
            {
                _numero = value;
            }






        }
    }
}
