// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.Sql;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// This is the main client class for interacting with the Azure SQL
    /// Database REST APIs.
    /// </summary>
    public static partial class ServiceObjectiveOperationsExtensions
    {
        /// <summary>
        /// Returns information about a certain Service Objective with a
        /// specific Id.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IServiceObjectiveOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server to be queried.
        /// </param>
        /// <param name='serviceObjectiveId'>
        /// Required. The Id of the Service Objective to be obtained.
        /// </param>
        /// <returns>
        /// Response containing the service objective for a given Azure SQL
        /// Database Server with matching service objective Id.
        /// </returns>
        public static ServiceObjectiveGetResponse Get(this IServiceObjectiveOperations operations, string serverName, string serviceObjectiveId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServiceObjectiveOperations)s).GetAsync(serverName, serviceObjectiveId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about a certain Service Objective with a
        /// specific Id.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IServiceObjectiveOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server to be queried.
        /// </param>
        /// <param name='serviceObjectiveId'>
        /// Required. The Id of the Service Objective to be obtained.
        /// </param>
        /// <returns>
        /// Response containing the service objective for a given Azure SQL
        /// Database Server with matching service objective Id.
        /// </returns>
        public static Task<ServiceObjectiveGetResponse> GetAsync(this IServiceObjectiveOperations operations, string serverName, string serviceObjectiveId)
        {
            return operations.GetAsync(serverName, serviceObjectiveId, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns information about all Service Objectives on an Azure SQL
        /// Database Server.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IServiceObjectiveOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server to be queried.
        /// </param>
        /// <returns>
        /// Response containing the list of service objective for a given
        /// server.  This is returnedfrom a call to List Service Objectives.
        /// </returns>
        public static ServiceObjectiveListResponse List(this IServiceObjectiveOperations operations, string serverName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServiceObjectiveOperations)s).ListAsync(serverName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about all Service Objectives on an Azure SQL
        /// Database Server.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IServiceObjectiveOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server to be queried.
        /// </param>
        /// <returns>
        /// Response containing the list of service objective for a given
        /// server.  This is returnedfrom a call to List Service Objectives.
        /// </returns>
        public static Task<ServiceObjectiveListResponse> ListAsync(this IServiceObjectiveOperations operations, string serverName)
        {
            return operations.ListAsync(serverName, CancellationToken.None);
        }
    }
}