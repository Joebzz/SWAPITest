using Refit;
using SWAPIHelper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAPIHelper
{
    interface ISWApi
    {
        [Get("/starships/{starship}")]
        Task<SWEntityList<Starship>> GetStarship(string starship);

        [Get("/starships/")]
        Task<SWEntityList<Starship>> GetStarships(int? page = null);
    }
}
