#
# Module manifest for module 'Az'
#
# Generated by: Microsoft Corporation
#
# Generated on: 3/17/2021
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '5.7.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'd48d710e-85cb-46a1-990f-22dae76f6b5f'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Cmdlets to manage resources in Azure. This module is compatible with WindowsPowerShell and PowerShell Core.
For more information about the Az module, please visit the following: https://docs.microsoft.com/en-us/powershell/azure/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.2.7'; }, 
               @{ModuleName = 'Az.Advisor'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.Aks'; RequiredVersion = '2.0.2'; }, 
               @{ModuleName = 'Az.AnalysisServices'; RequiredVersion = '1.1.4'; }, 
               @{ModuleName = 'Az.ApiManagement'; RequiredVersion = '2.2.0'; }, 
               @{ModuleName = 'Az.AppConfiguration'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.ApplicationInsights'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Automation'; RequiredVersion = '1.5.2'; }, 
               @{ModuleName = 'Az.Batch'; RequiredVersion = '3.1.0'; }, 
               @{ModuleName = 'Az.Billing'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Cdn'; RequiredVersion = '1.6.0'; }, 
               @{ModuleName = 'Az.CognitiveServices'; RequiredVersion = '1.8.0'; }, 
               @{ModuleName = 'Az.Compute'; RequiredVersion = '4.10.0'; }, 
               @{ModuleName = 'Az.ContainerInstance'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.ContainerRegistry'; RequiredVersion = '2.2.1'; }, 
               @{ModuleName = 'Az.CosmosDB'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.DataBoxEdge'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Databricks'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.DataFactory'; RequiredVersion = '1.11.5'; }, 
               @{ModuleName = 'Az.DataLakeAnalytics'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.DataLakeStore'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.DataShare'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.DesktopVirtualization'; RequiredVersion = '2.1.1'; }, 
               @{ModuleName = 'Az.DeploymentManager'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.DevTestLabs'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Dns'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.EventGrid'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.EventHub'; RequiredVersion = '1.7.2'; }, 
               @{ModuleName = 'Az.FrontDoor'; RequiredVersion = '1.7.0'; }, 
               @{ModuleName = 'Az.Functions'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.HDInsight'; RequiredVersion = '4.2.0'; }, 
               @{ModuleName = 'Az.HealthcareApis'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.IotHub'; RequiredVersion = '2.7.3'; }, 
               @{ModuleName = 'Az.KeyVault'; RequiredVersion = '3.4.1'; }, 
               @{ModuleName = 'Az.Kusto'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.LogicApp'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.MachineLearning'; RequiredVersion = '1.1.3'; }, 
               @{ModuleName = 'Az.Maintenance'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.ManagedServices'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.MarketplaceOrdering'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Media'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.Migrate'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Monitor'; RequiredVersion = '2.4.0'; }, 
               @{ModuleName = 'Az.Network'; RequiredVersion = '4.7.0'; }, 
               @{ModuleName = 'Az.NotificationHubs'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.OperationalInsights'; RequiredVersion = '2.3.0'; }, 
               @{ModuleName = 'Az.PolicyInsights'; RequiredVersion = '1.4.1'; }, 
               @{ModuleName = 'Az.PowerBIEmbedded'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.PrivateDns'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.RecoveryServices'; RequiredVersion = '3.5.0'; }, 
               @{ModuleName = 'Az.RedisCache'; RequiredVersion = '1.4.0'; }, 
               @{ModuleName = 'Az.RedisEnterpriseCache'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Relay'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.Resources'; RequiredVersion = '3.4.0'; }, 
               @{ModuleName = 'Az.ServiceBus'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.ServiceFabric'; RequiredVersion = '2.3.0'; }, 
               @{ModuleName = 'Az.SignalR'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.Sql'; RequiredVersion = '2.17.0'; }, 
               @{ModuleName = 'Az.SqlVirtualMachine'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Storage'; RequiredVersion = '3.5.0'; }, 
               @{ModuleName = 'Az.StorageSync'; RequiredVersion = '1.4.0'; }, 
               @{ModuleName = 'Az.StreamAnalytics'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.Support'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.TrafficManager'; RequiredVersion = '1.0.4'; }, 
               @{ModuleName = 'Az.Websites'; RequiredVersion = '2.5.0'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ARM','ResourceManager','Linux','AzureAutomationNotSupported'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '5.7.0 - March 2021
Az.Accounts
* Fixed incorrect warning message on Windows PowerShell [#14556]
* Set Azure Environment variable ''AzureKeyVaultServiceEndpointResourceId'' according to the value of ''AzureKeyVaultDnsSuffix'' when discovering environment 

Az.Automation
* Fixed the issue for starting Python3 runbooks with parameters

Az.DataFactory
* Updated ADF .Net SDK version to 4.15.0

Az.EventHub
* Fixed that ''New-AzServiceBusAuthorizationRuleSASToken'' returns invalid token. [#12975]

Az.IotHub
* Updated IoT Hub Management SDK and models to version 3.0.0 (api-version 2020-03-01)

Az.KeyVault
* Supported upcoming new API design for ''Export-AzKeyVaultSecurityDomain''
* Fixed several typos in cmdlet messages [#14341]

Az.Network
* Added new cmdlets to replace old product name ''virtual router'' with new name ''route server'' in the future.
    - ''Get-AzRouteServerPeerAdvertisedRoute''
    - ''Get-AzRouteServerPeerAdvertisedRoute''
    - Added deprecation attribute warning to the old cmdlets.
* Updated ''set-azExpressRouteGateway'' to allow parameter -MinScaleUnits without specifying -MaxScaleUnits
* Updated cmdlets to enable setting of VpnLinkConnectionMode on VpnSiteLinkConnections.
    - ''New-AzVpnSiteLinkConnection''
    - ''Update-AzVpnConnection''
* Added new cmdlet to fetch IKE Security Associations for VPN Site Link Connections.
    - ''Get-VpnSiteLinkConnectionIkeSa''
* Added new cmdlet to reset a Virtual Network Gateway Connection.
    - ''Reset-AzVirtualNetworkGatewayConnection''
* Added new cmdlet to reset a Vpn Site Link Connection.
    - ''Reset-VpnSiteLinkConnection''
* Updated cmdlets to enable setting an optional parameter -TrafficSelectorPolicies
    - ''New-AzVpnConnection''
    - ''Update-AzVpnConnection''
* Bug fix for update vpnServerConfiguration.
* Add scenarioTest for p2s multi auth VWAN.
* Added multi auth feature support for VNG
	- ''Get-AzVpnClientConfiguration''
	- ''New-AzVirtualNetworkGateway''
	- ''Set-AzVirtualNetworkGateway''

Az.RecoveryServices
* Added Cross Zonal Restore for managed virtual machines. 

Az.RedisEnterpriseCache
* GA version of Az.RedisEnterpriseCache

Az.Resources
* Redirected bicep message to verbose stream
* Removed the logic of copying Bicep template file to temp folder.
* Add support of policy exemption resource type
* Fixed what-if functionality when using ''-QueryString'' parameter.
* Normalized ''-QueryString'' starting with ''?'' for scenarios involving dynamic parameters.

Az.ServiceBus
* Fixed that ''New-AzServiceBusAuthorizationRuleSASToken'' returns invalid token. [#12975]

Az.ServiceFabric
* Added parameters ''VMImagePublisher'', ''VMImageOffer'', ''VMImageSku'', ''VMImageVersion'' to ''Add-AzServiceFabricNodeType'' to facilitate easy alternate OS image creation for new node type.
* Added parameter ''IsPrimaryNodeType'' to ''Add-AzServiceFabricNodeType'' to be able to create an additional primary node type, for the purpose of transitioning the primary node type to another one in the case of OS migration.
* ''Add-AzServiceFabricNodeType'' now correctly copies the LinuxDiagnostic extension. This was previously not working for Linux.
* ''Add-AzServiceFabricNodeType'' now correctly copies the RDP/SSH load balancer inbound NAT port mapping to the new node type.
* Added template for ''UbuntuServer1804'' for creating Ubuntu 18.04 clusters using ''New-AzServiceFabricCluster''.
* ''Remove-AzServiceFabricNodeType'' was incorrectly blocking Bronze durability node types for removal, and this has been updated to only block when the Bronze durability level differs between the SF node type and VMSS setting.
* Added cmdlet ''Update-AzServiceFabricVmImage'' to update the delivered SF runtime package type. This must be changed when migrating from Ubuntu 16 to 18.
* Added cmdlet ''Update-AzServiceFabricNodeType'' to update the properties of a cluster node type. For now this is solely used to update whether the node type is primary via bool parameter ''-IsPrimaryNodeType False''.
* ''Update-AzServiceFabricReliability'' is now able to update reliability level when the cluster has more than one primary node type. To do this, the name of the node type is supplied via the new -NodeType parameter.
* Added new cmdlets for managed applications:
    - ''New-AzServiceFabricManagedClusterApplication''
    - ''Get-AzServiceFabricManagedClusterApplication''
    - ''Set-AzServiceFabricManagedClusterApplication''
    - ''Remove-AzServiceFabricManagedClusterApplication''
    - ''New-AzServiceFabricManagedClusterApplicationType''
    - ''Get-AzServiceFabricManagedClusterApplicationType''
    - ''Set-AzServiceFabricManagedClusterApplicationType''
    - ''Remove-AzServiceFabricManagedClusterApplicationType''
    - ''New-AzServiceFabricManagedClusterApplicationTypeVersion''
    - ''Get-AzServiceFabricManagedClusterApplicationTypeVersion''
    - ''Set-AzServiceFabricManagedClusterApplicationTypeVersion''
    - ''Remove-AzServiceFabricManagedClusterApplicationTypeVersion''
    - ''New-AzServiceFabricManagedClusterService''
    - ''Get-AzServiceFabricManagedClusterService''
    - ''Set-AzServiceFabricManagedClusterService''
    - ''Remove-AzServiceFabricManagedClusterService''
* Upgraded Managed Cluster commands to use Service Fabric Managed Cluster SDK version 1.0.0-beta.1 which uses service fabric resource provider api-version 2021-01-01-preview.

Az.Sql
* Added cmdlet ''New-AzSqlServerTrustGroup''
* Added cmdlet ''Remove-AzSqlServerTrustGroup''
* Added cmdlet ''Get-AzSqlServerTrustGroup''

Az.Storage
* Fixed an issue that list account from resource group won''t use nextlink
    - ''Get-AzStorageAccount''
* Supported ChangeFeedRetentionInDays when Enable ChangeFeed on Blob service
    - ''Update-AzStorageBlobServiceProperty''

Az.Websites
* Updated ''Add-AzWebAppAccessRestrictionRule'' to allow all supported Service Tags and validate against Service Tag API.
'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

