using System;
using byte_Bank.IMovimentacaoConta;

namespace byte_Bank.Contas{

    public class ContaCorrente:IDeposito,ISaque,ITransferencia{
        
        // Static:

        public static int TotalDeContasCriadas {get; private set;}
        public static double TaxaOperacao {get; private set;}

        //Propriedades:

        //Numero Agencia:
        private int numeroAgencia;

        public int NumeroAgencia{
            get {return numeroAgencia;}

            private set{

                if (value > 0){

                    this.numeroAgencia = value;
                }
            }
        }

        public string Conta{get; private set;}

        public double Saldo {get; private set;} 
        
        //Contructor:

        public ContaCorrente(string conta, int agencia, double saldo){

            this.Conta = conta;
            this.NumeroAgencia = agencia;
            this.Saldo = saldo;

            TotalDeContasCriadas++;


        }

        // Depositar
        public bool Depositar(double valor){
            
            if (valor > 0){

                this.Saldo += valor;

                return true;
            }
            else{

                return false;
            }
        }

        // Sacar:

        public bool Sacar(double valor){

            if (valor <= this.Saldo){

                this.Saldo -= valor;

                return true;
            }
            else{

                return false;
            }
        }

        // Transferir:

        public bool Transferir(double valor, ContaCorrente favorecido){

            if( valor <= this.Saldo ){

                this.Saldo -= valor;

                favorecido.Saldo += valor;

                return true;
            }
            else{

                return false;
            }
        }

    }
}