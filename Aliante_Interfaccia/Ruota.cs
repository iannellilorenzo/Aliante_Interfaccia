using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Interfaccia
{
    public class Ruota : IComponent
    {
        private List<IComponent> _ruote;

        public List<IComponent> Ruote
        {
            get { return _ruote; }
            set { _ruote = value; }
        }

        public Ruota()
        {
            Ruote = new List<IComponent>();
        }

        public Ruota(List<IComponent> ruote)
        {
            Ruote = ruote;
        }

        public Ruota(Ruota oldRuote)
        {
            Ruote = oldRuote.Ruote;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Ruota) || obj == null)
            {
                return false;
            }

            Ruota other = (Ruota)obj;

            for (int i = 0; i < Ruote.Count; i++)
            {
                if (!Ruote[i].Equals(other.Ruote[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public void Aggiunta(IComponent component)
        {
            Ruote.Add(component);
        }

        public void Rimuovi(int index)
        {
            Ruote.RemoveAt(index);
        }

        public IComponent GetChild(int index)
        {
            return null;
        }

        public override string ToString()
        {
            string str = "";

            foreach (var component in Ruote)
            {
                str += component.ToString();
            }

            return str;
        }

        public double Prezzo()
        {
            double tot = 0;

            foreach (var component in Ruote)
            {
                tot += component.Prezzo();
            }

            return tot;
        }
    }
}
