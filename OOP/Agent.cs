using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Agent
    {
        public string CodeName;
        private int ClearanceLevel;
        internal string Unit;
        public Agent(string codeName, int clearanceLevel, string unit)
        {
            CodeName = codeName;
            ClearanceLevel = clearanceLevel;
            Unit = unit;
        }

        public int GetClearanceLevel()
        {
            return ClearanceLevel;
        }

        public void SetClearanceLevel(int level)
        {
            if (level >= 1 && level <= 5)
            {
                ClearanceLevel = level;
            }
        }


        public void Report()
        {
            Console.WriteLine($"Agent: {CodeName} reporting. Clearance Level: {ClearanceLevel}");
        }
    }
}
