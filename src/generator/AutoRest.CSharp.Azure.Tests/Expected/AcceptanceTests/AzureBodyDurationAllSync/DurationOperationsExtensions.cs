// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureBodyDurationAllSync
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for DurationOperations.
    /// </summary>
    public static partial class DurationOperationsExtensions
    {
            /// <summary>
            /// Get null duration value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static System.TimeSpan? GetNull(this IDurationOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IDurationOperations)s).GetNullAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null duration value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.TimeSpan?> GetNullAsync(this IDurationOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetNullWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get null duration value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static Microsoft.Rest.Azure.AzureOperationResponse<System.TimeSpan?> GetNullWithHttpMessages(this IDurationOperations operations, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null)
            {
                return operations.GetNullWithHttpMessagesAsync(customHeaders, System.Threading.CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put a positive duration value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='durationBody'>
            /// </param>
            public static void PutPositiveDuration(this IDurationOperations operations, System.TimeSpan durationBody)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IDurationOperations)s).PutPositiveDurationAsync(durationBody), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put a positive duration value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='durationBody'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PutPositiveDurationAsync(this IDurationOperations operations, System.TimeSpan durationBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.PutPositiveDurationWithHttpMessagesAsync(durationBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Put a positive duration value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='durationBody'>
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static Microsoft.Rest.Azure.AzureOperationResponse PutPositiveDurationWithHttpMessages(this IDurationOperations operations, System.TimeSpan durationBody, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null)
            {
                return operations.PutPositiveDurationWithHttpMessagesAsync(durationBody, customHeaders, System.Threading.CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a positive duration value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static System.TimeSpan? GetPositiveDuration(this IDurationOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IDurationOperations)s).GetPositiveDurationAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a positive duration value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.TimeSpan?> GetPositiveDurationAsync(this IDurationOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetPositiveDurationWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a positive duration value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static Microsoft.Rest.Azure.AzureOperationResponse<System.TimeSpan?> GetPositiveDurationWithHttpMessages(this IDurationOperations operations, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null)
            {
                return operations.GetPositiveDurationWithHttpMessagesAsync(customHeaders, System.Threading.CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an invalid duration value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static System.TimeSpan? GetInvalid(this IDurationOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IDurationOperations)s).GetInvalidAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an invalid duration value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.TimeSpan?> GetInvalidAsync(this IDurationOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetInvalidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get an invalid duration value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static Microsoft.Rest.Azure.AzureOperationResponse<System.TimeSpan?> GetInvalidWithHttpMessages(this IDurationOperations operations, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null)
            {
                return operations.GetInvalidWithHttpMessagesAsync(customHeaders, System.Threading.CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
