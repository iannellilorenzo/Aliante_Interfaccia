﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Interfaccia
{
    public class Ala : IComponent
    {
        private double _lung;
        private double _aper;

        public double Lung
        {
            get { return _lung; }
            set
            {
                if (value >= 15F)
                    _lung = value;
                else
                    _lung = 15F;
            }
        }

        public double Aper
        {
            get { return _aper; }
            set
            {
                if (value * 2F >= Lung)
                    _aper = value;
                else
                    _aper = Lung * 2F;
            }
        }

        public Ala()
        {
            Lung = 0F;
            Aper = 0F;
        }

        public Ala(double lung, double aper)
        {
            Lung = lung;
            Aper = aper;
        }

        public Ala(Ala oldWing)
        {
            Lung = oldWing.Lung;
            Aper = oldWing.Aper;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Ala) || obj == null)
            {
                return false;
            }

            Ala other = (Ala)obj;
            return Lung == other.Lung && Aper == other.Aper;
        }

        public void Aggiunta(IComponent component)
        {

        }

        public void Rimuovi(int index)
        {
            
        }

        public IComponent GetChild(int index)
        {
            return null;
        }

        public override string ToString()
        {
            return $"Lunghezza ala: {Lung}; Apertura ala: {Aper}";
        }

        public double Prezzo()
        {
            return Lung * Aper;
        }
    }
}
