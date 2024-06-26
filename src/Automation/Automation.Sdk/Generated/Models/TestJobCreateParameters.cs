// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create test job operation.
    /// </summary>
    public partial class TestJobCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the TestJobCreateParameters class.
        /// </summary>
        public TestJobCreateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestJobCreateParameters class.
        /// </summary>

        /// <param name="parameters">Gets or sets the parameters of the test job.
        /// </param>

        /// <param name="runOn">Gets or sets the runOn which specifies the group name where the job is to
        /// be executed.
        /// </param>
        public TestJobCreateParameters(System.Collections.Generic.IDictionary<string, string> parameters = default(System.Collections.Generic.IDictionary<string, string>), string runOn = default(string))

        {
            this.Parameters = parameters;
            this.RunOn = runOn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets gets or sets the parameters of the test job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.IDictionary<string, string> Parameters {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the runOn which specifies the group name where
        /// the job is to be executed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "runOn")]
        public string RunOn {get; set; }
    }
}