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
        YEAR = DAY * 365, // 365 days in a year, this does not take into account leap years.
        MONTH = DAY * 30, // this is an approximation as it does not state which month so the assumption is that a 'month' has 30 days
        WEEK = DAY * 7, // 7 days in a week
        DAY = 24
    }
}
