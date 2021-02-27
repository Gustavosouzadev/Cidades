using System;

namespace cidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\\----------------------\\");
            Console.WriteLine("|Cidades do Litoral Sul|");
            Console.WriteLine("\\----------------------\\");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Peruíbe, \"No rio dos tubarões\"");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Itanhaém, \"Pedra que Canta\"");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Mongaguá, \"Aguá Pegajosa\"");
            Console.ResetColor();
        }
    }
}
