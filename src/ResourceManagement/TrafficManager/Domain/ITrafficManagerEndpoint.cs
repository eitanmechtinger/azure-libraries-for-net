// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.TrafficManager.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.TrafficManager.Fluent.Models;
    using System.Collections.Generic;

    /// <summary>
    /// An immutable client-side representation of an Azure traffic manager profile endpoint.
    /// </summary>
    public interface ITrafficManagerEndpoint :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IExternalChildResource<Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerEndpoint, Microsoft.Azure.Management.TrafficManager.Fluent.ITrafficManagerProfile>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasInner<Models.EndpointInner>
    {
        /// <summary>
        /// Gets the priority of the endpoint which is used when traffic manager profile is configured with
        /// Priority traffic-routing method.
        /// </summary>
        long RoutingPriority { get; }

        /// <summary>
        /// Gets the endpoint type.
        /// </summary>
        Microsoft.Azure.Management.TrafficManager.Fluent.EndpointType EndpointType { get; }

        /// <summary>
        /// Gets true if the endpoint is enabled, false otherwise.
        /// </summary>
        bool IsEnabled { get; }

        /// <summary>
        /// Gets the weight of the endpoint which is used when traffic manager profile is configured with
        /// Weighted traffic-routing method.
        /// </summary>
        long RoutingWeight { get; }

        /// <summary>
        /// Gets the geographic location codes indicating the locations to which traffic will be distributed.
        /// </summary>
        System.Collections.Generic.IReadOnlyList<string> GeographicLocationCodes { get; }

        /// <summary>
        /// Gets the monitor status of the endpoint.
        /// </summary>
        Microsoft.Azure.Management.TrafficManager.Fluent.EndpointMonitorStatus MonitorStatus { get; }

        /// <summary>
        /// Gets the monitor custom headers
        /// </summary>
        IReadOnlyDictionary<string,string> CustomHeaders { get; }

        /// <summary>
        /// Gets the subnet route for the subnet routing feature
        /// </summary>
        IReadOnlyCollection<string> SubnetRoute { get; }
    }
}