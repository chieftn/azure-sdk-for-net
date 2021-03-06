// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PipelineOperations.
    /// </summary>
    public static partial class PipelineOperationsExtensions
    {
            /// <summary>
            /// Lists all pipelines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='startDateTime'>
            /// The start date for when to get the list of pipelines. The startDateTime and
            /// endDateTime can be no more than 30 days apart.
            /// </param>
            /// <param name='endDateTime'>
            /// The end date for when to get the list of pipelines. The startDateTime and
            /// endDateTime can be no more than 30 days apart.
            /// </param>
            public static IPage<JobPipelineInformation> List(this IPipelineOperations operations, string accountName, System.DateTimeOffset? startDateTime = default(System.DateTimeOffset?), System.DateTimeOffset? endDateTime = default(System.DateTimeOffset?))
            {
                return operations.ListAsync(accountName, startDateTime, endDateTime).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all pipelines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='startDateTime'>
            /// The start date for when to get the list of pipelines. The startDateTime and
            /// endDateTime can be no more than 30 days apart.
            /// </param>
            /// <param name='endDateTime'>
            /// The end date for when to get the list of pipelines. The startDateTime and
            /// endDateTime can be no more than 30 days apart.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobPipelineInformation>> ListAsync(this IPipelineOperations operations, string accountName, System.DateTimeOffset? startDateTime = default(System.DateTimeOffset?), System.DateTimeOffset? endDateTime = default(System.DateTimeOffset?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(accountName, startDateTime, endDateTime, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the Pipeline information for the specified pipeline ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='pipelineIdentity'>
            /// Pipeline ID.
            /// </param>
            /// <param name='startDateTime'>
            /// The start date for when to get the pipeline and aggregate its data. The
            /// startDateTime and endDateTime can be no more than 30 days apart.
            /// </param>
            /// <param name='endDateTime'>
            /// The end date for when to get the pipeline and aggregate its data. The
            /// startDateTime and endDateTime can be no more than 30 days apart.
            /// </param>
            public static JobPipelineInformation Get(this IPipelineOperations operations, string accountName, System.Guid pipelineIdentity, System.DateTimeOffset? startDateTime = default(System.DateTimeOffset?), System.DateTimeOffset? endDateTime = default(System.DateTimeOffset?))
            {
                return operations.GetAsync(accountName, pipelineIdentity, startDateTime, endDateTime).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Pipeline information for the specified pipeline ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='pipelineIdentity'>
            /// Pipeline ID.
            /// </param>
            /// <param name='startDateTime'>
            /// The start date for when to get the pipeline and aggregate its data. The
            /// startDateTime and endDateTime can be no more than 30 days apart.
            /// </param>
            /// <param name='endDateTime'>
            /// The end date for when to get the pipeline and aggregate its data. The
            /// startDateTime and endDateTime can be no more than 30 days apart.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobPipelineInformation> GetAsync(this IPipelineOperations operations, string accountName, System.Guid pipelineIdentity, System.DateTimeOffset? startDateTime = default(System.DateTimeOffset?), System.DateTimeOffset? endDateTime = default(System.DateTimeOffset?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(accountName, pipelineIdentity, startDateTime, endDateTime, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all pipelines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JobPipelineInformation> ListNext(this IPipelineOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all pipelines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobPipelineInformation>> ListNextAsync(this IPipelineOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
