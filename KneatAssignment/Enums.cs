using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KneatAssignment
{
    /// <summary>
    /// Enumeration for the time types
    /// </summary>
    public enum TimeEnum
    {
        YEAR,
        MONTH,
        WEEK,
        DAY,
        HOUR
    }

    /// <summary>
    /// Enum for ammount of hours each time type has
    /// </summary>
    public enum TimeInHours
    {
        YEAR = 8760,
        MONTH = 720,
        WEEK = 168,
        DAY = 24
    }
}
