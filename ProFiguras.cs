using System;
using System.Collections.Generic;
using System.Text;

namespace Poyecto_2
{
    internal class ProFiguras
    {
        double lado = 0;
        double radio = 0;
        double altura = 0;
        double area = 0;



        internal void areaCuadrado()
        {

            Console.WriteLine("Ingresa el valor del lado del CUADRADO:");
            lado = Convert.ToDouble(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("El área del cuadrado es:" + area);

        }
        internal void areaCirculo()
        {

            Console.WriteLine("Ingresa el valor del radio del CÍRCULO:");
            radio = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine("El radio del círculo es:" + area);

        }

        internal void areaRectángulo()
        {

            Console.WriteLine("Ingresa el valor de la base del RECTÁNGULO:");
            lado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de la altura del RECTÁNGULO:");
            altura = Convert.ToDouble(Console.ReadLine());
            area = lado * altura;
            Console.WriteLine("El área del rectángulo es:" + area);

        }
    }


}
