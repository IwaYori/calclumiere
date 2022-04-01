using System;

namespace Calculatrice_descartes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculatrice | Loi de Snell-Descartes";
            Console.WindowHeight =  40;
            
            int rec = 1;

            do
            {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nChoisissez la valeur cherchée :\n- n1 [Indice milieu 1]\n- n2 [Indice milieu 2]\n- i [Angle d'incidence]\n- r [Angle de réfraction]\n");

            string valCh = Convert.ToString(Console.ReadLine());
            
            if (valCh == "n1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nVeuillez entrer la valeur n2 [Indice milieu 2]");
                double n2 = Convert.ToDouble(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nVeuillez entrer la valeur r [Angle de réfraction]");
                double refr = Convert.ToDouble(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nVeuillez entrer la valeur i [Angle d'incidence]");
                double inci = Convert.ToDouble(Console.ReadLine());

                double dRefr = refr*((Math.PI) / 180);
                double dInci = inci*((Math.PI) / 180);
                double result = (n2 * Math.Sin(dRefr)) / Math.Sin(dInci);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nL'indice du milieu 1 est " + result);
            }

            if (valCh == "n2")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nVeuillez entrer la valeur n1 [Indice milieu 1]");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nVeuillez entrer la valeur i [Angle d'incidence]");
                double inci = Convert.ToDouble(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nVeuillez entrer la valeur r [Angle de réfraction]");
                double refr = Convert.ToDouble(Console.ReadLine());

                double dRefr = refr*((Math.PI) / 180);
                double dInci = inci*((Math.PI) / 180);
                double result = (n1 * Math.Sin(dInci)) / Math.Sin(dRefr);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nL'indice du milieu 2 est " + result);
            }

            if (valCh == "r")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nVeuillez entrer la valeur n1 [Indice milieu 1]");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nVeuillez entrer la valeur n2 [Indice milieu 2]");
                double n2 = Convert.ToDouble(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nVeuillez entrer la valeur i [Angle d'incidence]");
                double inci = Convert.ToDouble(Console.ReadLine());

                double dInci = inci*((Math.PI) / 180);
                double result = (Math.Asin((n1*n2)*Math.Sin(dInci)));
                double dResult = (result*180)/Math.PI;

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nL'angle de réfraction r est d'environ " + dResult + " degrès");
            }

            if (valCh == "i")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nVeuillez entrer la valeur n1 [Indice milieu 1]");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nVeuillez entrer la valeur n2 [Indice milieu 2]");
                double n2 = Convert.ToDouble(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nVeuillez entrer la valeur r [Angle de réfraction]");
                double refr = Convert.ToDouble(Console.ReadLine());

                double dRefr = refr*((Math.PI) / 180);
                double result = (Math.Asin((n1/n2)*Math.Sin(dRefr)));
                double dResult = (result*180)/Math.PI;

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nL'angle d'incidence i est d'environ " + dResult + " degrès");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEcrivez oui pour recommencer");
            if (Console.ReadLine() == "oui")
            {
                rec = 1;
            }

            }while(rec == 1);
            Console.ReadKey();

        }
    }
}
