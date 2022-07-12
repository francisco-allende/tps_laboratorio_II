using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Interfaces
{
    public interface ITabla
    {
        void PrintTabla();
        void AddToTabla();
        void RemoveFromTabla();
        void RefreshTabla();
        void ClearTabla();
    }
}
