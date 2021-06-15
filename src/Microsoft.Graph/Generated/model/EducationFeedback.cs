// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type EducationFeedback.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class EducationFeedback
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EducationFeedback"/> class.
        /// </summary>
        public EducationFeedback()
        {
            this.ODataType = "microsoft.graph.educationFeedback";
        }

        /// <summary>
        /// Gets or sets feedbackBy.
        /// User who created the feedback.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "feedbackBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet FeedbackBy { get; set; }
    
        /// <summary>
        /// Gets or sets feedbackDateTime.
        /// Moment in time when the feedback was given. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "feedbackDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? FeedbackDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets text.
        /// Feedback.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "text", Required = Newtonsoft.Json.Required.Default)]
        public EducationItemBody Text { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}