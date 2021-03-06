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
    /// SKU of an Azure Firewall.
    /// </summary>
    public partial class AzureFirewallSku
    {
        /// <summary>
        /// Initializes a new instance of the AzureFirewallSku class.
        /// </summary>
        public AzureFirewallSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureFirewallSku class.
        /// </summary>
        /// <param name="name">Name of an Azure Firewall SKU. Possible values
        /// include: 'AZFW_VNet', 'AZFW_Hub'</param>
        /// <param name="tier">Tier of an Azure Firewall. Possible values
        /// include: 'Standard'</param>
        public AzureFirewallSku(AzureFirewallSkuName name = default(AzureFirewallSkuName), AzureFirewallSkuTier tier = default(AzureFirewallSkuTier))
        {
            Name = name;
            Tier = tier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of an Azure Firewall SKU. Possible values
        /// include: 'AZFW_VNet', 'AZFW_Hub'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public AzureFirewallSkuName Name { get; set; }

        /// <summary>
        /// Gets or sets tier of an Azure Firewall. Possible values include:
        /// 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public AzureFirewallSkuTier Tier { get; set; }

    }
}
