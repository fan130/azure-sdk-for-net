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
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql.Models
{
    /// <summary>
    /// Response containing the list of service objective for a given server.
    /// </summary>
    public partial class ServiceObjectiveListResponse : OperationResponse, IEnumerable<ServiceObjective>
    {
        private IList<ServiceObjective> _serviceObjectives;
        
        /// <summary>
        /// Gets or sets the list of Service Objectives that are existing in a
        /// server.
        /// </summary>
        public IList<ServiceObjective> ServiceObjectives
        {
            get { return this._serviceObjectives; }
            set { this._serviceObjectives = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ServiceObjectiveListResponse
        /// class.
        /// </summary>
        public ServiceObjectiveListResponse()
        {
            this._serviceObjectives = new List<ServiceObjective>();
        }
        
        /// <summary>
        /// Gets the sequence of ServiceObjectives.
        /// </summary>
        public IEnumerator<ServiceObjective> GetEnumerator()
        {
            return this.ServiceObjectives.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of ServiceObjectives.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
