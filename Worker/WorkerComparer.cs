using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class WorkerComparerForSalary : IComparer<Worker>
    {
        public int Compare(Worker worker1, Worker worker2)
        {
            if (worker1.GetSalaryWorkers() < worker2.GetSalaryWorkers())
            {
                return 1;
            }
            else if(worker1.GetSalaryWorkers() > worker2.GetSalaryWorkers())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    class WorkerComparerForExperience : IComparer<Worker>
    {
        public int Compare(Worker worker1, Worker worker2)
        {
            if (worker1.GetWorkExperience() > worker2.GetWorkExperience())
            {
                return 1;
            }
            else if (worker1.GetWorkExperience() < worker2.GetWorkExperience())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
