﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace System_Pogoda___Projekt
{
    /// <summary>
    /// Klasa zawierająca obiekt opad śniegu
    /// Dziedzicząca po klasie Opad
    /// </summary>
    public class Opad_sniegu : Opad
    {
        [XmlIgnore] public double srednicaPlatkowSniegu;
        /// <summary>
        /// Konstruktor bazowy
        /// </summary>
        public Opad_sniegu() : base()
        {
            SrednicaPlatkowSniegu = 0;
        }
        /// <summary>
        /// Konstruktor parametryczny 
        /// </summary>
        public Opad_sniegu(string datar, string dataz, Skala_zagr zagrozenie, double iloscOpadowNa_M2, double srednicaPlatkowSniegu, Typ typ, decimal temp, double sredniecisnienieatm, double predkoscwiatru) : base(datar, dataz, zagrozenie, iloscOpadowNa_M2, typ, temp, sredniecisnienieatm, predkoscwiatru)
        {
            SrednicaPlatkowSniegu = srednicaPlatkowSniegu;
        }

        public double SrednicaPlatkowSniegu { get => srednicaPlatkowSniegu; set => srednicaPlatkowSniegu = value; }

        public override string ToString()
        {
            return "Opad śniegu: " + base.ToString() + ", Średnica płatków: " + SrednicaPlatkowSniegu + "mm";
        }
    }
}
