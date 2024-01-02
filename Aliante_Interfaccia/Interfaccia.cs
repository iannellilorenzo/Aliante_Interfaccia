using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Interfaccia
{
    interface IComposite
    {
        void Aggiunta(IComposite componente);

        void Rimuovi(int index);

        IComposite GetChild(int index);

        bool Equals(object obj);

        string ToString();

        double Prezzo();
    }
}
