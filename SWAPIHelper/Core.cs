using Refit;
using SWAPIHelper.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SWAPIHelper
{
    public class Core
    {
        /// <summary>
        /// The base URL for the API endpoints
        /// </summary>
        public string BaseUrl { get; set; }
        public Core(string baseUrl)
        {
            BaseUrl = baseUrl;
        }

        /// <summary>
        /// Gets all starships from API
        /// </summary>
        /// <returns></returns>
        public async Task<List<Starship>> GetAllStarships()
        {
            List<Starship> returnStarships = new List<Starship>();

            try
            {
                var swApi = RestService.For<ISWApi>(BaseUrl);

                int page = 1;
                while (true)
                {
                    var starships = await swApi.GetStarships(page);
                    returnStarships.AddRange(starships.results);

                    // Return when no next pages left
                    if (string.IsNullOrEmpty(starships.next))
                        break;
                    else
                        page++; // increment the page number
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return returnStarships;
        }
    }
}
