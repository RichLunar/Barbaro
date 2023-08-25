using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_coruja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Richard atividade Coruja");
            Console.ReadLine();

            Console.Write("\n atividade 1 ");
            Console.WriteLine();

            int n_gos = 0;

            Console.WriteLine("Digite qualquer número");
            n_gos = int.Parse(Console.ReadLine());

            Console.WriteLine("O sucessor é {0} e o anterios é {1}", n_gos + 1, n_gos - 1);
            Console.ReadLine();

            Console.Write("\nAtividade 2\n");
            Console.ReadLine();

            string s_nm = "";
            string s_end = "";
            string s_tel = "";

            Console.Write("nome: ");
            s_nm = Console.ReadLine();

            Console.Write("endereço: ");
            s_end = Console.ReadLine();

            Console.Write("telefone: ");
            s_tel = Console.ReadLine();

            Console.Write("{0},{1},{2}", s_nm, s_end, s_tel);
            Console.ReadLine();

            Console.Write("\n Atividade 3 \n");
            Console.ReadLine();

            int n_n1 = 0;
            int n_n2 = 0;

            Console.Write("Digite um número qualquer: ");
            n_n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número qualquer: ");
            n_n2 = int.Parse(Console.ReadLine());

            Console.Write(" o resultado da soma é {0} da subtração é {1} E da multiplicação é {2}. ", n_n1 + n_n2, n_n1 - n_n2, n_n1 * n_n2);
            Console.ReadLine();

            Console.WriteLine("\n Atividade 4 \n");
            Console.ReadLine();

            double d_peso = 0;
            double d_alt = 0;

            Console.Write("Digite seu peso: ");
            d_peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            d_alt = double.Parse(Console.ReadLine());

            Console.Write("O IMC é: {0:f}", d_peso / Math.Pow(d_alt, 2));
            Console.ReadLine();


        }
    }
}
