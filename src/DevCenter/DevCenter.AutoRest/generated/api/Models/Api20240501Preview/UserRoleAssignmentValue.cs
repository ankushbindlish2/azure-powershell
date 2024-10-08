// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Extensions;

    /// <summary>Mapping of user object ID to role assignments.</summary>
    public partial class UserRoleAssignmentValue :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IUserRoleAssignmentValue,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IUserRoleAssignmentValueInternal
    {

        /// <summary>Backing field for <see cref="Role" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IUserRoleAssignmentRoles _role;

        /// <summary>A map of roles to assign to the parent user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IUserRoleAssignmentRoles Role { get => (this._role = this._role ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.UserRoleAssignmentRoles()); set => this._role = value; }

        /// <summary>Creates an new <see cref="UserRoleAssignmentValue" /> instance.</summary>
        public UserRoleAssignmentValue()
        {

        }
    }
    /// Mapping of user object ID to role assignments.
    public partial interface IUserRoleAssignmentValue :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IJsonSerializable
    {
        /// <summary>A map of roles to assign to the parent user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A map of roles to assign to the parent user.",
        SerializedName = @"roles",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IUserRoleAssignmentRoles) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IUserRoleAssignmentRoles Role { get; set; }

    }
    /// Mapping of user object ID to role assignments.
    internal partial interface IUserRoleAssignmentValueInternal

    {
        /// <summary>A map of roles to assign to the parent user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IUserRoleAssignmentRoles Role { get; set; }

    }
}