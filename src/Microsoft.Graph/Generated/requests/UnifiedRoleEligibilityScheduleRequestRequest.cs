// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type UnifiedRoleEligibilityScheduleRequestRequest.
    /// </summary>
    public partial class UnifiedRoleEligibilityScheduleRequestRequest : BaseRequest, IUnifiedRoleEligibilityScheduleRequestRequest
    {
        /// <summary>
        /// Constructs a new UnifiedRoleEligibilityScheduleRequestRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UnifiedRoleEligibilityScheduleRequestRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UnifiedRoleEligibilityScheduleRequestObject using POST.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleRequestObjectToCreate">The UnifiedRoleEligibilityScheduleRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRoleEligibilityScheduleRequestObject.</returns>
        public async System.Threading.Tasks.Task<UnifiedRoleEligibilityScheduleRequestObject> CreateAsync(UnifiedRoleEligibilityScheduleRequestObject unifiedRoleEligibilityScheduleRequestObjectToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<UnifiedRoleEligibilityScheduleRequestObject>(unifiedRoleEligibilityScheduleRequestObjectToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UnifiedRoleEligibilityScheduleRequestObject using POST and returns a <see cref="GraphResponse{UnifiedRoleEligibilityScheduleRequestObject}"/> object.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleRequestObjectToCreate">The UnifiedRoleEligibilityScheduleRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilityScheduleRequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilityScheduleRequestObject>> CreateResponseAsync(UnifiedRoleEligibilityScheduleRequestObject unifiedRoleEligibilityScheduleRequestObjectToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<UnifiedRoleEligibilityScheduleRequestObject>(unifiedRoleEligibilityScheduleRequestObjectToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified UnifiedRoleEligibilityScheduleRequest.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<UnifiedRoleEligibilityScheduleRequestObject>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UnifiedRoleEligibilityScheduleRequest and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified UnifiedRoleEligibilityScheduleRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRoleEligibilityScheduleRequestObject.</returns>
        public async System.Threading.Tasks.Task<UnifiedRoleEligibilityScheduleRequestObject> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<UnifiedRoleEligibilityScheduleRequestObject>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UnifiedRoleEligibilityScheduleRequestObject and returns a <see cref="GraphResponse{UnifiedRoleEligibilityScheduleRequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilityScheduleRequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilityScheduleRequestObject>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<UnifiedRoleEligibilityScheduleRequestObject>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UnifiedRoleEligibilityScheduleRequestObject using PATCH.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleRequestObjectToUpdate">The UnifiedRoleEligibilityScheduleRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRoleEligibilityScheduleRequestObject.</returns>
        public async System.Threading.Tasks.Task<UnifiedRoleEligibilityScheduleRequestObject> UpdateAsync(UnifiedRoleEligibilityScheduleRequestObject unifiedRoleEligibilityScheduleRequestObjectToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<UnifiedRoleEligibilityScheduleRequestObject>(unifiedRoleEligibilityScheduleRequestObjectToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UnifiedRoleEligibilityScheduleRequestObject using PATCH and returns a <see cref="GraphResponse{UnifiedRoleEligibilityScheduleRequestObject}"/> object.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleRequestObjectToUpdate">The UnifiedRoleEligibilityScheduleRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilityScheduleRequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilityScheduleRequestObject>> UpdateResponseAsync(UnifiedRoleEligibilityScheduleRequestObject unifiedRoleEligibilityScheduleRequestObjectToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<UnifiedRoleEligibilityScheduleRequestObject>(unifiedRoleEligibilityScheduleRequestObjectToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UnifiedRoleEligibilityScheduleRequestObject using PUT.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleRequestObjectToUpdate">The UnifiedRoleEligibilityScheduleRequestObject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<UnifiedRoleEligibilityScheduleRequestObject> PutAsync(UnifiedRoleEligibilityScheduleRequestObject unifiedRoleEligibilityScheduleRequestObjectToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<UnifiedRoleEligibilityScheduleRequestObject>(unifiedRoleEligibilityScheduleRequestObjectToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UnifiedRoleEligibilityScheduleRequestObject using PUT and returns a <see cref="GraphResponse{UnifiedRoleEligibilityScheduleRequestObject}"/> object.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleRequestObjectToUpdate">The UnifiedRoleEligibilityScheduleRequestObject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{UnifiedRoleEligibilityScheduleRequestObject}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilityScheduleRequestObject>> PutResponseAsync(UnifiedRoleEligibilityScheduleRequestObject unifiedRoleEligibilityScheduleRequestObjectToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<UnifiedRoleEligibilityScheduleRequestObject>(unifiedRoleEligibilityScheduleRequestObjectToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRoleEligibilityScheduleRequestRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRoleEligibilityScheduleRequestRequest Expand(Expression<Func<UnifiedRoleEligibilityScheduleRequestObject, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRoleEligibilityScheduleRequestRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRoleEligibilityScheduleRequestRequest Select(Expression<Func<UnifiedRoleEligibilityScheduleRequestObject, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleRequestObjectToInitialize">The <see cref="UnifiedRoleEligibilityScheduleRequestObject"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UnifiedRoleEligibilityScheduleRequestObject unifiedRoleEligibilityScheduleRequestObjectToInitialize)
        {

        }
    }
}