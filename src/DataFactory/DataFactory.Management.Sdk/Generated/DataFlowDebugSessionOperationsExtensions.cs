// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.DataFactory
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for DataFlowDebugSessionOperations
    /// </summary>
    public static partial class DataFlowDebugSessionOperationsExtensions
    {
        /// <summary>
        /// Creates a data flow debug session.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        public static CreateDataFlowDebugSessionResponse Create(this IDataFlowDebugSessionOperations operations, string resourceGroupName, string factoryName, CreateDataFlowDebugSessionRequest request)
        {
                return ((IDataFlowDebugSessionOperations)operations).CreateAsync(resourceGroupName, factoryName, request).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a data flow debug session.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<CreateDataFlowDebugSessionResponse> CreateAsync(this IDataFlowDebugSessionOperations operations, string resourceGroupName, string factoryName, CreateDataFlowDebugSessionRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, factoryName, request, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Query all active data flow debug sessions.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<DataFlowDebugSessionInfo> QueryByFactory(this IDataFlowDebugSessionOperations operations, string resourceGroupName, string factoryName)
        {
                return ((IDataFlowDebugSessionOperations)operations).QueryByFactoryAsync(resourceGroupName, factoryName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query all active data flow debug sessions.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<DataFlowDebugSessionInfo>> QueryByFactoryAsync(this IDataFlowDebugSessionOperations operations, string resourceGroupName, string factoryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.QueryByFactoryWithHttpMessagesAsync(resourceGroupName, factoryName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Add a data flow into debug session.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        public static AddDataFlowToDebugSessionResponse AddDataFlow(this IDataFlowDebugSessionOperations operations, string resourceGroupName, string factoryName, DataFlowDebugPackage request)
        {
                return ((IDataFlowDebugSessionOperations)operations).AddDataFlowAsync(resourceGroupName, factoryName, request).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add a data flow into debug session.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<AddDataFlowToDebugSessionResponse> AddDataFlowAsync(this IDataFlowDebugSessionOperations operations, string resourceGroupName, string factoryName, DataFlowDebugPackage request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.AddDataFlowWithHttpMessagesAsync(resourceGroupName, factoryName, request, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Deletes a data flow debug session.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        public static void Delete(this IDataFlowDebugSessionOperations operations, string resourceGroupName, string factoryName, string sessionId = default(string))
        {
                ((IDataFlowDebugSessionOperations)operations).DeleteAsync(resourceGroupName, factoryName, sessionId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes a data flow debug session.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this IDataFlowDebugSessionOperations operations, string resourceGroupName, string factoryName, string sessionId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, factoryName, sessionId, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Execute a data flow debug command.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        public static DataFlowDebugCommandResponse ExecuteCommand(this IDataFlowDebugSessionOperations operations, string resourceGroupName, string factoryName, DataFlowDebugCommandRequest request)
        {
                return ((IDataFlowDebugSessionOperations)operations).ExecuteCommandAsync(resourceGroupName, factoryName, request).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Execute a data flow debug command.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<DataFlowDebugCommandResponse> ExecuteCommandAsync(this IDataFlowDebugSessionOperations operations, string resourceGroupName, string factoryName, DataFlowDebugCommandRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ExecuteCommandWithHttpMessagesAsync(resourceGroupName, factoryName, request, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Creates a data flow debug session.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        public static CreateDataFlowDebugSessionResponse BeginCreate(this IDataFlowDebugSessionOperations operations, string resourceGroupName, string factoryName, CreateDataFlowDebugSessionRequest request)
        {
                return ((IDataFlowDebugSessionOperations)operations).BeginCreateAsync(resourceGroupName, factoryName, request).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a data flow debug session.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<CreateDataFlowDebugSessionResponse> BeginCreateAsync(this IDataFlowDebugSessionOperations operations, string resourceGroupName, string factoryName, CreateDataFlowDebugSessionRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, factoryName, request, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Execute a data flow debug command.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        public static DataFlowDebugCommandResponse BeginExecuteCommand(this IDataFlowDebugSessionOperations operations, string resourceGroupName, string factoryName, DataFlowDebugCommandRequest request)
        {
                return ((IDataFlowDebugSessionOperations)operations).BeginExecuteCommandAsync(resourceGroupName, factoryName, request).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Execute a data flow debug command.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<DataFlowDebugCommandResponse> BeginExecuteCommandAsync(this IDataFlowDebugSessionOperations operations, string resourceGroupName, string factoryName, DataFlowDebugCommandRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginExecuteCommandWithHttpMessagesAsync(resourceGroupName, factoryName, request, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Query all active data flow debug sessions.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<DataFlowDebugSessionInfo> QueryByFactoryNext(this IDataFlowDebugSessionOperations operations, string nextPageLink)
        {
                return ((IDataFlowDebugSessionOperations)operations).QueryByFactoryNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query all active data flow debug sessions.
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
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<DataFlowDebugSessionInfo>> QueryByFactoryNextAsync(this IDataFlowDebugSessionOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.QueryByFactoryNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
