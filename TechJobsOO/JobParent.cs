using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobParent
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobParent()
        {
            Id = nextId;
            nextId++;
        }

        public JobParent(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}


    

