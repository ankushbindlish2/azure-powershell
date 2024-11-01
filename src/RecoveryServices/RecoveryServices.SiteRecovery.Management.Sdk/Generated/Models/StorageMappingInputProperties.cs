// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Storage mapping input properties.
    /// </summary>
    public partial class StorageMappingInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the StorageMappingInputProperties class.
        /// </summary>
        public StorageMappingInputProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageMappingInputProperties class.
        /// </summary>

        /// <param name="targetStorageClassificationId">The ID of the storage object.
        /// </param>
        public StorageMappingInputProperties(string targetStorageClassificationId = default(string))

        {
            this.TargetStorageClassificationId = targetStorageClassificationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the ID of the storage object.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetStorageClassificationId")]
        public string TargetStorageClassificationId {get; set; }
    }
}