// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Service Update Message.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ServiceUpdateMessage>))]
    public partial class ServiceUpdateMessage : ServiceAnnouncementBase
    {
    
        ///<summary>
        /// The ServiceUpdateMessage constructor
        ///</summary>
        public ServiceUpdateMessage()
        {
            this.ODataType = "microsoft.graph.serviceUpdateMessage";
        }

        /// <summary>
        /// Gets or sets action required by date time.
        /// The expected deadline of the action for the message.
        /// </summary>
        [JsonPropertyName("actionRequiredByDateTime")]
        public DateTimeOffset? ActionRequiredByDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets body.
        /// The content type and content of the service message body.
        /// </summary>
        [JsonPropertyName("body")]
        public ItemBody Body { get; set; }
    
        /// <summary>
        /// Gets or sets category.
        /// The service message category. Possible values are: preventOrFixIssue, planForChange, stayInformed, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("category")]
        public ServiceUpdateCategory? Category { get; set; }
    
        /// <summary>
        /// Gets or sets is major change.
        /// Indicates whether the message describes a major update for the service.
        /// </summary>
        [JsonPropertyName("isMajorChange")]
        public bool? IsMajorChange { get; set; }
    
        /// <summary>
        /// Gets or sets services.
        /// The affected services by the service message.
        /// </summary>
        [JsonPropertyName("services")]
        public IEnumerable<string> Services { get; set; }
    
        /// <summary>
        /// Gets or sets severity.
        /// The severity of the service message. Possible values are: normal, high, critical, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("severity")]
        public ServiceUpdateSeverity? Severity { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// A collection of tags for the service message.
        /// </summary>
        [JsonPropertyName("tags")]
        public IEnumerable<string> Tags { get; set; }
    
        /// <summary>
        /// Gets or sets view point.
        /// Represents user view points data of the service message. This data includes message status such as whether the user has archived, read, or marked the message as favorite. This property is null when accessed with application permissions.
        /// </summary>
        [JsonPropertyName("viewPoint")]
        public ServiceUpdateMessageViewpoint ViewPoint { get; set; }
    
    }
}
