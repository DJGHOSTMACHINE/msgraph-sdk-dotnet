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
    /// The interface IEducationFeedbackResourceOutcomeRequest.
    /// </summary>
    public partial interface IEducationFeedbackResourceOutcomeRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EducationFeedbackResourceOutcome using POST.
        /// </summary>
        /// <param name="educationFeedbackResourceOutcomeToCreate">The EducationFeedbackResourceOutcome to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationFeedbackResourceOutcome.</returns>
        System.Threading.Tasks.Task<EducationFeedbackResourceOutcome> CreateAsync(EducationFeedbackResourceOutcome educationFeedbackResourceOutcomeToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified EducationFeedbackResourceOutcome using POST and returns a <see cref="GraphResponse{EducationFeedbackResourceOutcome}"/> object.
        /// </summary>
        /// <param name="educationFeedbackResourceOutcomeToCreate">The EducationFeedbackResourceOutcome to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationFeedbackResourceOutcome}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationFeedbackResourceOutcome>> CreateResponseAsync(EducationFeedbackResourceOutcome educationFeedbackResourceOutcomeToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EducationFeedbackResourceOutcome.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EducationFeedbackResourceOutcome and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EducationFeedbackResourceOutcome.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationFeedbackResourceOutcome.</returns>
        System.Threading.Tasks.Task<EducationFeedbackResourceOutcome> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EducationFeedbackResourceOutcome and returns a <see cref="GraphResponse{EducationFeedbackResourceOutcome}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationFeedbackResourceOutcome}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationFeedbackResourceOutcome>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationFeedbackResourceOutcome using PATCH.
        /// </summary>
        /// <param name="educationFeedbackResourceOutcomeToUpdate">The EducationFeedbackResourceOutcome to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationFeedbackResourceOutcome.</returns>
        System.Threading.Tasks.Task<EducationFeedbackResourceOutcome> UpdateAsync(EducationFeedbackResourceOutcome educationFeedbackResourceOutcomeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationFeedbackResourceOutcome using PATCH and returns a <see cref="GraphResponse{EducationFeedbackResourceOutcome}"/> object.
        /// </summary>
        /// <param name="educationFeedbackResourceOutcomeToUpdate">The EducationFeedbackResourceOutcome to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationFeedbackResourceOutcome}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationFeedbackResourceOutcome>> UpdateResponseAsync(EducationFeedbackResourceOutcome educationFeedbackResourceOutcomeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationFeedbackResourceOutcome using PUT.
        /// </summary>
        /// <param name="educationFeedbackResourceOutcomeToUpdate">The EducationFeedbackResourceOutcome object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<EducationFeedbackResourceOutcome> PutAsync(EducationFeedbackResourceOutcome educationFeedbackResourceOutcomeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationFeedbackResourceOutcome using PUT and returns a <see cref="GraphResponse{EducationFeedbackResourceOutcome}"/> object.
        /// </summary>
        /// <param name="educationFeedbackResourceOutcomeToUpdate">The EducationFeedbackResourceOutcome object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{EducationFeedbackResourceOutcome}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationFeedbackResourceOutcome>> PutResponseAsync(EducationFeedbackResourceOutcome educationFeedbackResourceOutcomeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationFeedbackResourceOutcomeRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationFeedbackResourceOutcomeRequest Expand(Expression<Func<EducationFeedbackResourceOutcome, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationFeedbackResourceOutcomeRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationFeedbackResourceOutcomeRequest Select(Expression<Func<EducationFeedbackResourceOutcome, object>> selectExpression);

    }
}