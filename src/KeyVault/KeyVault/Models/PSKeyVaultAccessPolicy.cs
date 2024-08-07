﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------


using Microsoft.Azure.Commands.Common.MSGraph.Version1_0;
using System;
using System.Collections.Generic;
using KeyVaultManagement = Microsoft.Azure.Management.KeyVault;

namespace Microsoft.Azure.Commands.KeyVault.Models
{
    public class PSKeyVaultAccessPolicy
    {
        public PSKeyVaultAccessPolicy(Guid tenantId, string objectId, Guid? applicationId, string[] permissionsToKeys, string[] permissionsToSecrets, string[] permissionsToCertificates, string[] permissionsToStorage)
        {
            TenantId = tenantId;
            ObjectId = objectId;
            ApplicationId = applicationId;
            PermissionsToSecrets = permissionsToSecrets == null ? new List<string>() : new List<string>(permissionsToSecrets);
            PermissionsToKeys = permissionsToKeys == null ? new List<string>() : new List<string>(permissionsToKeys);
            PermissionsToCertificates = permissionsToCertificates == null ? new List<string>() : new List<string>(permissionsToCertificates);
            PermissionsToStorage = permissionsToStorage == null ? new List<string>() : new List<string>(permissionsToStorage);
        }

        public PSKeyVaultAccessPolicy(KeyVaultManagement.Models.AccessPolicyEntry s, IMicrosoftGraphClient graphClient) :
            this(s, ModelExtensions.GetDisplayNameForADObject(s.ObjectId, graphClient))
        { 
        }
       
        public PSKeyVaultAccessPolicy(KeyVaultManagement.Models.AccessPolicyEntry s, string displayName)
        {
            ObjectId = s.ObjectId;
            DisplayName = displayName;
            ApplicationId = s.ApplicationId;
            TenantId = s.TenantId;
            TenantName = s.TenantId.ToString();
            PermissionsToSecrets = s.Permissions.Secrets == null ? new List<string>() : new List<string>(s.Permissions.Secrets);
            PermissionsToKeys = s.Permissions.Keys == null ? new List<string>() : new List<string>(s.Permissions.Keys);
            PermissionsToCertificates = s.Permissions.Certificates == null ? new List<string>() : new List<string>(s.Permissions.Certificates);
            PermissionsToStorage = s.Permissions.Storage == null ? new List<string>() : new List<string>(s.Permissions.Storage);
        }

        public Guid TenantId { get; private set; }

        public string TenantName { get; private set; }

        public string ObjectId { get; private set; }

        public Guid? ApplicationId { get; private set; }
        public string DisplayName { get; private set; }

        public string ApplicationIdDisplayName { get { return ApplicationId.HasValue ? ApplicationId.Value.ToString() : string.Empty; } }

        public List<string> PermissionsToKeys { get; private set; }

        public string PermissionsToKeysStr { get { return string.Join(", ", PermissionsToKeys); } }

        public List<string> PermissionsToSecrets { get; private set; }

        public string PermissionsToSecretsStr { get { return string.Join(", ", PermissionsToSecrets); } }

        public List<string> PermissionsToCertificates { get; private set; }

        public string PermissionsToCertificatesStr { get { return string.Join(", ", PermissionsToCertificates); } }

        public List<string> PermissionsToStorage { get; private set; }

        public string PermissionsToStorageStr { get { return string.Join(", ", PermissionsToStorage); } }
    }
}
