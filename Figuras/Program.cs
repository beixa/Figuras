using System;
using System.Collections;
using System.Linq;

namespace Figuras
{
    public abstract class Figura
    {
        abstract public void Pintar();
    }
    public class Cuadrado : Figura
    {
        public override void Pintar() => Console.WriteLine("Cuadrado");
    }
    public class Triangulo : Figura
    {
        public override void Pintar() => Console.WriteLine("Triangulo");
    }
    public class Rectangulo : Cuadrado
    {
        public override void Pintar() => Console.WriteLine("Rectangulo");
    }
    public class Rombo : Cuadrado
    {
        public override void Pintar() => Console.WriteLine("Rombo");
    }
    class Principal
    {
        static void Main()
        {
            ArrayList figurasList = new ArrayList
            {
                new Triangulo(),
                new Rectangulo(),
                new Triangulo(),
                new Rectangulo(),
                new Rombo()
            };

            foreach (Cuadrado c in figurasList.OfType<Cuadrado>())
            {
                Console.Write("figuras de tipo cuadrado: ");
                c.Pintar();
            }                 
            foreach (Triangulo t in figurasList.OfType<Triangulo>())
            {
                Console.Write("figuras de tipo triangulo: ");
                t.Pintar();
            }
            
            Console.ReadLine();
        }
    }


}
