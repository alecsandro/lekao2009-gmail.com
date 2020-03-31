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

            

            ProjetoMicropost_DLL.ClasseMetodos cl = new ProjetoMicropost_DLL.ClasseMetodos();
            cl.iniciaProjeto();
            cl.RetornaTeste("13060705", "HomologacaoMP", "Dej6PFEcPiNGyHm1JK");

        }
    }
}
