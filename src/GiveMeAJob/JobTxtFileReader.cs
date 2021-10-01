using System.Collections.Generic;
using GiveMeAJob;

public class JobTxtFileReader : IJobFileReader
{
    public IEnumerable<Job> GetJobsFromFile(string filename)
    {
        var jobNames = System.IO.File.ReadAllLines(filename);

        foreach (var jobname in jobNames)
        {
            Job job = new Job();
            job.Name = jobname;
            
            yield return job;
        }        
    }
}