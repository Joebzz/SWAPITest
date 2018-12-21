using SWAPIHelper;
using SWAPIHelper.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KneatAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = NLog.LogManager.GetCurrentClassLogger(); // instatiate the logger
            try
            {
                var swAPIbaseUrl = ConfigurationManager.AppSettings["swAPIbaseUrl"]; // Get the base URL from the config file
                var apiCore = new Core(swAPIbaseUrl);
                Task<List<Starship>> allStarshipsTask = apiCore.GetAllStarships(); // Get all the starships from the API asynchronously

                Helper helper = new Helper(); // Create an instance of the helper class
                int? inputMGLT = helper.GetInput(); // Get the user input from the console
                while (inputMGLT.HasValue) // Continue running until the user enters q and the GetInput function returns null
                {
                    logger.Info("Input MGLT was " + inputMGLT);
                    Console.WriteLine("------------------------------");
                    allStarshipsTask.Wait(); // wait for the asynchronous api call to complete
                    foreach (var starship in allStarshipsTask.Result)
                    {
                        if (!string.IsNullOrEmpty(starship.MGLT) && starship.MGLT != "unknown") // only process starships with a MGLT set
                        {
                            var outputString = starship.name + ": " + helper.GetStopsRequired(inputMGLT.Value, starship.consumables, starship.MGLT);
                            Console.WriteLine(outputString);
                            logger.Info(outputString);
                        }
                    }

                    Console.WriteLine("##############################");
                    inputMGLT = helper.GetInput(); // Get the user input from the console
                }
            }
            catch (Exception e)
            {
                logger.Error(e);
            }
        }

    }
}
