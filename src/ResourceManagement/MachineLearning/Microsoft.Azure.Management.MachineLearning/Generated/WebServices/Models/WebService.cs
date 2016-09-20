// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using System.Linq;

    /// <summary>
    /// Instance of an Azure ML web service resource.
    /// </summary>
    public partial class WebService : Resource
    {
        /// <summary>
        /// Initializes a new instance of the WebService class.
        /// </summary>
        public WebService() { }

        /// <summary>
        /// Initializes a new instance of the WebService class.
        /// </summary>
        /// <param name="location">Resource Location</param>
        /// <param name="properties">Web service resource properties.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource Name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        public WebService(string location, WebServiceProperties properties, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>))
            : base(location, id, name, type, tags)
        {
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets web service resource properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public WebServiceProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Properties == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Properties");
            }
            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
        }
    }
}
