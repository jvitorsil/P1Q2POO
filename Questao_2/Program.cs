
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P1Questao2{
    class Program
    {
        static void Main(string[] args)
        {
            NumComplexos complexos = new NumComplexos();
            NumComplexos complexos2 = new NumComplexos();

            Console.WriteLine("Informe os valores dos complexos abaixo, sem o i: ");
            Console.WriteLine("Exemplo: 1 5, onde 1 é real e o 5 é imaginario ");


            Console.Write("Primeiro grupo de complexos: ");
            string valor1 = Convert.ToString(Console.ReadLine());
            complexos.setComplexos(Convert.ToDouble(valor1.Split(' ')[0]), Convert.ToDouble(valor1.Split(' ')[1]));
            Console.WriteLine(" ");


            Console.Write("Segundo grupo de complexos: ");
            string valor2 = Convert.ToString(Console.ReadLine());
            complexos2.setComplexos(Convert.ToDouble(valor2.Split(' ')[0]), Convert.ToDouble(valor2.Split(' ')[1]));
            Console.WriteLine(" ");

            //Letra A
            Console.Write("Soma Número Complexos: ");
            NumComplexos somaComplexos = complexos.soma(complexos2);
            somaComplexos.printComplexos();
            Console.WriteLine(" ");

            //Letra B
            Console.Write("Multiplicação Número Complexos: ");
            NumComplexos vezesComplexos = complexos.vezes(complexos2);
            vezesComplexos.printComplexos();
            Console.WriteLine(" ");


            //Letra C
            Console.WriteLine("Modulo dos complexos grupo  1: " + complexos.modulo());
            Console.WriteLine(" ");


            //Letra D
            Console.WriteLine("Argumento dos complexos grupo  1: " + complexos.Argumento());
            Console.WriteLine(" ");

            //Letra E
            Console.WriteLine("Forma Polar dos numeros complexos: ");
            complexos.printComplexosFormaPolar();
            Console.WriteLine(" ");


            // Letra F
            NumComplexos com1 = new NumComplexos(1, 1);
            NumComplexos com2 = new NumComplexos(3, -1);

            Console.WriteLine("Soma dos números complexos: ");
            NumComplexos somaComs = com1.soma(com2);
            somaComs.printComplexosFormaPolar();
            Console.WriteLine(" ");


            Console.WriteLine("Multiplicação dos números complexos: ");
            NumComplexos vezesComs = com1.vezes(com2);
            vezesComs.printComplexosFormaPolar();
            Console.WriteLine(" ");
        }
    }
}