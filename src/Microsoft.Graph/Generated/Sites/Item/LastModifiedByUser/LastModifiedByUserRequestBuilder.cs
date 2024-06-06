// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.Sites.Item.LastModifiedByUser.MailboxSettings;
using Microsoft.Graph.Sites.Item.LastModifiedByUser.ServiceProvisioningErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Sites.Item.LastModifiedByUser
{
    /// <summary>
    /// Provides operations to manage the lastModifiedByUser property of the microsoft.graph.baseItem entity.
    /// </summary>
    public class LastModifiedByUserRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The mailboxSettings property</summary>
        public Microsoft.Graph.Sites.Item.LastModifiedByUser.MailboxSettings.MailboxSettingsRequestBuilder MailboxSettings
        {
            get => new Microsoft.Graph.Sites.Item.LastModifiedByUser.MailboxSettings.MailboxSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The serviceProvisioningErrors property</summary>
        public Microsoft.Graph.Sites.Item.LastModifiedByUser.ServiceProvisioningErrors.ServiceProvisioningErrorsRequestBuilder ServiceProvisioningErrors
        {
            get => new Microsoft.Graph.Sites.Item.LastModifiedByUser.ServiceProvisioningErrors.ServiceProvisioningErrorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Sites.Item.LastModifiedByUser.LastModifiedByUserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LastModifiedByUserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sites/{site%2Did}/lastModifiedByUser{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Sites.Item.LastModifiedByUser.LastModifiedByUserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LastModifiedByUserRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sites/{site%2Did}/lastModifiedByUser{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Identity of the user who last modified the item. Read-only.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.User"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.User?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Sites.Item.LastModifiedByUser.LastModifiedByUserRequestBuilder.LastModifiedByUserRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.User> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Sites.Item.LastModifiedByUser.LastModifiedByUserRequestBuilder.LastModifiedByUserRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.User>(requestInfo, Microsoft.Graph.Models.User.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Identity of the user who last modified the item. Read-only.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Sites.Item.LastModifiedByUser.LastModifiedByUserRequestBuilder.LastModifiedByUserRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Sites.Item.LastModifiedByUser.LastModifiedByUserRequestBuilder.LastModifiedByUserRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Sites.Item.LastModifiedByUser.LastModifiedByUserRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Sites.Item.LastModifiedByUser.LastModifiedByUserRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Sites.Item.LastModifiedByUser.LastModifiedByUserRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Identity of the user who last modified the item. Read-only.
        /// </summary>
        public class LastModifiedByUserRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class LastModifiedByUserRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Sites.Item.LastModifiedByUser.LastModifiedByUserRequestBuilder.LastModifiedByUserRequestBuilderGetQueryParameters>
        {
        }
    }
}
