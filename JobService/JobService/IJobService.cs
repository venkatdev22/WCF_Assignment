﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace JobService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IJobService" in both code and config file together.
    [ServiceContract]
    public interface IJobService
    {
        [OperationContract]
        List<Job> OpeningJobs();

        [OperationContract]
        List<Job> OpeningJobsByRole(string role);
    }
}
