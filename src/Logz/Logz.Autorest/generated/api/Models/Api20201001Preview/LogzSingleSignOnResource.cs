// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Extensions;

    public partial class LogzSingleSignOnResource :
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnResource,
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnResourceInternal
    {

        /// <summary>The Id of the Enterprise App used for Single sign-on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.DoNotFormat]
        public string EnterpriseAppId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)Property).EnterpriseAppId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)Property).EnterpriseAppId = value ?? null; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ARM id of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.DoNotFormat]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnResourceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnResourceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnProperties Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.LogzSingleSignOnProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnResourceInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnResourceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.FormatTable(Index = 0)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnProperties _property;

        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.LogzSingleSignOnProperties()); set => this._property = value; }

        /// <summary>Flag specifying if the resource provisioning state as tracked by ARM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.FormatTable(Index = 1)]
        public Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.DoNotFormat]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Various states of the SSO resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.FormatTable(Index = 2)]
        public Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.SingleSignOnStates? SingleSignOnState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)Property).SingleSignOnState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)Property).SingleSignOnState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.SingleSignOnStates)""); }

        /// <summary>The login URL specific to this Logz Organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.FormatTable(Index = 3)]
        public string SingleSignOnUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)Property).SingleSignOnUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)Property).SingleSignOnUrl = value ?? null; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.ISystemData _systemData;

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.CreatedByType)""); }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.DoNotFormat]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="LogzSingleSignOnResource" /> instance.</summary>
        public LogzSingleSignOnResource()
        {

        }
    }
    public partial interface ILogzSingleSignOnResource :
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.IJsonSerializable
    {
        /// <summary>The Id of the Enterprise App used for Single sign-on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Id of the Enterprise App used for Single sign-on.",
        SerializedName = @"enterpriseAppId",
        PossibleTypes = new [] { typeof(string) })]
        string EnterpriseAppId { get; set; }
        /// <summary>ARM id of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"ARM id of the resource.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Name of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Name of the configuration.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Flag specifying if the resource provisioning state as tracked by ARM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Flag specifying if the resource provisioning state as tracked by ARM.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Various states of the SSO resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Various states of the SSO resource",
        SerializedName = @"singleSignOnState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.SingleSignOnStates) })]
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.SingleSignOnStates? SingleSignOnState { get; set; }
        /// <summary>The login URL specific to this Logz Organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The login URL specific to this Logz Organization.",
        SerializedName = @"singleSignOnUrl",
        PossibleTypes = new [] { typeof(string) })]
        string SingleSignOnUrl { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    internal partial interface ILogzSingleSignOnResourceInternal

    {
        /// <summary>The Id of the Enterprise App used for Single sign-on.</summary>
        string EnterpriseAppId { get; set; }
        /// <summary>ARM id of the resource.</summary>
        string Id { get; set; }
        /// <summary>Name of the configuration.</summary>
        string Name { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnProperties Property { get; set; }
        /// <summary>Flag specifying if the resource provisioning state as tracked by ARM.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Various states of the SSO resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.SingleSignOnStates? SingleSignOnState { get; set; }
        /// <summary>The login URL specific to this Logz Organization.</summary>
        string SingleSignOnUrl { get; set; }
        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>The type of the resource.</summary>
        string Type { get; set; }

    }
}