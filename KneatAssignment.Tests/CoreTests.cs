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

                Assert.IsNotNull(starships);
            }
            catch (Exception e)
            {
                Assert.Fail();
                throw e;
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

                Assert.IsInstanceOfType(starship, typeof(Starship));
            }
            catch (Exception e)
            {
                Assert.Fail();
                throw e;
            }
        }
    }
}