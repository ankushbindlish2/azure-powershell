// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Policy.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Extensions;

    /// <summary>
    /// Identity for the resource. Policy assignments support a maximum of one identity. That is either a system assigned identity
    /// or a single user assigned identity.
    /// </summary>
    public partial class Identity :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IIdentityInternal
    {

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IIdentityInternal.PrincipalId { get => this._principalId; set { {_principalId = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IIdentityInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>
        /// The principal ID of the resource identity. This property will only be provided for a system assigned identity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>
        /// The tenant ID of the resource identity. This property will only be provided for a system assigned identity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>
        /// The identity type. This is the only required field when adding a system or user assigned identity to a resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="UserAssignedIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IIdentityUserAssignedIdentities _userAssignedIdentity;

        /// <summary>
        /// The user identity associated with the policy. The user identity dictionary key references will be ARM resource ids in
        /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IIdentityUserAssignedIdentities UserAssignedIdentity { get => (this._userAssignedIdentity = this._userAssignedIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IdentityUserAssignedIdentities()); set => this._userAssignedIdentity = value; }

        /// <summary>Creates an new <see cref="Identity" /> instance.</summary>
        public Identity()
        {

        }
    }
    /// Identity for the resource. Policy assignments support a maximum of one identity. That is either a system assigned identity
    /// or a single user assigned identity.
    public partial interface IIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The principal ID of the resource identity. This property will only be provided for a system assigned identity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The principal ID of the resource identity.  This property will only be provided for a system assigned identity",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }
        /// <summary>
        /// The tenant ID of the resource identity. This property will only be provided for a system assigned identity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The tenant ID of the resource identity.  This property will only be provided for a system assigned identity",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }
        /// <summary>
        /// The identity type. This is the only required field when adding a system or user assigned identity to a resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identity type. This is the only required field when adding a system or user assigned identity to a resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Policy.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned", "None")]
        string Type { get; set; }
        /// <summary>
        /// The user identity associated with the policy. The user identity dictionary key references will be ARM resource ids in
        /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The user identity associated with the policy. The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IIdentityUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IIdentityUserAssignedIdentities UserAssignedIdentity { get; set; }

    }
    /// Identity for the resource. Policy assignments support a maximum of one identity. That is either a system assigned identity
    /// or a single user assigned identity.
    internal partial interface IIdentityInternal

    {
        /// <summary>
        /// The principal ID of the resource identity. This property will only be provided for a system assigned identity
        /// </summary>
        string PrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the resource identity. This property will only be provided for a system assigned identity
        /// </summary>
        string TenantId { get; set; }
        /// <summary>
        /// The identity type. This is the only required field when adding a system or user assigned identity to a resource.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Policy.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned", "None")]
        string Type { get; set; }
        /// <summary>
        /// The user identity associated with the policy. The user identity dictionary key references will be ARM resource ids in
        /// the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IIdentityUserAssignedIdentities UserAssignedIdentity { get; set; }

    }
}