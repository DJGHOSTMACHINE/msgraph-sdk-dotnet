// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ReviewSetRequestBuilder.
    /// </summary>
    public partial class ReviewSetRequestBuilder : Microsoft.Graph.EntityRequestBuilder, IReviewSetRequestBuilder
    {

        /// <summary>
        /// Constructs a new ReviewSetRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ReviewSetRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IReviewSetRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IReviewSetRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ReviewSetRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Queries.
        /// </summary>
        /// <returns>The <see cref="IReviewSetQueriesCollectionRequestBuilder"/>.</returns>
        public IReviewSetQueriesCollectionRequestBuilder Queries
        {
            get
            {
                return new ReviewSetQueriesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("queries"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for ReviewSetAddToReviewSet.
        /// </summary>
        /// <returns>The <see cref="IReviewSetAddToReviewSetRequestBuilder"/>.</returns>
        public IReviewSetAddToReviewSetRequestBuilder AddToReviewSet(
            SourceCollection sourceCollection = null,
            AdditionalDataOptions? additionalData = null)
        {
            return new ReviewSetAddToReviewSetRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.ediscovery.addToReviewSet"),
                this.Client,
                sourceCollection,
                additionalData);
        }

        /// <summary>
        /// Gets the request builder for ReviewSetExport.
        /// </summary>
        /// <returns>The <see cref="IReviewSetExportRequestBuilder"/>.</returns>
        public IReviewSetExportRequestBuilder Export(
            ExportFileStructure exportStructure,
            string outputName = null,
            string description = null,
            string azureBlobContainer = null,
            string azureBlobToken = null,
            ExportOptions? exportOptions = null)
        {
            return new ReviewSetExportRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.ediscovery.export"),
                this.Client,
                exportStructure,
                outputName,
                description,
                azureBlobContainer,
                azureBlobToken,
                exportOptions);
        }
    
    }
}