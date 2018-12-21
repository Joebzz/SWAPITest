using Refit;
using SWAPIHelper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAPIHelper
{
    /// <summary>
    /// Refit Interface
    /// </summary>
    interface ISWApi
    {
        // Get a single starship
        [Get("/starships/{starshipId}")]
        Task<SWEntityList<Starship>> GetStarship(string starshipId);

        // get all starships
        [Get("/starships/")]
        Task<SWEntityList<Starship>> GetStarships(int? page = null);
    }
}
