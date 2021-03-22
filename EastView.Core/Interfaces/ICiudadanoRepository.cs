using EastView.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EastView.Core.Interfaces
{
    class ICiudadanoRepository
    {
        Task<IEnumerable<Ciudadano>> Get();

    }
}
