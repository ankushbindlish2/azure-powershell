// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Extensions;

    /// <summary>The Intents of a cluster.</summary>
    public partial class IntentsAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal
    {

        /// <summary>Backing field for <see cref="AdapterPropertyOverride" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IAdapterPropertyOverridesAutoGenerated _adapterPropertyOverride;

        /// <summary>Set Adapter PropertyOverrides for cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IAdapterPropertyOverridesAutoGenerated AdapterPropertyOverride { get => (this._adapterPropertyOverride = this._adapterPropertyOverride ?? new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.AdapterPropertyOverridesAutoGenerated()); }

        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Inlined)]
        public string AdapterPropertyOverrideJumboPacket { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IAdapterPropertyOverridesAutoGeneratedInternal)AdapterPropertyOverride).JumboPacket; }

        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Inlined)]
        public string AdapterPropertyOverrideNetworkDirect { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IAdapterPropertyOverridesAutoGeneratedInternal)AdapterPropertyOverride).NetworkDirect; }

        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// Expected values are 'iWARP', 'RoCEv2', 'RoCE'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Inlined)]
        public string AdapterPropertyOverrideNetworkDirectTechnology { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IAdapterPropertyOverridesAutoGeneratedInternal)AdapterPropertyOverride).NetworkDirectTechnology; }

        /// <summary>Backing field for <see cref="IntentAdapter" /> property.</summary>
        private string[] _intentAdapter;

        /// <summary>Array of adapters used for the network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public string[] IntentAdapter { get => this._intentAdapter; }

        /// <summary>Backing field for <see cref="IntentName" /> property.</summary>
        private string _intentName;

        /// <summary>Name of the network intent you wish to create.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public string IntentName { get => this._intentName; }

        /// <summary>Backing field for <see cref="IntentType" /> property.</summary>
        private long? _intentType;

        /// <summary>IntentType for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public long? IntentType { get => this._intentType; }

        /// <summary>Backing field for <see cref="IsComputeIntentSet" /> property.</summary>
        private bool? _isComputeIntentSet;

        /// <summary>IsComputeIntentSet for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public bool? IsComputeIntentSet { get => this._isComputeIntentSet; }

        /// <summary>Backing field for <see cref="IsManagementIntentSet" /> property.</summary>
        private bool? _isManagementIntentSet;

        /// <summary>IsManagementIntentSet for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public bool? IsManagementIntentSet { get => this._isManagementIntentSet; }

        /// <summary>Backing field for <see cref="IsNetworkIntentType" /> property.</summary>
        private bool? _isNetworkIntentType;

        /// <summary>IsNetworkIntentType for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public bool? IsNetworkIntentType { get => this._isNetworkIntentType; }

        /// <summary>Backing field for <see cref="IsOnlyStorage" /> property.</summary>
        private bool? _isOnlyStorage;

        /// <summary>IntentType for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public bool? IsOnlyStorage { get => this._isOnlyStorage; }

        /// <summary>Backing field for <see cref="IsOnlyStretch" /> property.</summary>
        private bool? _isOnlyStretch;

        /// <summary>IsOnlyStretch for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public bool? IsOnlyStretch { get => this._isOnlyStretch; }

        /// <summary>Backing field for <see cref="IsStorageIntentSet" /> property.</summary>
        private bool? _isStorageIntentSet;

        /// <summary>IsStorageIntentSet for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public bool? IsStorageIntentSet { get => this._isStorageIntentSet; }

        /// <summary>Backing field for <see cref="IsStretchIntentSet" /> property.</summary>
        private bool? _isStretchIntentSet;

        /// <summary>IsStretchIntentSet for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public bool? IsStretchIntentSet { get => this._isStretchIntentSet; }

        /// <summary>Internal Acessors for AdapterPropertyOverride</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IAdapterPropertyOverridesAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.AdapterPropertyOverride { get => (this._adapterPropertyOverride = this._adapterPropertyOverride ?? new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.AdapterPropertyOverridesAutoGenerated()); set { {_adapterPropertyOverride = value;} } }

        /// <summary>Internal Acessors for AdapterPropertyOverrideJumboPacket</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.AdapterPropertyOverrideJumboPacket { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IAdapterPropertyOverridesAutoGeneratedInternal)AdapterPropertyOverride).JumboPacket; set => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IAdapterPropertyOverridesAutoGeneratedInternal)AdapterPropertyOverride).JumboPacket = value; }

        /// <summary>Internal Acessors for AdapterPropertyOverrideNetworkDirect</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.AdapterPropertyOverrideNetworkDirect { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IAdapterPropertyOverridesAutoGeneratedInternal)AdapterPropertyOverride).NetworkDirect; set => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IAdapterPropertyOverridesAutoGeneratedInternal)AdapterPropertyOverride).NetworkDirect = value; }

        /// <summary>Internal Acessors for AdapterPropertyOverrideNetworkDirectTechnology</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.AdapterPropertyOverrideNetworkDirectTechnology { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IAdapterPropertyOverridesAutoGeneratedInternal)AdapterPropertyOverride).NetworkDirectTechnology; set => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IAdapterPropertyOverridesAutoGeneratedInternal)AdapterPropertyOverride).NetworkDirectTechnology = value; }

        /// <summary>Internal Acessors for IntentAdapter</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.IntentAdapter { get => this._intentAdapter; set { {_intentAdapter = value;} } }

        /// <summary>Internal Acessors for IntentName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.IntentName { get => this._intentName; set { {_intentName = value;} } }

        /// <summary>Internal Acessors for IntentType</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.IntentType { get => this._intentType; set { {_intentType = value;} } }

        /// <summary>Internal Acessors for IsComputeIntentSet</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.IsComputeIntentSet { get => this._isComputeIntentSet; set { {_isComputeIntentSet = value;} } }

        /// <summary>Internal Acessors for IsManagementIntentSet</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.IsManagementIntentSet { get => this._isManagementIntentSet; set { {_isManagementIntentSet = value;} } }

        /// <summary>Internal Acessors for IsNetworkIntentType</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.IsNetworkIntentType { get => this._isNetworkIntentType; set { {_isNetworkIntentType = value;} } }

        /// <summary>Internal Acessors for IsOnlyStorage</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.IsOnlyStorage { get => this._isOnlyStorage; set { {_isOnlyStorage = value;} } }

        /// <summary>Internal Acessors for IsOnlyStretch</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.IsOnlyStretch { get => this._isOnlyStretch; set { {_isOnlyStretch = value;} } }

        /// <summary>Internal Acessors for IsStorageIntentSet</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.IsStorageIntentSet { get => this._isStorageIntentSet; set { {_isStorageIntentSet = value;} } }

        /// <summary>Internal Acessors for IsStretchIntentSet</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.IsStretchIntentSet { get => this._isStretchIntentSet; set { {_isStretchIntentSet = value;} } }

        /// <summary>Internal Acessors for OverrideAdapterProperty</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.OverrideAdapterProperty { get => this._overrideAdapterProperty; set { {_overrideAdapterProperty = value;} } }

        /// <summary>Internal Acessors for OverrideQosPolicy</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.OverrideQosPolicy { get => this._overrideQosPolicy; set { {_overrideQosPolicy = value;} } }

        /// <summary>Internal Acessors for OverrideVirtualSwitchConfiguration</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.OverrideVirtualSwitchConfiguration { get => this._overrideVirtualSwitchConfiguration; set { {_overrideVirtualSwitchConfiguration = value;} } }

        /// <summary>Internal Acessors for QosPolicyOverride</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IQosPolicyOverrides Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.QosPolicyOverride { get => (this._qosPolicyOverride = this._qosPolicyOverride ?? new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.QosPolicyOverrides()); set { {_qosPolicyOverride = value;} } }

        /// <summary>Internal Acessors for Scope</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.Scope { get => this._scope; set { {_scope = value;} } }

        /// <summary>Internal Acessors for VirtualSwitchConfigurationOverride</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IVirtualSwitchConfigurationOverridesAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.VirtualSwitchConfigurationOverride { get => (this._virtualSwitchConfigurationOverride = this._virtualSwitchConfigurationOverride ?? new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.VirtualSwitchConfigurationOverridesAutoGenerated()); set { {_virtualSwitchConfigurationOverride = value;} } }

        /// <summary>Internal Acessors for VirtualSwitchConfigurationOverrideEnableIov</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.VirtualSwitchConfigurationOverrideEnableIov { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IVirtualSwitchConfigurationOverridesAutoGeneratedInternal)VirtualSwitchConfigurationOverride).EnableIov; set => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IVirtualSwitchConfigurationOverridesAutoGeneratedInternal)VirtualSwitchConfigurationOverride).EnableIov = value; }

        /// <summary>Internal Acessors for VirtualSwitchConfigurationOverrideLoadBalancingAlgorithm</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IIntentsAutoGeneratedInternal.VirtualSwitchConfigurationOverrideLoadBalancingAlgorithm { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IVirtualSwitchConfigurationOverridesAutoGeneratedInternal)VirtualSwitchConfigurationOverride).LoadBalancingAlgorithm; set => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IVirtualSwitchConfigurationOverridesAutoGeneratedInternal)VirtualSwitchConfigurationOverride).LoadBalancingAlgorithm = value; }

        /// <summary>Backing field for <see cref="OverrideAdapterProperty" /> property.</summary>
        private bool? _overrideAdapterProperty;

        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public bool? OverrideAdapterProperty { get => this._overrideAdapterProperty; }

        /// <summary>Backing field for <see cref="OverrideQosPolicy" /> property.</summary>
        private bool? _overrideQosPolicy;

        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public bool? OverrideQosPolicy { get => this._overrideQosPolicy; }

        /// <summary>Backing field for <see cref="OverrideVirtualSwitchConfiguration" /> property.</summary>
        private bool? _overrideVirtualSwitchConfiguration;

        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public bool? OverrideVirtualSwitchConfiguration { get => this._overrideVirtualSwitchConfiguration; }

        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Inlined)]
        public string QoPolicyOverrideBandwidthPercentageSmb { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IQosPolicyOverridesInternal)QosPolicyOverride).BandwidthPercentageSmb; set => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IQosPolicyOverridesInternal)QosPolicyOverride).BandwidthPercentageSmb = value ?? null; }

        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Inlined)]
        public string QoPolicyOverridePriorityValue8021ActionCluster { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IQosPolicyOverridesInternal)QosPolicyOverride).PriorityValue8021ActionCluster; set => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IQosPolicyOverridesInternal)QosPolicyOverride).PriorityValue8021ActionCluster = value ?? null; }

        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Inlined)]
        public string QoPolicyOverridePriorityValue8021ActionSmb { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IQosPolicyOverridesInternal)QosPolicyOverride).PriorityValue8021ActionSmb; set => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IQosPolicyOverridesInternal)QosPolicyOverride).PriorityValue8021ActionSmb = value ?? null; }

        /// <summary>Backing field for <see cref="QosPolicyOverride" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IQosPolicyOverrides _qosPolicyOverride;

        /// <summary>Set QoS PolicyOverrides for cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IQosPolicyOverrides QosPolicyOverride { get => (this._qosPolicyOverride = this._qosPolicyOverride ?? new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.QosPolicyOverrides()); }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private long? _scope;

        /// <summary>Scope for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public long? Scope { get => this._scope; }

        /// <summary>Backing field for <see cref="VirtualSwitchConfigurationOverride" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IVirtualSwitchConfigurationOverridesAutoGenerated _virtualSwitchConfigurationOverride;

        /// <summary>Set virtualSwitch ConfigurationOverrides for cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IVirtualSwitchConfigurationOverridesAutoGenerated VirtualSwitchConfigurationOverride { get => (this._virtualSwitchConfigurationOverride = this._virtualSwitchConfigurationOverride ?? new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.VirtualSwitchConfigurationOverridesAutoGenerated()); }

        /// <summary>Enable IoV for Virtual Switch</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Inlined)]
        public string VirtualSwitchConfigurationOverrideEnableIov { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IVirtualSwitchConfigurationOverridesAutoGeneratedInternal)VirtualSwitchConfigurationOverride).EnableIov; }

        /// <summary>Load Balancing Algorithm for Virtual Switch</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Inlined)]
        public string VirtualSwitchConfigurationOverrideLoadBalancingAlgorithm { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IVirtualSwitchConfigurationOverridesAutoGeneratedInternal)VirtualSwitchConfigurationOverride).LoadBalancingAlgorithm; }

        /// <summary>Creates an new <see cref="IntentsAutoGenerated" /> instance.</summary>
        public IntentsAutoGenerated()
        {

        }
    }
    /// The Intents of a cluster.
    public partial interface IIntentsAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.IJsonSerializable
    {
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.",
        SerializedName = @"jumboPacket",
        PossibleTypes = new [] { typeof(string) })]
        string AdapterPropertyOverrideJumboPacket { get;  }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.",
        SerializedName = @"networkDirect",
        PossibleTypes = new [] { typeof(string) })]
        string AdapterPropertyOverrideNetworkDirect { get;  }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// Expected values are 'iWARP', 'RoCEv2', 'RoCE'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation. Expected values are 'iWARP', 'RoCEv2', 'RoCE'",
        SerializedName = @"networkDirectTechnology",
        PossibleTypes = new [] { typeof(string) })]
        string AdapterPropertyOverrideNetworkDirectTechnology { get;  }
        /// <summary>Array of adapters used for the network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Array of adapters used for the network intent.",
        SerializedName = @"intentAdapters",
        PossibleTypes = new [] { typeof(string) })]
        string[] IntentAdapter { get;  }
        /// <summary>Name of the network intent you wish to create.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Name of the network intent you wish to create.",
        SerializedName = @"intentName",
        PossibleTypes = new [] { typeof(string) })]
        string IntentName { get;  }
        /// <summary>IntentType for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"IntentType for host network intent.",
        SerializedName = @"intentType",
        PossibleTypes = new [] { typeof(long) })]
        long? IntentType { get;  }
        /// <summary>IsComputeIntentSet for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"IsComputeIntentSet for host network intent.",
        SerializedName = @"isComputeIntentSet",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsComputeIntentSet { get;  }
        /// <summary>IsManagementIntentSet for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"IsManagementIntentSet for host network intent.",
        SerializedName = @"isManagementIntentSet",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsManagementIntentSet { get;  }
        /// <summary>IsNetworkIntentType for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"IsNetworkIntentType for host network intent.",
        SerializedName = @"isNetworkIntentType",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsNetworkIntentType { get;  }
        /// <summary>IntentType for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"IntentType for host network intent.",
        SerializedName = @"isOnlyStorage",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsOnlyStorage { get;  }
        /// <summary>IsOnlyStretch for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"IsOnlyStretch for host network intent.",
        SerializedName = @"isOnlyStretch",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsOnlyStretch { get;  }
        /// <summary>IsStorageIntentSet for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"IsStorageIntentSet for host network intent.",
        SerializedName = @"isStorageIntentSet",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsStorageIntentSet { get;  }
        /// <summary>IsStretchIntentSet for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"IsStretchIntentSet for host network intent.",
        SerializedName = @"isStretchIntentSet",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsStretchIntentSet { get;  }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.",
        SerializedName = @"overrideAdapterProperty",
        PossibleTypes = new [] { typeof(bool) })]
        bool? OverrideAdapterProperty { get;  }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.",
        SerializedName = @"overrideQosPolicy",
        PossibleTypes = new [] { typeof(bool) })]
        bool? OverrideQosPolicy { get;  }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.",
        SerializedName = @"overrideVirtualSwitchConfiguration",
        PossibleTypes = new [] { typeof(bool) })]
        bool? OverrideVirtualSwitchConfiguration { get;  }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.",
        SerializedName = @"bandwidthPercentage_SMB",
        PossibleTypes = new [] { typeof(string) })]
        string QoPolicyOverrideBandwidthPercentageSmb { get; set; }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.",
        SerializedName = @"priorityValue8021Action_Cluster",
        PossibleTypes = new [] { typeof(string) })]
        string QoPolicyOverridePriorityValue8021ActionCluster { get; set; }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.",
        SerializedName = @"priorityValue8021Action_SMB",
        PossibleTypes = new [] { typeof(string) })]
        string QoPolicyOverridePriorityValue8021ActionSmb { get; set; }
        /// <summary>Scope for host network intent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Scope for host network intent.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(long) })]
        long? Scope { get;  }
        /// <summary>Enable IoV for Virtual Switch</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Enable IoV for Virtual Switch",
        SerializedName = @"enableIov",
        PossibleTypes = new [] { typeof(string) })]
        string VirtualSwitchConfigurationOverrideEnableIov { get;  }
        /// <summary>Load Balancing Algorithm for Virtual Switch</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Load Balancing Algorithm for Virtual Switch",
        SerializedName = @"loadBalancingAlgorithm",
        PossibleTypes = new [] { typeof(string) })]
        string VirtualSwitchConfigurationOverrideLoadBalancingAlgorithm { get;  }

    }
    /// The Intents of a cluster.
    internal partial interface IIntentsAutoGeneratedInternal

    {
        /// <summary>Set Adapter PropertyOverrides for cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IAdapterPropertyOverridesAutoGenerated AdapterPropertyOverride { get; set; }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        string AdapterPropertyOverrideJumboPacket { get; set; }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        string AdapterPropertyOverrideNetworkDirect { get; set; }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// Expected values are 'iWARP', 'RoCEv2', 'RoCE'
        /// </summary>
        string AdapterPropertyOverrideNetworkDirectTechnology { get; set; }
        /// <summary>Array of adapters used for the network intent.</summary>
        string[] IntentAdapter { get; set; }
        /// <summary>Name of the network intent you wish to create.</summary>
        string IntentName { get; set; }
        /// <summary>IntentType for host network intent.</summary>
        long? IntentType { get; set; }
        /// <summary>IsComputeIntentSet for host network intent.</summary>
        bool? IsComputeIntentSet { get; set; }
        /// <summary>IsManagementIntentSet for host network intent.</summary>
        bool? IsManagementIntentSet { get; set; }
        /// <summary>IsNetworkIntentType for host network intent.</summary>
        bool? IsNetworkIntentType { get; set; }
        /// <summary>IntentType for host network intent.</summary>
        bool? IsOnlyStorage { get; set; }
        /// <summary>IsOnlyStretch for host network intent.</summary>
        bool? IsOnlyStretch { get; set; }
        /// <summary>IsStorageIntentSet for host network intent.</summary>
        bool? IsStorageIntentSet { get; set; }
        /// <summary>IsStretchIntentSet for host network intent.</summary>
        bool? IsStretchIntentSet { get; set; }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        bool? OverrideAdapterProperty { get; set; }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        bool? OverrideQosPolicy { get; set; }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        bool? OverrideVirtualSwitchConfiguration { get; set; }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        string QoPolicyOverrideBandwidthPercentageSmb { get; set; }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        string QoPolicyOverridePriorityValue8021ActionCluster { get; set; }
        /// <summary>
        /// This parameter should only be modified based on your OEM guidance. Do not modify this parameter without OEM validation.
        /// </summary>
        string QoPolicyOverridePriorityValue8021ActionSmb { get; set; }
        /// <summary>Set QoS PolicyOverrides for cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IQosPolicyOverrides QosPolicyOverride { get; set; }
        /// <summary>Scope for host network intent.</summary>
        long? Scope { get; set; }
        /// <summary>Set virtualSwitch ConfigurationOverrides for cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IVirtualSwitchConfigurationOverridesAutoGenerated VirtualSwitchConfigurationOverride { get; set; }
        /// <summary>Enable IoV for Virtual Switch</summary>
        string VirtualSwitchConfigurationOverrideEnableIov { get; set; }
        /// <summary>Load Balancing Algorithm for Virtual Switch</summary>
        string VirtualSwitchConfigurationOverrideLoadBalancingAlgorithm { get; set; }

    }
}