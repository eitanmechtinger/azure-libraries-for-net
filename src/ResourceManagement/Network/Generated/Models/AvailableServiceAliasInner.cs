// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The available service alias.
    /// </summary>
    public partial class AvailableServiceAliasInner
    {
        /// <summary>
        /// Initializes a new instance of the AvailableServiceAliasInner class.
        /// </summary>
        public AvailableServiceAliasInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailableServiceAliasInner class.
        /// </summary>
        /// <param name="name">The name of the service alias.</param>
        /// <param name="id">The ID of the service alias.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="resourceName">The resource name of the service
        /// alias.</param>
        public AvailableServiceAliasInner(string name = default(string), string id = default(string), string type = default(string), string resourceName = default(string))
        {
            Name = name;
            Id = id;
            Type = type;
            ResourceName = resourceName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the service alias.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ID of the service alias.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the resource name of the service alias.
        /// </summary>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }

    }
}