using System;
using byte_Bank.Contas;

namespace byte_Bank.IMovimentacaoConta{

    public interface ITransferencia{

        //method:

        public bool Transferir(double valor, ContaCorrente favorecido);
    }
}