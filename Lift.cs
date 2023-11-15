using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHotelLift
{
    internal class Lift
    {
        DateTime idopont;
        int kartyaSzam;
        int induloSzint;
        int celSzint;
        public Lift(string sor) 
        {
            string[] tomb = sor.Split(' ');
            this.idopont = DateTime.Parse(tomb[0]) /*Convert.ToDateTime(tomb[0])*/;
            this.kartyaSzam = Convert.ToInt32(tomb[1]);
            this.induloSzint = Convert.ToInt32(tomb[2]);
            this.celSzint = Convert.ToInt32(tomb[3]);
        }

        public DateTime Idopont { get => idopont; }
        public int KartyaSzam { get => kartyaSzam; }
        public int InduloSzint { get => induloSzint; }
        public int CelSzint { get => celSzint; }
    }
}
