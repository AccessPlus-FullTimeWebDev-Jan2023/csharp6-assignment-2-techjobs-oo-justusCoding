using System;
using System.Runtime.CompilerServices;

namespace TechJobsOOAutoGraded6
{
	public class Job
	{


        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }



        public Job()
        {
            Id = nextId;
            nextId++;
        }



        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency):this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }








        // TODO: Task 3: Add the two necessary constructors.

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {

            if (Name == "")
            {
                Name = "Data not available";
            }

            if (EmployerName.Value == "" || EmployerName.Value == null)
            {
                EmployerName.Value = "Data not available";
            }

            if (EmployerLocation.Value == "" || EmployerLocation.Value == null)
            {
                EmployerLocation.Value = "Data not available";
            }

            if (JobType.Value == "" || JobType.Value == null)
            {
                JobType.Value = "Data not available";
            }

            if (JobCoreCompetency.Value == "" || JobCoreCompetency == null)
            {
                JobCoreCompetency.Value = "Data not available";
            }



            string output = Environment.NewLine + "ID: " + Id + Environment.NewLine +
                "Name: " + Name + Environment.NewLine +
                "Employer: " + EmployerName + Environment.NewLine +
                "Location: " + EmployerLocation + Environment.NewLine +
                "Position Type: " + JobType + Environment.NewLine +
                "Core Competency: " + JobCoreCompetency + Environment.NewLine;
            return output;

        }



    }
}

