using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Interfaccia
{
    public class Aliante : IComposite
    {
        private List<IComposite> _components;

        public List<IComposite> IComposites
        {
            get { return _components; }
            set { _components = value; }
        }

        public Aliante()
        {
            IComposites = new List<IComposite>();
        }

        public Aliante(List<IComposite> components)
        {
            IComposites = components;
        }

        public Aliante(Aliante oldAliante)
        {
            IComposites = oldAliante.IComposites;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Aliante) || obj == null)
            {
                return false;
            }

            Aliante other = (Aliante)obj;
            if (IComposites.Count != other.IComposites.Count)
            {
                return false;
            }

            for (int i = 0; i < IComposites.Count; i++)
            {
                if (!IComposites[i].Equals(other.IComposites[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public void Aggiunta(IComposite component)
        {
            IComposites.Add(component);
        }

        public void Rimuovi(int index)
        {
            IComposites.RemoveAt(index);
        }

        public IComposite GetChild(int index)
        {
            if (IComposites.Count > index)
            {
                return IComposites[index];
            }

            return null;
        }

        public override string ToString()
        {
            string str = "";

            foreach (var component in IComposites)
            {
                str += component.ToString();
            }

            return str;
        }

        public double Prezzo()
        {
            double tot = 0;

            foreach (var component in IComposites)
            {
                tot += component.Prezzo();
            }

            return tot;
        }
    }
}
