### Example 1: Get expected configuration names of difference connection
```powershell
Get-AzServiceLinkerConfigurationName
```

```output
systemAssignedIdentity none                    {Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.Config…
userAssignedIdentity   none                    {Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.Config…
servicePrincipalSecret none                    {Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.Config…
secret                 none                    {Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.Config…
accessKey              none                    {Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.Config…
```

Get the expected configuration names of connection with each auth type and client type.
