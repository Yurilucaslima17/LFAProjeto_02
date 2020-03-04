using System;
using System.Collections.Generic;

namespace LFAProjeto02
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Simbolo> simbolos = new List<Simbolo>()
            {
                new Simbolo(){ Valor="A",Grau="i"},
                new Simbolo(){ Valor="B",Grau="i"},
                new Simbolo(){Valor="C", Grau="j"},
                new Simbolo(){Valor="E",Grau="k"},
            };
            List<Regra> regras = new List<Regra>()
            {
                new Regra(){Min = 0,Max = 5,sim = "i"},
                new Regra(){Min = 2, Max= 4, sim="j"},
                new Regra(){Min = 1,Max=4,sim="k"},
            };
            Linguagem.GerarLinguagem(simbolos,regras);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }


}
