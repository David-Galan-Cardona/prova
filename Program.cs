using System;
/*
 * Autor: David Galán
 * Data: 11/12/2023
 * Exercici 23.Implementa un programa que retorni l'àrea per consola de les següents figures geomètriques:
 quadrat
 rectangle
 cercle
 pentàgon
 El programa haurà de demanar per teclat els valors necessaris.
 */
using System;
using System.Data.SqlTypes;

namespace activitats
{
    public class Exercici3
    {
        public static void Main(string[] args)
        {
            int choice = 0;
            double side = 0, otherSide = 0;
            const string Choice = "Quina forma vols calcular? \n 1.Quadrat \n 2.Rectangle \n 3.Cercle \n 4.Pentàgon", Square = "Digues el costat del quadrat",
                Rectangle = "Digues el primer costat", Rectangle2 = "Digues el segon costat", Sphere = "Digues el radi de la esfera", PentagonMsg = "Introdueix la base", Pentagon2 = "Introdueix l'apotema";

            Console.WriteLine(Choice);
            choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 1 && choice != 2 && choice != 3 && choice != 4)
            {
                Console.WriteLine(Choice);
                choice = Convert.ToInt32(Console.ReadLine());
            }

            if (choice == 1)
            {
                Console.WriteLine(Square);
                side = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Quadrat(side));
            }
            if (choice == 2)
            {
                Console.WriteLine(Rectangle);
                side = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Rectangle2);
                otherSide = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(RectangleMethod(side, otherSide));
            }
            if (choice == 3)
            {
                Console.WriteLine(Sphere);
                side = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Cercle(side));
            }
            if (choice == 4)
            {
                Console.WriteLine(PentagonMsg);
                side = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Pentagon2);
                otherSide = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Pentagon(side, otherSide));
            }
        }

        public static double Quadrat(double side)
        {
            return side * side;
        }

        public static double RectangleMethod(double side, double otherSide)
        {
            return side * otherSide;
        }
        public static double Cercle(double side)
        {
            return Math.PI * side * side;
        }
        public static double Pentagon(double side, double otherSide)
        {
            return side * 5 * otherSide / 2;
        }
    }
}