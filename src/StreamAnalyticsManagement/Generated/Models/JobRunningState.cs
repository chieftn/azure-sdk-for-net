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

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The running state of the job.
    /// </summary>
    public static partial class JobRunningState
    {
        /// <summary>
        /// Created.
        /// </summary>
        public const string Created = "Created";
        
        /// <summary>
        /// Starting.
        /// </summary>
        public const string Starting = "Starting";
        
        /// <summary>
        /// Stopping.
        /// </summary>
        public const string Stopping = "Stopping";
        
        /// <summary>
        /// Stopped.
        /// </summary>
        public const string Stopped = "Stopped";
        
        /// <summary>
        /// Deleting.
        /// </summary>
        public const string Deleting = "Deleting";
        
        /// <summary>
        /// Failed.
        /// </summary>
        public const string Failed = "Failed";
        
        /// <summary>
        /// Idle.
        /// </summary>
        public const string Idle = "Idle";
        
        /// <summary>
        /// Processing.
        /// </summary>
        public const string Processing = "Processing";
        
        /// <summary>
        /// Degraded.
        /// </summary>
        public const string Degraded = "Degraded";
    }
}