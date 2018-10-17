using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace JobService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JobService" in both code and config file together.
    public class JobService : IJobService
    {
        public List<Job> OpeningJobs()
        {
            return GetJobList();
        }

        public List<Job> OpeningJobsByRole(string role)
        {

            List<Job> listJob = GetJobList();

            var result = listJob.Where(x => x.Role.ToLower() == role.ToLower()).ToList();

            return result;
        }

        private List<Job> GetJobList()
        {
            List<Job> listJob = new List<Job>();

            Job objJob = null;
            objJob = new Job();
            objJob.Code = "J100";
            objJob.Title = "DotNet Developer";
            objJob.Role = "Associate";
            objJob.Description = "This opening for .net developer for associate.";
            objJob.Status = "Active";
            listJob.Add(objJob);

            objJob = new Job();
            objJob.Code = "J101";
            objJob.Title = "Java Developer";
            objJob.Role = "Associate";
            objJob.Description = "This opening for JAVA developer for associate.";
            objJob.Status = "Active";
            listJob.Add(objJob);

            objJob = new Job();
            objJob.Code = "J102";
            objJob.Title = "SAP Developer";
            objJob.Role = "SeniorAssociate";
            objJob.Description = "This opening for SAP developer for Senior Associate.";
            objJob.Status = "Active";
            listJob.Add(objJob);

            objJob = new Job();
            objJob.Code = "J103";
            objJob.Title = "DotNet Developer";
            objJob.Role = "SeniorAssociate";
            objJob.Description = "This opening for .net developer for Senior Associate.";
            objJob.Status = "Active";
            listJob.Add(objJob);

            objJob = new Job();
            objJob.Code = "J104";
            objJob.Title = "Java Developer";
            objJob.Role = "SeniorAssociate";
            objJob.Description = "This opening for Java developer for Senior Associate.";
            objJob.Status = "Active";
            listJob.Add(objJob);

            objJob = new Job();
            objJob.Code = "J105";
            objJob.Title = "Web Developer";
            objJob.Role = "Associate";
            objJob.Description = "This opening for web developer for associate.";
            objJob.Status = "Active";
            listJob.Add(objJob);

            return listJob;
        }
    }
}
