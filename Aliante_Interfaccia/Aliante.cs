using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Interfaccia
{
    public class Aliante : IComponent
    {
        private List<IComponent> _components;

        public List<IComponent> IComponents
        {
            get { return _components; }
            set { _components = value; }
        }

        public Aliante()
        {
            IComponents = new List<IComponent>();
        }

        public Aliante(List<IComponent> components)
        {
            IComponents = components;
        }

        public Aliante(Aliante oldAliante)
        {
            IComponents = oldAliante.IComponents;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Aliante) || obj == null)
            {
                return false;
            }

            Aliante other = (Aliante)obj;
            if (IComponents.Count != other.IComponents.Count)
            {
                return false;
            }

            for (int i = 0; i < IComponents.Count; i++)
            {
                if (!IComponents[i].Equals(other.IComponents[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public void Aggiunta(IComponent component)
        {
            IComponents.Add(component);
        }

        public void Rimuovi(int index)
        {
            IComponents.RemoveAt(index);
        }

        public IComponent GetChild(int index)
        {
            if (IComponents.Count > index)
            {
                return IComponents[index];
            }

            return null;
        }

        public override string ToString()
        {
            string str = "";

            foreach (var component in IComponents)
            {
                str += component.ToString();
            }

            return str;
        }

        public double Prezzo()
        {
            double tot = 0;

            foreach (var component in IComponents)
            {
                tot += component.Prezzo();
            }

            return tot;
        }
    }
}
