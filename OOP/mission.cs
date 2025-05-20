using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Mission
    {
            public string MissionName; //{ get; set; }
            public string TargetLocation; // { get; set; }
            public Agent AssignedAgent; // { get; private set; }

            public Mission(string missionName, string targetLocation)
            {
                MissionName = missionName;
                TargetLocation = targetLocation;
            }

            public void AssignAgent(Agent agent)
            {
                AssignedAgent = agent;
            }

            public void Brief()
            {
                if (AssignedAgent != null)
                {
                    Console.WriteLine($"Mission: {MissionName}, Target: {TargetLocation}, Agent: {AssignedAgent.CodeName}");
                }
            else
                {
                    Console.WriteLine("No agent assigned to this mission.");
                }
            }
    }

}
