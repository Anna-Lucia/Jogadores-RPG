using System;
using jogo.src.Entities;

class Program
{

    static void Main(string[] args)
    {
        Knight arus = new Knight("Arus", 42, "Knight", 469, 72);
        Wizard topapa = new Wizard ("Topapa", 42, "Black Wizard", 106, 611);
        Wizard jenica = new Wizard("Jenica", 42, "White Wizard", 325, 474);
        Ninja wedge = new Ninja("Wedge", 42, "Ninja", 292, 89);

        
        Console.WriteLine (arus);
        Console.WriteLine (jenica);
        Console.WriteLine (topapa);
        Console.Write (wedge);
    }
}
