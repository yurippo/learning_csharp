﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto A condicional if");

        Console.WriteLine("testando condicionais");

        int idade = 20;
        int quantidadePessoas = 3;

        if (idade >= 18)
        {
            Console.WriteLine("Você tem mais que 18 anos");

            Console.WriteLine("Seja bem vindo");
        }
        else
        {
            if (quantidadePessoas >= 2)
            {
                Console.WriteLine("voce nao tem 18, mas pode entrar,"
                    + "pois está acompanhado");
            }
            else
            {
                Console.WriteLine("infelizmente voce nao pode entrar");
            }


            Console.WriteLine("A execução acabou. Tecle enter para sair...");

            Console.ReadLine();

        }

    }
}
