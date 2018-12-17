using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAPIHelper.Entities
{
    class SWEntityList<T> : ISWEntityList<T>
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
