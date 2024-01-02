using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Interfaccia
{
    public class Coda : IComposite
    {
        private double _lung;

        public double Lung
        {
            get { return _lung; }
            set
            {
                if (value >= 7F && value <= 12F)
                    _lung = value;
                else
                    _lung = 8F;
            }
        }

        public Coda()
        {
            Lung = 0F;
        }

        public Coda(double lung)
        {
            Lung = lung;
        }

        public Coda(Coda oldCoda)
        {
            Lung = oldCoda.Lung;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Coda) || obj == null)
            {
                return false;
            }

            Coda other = (Coda)obj;
            return Lung == other.Lung;
        }

        public void Aggiunta(IComposite component)
        {

        }

        public void Rimuovi(int index)
        {
            
        }

        public IComposite GetChild(int index)
        {
            return null;
        }

        public override string ToString()
        {
            return $"Lunghezza coda: {Lung}";
        }

        public double Prezzo()
        {
            return Lung * 30;
        }
    }
}
