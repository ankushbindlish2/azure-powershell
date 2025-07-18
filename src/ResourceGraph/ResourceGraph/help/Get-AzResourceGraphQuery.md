---
external help file: Az.ResourceGraph-help.xml
Module Name: Az.ResourceGraph
online version: https://learn.microsoft.com/powershell/module/az.resourcegraph/get-azresourcegraphquery
schema: 2.0.0
---

# Get-AzResourceGraphQuery

## SYNOPSIS
Get a single graph query by its resourceName.

## SYNTAX

### List (Default)
```
Get-AzResourceGraphQuery [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### Get
```
Get-AzResourceGraphQuery -Name <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### List1
```
Get-AzResourceGraphQuery -ResourceGroupName <String> [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzResourceGraphQuery -InputObject <IResourceGraphIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Get a single graph query by its resourceName.

## EXAMPLES

### Example 1: Get all resource graph query under a resource group
```powershell
Get-AzResourceGraphQuery -ResourceGroupName azure-rg-test
```

```output
Location Name            Type
-------- ----            ----
global   SharedQuery-t01 microsoft.resourcegraph/queries
```

This command gets all resource graph query under a resource group.

### Example 2: Get a resource graph query by name
```powershell
Get-AzResourceGraphQuery -ResourceGroupName azure-rg-test -Name SharedQuery-t01
```

```output
Location Name            Type
-------- ----            ----
global   SharedQuery-t01 microsoft.resourcegraph/queries
```

This command gets a resource graph query by name.

### Example 3: Get a resource graph query by object
```powershell
$query = New-AzResourceGraphQuery -ResourceGroupName azure-rg-test -Name query-t03 -Location 'global' -Query 'project id, name, type, location' -Description 'test'
Get-AzResourceGraphQuery -InputObject $query
```

```output
Location Name            Type
-------- ----            ----
global   SharedQuery-t01 microsoft.resourcegraph/queries
```

This command gets a resource graph query by object.

## PARAMETERS

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

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

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ResourceGraph.Models.IResourceGraphIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The name of the Graph Query resource.

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
Parameter Sets: Get, List1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.
The value must be an UUID.

```yaml
Type: System.String[]
Parameter Sets: List, Get, List1
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

### Microsoft.Azure.PowerShell.Cmdlets.ResourceGraph.Models.IResourceGraphIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ResourceGraph.Models.IGraphQueryResource

## NOTES

## RELATED LINKS
