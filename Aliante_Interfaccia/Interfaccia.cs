using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Interfaccia
{
    public interface IComponent
    {
        void Aggiunta(IComponent componente);

        void Rimuovi(int index);

        IComponent GetChild(int index);

        bool Equals(object obj);

        string ToString();

        double Prezzo();
    }
}
