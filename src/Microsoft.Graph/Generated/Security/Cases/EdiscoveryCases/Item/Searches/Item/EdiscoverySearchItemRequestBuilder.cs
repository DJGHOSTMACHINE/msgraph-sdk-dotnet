// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models.Security;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Searches.Item.AddToReviewSetOperation;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Searches.Item.AdditionalSources;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Searches.Item.CustodianSources;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Searches.Item.LastEstimateStatisticsOperation;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Searches.Item.MicrosoftGraphSecurityEstimateStatistics;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Searches.Item.MicrosoftGraphSecurityPurgeData;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Searches.Item.NoncustodialSources;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Searches.Item {
    /// <summary>
    /// Provides operations to manage the searches property of the microsoft.graph.security.ediscoveryCase entity.
    /// </summary>
    public class EdiscoverySearchItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the additionalSources property of the microsoft.graph.security.ediscoverySearch entity.</summary>
        public AdditionalSourcesRequestBuilder AdditionalSources { get =>
            new AdditionalSourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the addToReviewSetOperation property of the microsoft.graph.security.ediscoverySearch entity.</summary>
        public AddToReviewSetOperationRequestBuilder AddToReviewSetOperation { get =>
            new AddToReviewSetOperationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the custodianSources property of the microsoft.graph.security.ediscoverySearch entity.</summary>
        public CustodianSourcesRequestBuilder CustodianSources { get =>
            new CustodianSourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastEstimateStatisticsOperation property of the microsoft.graph.security.ediscoverySearch entity.</summary>
        public LastEstimateStatisticsOperationRequestBuilder LastEstimateStatisticsOperation { get =>
            new LastEstimateStatisticsOperationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the estimateStatistics method.</summary>
        public MicrosoftGraphSecurityEstimateStatisticsRequestBuilder MicrosoftGraphSecurityEstimateStatistics { get =>
            new MicrosoftGraphSecurityEstimateStatisticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the purgeData method.</summary>
        public MicrosoftGraphSecurityPurgeDataRequestBuilder MicrosoftGraphSecurityPurgeData { get =>
            new MicrosoftGraphSecurityPurgeDataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the noncustodialSources property of the microsoft.graph.security.ediscoverySearch entity.</summary>
        public NoncustodialSourcesRequestBuilder NoncustodialSources { get =>
            new NoncustodialSourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new EdiscoverySearchItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EdiscoverySearchItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/searches/{ediscoverySearch%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new EdiscoverySearchItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EdiscoverySearchItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/searches/{ediscoverySearch%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete an ediscoverySearch object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/security-ediscoverycase-delete-searches?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<EdiscoverySearchItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<EdiscoverySearchItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Read the properties and relationships of an ediscoverySearch object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/security-ediscoverysearch-get?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<EdiscoverySearch?> GetAsync(Action<EdiscoverySearchItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<EdiscoverySearch> GetAsync(Action<EdiscoverySearchItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<EdiscoverySearch>(requestInfo, EdiscoverySearch.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the properties of an ediscoverySearch object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/security-ediscoverysearch-update?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<EdiscoverySearch?> PatchAsync(EdiscoverySearch body, Action<EdiscoverySearchItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<EdiscoverySearch> PatchAsync(EdiscoverySearch body, Action<EdiscoverySearchItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<EdiscoverySearch>(requestInfo, EdiscoverySearch.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete an ediscoverySearch object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<EdiscoverySearchItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<EdiscoverySearchItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new EdiscoverySearchItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of an ediscoverySearch object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<EdiscoverySearchItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<EdiscoverySearchItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new EdiscoverySearchItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of an ediscoverySearch object.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(EdiscoverySearch body, Action<EdiscoverySearchItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(EdiscoverySearch body, Action<EdiscoverySearchItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new EdiscoverySearchItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class EdiscoverySearchItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new EdiscoverySearchItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public EdiscoverySearchItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Read the properties and relationships of an ediscoverySearch object.
        /// </summary>
        public class EdiscoverySearchItemRequestBuilderGetQueryParameters {
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
        public class EdiscoverySearchItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public EdiscoverySearchItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new EdiscoverySearchItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new EdiscoverySearchItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public EdiscoverySearchItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class EdiscoverySearchItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new EdiscoverySearchItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public EdiscoverySearchItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
