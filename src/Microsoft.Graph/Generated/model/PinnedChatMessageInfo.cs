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
    /// The type Pinned Chat Message Info.
    /// </summary>
    public partial class PinnedChatMessageInfo : Entity
    {
    
        /// <summary>
        /// Gets or sets message.
        /// Represents details about the chat message that is pinned.
        /// </summary>
        [JsonPropertyName("message")]
        public ChatMessage Message { get; set; }
    
    }
}
