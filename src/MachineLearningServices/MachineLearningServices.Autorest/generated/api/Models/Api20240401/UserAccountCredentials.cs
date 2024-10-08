// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Settings for user account that gets created on each on the nodes of a compute.</summary>
    public partial class UserAccountCredentials :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IUserAccountCredentials,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IUserAccountCredentialsInternal
    {

        /// <summary>Backing field for <see cref="AdminUserName" /> property.</summary>
        private string _adminUserName;

        /// <summary>Name of the administrator user account which can be used to SSH to nodes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string AdminUserName { get => this._adminUserName; set => this._adminUserName = value; }

        /// <summary>Backing field for <see cref="AdminUserPassword" /> property.</summary>
        private string _adminUserPassword;

        /// <summary>Password of the administrator user account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string AdminUserPassword { get => this._adminUserPassword; set => this._adminUserPassword = value; }

        /// <summary>Backing field for <see cref="AdminUserSshPublicKey" /> property.</summary>
        private string _adminUserSshPublicKey;

        /// <summary>SSH public key of the administrator user account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string AdminUserSshPublicKey { get => this._adminUserSshPublicKey; set => this._adminUserSshPublicKey = value; }

        /// <summary>Creates an new <see cref="UserAccountCredentials" /> instance.</summary>
        public UserAccountCredentials()
        {

        }
    }
    /// Settings for user account that gets created on each on the nodes of a compute.
    public partial interface IUserAccountCredentials :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>Name of the administrator user account which can be used to SSH to nodes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the administrator user account which can be used to SSH to nodes.",
        SerializedName = @"adminUserName",
        PossibleTypes = new [] { typeof(string) })]
        string AdminUserName { get; set; }
        /// <summary>Password of the administrator user account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Password of the administrator user account.",
        SerializedName = @"adminUserPassword",
        PossibleTypes = new [] { typeof(string) })]
        string AdminUserPassword { get; set; }
        /// <summary>SSH public key of the administrator user account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SSH public key of the administrator user account.",
        SerializedName = @"adminUserSshPublicKey",
        PossibleTypes = new [] { typeof(string) })]
        string AdminUserSshPublicKey { get; set; }

    }
    /// Settings for user account that gets created on each on the nodes of a compute.
    internal partial interface IUserAccountCredentialsInternal

    {
        /// <summary>Name of the administrator user account which can be used to SSH to nodes.</summary>
        string AdminUserName { get; set; }
        /// <summary>Password of the administrator user account.</summary>
        string AdminUserPassword { get; set; }
        /// <summary>SSH public key of the administrator user account.</summary>
        string AdminUserSshPublicKey { get; set; }

    }
}