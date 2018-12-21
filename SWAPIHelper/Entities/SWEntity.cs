using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAPIHelper.Entities
{
    // abstract class to define the properties that would be shared amoung all entities returned from the SW API, only the starship is currently implemented.
    public abstract class SWEntity
    {
        /// <summary>
        /// the hypermedia URL of this resource.
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// the ISO 8601 date format of the time that this resource was created.
        /// </summary>
        public DateTime created { get; set; }

        /// <summary>
        /// the ISO 8601 date format of the time that this resource was edited.
        /// </summary>
        public DateTime edited { get; set; }
    }
}
