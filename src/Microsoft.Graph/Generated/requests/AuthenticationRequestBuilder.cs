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
    /// The type AuthenticationRequestBuilder.
    /// </summary>
    public partial class AuthenticationRequestBuilder : EntityRequestBuilder, IAuthenticationRequestBuilder
    {

        /// <summary>
        /// Constructs a new AuthenticationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AuthenticationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAuthenticationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAuthenticationRequest Request(IEnumerable<Option> options)
        {
            return new AuthenticationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for EmailMethods.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationEmailMethodsCollectionRequestBuilder"/>.</returns>
        public IAuthenticationEmailMethodsCollectionRequestBuilder EmailMethods
        {
            get
            {
                return new AuthenticationEmailMethodsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("emailMethods"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Fido2Methods.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationFido2MethodsCollectionRequestBuilder"/>.</returns>
        public IAuthenticationFido2MethodsCollectionRequestBuilder Fido2Methods
        {
            get
            {
                return new AuthenticationFido2MethodsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("fido2Methods"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Methods.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationMethodsCollectionRequestBuilder"/>.</returns>
        public IAuthenticationMethodsCollectionRequestBuilder Methods
        {
            get
            {
                return new AuthenticationMethodsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("methods"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MicrosoftAuthenticatorMethods.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationMicrosoftAuthenticatorMethodsCollectionRequestBuilder"/>.</returns>
        public IAuthenticationMicrosoftAuthenticatorMethodsCollectionRequestBuilder MicrosoftAuthenticatorMethods
        {
            get
            {
                return new AuthenticationMicrosoftAuthenticatorMethodsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("microsoftAuthenticatorMethods"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Operations.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationOperationsCollectionRequestBuilder"/>.</returns>
        public IAuthenticationOperationsCollectionRequestBuilder Operations
        {
            get
            {
                return new AuthenticationOperationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("operations"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for PasswordMethods.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationPasswordMethodsCollectionRequestBuilder"/>.</returns>
        public IAuthenticationPasswordMethodsCollectionRequestBuilder PasswordMethods
        {
            get
            {
                return new AuthenticationPasswordMethodsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("passwordMethods"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for PhoneMethods.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationPhoneMethodsCollectionRequestBuilder"/>.</returns>
        public IAuthenticationPhoneMethodsCollectionRequestBuilder PhoneMethods
        {
            get
            {
                return new AuthenticationPhoneMethodsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("phoneMethods"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SoftwareOathMethods.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationSoftwareOathMethodsCollectionRequestBuilder"/>.</returns>
        public IAuthenticationSoftwareOathMethodsCollectionRequestBuilder SoftwareOathMethods
        {
            get
            {
                return new AuthenticationSoftwareOathMethodsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("softwareOathMethods"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TemporaryAccessPassMethods.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationTemporaryAccessPassMethodsCollectionRequestBuilder"/>.</returns>
        public IAuthenticationTemporaryAccessPassMethodsCollectionRequestBuilder TemporaryAccessPassMethods
        {
            get
            {
                return new AuthenticationTemporaryAccessPassMethodsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("temporaryAccessPassMethods"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for WindowsHelloForBusinessMethods.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationWindowsHelloForBusinessMethodsCollectionRequestBuilder"/>.</returns>
        public IAuthenticationWindowsHelloForBusinessMethodsCollectionRequestBuilder WindowsHelloForBusinessMethods
        {
            get
            {
                return new AuthenticationWindowsHelloForBusinessMethodsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("windowsHelloForBusinessMethods"), this.Client);
            }
        }
    
    }
}
