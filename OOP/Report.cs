using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Report
    {
        internal string Summary;
        internal Agent SubmittedBy;
         internal int UrgencyLevel;

        public Report(string summary, Agent submittedy, int urgencyLevel)
        {
            Summary = summary;
            SubmittedBy = submittedy;
            UrgencyLevel = urgencyLevel;
        }

    }
}
