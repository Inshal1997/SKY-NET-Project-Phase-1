using System;
using System.Text;
using System.IO;
using System.Management;
using System.Diagnostics;
using NetFwTypeLib;

namespace SKY
{
    public class Firewall_Check
    {
        private static bool firewall_check(string name, string miner_path)
        {
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            foreach (INetFwRule rule in firewallPolicy.Rules)
            {

                if (rule.Name == name && rule.ApplicationName == miner_path)
                {
                 
                    return true;
                }
            }
            return false;
        }
        private static void firewall_add(string name, string miner_path)
        {
            INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            firewallRule.ApplicationName = miner_path;
            firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
            firewallRule.Description = name + " for Skynet ";
            firewallRule.Enabled = true;
            firewallRule.InterfaceTypes = "All";
            firewallRule.Name = name;
            firewallPolicy.Rules.Add(firewallRule);
        }
        public void run_firewall(string name, string miner_path)
        {
            //string name =     ;
            // string ethminer_path = @"D:\New\ethminer-API_V1.exe";
            bool firewall = firewall_check(name, miner_path);
            if (firewall)
            {
                
            }
            else
            {
               
                while (!firewall)
                {
                    firewall_add(name, miner_path);
                    firewall = firewall_check(name, miner_path);
                }
            }

        }

        
    }
}
