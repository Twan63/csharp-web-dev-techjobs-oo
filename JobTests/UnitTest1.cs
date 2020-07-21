
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace JobTest
{
    [TestClass]
    class JobTests
    {
        Job jobObj;

     /*   [TestInitialize]
        public void CreateJobObj()
        {
            Job job1 = new Job();

            jobObj = job1;

            Job testO = new Job();
            Assert.AreEqual(testO, jobObj);
        }*/

        [TestMethod]
        public void constructorTest()
        {
            //each Job must have unique Id Number 
            jobObj = new Job();
            Job testO = new Job();

            Assert.AreEqual(testO, jobObj);

        }
        [TestMethod]
        public void TestAllFields()  
        {
            //should test if all constructors are filled
            Job jobObj = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Job testO = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(testO, jobObj);

        }

    }
}
