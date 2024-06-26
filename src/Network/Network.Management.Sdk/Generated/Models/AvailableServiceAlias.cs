// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// The available service alias.
    /// </summary>
    public partial class AvailableServiceAlias
    {
        /// <summary>
        /// Initializes a new instance of the AvailableServiceAlias class.
        /// </summary>
        public AvailableServiceAlias()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailableServiceAlias class.
        /// </summary>

        /// <param name="name">The name of the service alias.
        /// </param>

        /// <param name="id">The ID of the service alias.
        /// </param>

        /// <param name="type">The type of the resource.
        /// </param>

        /// <param name="resourceName">The resource name of the service alias.
        /// </param>
        public AvailableServiceAlias(string name = default(string), string id = default(string), string type = default(string), string resourceName = default(string))

        {
            this.Name = name;
            this.Id = id;
            this.Type = type;
            this.ResourceName = resourceName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the name of the service alias.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets the ID of the service alias.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; set; }

        /// <summary>
        /// Gets or sets the type of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; set; }

        /// <summary>
        /// Gets or sets the resource name of the service alias.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceName")]
        public string ResourceName {get; set; }
    }
}