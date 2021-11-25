using System;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace AlexTeamGenix
{
    class DesktopID
    {
        /*
         * Creating a Desktop ID using the processor ID, this might not be the best approached since
         * processor ID's might not always be unique, the better approach should be a ID generated from 
         * the MAC address
         */
        public static string Get_DesktopID => ReturnDesktopID().Result;
        private static async Task<string> ReturnDesktopID()
        {
            byte[] bytes;
            byte[] hashedBytes;
            StringBuilder sb = new StringBuilder();
            Task task = Task.Run(() =>
            {
                ManagementObjectSearcher cpuID = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                ManagementObjectCollection cpuID_Collection = cpuID.Get();
                foreach (ManagementObject obj in cpuID_Collection)
                {
                    sb.Append(obj["ProcessorID"].ToString().Substring(0, 4));
                }

            });
            Task.WaitAll(task);
            bytes = System.Text.Encoding.UTF8.GetBytes(sb.ToString());
            hashedBytes = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes);
            return await Task.FromResult(Convert.ToBase64String(hashedBytes).Substring(25));
        }
    }
}
