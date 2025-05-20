using Rechner;
using System;
namespace Rechner
{
    class Division
    {
        public void dividiere(double a, double b) {
            if (a == 0 && b == 0)
            {
                for (int j = 1; j < 36; j++)
                {
                    Console.Write("-");
                }

                Console.Write("\n\nNennen Sie mir eine erste Zahl: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nennen Sie mir eine zweite Zahl: ");
                b = Convert.ToDouble(Console.ReadLine());

            }
            
            decimal konv1 = (decimal)a;
            decimal konv2 = (decimal)b;

            try
            {
                decimal ergebnis = konv1 / konv2;
                if (ergebnis % 1 == 0)
                {
                    Console.WriteLine("Das Ergebnis ist: " + (int)ergebnis);
                }
                else
                {
                    Console.WriteLine("Das Ergebnis ist: " + ergebnis);
                }
                Console.WriteLine("Geben Sie 'x' ein, um das Programm zu beenden.\nUm weiter zu machen, drücken Sie einfach die Entertaste.");


                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.X:
                        Environment.Exit(0);
                        break;

                    case ConsoleKey.Enter:
                        for (int i = 5; i >= 1; i--)
                        {
                            Console.WriteLine("\n\nDas Programm startet neu in: " + i);
                            Thread.Sleep(500);
                            Console.Write("\n-");
                            for (int j = 1; j < 36; j++)
                            {
                                Console.Write("-");
                            }
                            Thread.Sleep(500);
                        }
                        for (int i = 0; i < 50; i++)
                        {
                            Console.WriteLine();
                        }
                        break;
                }
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Ich kann nicht durch 0 teilen!\nIch setze Ihre Eingaben auf 0, sodass Sie neue Eingaben für die Division eingeben können\n");
                a = 0;
                b = 0;
                dividiere(a, b);
            }

            


        }
    }
    class Subtraktion
    {
        public void subtrahiere(double a, double b)
        {

            decimal konv1 = (decimal)a;
            decimal konv2 = (decimal)b;


            decimal ergebnis = konv1 - konv2;

            if (ergebnis % 1 == 0)
            {
                Console.WriteLine("Das Ergebnis ist: " + (int)ergebnis);
            }
            else
            {
                Console.WriteLine("Das Ergebnis ist: " + ergebnis);
            }
            Console.WriteLine("Geben Sie 'x' ein, um das Programm zu beenden.\nUm weiter zu machen, drücken Sie einfach die Entertaste.");


            var input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.X:
                    Environment.Exit(0);
                    break;

                case ConsoleKey.Enter:
                    for (int i = 5; i >= 1; i--)
                    {
                        Console.WriteLine("\n\nDas Programm startet neu in: " + i);
                        Thread.Sleep(500);
                        Console.Write("\n-");
                        for (int j = 1; j < 36; j++)
                        {
                            Console.Write("-");
                        }
                        Thread.Sleep(500);
                    }
                    for (int i = 0; i < 50; i++)
                    {
                        Console.WriteLine();
                    }
                    break;


            }
        }
    }
    class Multiplikation
    {
        public void multipliziere(double a, double b) {
            double ergebnis = a * b;
            if (ergebnis % 1 == 0)
            {
                Console.WriteLine("Das Ergebnis ist: " + (int)ergebnis);
            }
            else
            {
                Console.WriteLine("Das Ergebnis ist: " + ergebnis);
            }
            Console.WriteLine("Geben Sie 'x' ein, um das Programm zu beenden.\nUm weiter zu machen, drücken Sie einfach die Entertaste.");


            var input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.X:
                    Environment.Exit(0);
                    break;

                case ConsoleKey.Enter:
                    for (int i = 5; i >= 1; i--)
                    {
                        Console.WriteLine("\n\nDas Programm startet neu in: " + i);
                        Thread.Sleep(500);
                        Console.Write("\n-");
                        for (int j = 1; j < 36; j++)
                        {
                            Console.Write("-");
                        }
                        Thread.Sleep(500);
                    }
                    for (int i = 0; i < 50; i++)
                    {
                        Console.WriteLine();
                    }
                    break;
            }
        }
    }

    class Addition
    {
        public void addiere(double a, double b) {
           double ergebnis = a + b;
            if (ergebnis % 1 == 0) {
                Console.WriteLine("Das Ergebnis ist: " + (int)ergebnis);
            }
            else
            {
                Console.WriteLine("Das Ergebnis ist: " + ergebnis);
            }
            Console.WriteLine("Geben Sie 'x' ein, um das Programm zu beenden.\nUm weiter zu machen, drücken Sie einfach die Entertaste.");
            
            
            var input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.X :
                    Environment.Exit(0);
                    break;

                case ConsoleKey.Enter:
                    for (int i = 5; i >= 1; i--)
                    {
                        Console.WriteLine("\n\nDas Programm startet neu in: " + i);
                        Thread.Sleep(500);
                        Console.Write("\n-");
                        for (int j = 1; j < 36; j++)
                        {
                            Console.Write("-");
                        }
                        Thread.Sleep(500);
                    }
                    for (int i = 0; i < 50; i++)
                    {
                        Console.WriteLine();
                    }
                    break;
            }
            
           
        }
        
    }
    class ausgabeHalloWelt
    {
    
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            char entscheidung;

            do
            {

                Console.Write("\n\nNennen Sie mir eine erste Zahl: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nennen Sie mir eine zweite Zahl: ");
                double b = Convert.ToDouble(Console.ReadLine());

                

                Console.WriteLine("\nWelche der Grundrechenoperationen wollen sie durchführen?\n");
                Console.WriteLine("Schreiben sie 'a' für Addition.");
                Console.WriteLine("Schreiben sie 's' für Subtraktion.");
                Console.WriteLine("Schreiben sie 'm' für Multiplikation.");
                Console.WriteLine("Schreiben sie 'd' für Division.\n");

                Console.WriteLine("Schreiben sie '0' um das Programm zu beenden. ");

                entscheidung = Console.ReadLine()[0];

                switch (entscheidung)
                {
                    case 'a':
                        Addition add = new Addition();
                        add.addiere(a, b);
                        break;

                    case 's':
                        Subtraktion sub = new Subtraktion();
                        sub.subtrahiere(a, b);
                        break;

                    case 'm':
                        Multiplikation mul = new Multiplikation();
                        mul.multipliziere(a, b);
                        break;

                    case 'd':
                        Division div = new Division();
                        div.dividiere(a, b);
                        break;

                    case '0':
                        return;
                }
            } while (entscheidung!= '0');
        }
    }
}










