using System;
using System.Collections.Generic;
using System.Linq;

namespace GiveMeAJob
{
    public class Class1
    {
        public Job ReturnJob(IEnumerable<Job> jobs)
        {
            var jobsArray = jobs.ToArray();

            var random = DryLib.Security.Cryptography.RandomNumber.Between(0,jobsArray.Length-1);

            return jobsArray[random];
        }
    }
}
