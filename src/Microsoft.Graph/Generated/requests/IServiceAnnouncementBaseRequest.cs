// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IServiceAnnouncementBaseRequest.
    /// </summary>
    public partial interface IServiceAnnouncementBaseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ServiceAnnouncementBase using POST.
        /// </summary>
        /// <param name="serviceAnnouncementBaseToCreate">The ServiceAnnouncementBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ServiceAnnouncementBase.</returns>
        System.Threading.Tasks.Task<ServiceAnnouncementBase> CreateAsync(ServiceAnnouncementBase serviceAnnouncementBaseToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ServiceAnnouncementBase using POST and returns a <see cref="GraphResponse{ServiceAnnouncementBase}"/> object.
        /// </summary>
        /// <param name="serviceAnnouncementBaseToCreate">The ServiceAnnouncementBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ServiceAnnouncementBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServiceAnnouncementBase>> CreateResponseAsync(ServiceAnnouncementBase serviceAnnouncementBaseToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ServiceAnnouncementBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ServiceAnnouncementBase and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ServiceAnnouncementBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ServiceAnnouncementBase.</returns>
        System.Threading.Tasks.Task<ServiceAnnouncementBase> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ServiceAnnouncementBase and returns a <see cref="GraphResponse{ServiceAnnouncementBase}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ServiceAnnouncementBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServiceAnnouncementBase>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ServiceAnnouncementBase using PATCH.
        /// </summary>
        /// <param name="serviceAnnouncementBaseToUpdate">The ServiceAnnouncementBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ServiceAnnouncementBase.</returns>
        System.Threading.Tasks.Task<ServiceAnnouncementBase> UpdateAsync(ServiceAnnouncementBase serviceAnnouncementBaseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ServiceAnnouncementBase using PATCH and returns a <see cref="GraphResponse{ServiceAnnouncementBase}"/> object.
        /// </summary>
        /// <param name="serviceAnnouncementBaseToUpdate">The ServiceAnnouncementBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ServiceAnnouncementBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServiceAnnouncementBase>> UpdateResponseAsync(ServiceAnnouncementBase serviceAnnouncementBaseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ServiceAnnouncementBase using PUT.
        /// </summary>
        /// <param name="serviceAnnouncementBaseToUpdate">The ServiceAnnouncementBase object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ServiceAnnouncementBase> PutAsync(ServiceAnnouncementBase serviceAnnouncementBaseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ServiceAnnouncementBase using PUT and returns a <see cref="GraphResponse{ServiceAnnouncementBase}"/> object.
        /// </summary>
        /// <param name="serviceAnnouncementBaseToUpdate">The ServiceAnnouncementBase object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ServiceAnnouncementBase}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServiceAnnouncementBase>> PutResponseAsync(ServiceAnnouncementBase serviceAnnouncementBaseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IServiceAnnouncementBaseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IServiceAnnouncementBaseRequest Expand(Expression<Func<ServiceAnnouncementBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IServiceAnnouncementBaseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IServiceAnnouncementBaseRequest Select(Expression<Func<ServiceAnnouncementBase, object>> selectExpression);

    }
}