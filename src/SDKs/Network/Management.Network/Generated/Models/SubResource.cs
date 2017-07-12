// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SubResource : IResource
    {
        /// <summary>
        /// Initializes a new instance of the SubResource class.
        /// </summary>
        public SubResource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubResource class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        public SubResource(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
