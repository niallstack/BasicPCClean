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
    class ResetIExplorer
    {
        public static void ResetIE()
        {
            using (PowerShell PowerShellInstanceResetIE = PowerShell.Create())
            {
                PowerShellInstanceResetIE.AddScript("[void][reflection.assembly]::Load('System.Windows.Forms, Version = 2.0.0.0,"
                    + "Culture = neutral, PublicKeyToken = b77a5c561934e089');"
                    + "$arrOfficeProcs = 'iexplore'; $continue = $false; cls; do{$arrRunning = @(); foreach ($proc in $arrofficeProcs) {;"
                    + "if(((get-process $proc -ea SilentlyContinue) -ne $Null)){ $arrRunning += $proc }}; if ($arrRunning.length -gt 0 ) {;"
                    + "$d = [System.Windows.Forms.MessageBox]::Show('Please Close All Instances of IE','Reset IE',"
                    + "[System.Windows.Forms.MessageBoxButtons]::RetryCancel, [System.Windows.Forms.MessageBoxIcon]::Warning );"
                    + "if ($d -eq [Windows.Forms.DialogResult]::Cancel) { exit }} else {$continue = $true;  RunDll32.exe InetCpl.cpl,ResetIEtoDefaults | Out-Null}}"
                    + "while ( $continue -eq $false )");
                PowerShellInstanceResetIE.Invoke();
            }
        }
    }
}
