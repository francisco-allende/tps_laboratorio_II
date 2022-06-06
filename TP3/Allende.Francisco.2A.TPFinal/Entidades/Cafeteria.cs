using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cafeteria
    {
        private List<Cafe> listaCafes;

        public Cafeteria()
        {
            
        }

        public List<Cafe> ListaCafes { get => listaCafes; set => listaCafes = value; }
    }
}
