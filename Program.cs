using System;

namespace Poyecto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int contador = 1;

                ProFiguras figuras = new ProFiguras();
                for (int i = 0; i < contador; i++)
                {

                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Calcula el área de una figura <S/N>");
                    string opcion = Console.ReadLine();
                    if (opcion.ToUpper() == "S")
                    {
                        contador++;
                        Console.WriteLine(" Elije una Figura: \t" +
                            "1 CUADRADO \t" + "2 CÍRCULO \t" + "3 RECTÁNGULO");
                        char figuraSeleccionada = Convert.ToChar(Console.ReadLine());

                        switch (figuraSeleccionada)
                        {
                            case '1': figuras.areaCuadrado(); break;
                            case '2': figuras.areaCirculo(); break;
                            case '3': figuras.areaRectángulo(); break;

                            default:
                                Console.WriteLine("Esa opción no está Disponible");
                                break;
                        }


                    }
                    else
                    {
                        Console.WriteLine("Gracias, enseguida se Cerrará la Aplicación");
                        Console.WriteLine("...3");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("..2");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(".1");
                        System.Threading.Thread.Sleep(1000);
                        Environment.Exit(0);
                        //return;

                    }
                    Console.ReadLine();

                }
               
               
            }
            catch (Exception x)
            {
                Console.WriteLine("SE HA DETECTADO UN ERROR: \t" + x.Message);
                Console.ReadLine();

            }

            



        }
    }
}
