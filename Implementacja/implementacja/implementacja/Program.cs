using System;

namespace implementacja
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Pracownik();
            p1.Wynagrodzenie = 100;
            p1.Nazwisko = " Szewczyk ";
            p1.DataZatrudnienia = new DateTime(2021, 10, 12);
            Console.WriteLine(p1);
        }
    }
}
