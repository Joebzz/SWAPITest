using System;
using System.Text.RegularExpressions;

namespace KneatAssignment
{
    public class Helper
    {

        /// <summary>
        /// Get the ammount of stops required for the provided input for the staraship
        /// </summary>
        /// <param name="input">The ammount of MGLT(mega lights) to use as the distance</param>
        /// <param name="consumables">The maximum length of time that this starship can provide consumables for its entire crew without having to resupply.</param>
        /// <param name="MGLT">The Maximum number of Megalights this starship can travel in a standard hour. A "Megalight" is a standard unit of distance and has never been defined before within the Star Wars universe. This figure is only really useful for measuring the difference in speed of starships. We can assume it is similar to AU, the distance between our Sun (Sol) and Earth.</param>
        /// <returns>The number of stops that are required for the starship</returns>
        public int GetStopsRequired(int input, string consumables, string MGLT)
        {
            int hours = 0, consumableValue = 0;

            var consumableValueString = Regex.Match(consumables, @"\d+").Value;
            if (int.TryParse(consumableValueString, out consumableValue))
            {
                if (consumables.Contains("year") || consumables.Contains("years"))
                    hours = CalculateHours(TimeEnum.YEAR, consumableValue);
                else if (consumables.Contains("month") || consumables.Contains("months"))
                    hours = CalculateHours(TimeEnum.MONTH, consumableValue);
                else if (consumables.Contains("week") || consumables.Contains("weeks"))
                    hours = CalculateHours(TimeEnum.WEEK, consumableValue);
                else if (consumables.Contains("day") || consumables.Contains("days"))
                    hours = CalculateHours(TimeEnum.DAY, consumableValue);
                else if (consumables.Contains("hour") || consumables.Contains("hours"))
                    hours = CalculateHours(TimeEnum.HOUR, consumableValue);
            }

            int mglt = 0;
            if (int.TryParse(MGLT, out mglt))
            {
                return (input / mglt) / hours;
            }
            else
            {
                Console.WriteLine("Error in parsing the MGLT");
                return -1;
            }
        }

        /// <summary>
        /// Calculates the number of hours based on the time type e.g. days, weeks or months
        /// </summary>
        /// <param name="timeType"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        int CalculateHours(TimeEnum timeType, int value)
        {
            switch (timeType)
            {
                case TimeEnum.YEAR:
                    return value * (int)TimeInHours.YEAR;
                case TimeEnum.MONTH:
                    return value * (int)TimeInHours.MONTH;
                case TimeEnum.WEEK:
                    return value * (int)TimeInHours.WEEK;
                case TimeEnum.DAY:
                    return value * (int)TimeInHours.DAY;
                case TimeEnum.HOUR:
                    return value;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Gets the user input from the console
        /// </summary>
        /// <returns></returns>
        public int GetInput()
        {
            int mgltInt;

            Console.WriteLine("Enter number of MGLT(mega lights) or enter 'q' to quit: ");
            var mgltInput = Console.ReadLine();

            while (mgltInput.Trim().ToLower() != "q")
            {
                if (!int.TryParse(mgltInput, out mgltInt))
                {
                    Console.WriteLine("Input is not a number. Try again or enter 'q' to quit: ");
                    mgltInput = Console.ReadLine();
                }
                else if (mgltInt < 0)
                {
                    Console.WriteLine("Input must be greather than 0! Try again or enter 'q' to quit: ");
                    mgltInput = Console.ReadLine();
                }
                else
                {
                    return mgltInt;
                }
            }
            return -1;
        }
    }
}
