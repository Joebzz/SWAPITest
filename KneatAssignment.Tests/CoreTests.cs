using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWAPIHelper.Entities;
using System;
using System.Configuration;
using System.Linq;

namespace SWAPIHelper.Tests
{
    [TestClass()]
    public class CoreTests
    {
        [TestMethod()]
        public void GetAllStarshipsTest()
        {
            try
            {
                var swAPIbaseUrl = ConfigurationManager.AppSettings["swAPIbaseUrl"]; // Get the base URL from the config file
                var core = new Core(swAPIbaseUrl);

                var starships = core.GetAllStarships();

                Assert.IsNotNull(starships); // check that there is a response from the API
            }
            catch
            {
                Assert.Fail();
                throw;
            }
        }

        [TestMethod()]
        public void GetAllStarshipsTestStarship()
        {
            try
            {
                var swAPIbaseUrl = ConfigurationManager.AppSettings["swAPIbaseUrl"]; // Get the base URL from the config file
                var core = new Core(swAPIbaseUrl);

                var starships = core.GetAllStarships();
                var starship = starships.Result.FirstOrDefault();

                Assert.IsInstanceOfType(starship, typeof(Starship));  /// check if the returned object is a starship object
            }
            catch
            {
                Assert.Fail();
                throw;
            }
        }
    }
}