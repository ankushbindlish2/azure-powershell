// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Extensions;

    /// <summary>Definition of data collection endpoint.</summary>
    public partial class DataCollectionEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpoint,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal
    {

        /// <summary>Backing field for <see cref="ConfigurationAccess" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointConfigurationAccess _configurationAccess;

        /// <summary>The endpoint used by clients to access their configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointConfigurationAccess ConfigurationAccess { get => (this._configurationAccess = this._configurationAccess ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointConfigurationAccess()); set => this._configurationAccess = value; }

        /// <summary>The endpoint. This property is READ-ONLY.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inlined)]
        public string ConfigurationAccessEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IConfigurationAccessEndpointSpecInternal)ConfigurationAccess).Endpoint; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the data collection endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="FailoverConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointFailoverConfiguration _failoverConfiguration;

        /// <summary>Failover configuration on this endpoint. This property is READ-ONLY.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointFailoverConfiguration FailoverConfiguration { get => (this._failoverConfiguration = this._failoverConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointFailoverConfiguration()); }

        /// <summary>Active location where data flow will occur.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inlined)]
        public string FailoverConfigurationActiveLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IFailoverConfigurationSpecInternal)FailoverConfiguration).ActiveLocation; }

        /// <summary>Locations that are configured for failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.ILocationSpec> FailoverConfigurationLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IFailoverConfigurationSpecInternal)FailoverConfiguration).Location; }

        /// <summary>Backing field for <see cref="ImmutableId" /> property.</summary>
        private string _immutableId;

        /// <summary>
        /// The immutable ID of this data collection endpoint resource. This property is READ-ONLY.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Owned)]
        public string ImmutableId { get => this._immutableId; set => this._immutableId = value; }

        /// <summary>The endpoint. This property is READ-ONLY.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inlined)]
        public string LogIngestionEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.ILogsIngestionEndpointSpecInternal)LogsIngestion).Endpoint; }

        /// <summary>Backing field for <see cref="LogsIngestion" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointLogsIngestion _logsIngestion;

        /// <summary>The endpoint used by clients to ingest logs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointLogsIngestion LogsIngestion { get => (this._logsIngestion = this._logsIngestion ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointLogsIngestion()); set => this._logsIngestion = value; }

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointMetadata _metadata;

        /// <summary>Metadata for the resource. This property is READ-ONLY.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointMetadata Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointMetadata()); }

        /// <summary>Azure offering managing this resource on-behalf-of customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inlined)]
        public string MetadataProvisionedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IMetadataInternal)Metadata).ProvisionedBy; }

        /// <summary>Resource Id of azure offering managing this resource on-behalf-of customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inlined)]
        public string MetadataProvisionedByResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IMetadataInternal)Metadata).ProvisionedByResourceId; }

        /// <summary>The endpoint. This property is READ-ONLY.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inlined)]
        public string MetricIngestionEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IMetricsIngestionEndpointSpecInternal)MetricsIngestion).Endpoint; }

        /// <summary>Backing field for <see cref="MetricsIngestion" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointMetricsIngestion _metricsIngestion;

        /// <summary>The endpoint used by clients to ingest metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointMetricsIngestion MetricsIngestion { get => (this._metricsIngestion = this._metricsIngestion ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointMetricsIngestion()); set => this._metricsIngestion = value; }

        /// <summary>Internal Acessors for ConfigurationAccess</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointConfigurationAccess Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal.ConfigurationAccess { get => (this._configurationAccess = this._configurationAccess ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointConfigurationAccess()); set { {_configurationAccess = value;} } }

        /// <summary>Internal Acessors for ConfigurationAccessEndpoint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal.ConfigurationAccessEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IConfigurationAccessEndpointSpecInternal)ConfigurationAccess).Endpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IConfigurationAccessEndpointSpecInternal)ConfigurationAccess).Endpoint = value ?? null; }

        /// <summary>Internal Acessors for FailoverConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointFailoverConfiguration Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal.FailoverConfiguration { get => (this._failoverConfiguration = this._failoverConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointFailoverConfiguration()); set { {_failoverConfiguration = value;} } }

        /// <summary>Internal Acessors for FailoverConfigurationActiveLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal.FailoverConfigurationActiveLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IFailoverConfigurationSpecInternal)FailoverConfiguration).ActiveLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IFailoverConfigurationSpecInternal)FailoverConfiguration).ActiveLocation = value ?? null; }

        /// <summary>Internal Acessors for FailoverConfigurationLocation</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.ILocationSpec> Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal.FailoverConfigurationLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IFailoverConfigurationSpecInternal)FailoverConfiguration).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IFailoverConfigurationSpecInternal)FailoverConfiguration).Location = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LogIngestionEndpoint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal.LogIngestionEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.ILogsIngestionEndpointSpecInternal)LogsIngestion).Endpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.ILogsIngestionEndpointSpecInternal)LogsIngestion).Endpoint = value ?? null; }

        /// <summary>Internal Acessors for LogsIngestion</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointLogsIngestion Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal.LogsIngestion { get => (this._logsIngestion = this._logsIngestion ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointLogsIngestion()); set { {_logsIngestion = value;} } }

        /// <summary>Internal Acessors for Metadata</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointMetadata Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal.Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointMetadata()); set { {_metadata = value;} } }

        /// <summary>Internal Acessors for MetadataProvisionedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal.MetadataProvisionedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IMetadataInternal)Metadata).ProvisionedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IMetadataInternal)Metadata).ProvisionedBy = value ?? null; }

        /// <summary>Internal Acessors for MetadataProvisionedByResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal.MetadataProvisionedByResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IMetadataInternal)Metadata).ProvisionedByResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IMetadataInternal)Metadata).ProvisionedByResourceId = value ?? null; }

        /// <summary>Internal Acessors for MetricIngestionEndpoint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal.MetricIngestionEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IMetricsIngestionEndpointSpecInternal)MetricsIngestion).Endpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IMetricsIngestionEndpointSpecInternal)MetricsIngestion).Endpoint = value ?? null; }

        /// <summary>Internal Acessors for MetricsIngestion</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointMetricsIngestion Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal.MetricsIngestion { get => (this._metricsIngestion = this._metricsIngestion ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointMetricsIngestion()); set { {_metricsIngestion = value;} } }

        /// <summary>Internal Acessors for NetworkAcls</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointNetworkAcls Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal.NetworkAcls { get => (this._networkAcls = this._networkAcls ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointNetworkAcls()); set { {_networkAcls = value;} } }

        /// <summary>Internal Acessors for PrivateLinkScopedResource</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IPrivateLinkScopedResource> Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal.PrivateLinkScopedResource { get => this._privateLinkScopedResource; set { {_privateLinkScopedResource = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="NetworkAcls" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointNetworkAcls _networkAcls;

        /// <summary>Network access control rules for the endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointNetworkAcls NetworkAcls { get => (this._networkAcls = this._networkAcls ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointNetworkAcls()); set => this._networkAcls = value; }

        /// <summary>
        /// The configuration to set whether network access from public internet to the endpoints are allowed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inlined)]
        public string NetworkAclsPublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.INetworkRuleSetInternal)NetworkAcls).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.INetworkRuleSetInternal)NetworkAcls).PublicNetworkAccess = value ?? null; }

        /// <summary>Backing field for <see cref="PrivateLinkScopedResource" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IPrivateLinkScopedResource> _privateLinkScopedResource;

        /// <summary>
        /// List of Azure Monitor Private Link Scope Resources to which this data collection endpoint resource is associated. This
        /// property is READ-ONLY.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IPrivateLinkScopedResource> PrivateLinkScopedResource { get => this._privateLinkScopedResource; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The resource provisioning state. This property is READ-ONLY.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="DataCollectionEndpoint" /> instance.</summary>
        public DataCollectionEndpoint()
        {

        }
    }
    /// Definition of data collection endpoint.
    public partial interface IDataCollectionEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.IJsonSerializable
    {
        /// <summary>The endpoint. This property is READ-ONLY.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The endpoint. This property is READ-ONLY.",
        SerializedName = @"endpoint",
        PossibleTypes = new [] { typeof(string) })]
        string ConfigurationAccessEndpoint { get;  }
        /// <summary>Description of the data collection endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Description of the data collection endpoint.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Active location where data flow will occur.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Active location where data flow will occur.",
        SerializedName = @"activeLocation",
        PossibleTypes = new [] { typeof(string) })]
        string FailoverConfigurationActiveLocation { get;  }
        /// <summary>Locations that are configured for failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Locations that are configured for failover.",
        SerializedName = @"locations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.ILocationSpec) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.ILocationSpec> FailoverConfigurationLocation { get;  }
        /// <summary>
        /// The immutable ID of this data collection endpoint resource. This property is READ-ONLY.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The immutable ID of this data collection endpoint resource. This property is READ-ONLY.",
        SerializedName = @"immutableId",
        PossibleTypes = new [] { typeof(string) })]
        string ImmutableId { get; set; }
        /// <summary>The endpoint. This property is READ-ONLY.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The endpoint. This property is READ-ONLY.",
        SerializedName = @"endpoint",
        PossibleTypes = new [] { typeof(string) })]
        string LogIngestionEndpoint { get;  }
        /// <summary>Azure offering managing this resource on-behalf-of customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azure offering managing this resource on-behalf-of customer.",
        SerializedName = @"provisionedBy",
        PossibleTypes = new [] { typeof(string) })]
        string MetadataProvisionedBy { get;  }
        /// <summary>Resource Id of azure offering managing this resource on-behalf-of customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource Id of azure offering managing this resource on-behalf-of customer.",
        SerializedName = @"provisionedByResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string MetadataProvisionedByResourceId { get;  }
        /// <summary>The endpoint. This property is READ-ONLY.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The endpoint. This property is READ-ONLY.",
        SerializedName = @"endpoint",
        PossibleTypes = new [] { typeof(string) })]
        string MetricIngestionEndpoint { get;  }
        /// <summary>
        /// The configuration to set whether network access from public internet to the endpoints are allowed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The configuration to set whether network access from public internet to the endpoints are allowed.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PSArgumentCompleterAttribute("Enabled", "Disabled", "SecuredByPerimeter")]
        string NetworkAclsPublicNetworkAccess { get; set; }
        /// <summary>
        /// List of Azure Monitor Private Link Scope Resources to which this data collection endpoint resource is associated. This
        /// property is READ-ONLY.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of Azure Monitor Private Link Scope Resources to which this data collection endpoint resource is associated. This property is READ-ONLY.",
        SerializedName = @"privateLinkScopedResources",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IPrivateLinkScopedResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IPrivateLinkScopedResource> PrivateLinkScopedResource { get;  }
        /// <summary>The resource provisioning state. This property is READ-ONLY.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The resource provisioning state. This property is READ-ONLY.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PSArgumentCompleterAttribute("Creating", "Updating", "Deleting", "Succeeded", "Canceled", "Failed")]
        string ProvisioningState { get;  }

    }
    /// Definition of data collection endpoint.
    internal partial interface IDataCollectionEndpointInternal

    {
        /// <summary>The endpoint used by clients to access their configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointConfigurationAccess ConfigurationAccess { get; set; }
        /// <summary>The endpoint. This property is READ-ONLY.</summary>
        string ConfigurationAccessEndpoint { get; set; }
        /// <summary>Description of the data collection endpoint.</summary>
        string Description { get; set; }
        /// <summary>Failover configuration on this endpoint. This property is READ-ONLY.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointFailoverConfiguration FailoverConfiguration { get; set; }
        /// <summary>Active location where data flow will occur.</summary>
        string FailoverConfigurationActiveLocation { get; set; }
        /// <summary>Locations that are configured for failover.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.ILocationSpec> FailoverConfigurationLocation { get; set; }
        /// <summary>
        /// The immutable ID of this data collection endpoint resource. This property is READ-ONLY.
        /// </summary>
        string ImmutableId { get; set; }
        /// <summary>The endpoint. This property is READ-ONLY.</summary>
        string LogIngestionEndpoint { get; set; }
        /// <summary>The endpoint used by clients to ingest logs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointLogsIngestion LogsIngestion { get; set; }
        /// <summary>Metadata for the resource. This property is READ-ONLY.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointMetadata Metadata { get; set; }
        /// <summary>Azure offering managing this resource on-behalf-of customer.</summary>
        string MetadataProvisionedBy { get; set; }
        /// <summary>Resource Id of azure offering managing this resource on-behalf-of customer.</summary>
        string MetadataProvisionedByResourceId { get; set; }
        /// <summary>The endpoint. This property is READ-ONLY.</summary>
        string MetricIngestionEndpoint { get; set; }
        /// <summary>The endpoint used by clients to ingest metrics.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointMetricsIngestion MetricsIngestion { get; set; }
        /// <summary>Network access control rules for the endpoints.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointNetworkAcls NetworkAcls { get; set; }
        /// <summary>
        /// The configuration to set whether network access from public internet to the endpoints are allowed.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PSArgumentCompleterAttribute("Enabled", "Disabled", "SecuredByPerimeter")]
        string NetworkAclsPublicNetworkAccess { get; set; }
        /// <summary>
        /// List of Azure Monitor Private Link Scope Resources to which this data collection endpoint resource is associated. This
        /// property is READ-ONLY.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IPrivateLinkScopedResource> PrivateLinkScopedResource { get; set; }
        /// <summary>The resource provisioning state. This property is READ-ONLY.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PSArgumentCompleterAttribute("Creating", "Updating", "Deleting", "Succeeded", "Canceled", "Failed")]
        string ProvisioningState { get; set; }

    }
}