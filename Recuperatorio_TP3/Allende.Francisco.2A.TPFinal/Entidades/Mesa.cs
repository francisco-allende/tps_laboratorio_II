using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mesa
    {
        private int id;
        private bool estaLibre;

        public Mesa()
        {

        }

        public Mesa(int id, bool estaLibre)
        {
            this.id = id;
            this.estaLibre = estaLibre;
        }

        public int Id { get => id; set => id = value; }
        public bool EstaLibre { get => estaLibre; set => estaLibre = value; }

        public override string ToString()
        {
            return $"Id: {this.id}\nEsta libre {this.estaLibre}";
        }
    }
}
