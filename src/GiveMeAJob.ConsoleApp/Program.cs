using System;

namespace GiveMeAJob.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your job is:");
            Console.WriteLine();

            var jobreader = new JobTxtFileReader();
            var jobs = jobreader.GetJobsFromFile(args[0]);

            GiveMeAJobService service = new GiveMeAJobService();
            var job = service.ReturnJob(jobs);

            Console.WriteLine(job.Name);
            
            Console.WriteLine();
        }
    }
}
