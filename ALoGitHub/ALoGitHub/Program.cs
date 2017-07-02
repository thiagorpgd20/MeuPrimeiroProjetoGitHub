using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoGitHub
{
    class Program
    {
        static void EscreveNaTela(String txt)
        {
            Console.WriteLine(txt);
        }
        static void EscreveNaTela2(String txt)
        {

            EscreveNaTela(txt);
        }
        static void Main(string[] args)
        {
            EscreveNaTela("Primeiro teste com o gitHub");
            Console.ReadKey();
        }
    }
}
