using System.Collections.Generic;
using GiveMeAJob;

public interface IJobFileReader
{
    IEnumerable<Job> GetJobsFromFile(string filename);
}