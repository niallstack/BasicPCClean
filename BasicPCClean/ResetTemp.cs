using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;

namespace BasicPCClean
{
    class ResetTemp
    {
        public static void RemoveTemp()
        {
            using (PowerShell PowerShellInstanceRemoveTemp = PowerShell.Create())
            {
                PowerShellInstanceRemoveTemp.AddScript("$tempfolders = @('C:/Windows/Temp/*', 'C:/Windows/Prefetch/*', " +
                    "'C:/Documents and Settings/*/Local Settings/temp/*', 'C:/Users/*/Appdata/Local/Temp/*'); Remove-Item $tempfolders -force -recurse");
                PowerShellInstanceRemoveTemp.Invoke();
            }
        }
    }
}
