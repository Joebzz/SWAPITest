using System;
using System.Collections.Generic;

namespace SWAPIHelper.Entities
{
    /// <summary>
    /// A Starship.
    /// </summary>
    public class Starship : SWEntity
    {
        /// <summary>
        /// The name of this starship. The common name, such as "Death Star".
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The model or official name of this starship. Such as "T-65 X-wing" or "DS-1 Orbital Battle Station".
        /// </summary>
        public string model { get; set; }

        /// <summary>
        /// The class of this starship, such as "Starfighter" or "Deep Space Mobile Battlestation"
        /// </summary>
        public string starship_class { get; set; }

        /// <summary>
        /// The manufacturer of this starship. Comma separated if more than one.
        /// </summary>
        public string manufacturer { get; set; }

        /// <summary>
        /// The cost of this starship new, in galactic credits.
        /// </summary>
        public string cost_in_credits { get; set; }

        /// <summary>
        /// The length of this starship in meters.
        /// </summary>
        public string length { get; set; }

        /// <summary>
        /// The number of personnel needed to run or pilot this starship.
        /// </summary>
        public string crew { get; set; }

        /// <summary>
        /// The number of non-essential people this starship can transport.
        /// </summary>
        public string passengers { get; set; }

        /// <summary>
        /// The maximum speed of this starship in the atmosphere. "N/A" if this starship is incapable of atmospheric flight.
        /// </summary>
        public string max_atmosphering_speed { get; set; }
                
        /// <summary>
        /// The class of this starships hyperdrive.
        /// </summary>
        public string hyperdrive_rating { get; set; }

        /// <summary>
        /// The Maximum number of Megalights this starship can travel in a standard hour.
        /// A "Megalight" is a standard unit of distance and has never been defined before within the Star Wars universe. 
        /// This figure is only really useful for measuring the difference in speed of starships. 
        /// We can assume it is similar to AU, the distance between our Sun (Sol) and Earth.
        /// </summary>
        public string MGLT { get; set; }

        /// <summary>
        /// The maximum number of kilograms that this starship can transport.
        /// </summary>
        public string cargo_capacity { get; set; }

        /// <summary>
        /// The maximum length of time that this starship can provide consumables for its entire crew without having to resupply.
        /// </summary>
        public string consumables { get; set; }

        /// <summary>
        /// An array of Film URL Resources that this starship has appeared in.
        /// </summary>
        public List<string> films { get; set; }

        /// <summary>
        /// An array of People URL Resources that this starship has been piloted by.
        /// </summary>
        public List<string> pilots { get; set; }
    }
}
