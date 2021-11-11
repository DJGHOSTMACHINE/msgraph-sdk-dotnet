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
    /// The interface ICaseCustodiansCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(Microsoft.Graph.InterfaceConverter<CaseCustodiansCollectionPage>))]
    public interface ICaseCustodiansCollectionPage : Microsoft.Graph.ICollectionPage<Custodian>
    {
        /// <summary>
        /// Gets the next page <see cref="ICaseCustodiansCollectionRequest"/> instance.
        /// </summary>
        ICaseCustodiansCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString);
    }
}