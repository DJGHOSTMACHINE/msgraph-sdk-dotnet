// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The interface IRbacApplicationRoleDefinitionsCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<RbacApplicationRoleDefinitionsCollectionPage>))]
    public interface IRbacApplicationRoleDefinitionsCollectionPage : ICollectionPage<UnifiedRoleDefinition>
    {
        /// <summary>
        /// Gets the next page <see cref="IRbacApplicationRoleDefinitionsCollectionRequest"/> instance.
        /// </summary>
        IRbacApplicationRoleDefinitionsCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}