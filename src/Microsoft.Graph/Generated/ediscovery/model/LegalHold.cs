// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Legal Hold.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<LegalHold>))]
    public partial class LegalHold : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets content query.
        /// KQL query that specifies content to be held in the specified locations. To learn more, see Keyword queries and search conditions for Content Search and eDiscovery.  To hold all content in the specified locations, leave contentQuery blank.
        /// </summary>
        [JsonPropertyName("contentQuery")]
        public string ContentQuery { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// The user who created the legal hold.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public Microsoft.Graph.IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date and time the legal hold was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The legal hold description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the legal hold.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets errors.
        /// Lists any errors that happened while placing the hold.
        /// </summary>
        [JsonPropertyName("errors")]
        public IEnumerable<string> Errors { get; set; }
    
        /// <summary>
        /// Gets or sets is enabled.
        /// Indicates whether the hold is enabled and actively holding content.
        /// </summary>
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// the user who last modified the legal hold.
        /// </summary>
        [JsonPropertyName("lastModifiedBy")]
        public Microsoft.Graph.IdentitySet LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date and time the legal hold was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The status of the legal hold. Possible values are: Pending, Error, Success, UnknownFutureValue.
        /// </summary>
        [JsonPropertyName("status")]
        public LegalHoldStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets site sources.
        /// Data source entity for SharePoint sites associated with the legal hold.
        /// </summary>
        [JsonPropertyName("siteSources")]
        public ILegalHoldSiteSourcesCollectionPage SiteSources { get; set; }

        /// <summary>
        /// Gets or sets siteSourcesNextLink.
        /// </summary>
        [JsonPropertyName("siteSources@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SiteSourcesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets user sources.
        /// Data source entity for a the legal hold. This is the container for a mailbox and OneDrive for Business site.
        /// </summary>
        [JsonPropertyName("userSources")]
        public ILegalHoldUserSourcesCollectionPage UserSources { get; set; }

        /// <summary>
        /// Gets or sets userSourcesNextLink.
        /// </summary>
        [JsonPropertyName("userSources@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string UserSourcesNextLink { get; set; }
    
    }
}
