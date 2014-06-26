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

namespace Microsoft.WindowsAzure.Scheduler.Models
{
    /// <summary>
    /// Parameters supplied to the Get Job History operation.
    /// </summary>
    public partial class JobGetHistoryParameters
    {
        private int _skip;
        
        /// <summary>
        /// Required. Specify the (0-based) index of the history list from
        /// which to begin requesting entries.
        /// </summary>
        public int Skip
        {
            get { return this._skip; }
            set { this._skip = value; }
        }
        
        private int _top;
        
        /// <summary>
        /// Required. Specify the number of history entries to request, in the
        /// of range [1..100].
        /// </summary>
        public int Top
        {
            get { return this._top; }
            set { this._top = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobGetHistoryParameters class.
        /// </summary>
        public JobGetHistoryParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the JobGetHistoryParameters class
        /// with required arguments.
        /// </summary>
        public JobGetHistoryParameters(int skip, int top)
            : this()
        {
            this.Skip = skip;
            this.Top = top;
        }
    }
}