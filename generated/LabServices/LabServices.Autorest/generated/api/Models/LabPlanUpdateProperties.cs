// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>Lab plan resource properties for updates</summary>
    public partial class LabPlanUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AllowedRegion" /> property.</summary>
        private System.Collections.Generic.List<string> _allowedRegion;

        /// <summary>
        /// The allowed regions for the lab creator to use when creating labs using this lab plan.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> AllowedRegion { get => this._allowedRegion; set => this._allowedRegion = value; }

        /// <summary>Backing field for <see cref="DefaultAutoShutdownProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfile _defaultAutoShutdownProfile;

        /// <summary>
        /// The default lab shutdown profile. This can be changed on a lab resource and only provides a default profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfile DefaultAutoShutdownProfile { get => (this._defaultAutoShutdownProfile = this._defaultAutoShutdownProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.AutoShutdownProfile()); set => this._defaultAutoShutdownProfile = value; }

        /// <summary>
        /// The amount of time a VM will stay running after a user disconnects if this behavior is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.TimeSpan? DefaultAutoShutdownProfileDisconnectDelay { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfileInternal)DefaultAutoShutdownProfile).DisconnectDelay; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfileInternal)DefaultAutoShutdownProfile).DisconnectDelay = value ?? default(global::System.TimeSpan); }

        /// <summary>
        /// The amount of time a VM will idle before it is shutdown if this behavior is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.TimeSpan? DefaultAutoShutdownProfileIdleDelay { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfileInternal)DefaultAutoShutdownProfile).IdleDelay; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfileInternal)DefaultAutoShutdownProfile).IdleDelay = value ?? default(global::System.TimeSpan); }

        /// <summary>
        /// The amount of time a VM will stay running before it is shutdown if no connection is made and this behavior is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.TimeSpan? DefaultAutoShutdownProfileNoConnectDelay { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfileInternal)DefaultAutoShutdownProfile).NoConnectDelay; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfileInternal)DefaultAutoShutdownProfile).NoConnectDelay = value ?? default(global::System.TimeSpan); }

        /// <summary>Whether shutdown on disconnect is enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DefaultAutoShutdownProfileShutdownOnDisconnect { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfileInternal)DefaultAutoShutdownProfile).ShutdownOnDisconnect; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfileInternal)DefaultAutoShutdownProfile).ShutdownOnDisconnect = value ?? null; }

        /// <summary>Whether a VM will get shutdown when it has idled for a period of time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DefaultAutoShutdownProfileShutdownOnIdle { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfileInternal)DefaultAutoShutdownProfile).ShutdownOnIdle; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfileInternal)DefaultAutoShutdownProfile).ShutdownOnIdle = value ?? null; }

        /// <summary>
        /// Whether a VM will get shutdown when it hasn't been connected to after a period of time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DefaultAutoShutdownProfileShutdownWhenNotConnected { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfileInternal)DefaultAutoShutdownProfile).ShutdownWhenNotConnected; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfileInternal)DefaultAutoShutdownProfile).ShutdownWhenNotConnected = value ?? null; }

        /// <summary>Backing field for <see cref="DefaultConnectionProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IConnectionProfile _defaultConnectionProfile;

        /// <summary>
        /// The default lab connection profile. This can be changed on a lab resource and only provides a default profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IConnectionProfile DefaultConnectionProfile { get => (this._defaultConnectionProfile = this._defaultConnectionProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ConnectionProfile()); set => this._defaultConnectionProfile = value; }

        /// <summary>The enabled access level for Client Access over RDP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DefaultConnectionProfileClientRdpAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IConnectionProfileInternal)DefaultConnectionProfile).ClientRdpAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IConnectionProfileInternal)DefaultConnectionProfile).ClientRdpAccess = value ?? null; }

        /// <summary>The enabled access level for Client Access over SSH.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DefaultConnectionProfileClientSshAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IConnectionProfileInternal)DefaultConnectionProfile).ClientSshAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IConnectionProfileInternal)DefaultConnectionProfile).ClientSshAccess = value ?? null; }

        /// <summary>The enabled access level for Web Access over RDP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DefaultConnectionProfileWebRdpAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IConnectionProfileInternal)DefaultConnectionProfile).WebRdpAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IConnectionProfileInternal)DefaultConnectionProfile).WebRdpAccess = value ?? null; }

        /// <summary>The enabled access level for Web Access over SSH.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DefaultConnectionProfileWebSshAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IConnectionProfileInternal)DefaultConnectionProfile).WebSshAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IConnectionProfileInternal)DefaultConnectionProfile).WebSshAccess = value ?? null; }

        /// <summary>Backing field for <see cref="DefaultNetworkProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanNetworkProfile _defaultNetworkProfile;

        /// <summary>
        /// The lab plan network profile. To enforce lab network policies they must be defined here and cannot be changed when there
        /// are existing labs associated with this lab plan.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanNetworkProfile DefaultNetworkProfile { get => (this._defaultNetworkProfile = this._defaultNetworkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.LabPlanNetworkProfile()); set => this._defaultNetworkProfile = value; }

        /// <summary>The external subnet resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DefaultNetworkProfileSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanNetworkProfileInternal)DefaultNetworkProfile).SubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanNetworkProfileInternal)DefaultNetworkProfile).SubnetId = value ?? null; }

        /// <summary>Backing field for <see cref="LinkedLmsInstance" /> property.</summary>
        private string _linkedLmsInstance;

        /// <summary>Base Url of the lms instance this lab plan can link lab rosters against.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string LinkedLmsInstance { get => this._linkedLmsInstance; set => this._linkedLmsInstance = value; }

        /// <summary>Internal Acessors for DefaultAutoShutdownProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfile Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal.DefaultAutoShutdownProfile { get => (this._defaultAutoShutdownProfile = this._defaultAutoShutdownProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.AutoShutdownProfile()); set { {_defaultAutoShutdownProfile = value;} } }

        /// <summary>Internal Acessors for DefaultConnectionProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IConnectionProfile Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal.DefaultConnectionProfile { get => (this._defaultConnectionProfile = this._defaultConnectionProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ConnectionProfile()); set { {_defaultConnectionProfile = value;} } }

        /// <summary>Internal Acessors for DefaultNetworkProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanNetworkProfile Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal.DefaultNetworkProfile { get => (this._defaultNetworkProfile = this._defaultNetworkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.LabPlanNetworkProfile()); set { {_defaultNetworkProfile = value;} } }

        /// <summary>Internal Acessors for SupportInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ISupportInfo Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanUpdatePropertiesInternal.SupportInfo { get => (this._supportInfo = this._supportInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.SupportInfo()); set { {_supportInfo = value;} } }

        /// <summary>Backing field for <see cref="SharedGalleryId" /> property.</summary>
        private string _sharedGalleryId;

        /// <summary>
        /// Resource ID of the Shared Image Gallery attached to this lab plan. When saving a lab template virtual machine image it
        /// will be persisted in this gallery. Shared images from the gallery can be made available to use when creating new labs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string SharedGalleryId { get => this._sharedGalleryId; set => this._sharedGalleryId = value; }

        /// <summary>Backing field for <see cref="SupportInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ISupportInfo _supportInfo;

        /// <summary>
        /// Support contact information and instructions for users of the lab plan. This information is displayed to lab owners and
        /// virtual machine users for all labs in the lab plan.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ISupportInfo SupportInfo { get => (this._supportInfo = this._supportInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.SupportInfo()); set => this._supportInfo = value; }

        /// <summary>Support contact email address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string SupportInfoEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ISupportInfoInternal)SupportInfo).Email; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ISupportInfoInternal)SupportInfo).Email = value ?? null; }

        /// <summary>Support instructions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string SupportInfoInstruction { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ISupportInfoInternal)SupportInfo).Instruction; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ISupportInfoInternal)SupportInfo).Instruction = value ?? null; }

        /// <summary>Support contact phone number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string SupportInfoPhone { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ISupportInfoInternal)SupportInfo).Phone; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ISupportInfoInternal)SupportInfo).Phone = value ?? null; }

        /// <summary>Support web address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string SupportInfoUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ISupportInfoInternal)SupportInfo).Url; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ISupportInfoInternal)SupportInfo).Url = value ?? null; }

        /// <summary>Creates an new <see cref="LabPlanUpdateProperties" /> instance.</summary>
        public LabPlanUpdateProperties()
        {

        }
    }
    /// Lab plan resource properties for updates
    public partial interface ILabPlanUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The allowed regions for the lab creator to use when creating labs using this lab plan.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The allowed regions for the lab creator to use when creating labs using this lab plan.",
        SerializedName = @"allowedRegions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AllowedRegion { get; set; }
        /// <summary>
        /// The amount of time a VM will stay running after a user disconnects if this behavior is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time a VM will stay running after a user disconnects if this behavior is enabled.",
        SerializedName = @"disconnectDelay",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? DefaultAutoShutdownProfileDisconnectDelay { get; set; }
        /// <summary>
        /// The amount of time a VM will idle before it is shutdown if this behavior is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time a VM will idle before it is shutdown if this behavior is enabled.",
        SerializedName = @"idleDelay",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? DefaultAutoShutdownProfileIdleDelay { get; set; }
        /// <summary>
        /// The amount of time a VM will stay running before it is shutdown if no connection is made and this behavior is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time a VM will stay running before it is shutdown if no connection is made and this behavior is enabled.",
        SerializedName = @"noConnectDelay",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? DefaultAutoShutdownProfileNoConnectDelay { get; set; }
        /// <summary>Whether shutdown on disconnect is enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether shutdown on disconnect is enabled",
        SerializedName = @"shutdownOnDisconnect",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string DefaultAutoShutdownProfileShutdownOnDisconnect { get; set; }
        /// <summary>Whether a VM will get shutdown when it has idled for a period of time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether a VM will get shutdown when it has idled for a period of time.",
        SerializedName = @"shutdownOnIdle",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("None", "UserAbsence", "LowUsage")]
        string DefaultAutoShutdownProfileShutdownOnIdle { get; set; }
        /// <summary>
        /// Whether a VM will get shutdown when it hasn't been connected to after a period of time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether a VM will get shutdown when it hasn't been connected to after a period of time.",
        SerializedName = @"shutdownWhenNotConnected",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string DefaultAutoShutdownProfileShutdownWhenNotConnected { get; set; }
        /// <summary>The enabled access level for Client Access over RDP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The enabled access level for Client Access over RDP.",
        SerializedName = @"clientRdpAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Public", "Private", "None")]
        string DefaultConnectionProfileClientRdpAccess { get; set; }
        /// <summary>The enabled access level for Client Access over SSH.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The enabled access level for Client Access over SSH.",
        SerializedName = @"clientSshAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Public", "Private", "None")]
        string DefaultConnectionProfileClientSshAccess { get; set; }
        /// <summary>The enabled access level for Web Access over RDP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The enabled access level for Web Access over RDP.",
        SerializedName = @"webRdpAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Public", "Private", "None")]
        string DefaultConnectionProfileWebRdpAccess { get; set; }
        /// <summary>The enabled access level for Web Access over SSH.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The enabled access level for Web Access over SSH.",
        SerializedName = @"webSshAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Public", "Private", "None")]
        string DefaultConnectionProfileWebSshAccess { get; set; }
        /// <summary>The external subnet resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The external subnet resource id",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultNetworkProfileSubnetId { get; set; }
        /// <summary>Base Url of the lms instance this lab plan can link lab rosters against.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Base Url of the lms instance this lab plan can link lab rosters against.",
        SerializedName = @"linkedLmsInstance",
        PossibleTypes = new [] { typeof(string) })]
        string LinkedLmsInstance { get; set; }
        /// <summary>
        /// Resource ID of the Shared Image Gallery attached to this lab plan. When saving a lab template virtual machine image it
        /// will be persisted in this gallery. Shared images from the gallery can be made available to use when creating new labs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource ID of the Shared Image Gallery attached to this lab plan. When saving a lab template virtual machine image it will be persisted in this gallery. Shared images from the gallery can be made available to use when creating new labs.",
        SerializedName = @"sharedGalleryId",
        PossibleTypes = new [] { typeof(string) })]
        string SharedGalleryId { get; set; }
        /// <summary>Support contact email address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Support contact email address.",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string SupportInfoEmail { get; set; }
        /// <summary>Support instructions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Support instructions.",
        SerializedName = @"instructions",
        PossibleTypes = new [] { typeof(string) })]
        string SupportInfoInstruction { get; set; }
        /// <summary>Support contact phone number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Support contact phone number.",
        SerializedName = @"phone",
        PossibleTypes = new [] { typeof(string) })]
        string SupportInfoPhone { get; set; }
        /// <summary>Support web address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Support web address.",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string SupportInfoUrl { get; set; }

    }
    /// Lab plan resource properties for updates
    internal partial interface ILabPlanUpdatePropertiesInternal

    {
        /// <summary>
        /// The allowed regions for the lab creator to use when creating labs using this lab plan.
        /// </summary>
        System.Collections.Generic.List<string> AllowedRegion { get; set; }
        /// <summary>
        /// The default lab shutdown profile. This can be changed on a lab resource and only provides a default profile.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IAutoShutdownProfile DefaultAutoShutdownProfile { get; set; }
        /// <summary>
        /// The amount of time a VM will stay running after a user disconnects if this behavior is enabled.
        /// </summary>
        global::System.TimeSpan? DefaultAutoShutdownProfileDisconnectDelay { get; set; }
        /// <summary>
        /// The amount of time a VM will idle before it is shutdown if this behavior is enabled.
        /// </summary>
        global::System.TimeSpan? DefaultAutoShutdownProfileIdleDelay { get; set; }
        /// <summary>
        /// The amount of time a VM will stay running before it is shutdown if no connection is made and this behavior is enabled.
        /// </summary>
        global::System.TimeSpan? DefaultAutoShutdownProfileNoConnectDelay { get; set; }
        /// <summary>Whether shutdown on disconnect is enabled</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string DefaultAutoShutdownProfileShutdownOnDisconnect { get; set; }
        /// <summary>Whether a VM will get shutdown when it has idled for a period of time.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("None", "UserAbsence", "LowUsage")]
        string DefaultAutoShutdownProfileShutdownOnIdle { get; set; }
        /// <summary>
        /// Whether a VM will get shutdown when it hasn't been connected to after a period of time.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string DefaultAutoShutdownProfileShutdownWhenNotConnected { get; set; }
        /// <summary>
        /// The default lab connection profile. This can be changed on a lab resource and only provides a default profile.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IConnectionProfile DefaultConnectionProfile { get; set; }
        /// <summary>The enabled access level for Client Access over RDP.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Public", "Private", "None")]
        string DefaultConnectionProfileClientRdpAccess { get; set; }
        /// <summary>The enabled access level for Client Access over SSH.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Public", "Private", "None")]
        string DefaultConnectionProfileClientSshAccess { get; set; }
        /// <summary>The enabled access level for Web Access over RDP.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Public", "Private", "None")]
        string DefaultConnectionProfileWebRdpAccess { get; set; }
        /// <summary>The enabled access level for Web Access over SSH.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Public", "Private", "None")]
        string DefaultConnectionProfileWebSshAccess { get; set; }
        /// <summary>
        /// The lab plan network profile. To enforce lab network policies they must be defined here and cannot be changed when there
        /// are existing labs associated with this lab plan.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabPlanNetworkProfile DefaultNetworkProfile { get; set; }
        /// <summary>The external subnet resource id</summary>
        string DefaultNetworkProfileSubnetId { get; set; }
        /// <summary>Base Url of the lms instance this lab plan can link lab rosters against.</summary>
        string LinkedLmsInstance { get; set; }
        /// <summary>
        /// Resource ID of the Shared Image Gallery attached to this lab plan. When saving a lab template virtual machine image it
        /// will be persisted in this gallery. Shared images from the gallery can be made available to use when creating new labs.
        /// </summary>
        string SharedGalleryId { get; set; }
        /// <summary>
        /// Support contact information and instructions for users of the lab plan. This information is displayed to lab owners and
        /// virtual machine users for all labs in the lab plan.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ISupportInfo SupportInfo { get; set; }
        /// <summary>Support contact email address.</summary>
        string SupportInfoEmail { get; set; }
        /// <summary>Support instructions.</summary>
        string SupportInfoInstruction { get; set; }
        /// <summary>Support contact phone number.</summary>
        string SupportInfoPhone { get; set; }
        /// <summary>Support web address.</summary>
        string SupportInfoUrl { get; set; }

    }
}