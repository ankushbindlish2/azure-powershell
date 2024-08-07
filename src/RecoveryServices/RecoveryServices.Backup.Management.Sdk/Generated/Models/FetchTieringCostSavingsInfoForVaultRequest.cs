// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Request parameters for tiering cost info for vault
    /// </summary>
    [Newtonsoft.Json.JsonObject("FetchTieringCostSavingsInfoForVaultRequest")]
    public partial class FetchTieringCostSavingsInfoForVaultRequest : FetchTieringCostInfoRequest
    {
        /// <summary>
        /// Initializes a new instance of the FetchTieringCostSavingsInfoForVaultRequest class.
        /// </summary>
        public FetchTieringCostSavingsInfoForVaultRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FetchTieringCostSavingsInfoForVaultRequest class.
        /// </summary>

        /// <param name="sourceTierType">Source tier for the request
        /// Possible values include: &#39;Invalid&#39;, &#39;InstantRP&#39;, &#39;HardenedRP&#39;, &#39;ArchivedRP&#39;</param>

        /// <param name="targetTierType">target tier for the request
        /// Possible values include: &#39;Invalid&#39;, &#39;InstantRP&#39;, &#39;HardenedRP&#39;, &#39;ArchivedRP&#39;</param>
        public FetchTieringCostSavingsInfoForVaultRequest(RecoveryPointTierType sourceTierType, RecoveryPointTierType targetTierType)

        : base(sourceTierType, targetTierType)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}