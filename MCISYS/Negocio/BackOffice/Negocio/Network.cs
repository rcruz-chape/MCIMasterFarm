using System;
using System.Management;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCIMasterFarm.Negocio.BackOffice.Negocio
{
    public class Network
    {
        private string _ip;
        private string _Mac;
        private OperatingSystem _OS;
        private string _HostName;
        private string[] NetworkAdapter()
        {
            string[] Return = new string[9999];
            ManagementObjectSearcher ObjMOS = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
            ManagementObjectCollection ObjMOC = ObjMOS.Get();
            foreach(ManagementObject mo in ObjMOC)
            {
                Return = (string[])mo["IPAddress"];
                this._ip = Return[0];
                this._Mac = Return[1];
            }
            this._OS = Environment.OSVersion;
            this._HostName = Dns.GetHostName();
            return Return;
        }
        public string MAC()
        {
            if (this._Mac == null)
            {
                string[] Return = NetworkAdapter();
            }
            return this._Mac; 
        }

        public string IP()
        {
            string[] Return = NetworkAdapter();
            return this._ip;
        }
        public string OS()
        {
            if (this._OS == null)
            {
                string[] Return = NetworkAdapter();
            }
            return this._OS.ToString();
        }

        public string HostName()
        {
            if (this._HostName == null)
            {
                string[] Return = NetworkAdapter();
            }
            return this._HostName;
        }


    }
}
