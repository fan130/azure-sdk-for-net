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
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// The List Available Extensions operation response.
    /// </summary>
    public partial class HostedServiceListAvailableExtensionsResponse : OperationResponse, IEnumerable<HostedServiceListAvailableExtensionsResponse.ExtensionImage>
    {
        private IList<HostedServiceListAvailableExtensionsResponse.ExtensionImage> _extensionImages;
        
        /// <summary>
        /// The extensions that are available to add to your cloud service.
        /// </summary>
        public IList<HostedServiceListAvailableExtensionsResponse.ExtensionImage> ExtensionImages
        {
            get { return this._extensionImages; }
            set { this._extensionImages = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// HostedServiceListAvailableExtensionsResponse class.
        /// </summary>
        public HostedServiceListAvailableExtensionsResponse()
        {
            this._extensionImages = new List<HostedServiceListAvailableExtensionsResponse.ExtensionImage>();
        }
        
        /// <summary>
        /// Gets the sequence of ExtensionImages.
        /// </summary>
        public IEnumerator<HostedServiceListAvailableExtensionsResponse.ExtensionImage> GetEnumerator()
        {
            return this.ExtensionImages.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of ExtensionImages.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// An extension available to add to your cloud service.
        /// </summary>
        public partial class ExtensionImage
        {
            private string _description;
            
            /// <summary>
            /// The description of the extension.
            /// </summary>
            public string Description
            {
                get { return this._description; }
                set { this._description = value; }
            }
            
            private string _hostingResources;
            
            /// <summary>
            /// The type of resource that supports the extension. This value
            /// can be WebRole, WorkerRole, or WebRole|WorkerRole.
            /// </summary>
            public string HostingResources
            {
                get { return this._hostingResources; }
                set { this._hostingResources = value; }
            }
            
            private string _label;
            
            /// <summary>
            /// The label that is used to identify the extension.
            /// </summary>
            public string Label
            {
                get { return this._label; }
                set { this._label = value; }
            }
            
            private string _privateConfigurationSchema;
            
            /// <summary>
            /// The schema of the private configuration.
            /// </summary>
            public string PrivateConfigurationSchema
            {
                get { return this._privateConfigurationSchema; }
                set { this._privateConfigurationSchema = value; }
            }
            
            private string _providerNamespace;
            
            /// <summary>
            /// The provider namespace of the extension. The provider namespace
            /// for Windows Azure extensions is
            /// Microsoft.Windows.Azure.Extensions.
            /// </summary>
            public string ProviderNamespace
            {
                get { return this._providerNamespace; }
                set { this._providerNamespace = value; }
            }
            
            private string _publicConfigurationSchema;
            
            /// <summary>
            /// The schema of the public configuration.
            /// </summary>
            public string PublicConfigurationSchema
            {
                get { return this._publicConfigurationSchema; }
                set { this._publicConfigurationSchema = value; }
            }
            
            private string _thumbprintAlgorithm;
            
            /// <summary>
            /// The thumbprint algorithm of the certificate that is used for
            /// encryption.
            /// </summary>
            public string ThumbprintAlgorithm
            {
                get { return this._thumbprintAlgorithm; }
                set { this._thumbprintAlgorithm = value; }
            }
            
            private string _type;
            
            /// <summary>
            /// Required. The type of the extension.
            /// </summary>
            public string Type
            {
                get { return this._type; }
                set { this._type = value; }
            }
            
            private string _version;
            
            /// <summary>
            /// The version of the extension.
            /// </summary>
            public string Version
            {
                get { return this._version; }
                set { this._version = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the ExtensionImage class.
            /// </summary>
            public ExtensionImage()
            {
            }
        }
    }
}
