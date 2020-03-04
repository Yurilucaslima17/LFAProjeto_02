using System;
using System.Collections.Generic;
using System.Text;

namespace LFAProjeto02
{
    static public class Linguagem
    {
        static public List<string> GerarLinguagem(List<Simbolo> simbolos, List<Regra> regras)
        {
            List<string> ret = null;
            bool flag = true;
            try
            {
                ret = new List<string>();
                while (flag)
                {
                    string aux = "";
                    foreach (Regra item in regras)
                    {

                        foreach (Simbolo sim in simbolos)
                        {
                            if (sim.Grau == item.sim)
                                for(int j = 0; j<item.Min+1;j++)
                                    aux += sim.Valor;
                        }

                    }
                    ret.Add(aux);
                    Console.WriteLine(aux);
                    flag = Verifica(regras);
                    
                    //if (flag)
                    //{
                    //    for(int i = 0; i > regras.Count; i--)
                    //    {
                    //        if(regras[i].Min +1 >= regras[i].Max)

                    //    }
                    //}
                    aux = "";
                    //item.Min = item.Min + 1;


                }
            }
            catch (Exception)
            {

                throw;
            }

            return ret;
        }
        static public string Permuta(Simbolo sim, Regra regra)
        {
            string ret = null;


            return ret;
        }
        static public bool Verifica(List<Regra> regras)
        {
            int count = 0;
            foreach (Regra item in regras)
            {
                if (item.Min + 1 >= item.Max)
                    count++;
            }

            return count < regras.Count ? true : false;
        }
    }
}
