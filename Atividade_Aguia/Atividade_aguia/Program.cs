using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Águia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Richard Atividades");
            Console.ReadLine();



            Console.WriteLine("\n Atividade 1 \n");
            Console.WriteLine();



            int nm_tb = 0;





            Console.Write("Digite qualquer numero e lhe mostrarei a tabuada do mesmo:");
            nm_tb = int.Parse(Console.ReadLine());





            Console.WriteLine("Tabuada do {0}", nm_tb);
            Console.WriteLine(" 1 x {0} = {1}", nm_tb, nm_tb * 1);
            Console.WriteLine(" 2 x {0} = {1}", nm_tb, nm_tb * 2);
            Console.WriteLine(" 3 x {0} = {1}", nm_tb, nm_tb * 3);
            Console.WriteLine(" 4 x {0} = {1}", nm_tb, nm_tb * 4);
            Console.WriteLine(" 5 x {0} = {1}", nm_tb, nm_tb * 5);
            Console.WriteLine(" 6 x {0} = {1}", nm_tb, nm_tb * 6);
            Console.WriteLine(" 7 x {0} = {1}", nm_tb, nm_tb * 7);
            Console.WriteLine(" 8 x {0} = {1}", nm_tb, nm_tb * 8);
            Console.WriteLine(" 9 x {0} = {1}", nm_tb, nm_tb * 9);
            Console.WriteLine("10 x {0} = {1}", nm_tb, nm_tb * 10);
            Console.ReadLine();





            Console.WriteLine("\n Atividade 2 \n");
            Console.WriteLine();



            Console.WriteLine("Atividade 2 : Valor de Lauda ");
            Console.ReadLine();



            Console.Clear();



            double ld_0 = 0;



            Console.WriteLine("Insira a quantidade de laudas:");
            ld_0 = double.Parse(Console.ReadLine());



            Console.Clear();



            Console.WriteLine("Sua quantidade de laudas é  de :{0}", ld_0);
            Console.WriteLine("O preço total é de :{0:c}", ld_0 * 50);
            Console.WriteLine("A quantidade de parcelas iguais de 3 partes será de:{0:c}", (ld_0 * 50) / 3);
            Console.ReadLine();



            Console.WriteLine("\n Atividade 3 \n");
            Console.WriteLine();



            string s_nm = "";



            Console.Write("digite seu nome: ");
            s_nm = Console.ReadLine();



            Console.Write("Bem Vindo");
            Console.ReadLine();



            Console.Write("Parabéns {0},\nTecle Enter para finalizar.", s_nm);
            Console.ReadLine();
        }
    }
}
