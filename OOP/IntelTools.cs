using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    static class IntelTools
    {
        internal static string EncryptMessage(string msg)
        {
            string encrypt = "";
            for (int i = msg.Length - 1; i >= 0; i--)
            {
                encrypt += msg[i];
            }
            return encrypt;
        }

        internal static void LogTransmission(string agentName, string message)
        {
            Console.WriteLine($"{agentName} sent encrypted message {message}");
        }
    }
}
