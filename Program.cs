using System;

namespace cidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\\----------------------\\");
            Console.WriteLine("|Cidades do Litoral Sul|");
            Console.WriteLine("\\----------------------\\");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Peruíbe, \"No rio de tubarões\"");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Itanhaém, \"Pedra que Canta\"");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Mongaguá, \"Aguá Pegajosa\"");
            Console.ResetColor();
            Console.Beep();
        }
    }
}
