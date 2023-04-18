
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{

        //Testing objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        Job job5 = new Job("", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //initalize your testing objects here

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreEqual(job1.Id+1 , job2.Id );
            Assert.IsTrue(job1.Id != job2.Id);
        }

/*
        "Product tester" for Name
"ACME" for EmployerName
"Desert" for JobLocation
"Quality control" for JobType
"Persistence" for JobCoreCompetency*/
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {

            Assert.AreEqual(job3.Name, "Product tester");
            Assert.IsTrue(job3.EmployerName.Value == "ACME");
            Assert.IsTrue(job3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job3.JobType.Value == "Quality control");
            Assert.IsTrue(job3.JobCoreCompetency.Value == "Persistence");

        }


        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job1));
        }




        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));
            Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));

        }

        [TestMethod]

        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.IsTrue(job3.ToString().Contains(job3.Name));
            Assert.IsTrue(job3.ToString().Contains(job3.EmployerName.Value));
            Assert.IsTrue(job3.ToString().Contains(job3.EmployerLocation.Value));
            Assert.IsTrue(job3.ToString().Contains(job3.JobType.Value));
            Assert.IsTrue(job3.ToString().Contains(job3.JobCoreCompetency.Value));
        }


        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Assert.AreEqual(Environment.NewLine + "ID: " + job5.Id + Environment.NewLine + "Name: Data not available" + Environment.NewLine + "Employer: Data not available" + Environment.NewLine + "Location: Desert" + Environment.NewLine + "Position Type: Quality control" + Environment.NewLine + "Core Competency: Persistence" + Environment.NewLine, job5.ToString());

        }
    }
}

