// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionPage.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface ICaseReviewSetsCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(Microsoft.Graph.InterfaceConverter<CaseReviewSetsCollectionPage>))]
    public interface ICaseReviewSetsCollectionPage : Microsoft.Graph.ICollectionPage<ReviewSet>
    {
        /// <summary>
        /// Gets the next page <see cref="ICaseReviewSetsCollectionRequest"/> instance.
        /// </summary>
        ICaseReviewSetsCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString);
    }
}