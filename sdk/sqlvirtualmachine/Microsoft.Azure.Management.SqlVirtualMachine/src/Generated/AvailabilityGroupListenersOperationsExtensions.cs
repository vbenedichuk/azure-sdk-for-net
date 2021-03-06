// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SqlVirtualMachine
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AvailabilityGroupListenersOperations.
    /// </summary>
    public static partial class AvailabilityGroupListenersOperationsExtensions
    {
            /// <summary>
            /// Gets an availability group listener.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='availabilityGroupListenerName'>
            /// Name of the availability group listener.
            /// </param>
            public static AvailabilityGroupListener Get(this IAvailabilityGroupListenersOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, string availabilityGroupListenerName)
            {
                return operations.GetAsync(resourceGroupName, sqlVirtualMachineGroupName, availabilityGroupListenerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an availability group listener.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='availabilityGroupListenerName'>
            /// Name of the availability group listener.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AvailabilityGroupListener> GetAsync(this IAvailabilityGroupListenersOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, string availabilityGroupListenerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, sqlVirtualMachineGroupName, availabilityGroupListenerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an availability group listener.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='availabilityGroupListenerName'>
            /// Name of the availability group listener.
            /// </param>
            /// <param name='parameters'>
            /// The availability group listener.
            /// </param>
            public static AvailabilityGroupListener CreateOrUpdate(this IAvailabilityGroupListenersOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, string availabilityGroupListenerName, AvailabilityGroupListener parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, sqlVirtualMachineGroupName, availabilityGroupListenerName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an availability group listener.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='availabilityGroupListenerName'>
            /// Name of the availability group listener.
            /// </param>
            /// <param name='parameters'>
            /// The availability group listener.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AvailabilityGroupListener> CreateOrUpdateAsync(this IAvailabilityGroupListenersOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, string availabilityGroupListenerName, AvailabilityGroupListener parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, sqlVirtualMachineGroupName, availabilityGroupListenerName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an availability group listener.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='availabilityGroupListenerName'>
            /// Name of the availability group listener.
            /// </param>
            public static void Delete(this IAvailabilityGroupListenersOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, string availabilityGroupListenerName)
            {
                operations.DeleteAsync(resourceGroupName, sqlVirtualMachineGroupName, availabilityGroupListenerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an availability group listener.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='availabilityGroupListenerName'>
            /// Name of the availability group listener.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAvailabilityGroupListenersOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, string availabilityGroupListenerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, sqlVirtualMachineGroupName, availabilityGroupListenerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all availability group listeners in a SQL virtual machine group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            public static IPage<AvailabilityGroupListener> ListByGroup(this IAvailabilityGroupListenersOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName)
            {
                return operations.ListByGroupAsync(resourceGroupName, sqlVirtualMachineGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all availability group listeners in a SQL virtual machine group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AvailabilityGroupListener>> ListByGroupAsync(this IAvailabilityGroupListenersOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByGroupWithHttpMessagesAsync(resourceGroupName, sqlVirtualMachineGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an availability group listener.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='availabilityGroupListenerName'>
            /// Name of the availability group listener.
            /// </param>
            /// <param name='parameters'>
            /// The availability group listener.
            /// </param>
            public static AvailabilityGroupListener BeginCreateOrUpdate(this IAvailabilityGroupListenersOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, string availabilityGroupListenerName, AvailabilityGroupListener parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, sqlVirtualMachineGroupName, availabilityGroupListenerName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an availability group listener.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='availabilityGroupListenerName'>
            /// Name of the availability group listener.
            /// </param>
            /// <param name='parameters'>
            /// The availability group listener.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AvailabilityGroupListener> BeginCreateOrUpdateAsync(this IAvailabilityGroupListenersOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, string availabilityGroupListenerName, AvailabilityGroupListener parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, sqlVirtualMachineGroupName, availabilityGroupListenerName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an availability group listener.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='availabilityGroupListenerName'>
            /// Name of the availability group listener.
            /// </param>
            public static void BeginDelete(this IAvailabilityGroupListenersOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, string availabilityGroupListenerName)
            {
                operations.BeginDeleteAsync(resourceGroupName, sqlVirtualMachineGroupName, availabilityGroupListenerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an availability group listener.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='availabilityGroupListenerName'>
            /// Name of the availability group listener.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IAvailabilityGroupListenersOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, string availabilityGroupListenerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, sqlVirtualMachineGroupName, availabilityGroupListenerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all availability group listeners in a SQL virtual machine group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AvailabilityGroupListener> ListByGroupNext(this IAvailabilityGroupListenersOperations operations, string nextPageLink)
            {
                return operations.ListByGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all availability group listeners in a SQL virtual machine group.
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
            public static async Task<IPage<AvailabilityGroupListener>> ListByGroupNextAsync(this IAvailabilityGroupListenersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
