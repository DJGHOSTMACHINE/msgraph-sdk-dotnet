// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type X509CertificateAuthenticationMethodConfigurationRequestBuilder.
    /// </summary>
    public partial class X509CertificateAuthenticationMethodConfigurationRequestBuilder : AuthenticationMethodConfigurationRequestBuilder, IX509CertificateAuthenticationMethodConfigurationRequestBuilder
    {

        /// <summary>
        /// Constructs a new X509CertificateAuthenticationMethodConfigurationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public X509CertificateAuthenticationMethodConfigurationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IX509CertificateAuthenticationMethodConfigurationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IX509CertificateAuthenticationMethodConfigurationRequest Request(IEnumerable<Option> options)
        {
            return new X509CertificateAuthenticationMethodConfigurationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for IncludeTargets.
        /// </summary>
        /// <returns>The <see cref="IX509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder"/>.</returns>
        public IX509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder IncludeTargets
        {
            get
            {
                return new X509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("includeTargets"), this.Client);
            }
        }
    
    }
}