---
external help file: Az.LabServices-help.xml
Module Name: Az.LabServices
online version: https://learn.microsoft.com/powershell/module/az.labservices/get-azlabservicestemplatevm
schema: 2.0.0
---

# Get-AzLabServicesTemplateVM

## SYNOPSIS
API to get the template vm for the lab.

## SYNTAX

### Get (Default)
```
Get-AzLabServicesTemplateVM -ResourceGroupName <String> -LabName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Lab
```
Get-AzLabServicesTemplateVM [-SubscriptionId <String[]>] -Lab <Lab> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
API to get the template vm for the lab.

## EXAMPLES

### Example 1: Get the template for the lab.
```powershell
Get-AzLabServicesTemplateVM -ResourceGroupName "group name" -LabName "lab name"
```

```output
Name Type
---- ----
0    Microsoft.LabServices/labs/virtualMachines
```

Returns the template VM for the lab.

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Lab
The object of lab service lab.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Lab
Parameter Sets: Lab
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LabName
The name of lab service lab.

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Lab

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IVirtualMachine

## NOTES

## RELATED LINKS
