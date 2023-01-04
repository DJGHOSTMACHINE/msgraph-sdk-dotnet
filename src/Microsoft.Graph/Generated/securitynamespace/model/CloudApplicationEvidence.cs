// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type CloudApplicationEvidence.
    /// </summary>
    public partial class CloudApplicationEvidence : AlertEvidence
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudApplicationEvidence"/> class.
        /// </summary>
        public CloudApplicationEvidence()
        {
            this.ODataType = "microsoft.graph.security.cloudApplicationEvidence";
        }

        /// <summary>
        /// Gets or sets appId.
        /// Unique identifier of the application.
        /// </summary>
        [JsonPropertyName("appId")]
        public Int64? AppId { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// Name of the application.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets instanceId.
        /// Identifier of the instance of the Software as a Service (SaaS) application.
        /// </summary>
        [JsonPropertyName("instanceId")]
        public Int64? InstanceId { get; set; }
    
        /// <summary>
        /// Gets or sets instanceName.
        /// Name of the instance of the SaaS application.
        /// </summary>
        [JsonPropertyName("instanceName")]
        public string InstanceName { get; set; }
    
        /// <summary>
        /// Gets or sets saasAppId.
        /// The identifier of the SaaS application.
        /// </summary>
        [JsonPropertyName("saasAppId")]
        public Int64? SaasAppId { get; set; }
    
    }
}