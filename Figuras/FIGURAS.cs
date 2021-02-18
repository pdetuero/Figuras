using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras
{
    class FIGURAS
    {
        double area = 0;
        double lado = 0;
        double ancho = 0;
        double radio = 0;

        public void areaCuadrado()
        {
            Console.WriteLine("Indica el lado: ");
            lado = Convert.ToDouble(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("El resultado del area es: " + area);
            Console.WriteLine(". . .");
            Console.WriteLine(".   .");
            Console.WriteLine(". . .");
        }
        public void areaRectangulo()
        {
            Console.WriteLine("Indica el largo: ");
            lado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Indica el ancho: ");
            lado = Convert.ToDouble(Console.ReadLine());
            area = lado * ancho;
            Console.WriteLine("El resultado del area es: " + area);
            Console.WriteLine(". . . .");
            Console.WriteLine(".     .");
            Console.WriteLine(". . . .");
        }
        public void areaCirculo()
        {
            Console.WriteLine("Indica el radio: ");
            radio = Convert.ToDouble(Console.ReadLine());
            area = Math.PI*Math.Pow(radio,2);
            Console.WriteLine("El resultado del area es: " + area);
            Console.WriteLine(" .  .");
            Console.WriteLine(".    .");
            Console.WriteLine(".    .");
            Console.WriteLine(" .  .");
        }
    }
}
