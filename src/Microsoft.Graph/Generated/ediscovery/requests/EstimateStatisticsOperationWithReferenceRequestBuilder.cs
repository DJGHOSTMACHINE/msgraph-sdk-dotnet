// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EstimateStatisticsOperationWithReferenceRequestBuilder.
    /// </summary>
    public partial class EstimateStatisticsOperationWithReferenceRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IEstimateStatisticsOperationWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new EstimateStatisticsOperationWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public EstimateStatisticsOperationWithReferenceRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEstimateStatisticsOperationWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEstimateStatisticsOperationWithReferenceRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new EstimateStatisticsOperationWithReferenceRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets the request builder for the reference of the estimateStatisticsOperation.
        /// </summary>
        /// <returns>The <see cref="IEstimateStatisticsOperationReferenceRequestBuilder"/>.</returns>
        public IEstimateStatisticsOperationReferenceRequestBuilder Reference
        {
            get
            {
                return new EstimateStatisticsOperationReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}