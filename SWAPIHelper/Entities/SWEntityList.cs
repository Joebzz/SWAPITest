using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAPIHelper.Entities
{
    // Use a generic class so that it can be used in future for other types of objects returned in a collection
    class SWEntityList<T> 
    {
        /// <summary>
        /// Total number of results
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// Next page API URL
        /// </summary>
        public string next { get; set; }

        /// <summary>
        /// Previous page API URL
        /// </summary>
        public string previous { get; set; }

        /// <summary>
        /// The list of results
        /// </summary>
        public List<T> results { get; set; }
    }
}
