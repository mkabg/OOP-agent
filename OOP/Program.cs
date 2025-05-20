using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calclate calculator = new Calclate(10, 5);
            //calculator.print();

            //Animal cat = new Animal("tom", 7);
            //cat.print();

            Agent agent = new Agent("Bond", 7, "8200");
            Mission mission = new Mission("Operation Thunder", "London");
            mission.AssignAgent(agent);
            agent.Report();
            mission.Brief();
            IntelTools.LogTransmission("david", "hello");
            Report report = new Report("abc", agent, 4);
            MissionControl.AnalyzeReport(report);
            string AN = report.SubmittedBy.CodeName;
            string message = report.Summary;
            IntelTools.LogTransmission(AN, message);

        }
    }
}
