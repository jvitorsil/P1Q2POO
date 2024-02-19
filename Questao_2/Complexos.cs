using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P1Questao2{
    class NumComplexos
    {
        double real;
        double im;

        public NumComplexos() { }
        public NumComplexos(double _real, double _im) {
            real = _real;
            im = _im;
        }

        public void setComplexos(double _real, double _im) {
            real = _real;
            im = _im;
        }

        public NumComplexos soma(NumComplexos comp2){
            double real3 = real + comp2.real;
            double im3 = im + comp2.im;

            return new NumComplexos(real3, im3);
        }

        public NumComplexos vezes(NumComplexos comp2){

            double real3 = (real*comp2.real) - (im*comp2.im);
            double im3 = (real*comp2.im) + (im*comp2.real);

            return new NumComplexos(real3, im3);
        }


        public double modulo(){
            double module = Math.Sqrt(Math.Pow(real, 2) + Math.Pow(im, 2));
            return module;
        }


        public double Argumento(){
            double module = Math.Sqrt(Math.Pow(real, 2) + Math.Pow(im, 2));
            double cos = real/module;
            double sen = im/module;
            double soma = cos + sen;

            return soma;
        }

        public void printComplexos(){
            Console.WriteLine(real + " " + im + "i");
        }

        public void printComplexosFormaPolar(){
            double module = Math.Sqrt(Math.Pow(real, 2) + Math.Pow(im, 2));
            double cos = real/module;
            double sen = im/module * Math.Sqrt(-1);

            Console.Write("p( " +cos + " + " + im + "i )");
        }

    }
}