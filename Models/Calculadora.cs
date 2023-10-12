using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosNET.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            System.Console.WriteLine($"{x} + {y} = {x + y}");
        }

           public void Subtrair(int x, int y){
            System.Console.WriteLine($"{x} - {y} = {x - y}");
        }

           public void Multiplicar(int x, int y){
            System.Console.WriteLine($"{x} * {y} = {x * y}");
        }

           public void Dividir(int x, int y){
            System.Console.WriteLine($"{x} / {y} = {x / y}");
        }

          public void Potencia(int x, int y){
            var result = Math.Pow(x, y);
            System.Console.WriteLine($"{x}^{y} = {result}");
        }

         public void Seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            var result = Math.Sin(radiano);
            System.Console.WriteLine($"O Seno de {angulo}° = {Math.Round(result, 4)}");
        }

          public void Cosseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            var result = Math.Cos(radiano);
            System.Console.WriteLine($"O Cosseno de {angulo}° = {Math.Round(result, 4)}");
        }

          public void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            var result = Math.Tan(radiano);
            System.Console.WriteLine($"A Tangente de {angulo}° = {Math.Round(result, 4)}");
        }

        public void RaizQuadrada(double x){
            var result = Math.Sqrt(x);
            System.Console.WriteLine($"A Raiz quadrada de {x} = {result}");
        }
    }
}