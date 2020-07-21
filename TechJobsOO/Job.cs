using System;
using System.Collections.Generic;

namespace TechJobsOO
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

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId++;
        

        }

        public Job(string name, Employer employerName, Location employerLocate, PositionType jobType, CoreCompetency jobCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocate;
            JobType = jobType;
            JobCoreCompetency = jobCompetency;

            
        }

        // TODO: Generate Equals() and GetHashCode() methods.

        public override string ToString()
        {
            /*ID:  _______
             Name: _______
             Employer: _______
             Location: _______
             Position Type: _______
             Core Competency: _______*/

            string outMsg = "This field is empty";

            string nameToString = this.Name == null ? "OOPS! this job does not seem to exist" : string.IsNullOrEmpty(this.Name)? outMsg: this.Name;
            string employerNameToString = this.EmployerName == null ? outMsg: string.IsNullOrEmpty(this.EmployerName.Value) ? outMsg : this.EmployerName.Value ;
            string employerLocationToString = this.EmployerLocation == null ? outMsg : string.IsNullOrEmpty(this.EmployerLocation.Value) ? outMsg : this.EmployerLocation.Value;
            string jobTypeToString =this.JobType == null ? outMsg : string.IsNullOrEmpty(this.JobType.Value) ? outMsg : this.JobType.Value;
            string coreCompToString = this.JobCoreCompetency == null ? outMsg : string.IsNullOrEmpty(this.JobCoreCompetency.Value) ? outMsg : this.JobCoreCompetency.Value;

            

            //test if any of the id field is the only one with data  

          //  string checkit = nameToString == null ? "OOPS! this job does not seem to exist" : employerNameToString == null ? outMsg : employerLocationToString == null ? outMsg : jobTypeToString == null ? outMsg : coreCompToString == null ? outMsg : output;

            string checkit = "ID: " + this.Id + "\n" +
                               "Name:" + nameToString + "\n" +
                              "Employer: " + employerNameToString + "\n" +
                              "Location: " + employerLocationToString + "\n" +
                              "Position Type: " + jobTypeToString + "\n" +
                              "Core Competency: " + coreCompToString + "\n";


            return checkit;
          
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id &&
                   Name == job.Name &&
                   EqualityComparer<Employer>.Default.Equals(EmployerName, job.EmployerName) &&
                   EqualityComparer<Location>.Default.Equals(EmployerLocation, job.EmployerLocation) &&
                   EqualityComparer<PositionType>.Default.Equals(JobType, job.JobType) &&
                   EqualityComparer<CoreCompetency>.Default.Equals(JobCoreCompetency, job.JobCoreCompetency);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }
    }
}
