using System;
using byte_Bank.Contas;

namespace byte_Bank.Titular{

    public class Cliente:ContaCorrente{
    
        public string Nome {get; private set;}
        public string Cpf {get; private set;}
        public string Profissao {get; private set;}
        
        public Cliente(string nome, string cpf, string profissao, string conta, int agencia, double saldo): base(conta,agencia,saldo){

            this.Nome = nome;
            this.Cpf = cpf;
            this.Profissao = profissao;

        }

    }
    
}