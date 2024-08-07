// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Resources that have an association with the parent resource.
    /// </summary>
    public partial class TopologyAssociation
    {
        /// <summary>
        /// Initializes a new instance of the TopologyAssociation class.
        /// </summary>
        public TopologyAssociation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TopologyAssociation class.
        /// </summary>

        /// <param name="name">The name of the resource that is associated with the parent resource.
        /// </param>

        /// <param name="resourceId">The ID of the resource that is associated with the parent resource.
        /// </param>

        /// <param name="associationType">The association type of the child resource to the parent resource.
        /// Possible values include: &#39;Associated&#39;, &#39;Contains&#39;</param>
        public TopologyAssociation(string name = default(string), string resourceId = default(string), string associationType = default(string))

        {
            this.Name = name;
            this.ResourceId = resourceId;
            this.AssociationType = associationType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the name of the resource that is associated with the parent
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets the ID of the resource that is associated with the parent
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceId")]
        public string ResourceId {get; set; }

        /// <summary>
        /// Gets or sets the association type of the child resource to the parent
        /// resource. Possible values include: &#39;Associated&#39;, &#39;Contains&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "associationType")]
        public string AssociationType {get; set; }
    }
}