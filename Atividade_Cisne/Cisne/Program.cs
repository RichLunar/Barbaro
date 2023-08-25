using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Cisne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Exercicios Richard :) ");
            Console.WriteLine();

            Console.WriteLine("\n exercicio 1 \n");
            Console.ReadLine();

            Console.Write("o primeiro numero é: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("o segundo numero é: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Double soma = n1 + n2;
            Console.WriteLine($"soma: {soma}");
            Console.ReadLine();
            Console.Write("Good Job!!!");
            Console.ReadLine();

            Console.WriteLine("\n Exercicio 2 \n");
            Console.ReadLine();

            Console.Write("o primeiro numero: ");
            double n_nmr = Convert.ToDouble(Console.ReadLine());
            double div = n_nmr / 3;
            Console.WriteLine($"terca parte do numero é {div}");
            Console.ReadLine();
            Console.Write("Good Job!!!");
            Console.WriteLine();


            Console.WriteLine("\n Exercicio 3 \n");

            int i_art = 0;
            int i_art2 = 0;

            Console.Write("digite o 1° valor ");
            i_art = int.Parse(Console.ReadLine());

            Console.Write("digite o 2° valor ");
            i_art2 = int.Parse(Console.ReadLine());

            Console.Write("média: {0}", i_art + i_art2 / 2);
            Console.WriteLine();



            Console.WriteLine("\n Exercicio 4 \n ");

            double d_sld = 0;

            Console.Write("Digite o saldo R$: ");
            d_sld = double.Parse(Console.ReadLine());

            Console.Write("o saldo reajustado é: {0:c}", d_sld * 1.01);
            Console.ReadLine();

            Console.WriteLine("\n Exercicio 5 \n ");

            double n_p1 = 0;
            double n_p2 = 0;
            double n_p3 = 0;
            double n_p4 = 0;



            Console.Write("primeira nota: ");
            n_p1 = double.Parse(Console.ReadLine());



            Console.Write("segunda nota: ");
            n_p2 = double.Parse(Console.ReadLine());



            Console.Write("terceira nota: ");
            n_p3 = double.Parse(Console.ReadLine());





            Console.Write("quarta nota: ");
            n_p4 = double.Parse(Console.ReadLine());



            Console.Write("média: {0}", (n_p1 + n_p2 + n_p3 + n_p4) / 4);
            Console.ReadLine();


















        }
    }
}
