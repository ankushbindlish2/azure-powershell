// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using System.Linq;

    public partial class ThrottlingRule
    {
        /// <summary>
        /// Initializes a new instance of the ThrottlingRule class.
        /// </summary>
        public ThrottlingRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ThrottlingRule class.
        /// </summary>

        /// <param name="key">
        /// </param>

        /// <param name="renewalPeriod">
        /// </param>

        /// <param name="count">
        /// </param>

        /// <param name="minCount">
        /// </param>

        /// <param name="dynamicThrottlingEnabled">
        /// </param>

        /// <param name="matchPatterns">
        /// </param>
        public ThrottlingRule(string key = default(string), double? renewalPeriod = default(double?), double? count = default(double?), double? minCount = default(double?), bool? dynamicThrottlingEnabled = default(bool?), System.Collections.Generic.IList<RequestMatchPattern> matchPatterns = default(System.Collections.Generic.IList<RequestMatchPattern>))

        {
            this.Key = key;
            this.RenewalPeriod = renewalPeriod;
            this.Count = count;
            this.MinCount = minCount;
            this.DynamicThrottlingEnabled = dynamicThrottlingEnabled;
            this.MatchPatterns = matchPatterns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "key")]
        public string Key {get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "renewalPeriod")]
        public double? RenewalPeriod {get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "count")]
        public double? Count {get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "minCount")]
        public double? MinCount {get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dynamicThrottlingEnabled")]
        public bool? DynamicThrottlingEnabled {get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "matchPatterns")]
        public System.Collections.Generic.IList<RequestMatchPattern> MatchPatterns {get; set; }
    }
}