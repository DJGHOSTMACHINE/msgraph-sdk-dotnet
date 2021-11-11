// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ContentTypeAssociateWithHubSitesRequestBuilder.
    /// </summary>
    public partial class ContentTypeAssociateWithHubSitesRequestBuilder : BaseActionMethodRequestBuilder<IContentTypeAssociateWithHubSitesRequest>, IContentTypeAssociateWithHubSitesRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ContentTypeAssociateWithHubSitesRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="hubSiteUrls">A hubSiteUrls parameter for the OData method call.</param>
        /// <param name="propagateToExistingLists">A propagateToExistingLists parameter for the OData method call.</param>
        public ContentTypeAssociateWithHubSitesRequestBuilder(
            string requestUrl,
            IBaseClient client,
            IEnumerable<string> hubSiteUrls,
            bool? propagateToExistingLists)
            : base(requestUrl, client)
        {
            this.SetParameter("hubSiteUrls", hubSiteUrls, false);
            this.SetParameter("propagateToExistingLists", propagateToExistingLists, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IContentTypeAssociateWithHubSitesRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new ContentTypeAssociateWithHubSitesRequest(functionUrl, this.Client, options);

            if (this.HasParameter("hubSiteUrls"))
            {
                request.RequestBody.HubSiteUrls = this.GetParameter<IEnumerable<string>>("hubSiteUrls");
            }

            if (this.HasParameter("propagateToExistingLists"))
            {
                request.RequestBody.PropagateToExistingLists = this.GetParameter<bool?>("propagateToExistingLists");
            }

            return request;
        }
    }
}