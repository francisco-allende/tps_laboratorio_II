﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Interfaces
{
    public interface IEsConsumible
    {
        int Id { get; set; }
        double CantidadStock { get; set; }
    }
}
