// See https://aka.ms/new-console-template for more information
using System;
using byte_Bank.Titular;

Cliente brenno = new Cliente("Edson brenno","082671","Desenvolvedor","49500-x",3091,500);
Cliente caio = new Cliente("Caio Alves","11111111111","Preguicoso","0501-x",3092,150);

brenno.Transferir(450,caio);

Console.WriteLine(caio.Saldo);
Console.WriteLine(brenno.Saldo);