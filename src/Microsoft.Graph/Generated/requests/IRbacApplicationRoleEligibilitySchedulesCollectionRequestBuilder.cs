// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IRbacApplicationRoleEligibilitySchedulesCollectionRequestBuilder.
    /// </summary>
    public partial interface IRbacApplicationRoleEligibilitySchedulesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IRbacApplicationRoleEligibilitySchedulesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IRbacApplicationRoleEligibilitySchedulesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IUnifiedRoleEligibilityScheduleRequestBuilder"/> for the specified UnifiedRoleEligibilitySchedule.
        /// </summary>
        /// <param name="id">The ID for the UnifiedRoleEligibilitySchedule.</param>
        /// <returns>The <see cref="IUnifiedRoleEligibilityScheduleRequestBuilder"/>.</returns>
        IUnifiedRoleEligibilityScheduleRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for UnifiedRoleEligibilityScheduleFilterByCurrentUser.
        /// </summary>
        /// <returns>The <see cref="IUnifiedRoleEligibilityScheduleFilterByCurrentUserRequestBuilder"/>.</returns>
        IUnifiedRoleEligibilityScheduleFilterByCurrentUserRequestBuilder FilterByCurrentUser(
            RoleEligibilityScheduleFilterByCurrentUserOptions on);
    }
}