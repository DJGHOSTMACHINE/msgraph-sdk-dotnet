// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Print.TaskDefinitions.Item.Tasks.Item.Trigger
{
    /// <summary>
    /// Provides operations to manage the trigger property of the microsoft.graph.printTask entity.
    /// </summary>
    public class TriggerRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Print.TaskDefinitions.Item.Tasks.Item.Trigger.TriggerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TriggerRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/print/taskDefinitions/{printTaskDefinition%2Did}/tasks/{printTask%2Did}/trigger{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Print.TaskDefinitions.Item.Tasks.Item.Trigger.TriggerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TriggerRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/print/taskDefinitions/{printTaskDefinition%2Did}/tasks/{printTask%2Did}/trigger{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// The printTaskTrigger that triggered this task&apos;s execution. Read-only.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.PrintTaskTrigger"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.PrintTaskTrigger?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Print.TaskDefinitions.Item.Tasks.Item.Trigger.TriggerRequestBuilder.TriggerRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.PrintTaskTrigger> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Print.TaskDefinitions.Item.Tasks.Item.Trigger.TriggerRequestBuilder.TriggerRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.PrintTaskTrigger>(requestInfo, Microsoft.Graph.Models.PrintTaskTrigger.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The printTaskTrigger that triggered this task&apos;s execution. Read-only.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Print.TaskDefinitions.Item.Tasks.Item.Trigger.TriggerRequestBuilder.TriggerRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Print.TaskDefinitions.Item.Tasks.Item.Trigger.TriggerRequestBuilder.TriggerRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Print.TaskDefinitions.Item.Tasks.Item.Trigger.TriggerRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Print.TaskDefinitions.Item.Tasks.Item.Trigger.TriggerRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Print.TaskDefinitions.Item.Tasks.Item.Trigger.TriggerRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// The printTaskTrigger that triggered this task&apos;s execution. Read-only.
        /// </summary>
        public class TriggerRequestBuilderGetQueryParameters 
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
        public class TriggerRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Print.TaskDefinitions.Item.Tasks.Item.Trigger.TriggerRequestBuilder.TriggerRequestBuilderGetQueryParameters>
        {
        }
    }
}
