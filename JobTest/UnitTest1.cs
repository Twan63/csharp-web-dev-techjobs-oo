using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace JobTest
{
    [TestClass]
    public class UnitTest1
    {
        Job jobObj;

        Job jobObj1;

        Job jobObj2;
        Job testO;

        

        [TestInitialize]
        public void CreateJobObj()
        {
            jobObj = new Job();

            jobObj1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            jobObj2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            testO = new Job();
        }

        [TestMethod]
        public void constructorTest()
        {
            //each Job must have unique Id Number 
            int jobId = jobObj.Id;
            int jobId1 = jobObj1.Id;
            int jobId2 = jobObj2.Id; 
            int testOId = testO.Id;

            Assert.IsTrue(jobId1 != jobId2);

            Assert.IsTrue(jobId != testOId);

            //verifing that it is ++
            //Assert.IsTrue(testOId == jobId + 1);
        }
        [TestMethod]
        public void TestAllConstructors()
        {
            string jobName = jobObj1.Name;
            string jobEmploy = jobObj1.EmployerName.Value;
            string jobLocation = jobObj1.EmployerLocation.Value;
            string jobType = jobObj1.JobType.Value;
            string jobCore = jobObj1.JobCoreCompetency.Value;

            Assert.IsTrue(jobName == "Product tester");
            Assert.IsTrue(jobEmploy == "ACME");
            Assert.IsTrue(jobLocation == "Desert");
            Assert.IsTrue(jobType == "Quality control");
            Assert.IsTrue(jobCore == "Persistence");

        }

        [TestMethod]
        public void toStringTest()
        {
            //should take all of the fields and print them on seperate lines 
            string expected = "ID: " + jobObj1.Id + "\n" +
                                "Name:" + jobObj1.Name + "\n" +
                               "Employer: " + jobObj1.EmployerName + "\n" +
                               "Location: " + jobObj1.EmployerLocation + "\n" +
                               "Position Type: " + jobObj1.JobType + "\n" +
                               "Core Competency: " + jobObj1.JobCoreCompetency + "\n";


           
            string actual = jobObj1.ToString();

            Assert.AreEqual(expected, actual);
                     



        }
    }
}


