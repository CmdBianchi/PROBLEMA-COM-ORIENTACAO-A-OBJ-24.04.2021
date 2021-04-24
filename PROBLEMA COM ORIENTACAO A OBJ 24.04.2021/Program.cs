using System;
namespace Problema_sem_orientação_a_objetos_24._04._2021{
   class Program{
        //-----> START / MAIN 
        ////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Msg();
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            Console.WriteLine("Digite os valores do TRIANGULO X | 1º valor lado A, 2º valor lado B, 3º valor lado C");
            x.A = double.Parse(Console.ReadLine()); x.B = double.Parse(Console.ReadLine()); x.C = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite os valores do TRIANGULO Y | 1º valor lado A, 2º valor lado B, 3º valor lado C");
            y.A = double.Parse(Console.ReadLine()); y.B = double.Parse(Console.ReadLine()); y.C = double.Parse(Console.ReadLine());         
            Console.WriteLine("A maior area é: " + EquationTriangleA(x.A, x.B, x.C, y.A, y.B, y.C).ToString("F2"));  
        }
        /// -------> FUNCTIONS
        //////////////////////////////////////////////////////////////////////////////////////////// 
        static void Msg(){
            Console.WriteLine("Calcular a área de dois triângulos a partir das medidas de seus lados a, b e c");
            Console.WriteLine("e dizer qual dos dois triângulospossui a maior área.");
            Console.WriteLine("");
        }
        //-----------------------------------------------------------------------------------------//
        static double EquationTriangleA(double xa, double xb, double xc, double ya, double yb, double yc){
            double px = (xa + xb + xc) / 2;
            double areax = Math.Sqrt(px * (px - xa) * (px - xb) * (px - xc));
            double py = (ya + yb + yc) / 2;
            double areay = Math.Sqrt(py * (py - ya) * (py - yb) * (py - yc));
            Console.Write("AREA TRIANGULO X: "+areax);
            Console.WriteLine("");
            Console.Write("AREA TRIANGULO y: " +areay);
            Console.WriteLine("");
            if ( areax > areay) {
                return areax;
            }
            else {
                return areay;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////
        //-----> END
   }
}

