using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_CadastroUsuarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DataBase dataBase = new DataBase();
           GraphicInterface myProgram = new GraphicInterface(dataBase);
           myProgram.RunInterface();
        }
    }
}
