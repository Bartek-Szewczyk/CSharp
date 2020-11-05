using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace implementacja
{
    class Pracownik
    {
        public string Nazwisko { get; set; }

        public DateTime _dz;

        public DateTime DataZatrudnienia
        {
            get;
            set;
        }

        private decimal _wyn;
        public decimal Wynagrodzenie
        {
            get => _wyn;
            set => _wyn = (value < 0) ? 0 : value;
        }

        public override string ToString() => $"({Nazwisko.Trim()}, {DataZatrudnienia:d MMM yyyy}, {Wynagrodzenie} PLN)";
 
    }
   
}
