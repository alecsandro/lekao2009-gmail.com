using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //projet dll nao estarta tem que criar esse de console pra chamar os metodos.
            ProjetoMicropost_DLL.ClasseMetodos cl = new ProjetoMicropost_DLL.ClasseMetodos();           
            var lcRetorno = cl.metodo30parametrosFoxChama("VALOR1#valor2#valor3#");
            Console.WriteLine(lcRetorno);
            Console.ReadLine();
            
            //cl.RetornaTeste("13060705", "HomologacaoMP", "Dej6PFEcPiNGyHm1JK");

        }
    }
}
