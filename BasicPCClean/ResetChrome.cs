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
    class ResetChrome
    {
        public static void ResetCCChrome()
        {
            using (PowerShell PowerShellInstanceResetCCChrome = PowerShell.Create())
            {
                PowerShellInstanceResetCCChrome.AddScript("dir C:/Users | select Name | Export-Csv -Path C:/users/$env:USERNAME/users.csv -NoTypeInformation; "
                    + "$list=Test-Path C:/users/$env:USERNAME/users.csv; if ($list) {; Import-CSV -Path C:/users/$env:USERNAME/users.csv -Header Name | foreach {;"
                    + "$folders = @('C: /Users/$($_.Name)/AppData/Local/Google/Chrome/User Data/Default/Cache/*',"
                    + "'C:/Users/$($_.Name)/AppData/Local/Google/Chrome/User Data/Default/Cache2/entries/*', "
                    + "'C:/Users/$($_.Name)/AppData/Local/Google/Chrome/User Data/Default/Cookies', "
                    + "'C:/Users/$($_.Name)/AppData/Local/Google/Chrome/User Data/Default/Media Cache', "
                    + "'C:/Users/$($_.Name)/AppData/Local/Google/Chrome/User Data/Default/Cookies-Journal'); "
                    + "Remove-Item $folders -Recurse -Force -EA SilentlyContinue -Verbose;}} else{ exit }");
                PowerShellInstanceResetCCChrome.Invoke();
            }
        }
    }
}
