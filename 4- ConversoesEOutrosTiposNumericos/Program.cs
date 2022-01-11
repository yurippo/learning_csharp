using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 4");

        double salario = 1200.50;

        //O int é um tipo de variavel que suporta valores ate 32 bits
        int salarioEmInteiro = (int)salario;

        Console.WriteLine(salarioEmInteiro);

        //O long é uma variavel de 64 bits
        long idade = 1300000000000;

        Console.WriteLine(idade);


        //O short é um tipode variavel de 16 bits
        short quantidadeProdutos = 15000;

        Console.WriteLine(quantidadeProdutos);


        //Quando for usar o float colocar um f apos o numero
        float altura = 1.80f;

        Console.WriteLine(altura);

        float pontoFlutuante = 3.14f;   // aqui!

        double salary = 1270.50;
        int valor = (int)salary;

        Console.WriteLine(valor);

        double valor1 = 0.2;
        double valor2 = 0.1;
        double total = valor1 + valor2;

        Console.WriteLine(total);



        Console.WriteLine("A execução acabou. Tecle enter para sair...");

        Console.ReadLine();




    }
}