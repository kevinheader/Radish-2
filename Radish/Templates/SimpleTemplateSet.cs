﻿#region License
//   Copyright (C) 2015 Alexander Krutov
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
#endregion License

namespace Radish
{
    /// <summary>
    /// Simple and ascetic template set for the REST API documentation.
    /// Does not require any external JS or CSS resources.
    /// </summary>
    public class SimpleTemplateSet : BasicTemplateSet
    {
        /// <summary>
        /// Template for whole documentation page.
        /// </summary>
        public override string Page { get; set; }

        /// <summary>
        /// Documentation title.
        /// </summary>
        public override string Title { get; set; }

        /// <summary>
        /// Template for documentation section of particular method.
        /// </summary>
        public override string Method { get; set; }

        /// <summary>
        /// Template for documentation section of group of methods.
        /// </summary>
        public override string MethodsGroup { get; set; }

        /// <summary>
        /// Template for single row in a table of request parameters of the method.
        /// </summary>
        public override string RequestParameter { get; set; }

        /// <summary>
        /// Template for rendering table of request parameters of the method.
        /// </summary>
        public override string RequestParametersList { get; set; }

        /// <summary>
        /// Template for documentation section about request information for the method.
        /// </summary>
        public override string RequestBodyDescription { get; set; }

        /// <summary>
        /// Template for documentation section with example of request body for the method. 
        /// </summary>
        public override string RequestBodyExample { get; set; }

        /// <summary>
        /// Template for documentation section about response information for the method.
        /// </summary>
        public override string ResponseBodyDescription { get; set; }

        /// <summary>
        /// Template for documentation section with example of response body for the method. 
        /// </summary>
        public override string ResponseBodyExample { get; set; }

        /// <summary>
        /// Template for single row in a table of response codes for the method.
        /// </summary>
        public override string ResponseCode { get; set; }

        /// <summary>
        /// Template for table of response codes for the method.
        /// </summary>
        public override string ResponseCodesList { get; set; }

        /// <summary>
        /// Creates new instance of SimpleTemplateSet.
        /// </summary>
        public SimpleTemplateSet() : base() 
        {
            Title = "Documentation";
            Page = Templates.Simple.Templates.Page;
            Method = Templates.Simple.Templates.Method;
            MethodsGroup = Templates.Simple.Templates.MethodsGroup;
            RequestParameter = Templates.Simple.Templates.RequestParameter;
            RequestParametersList = Templates.Simple.Templates.RequestParametersList;
            RequestBodyDescription = Templates.Simple.Templates.RequestBodyDescription;
            RequestBodyExample = Templates.Simple.Templates.RequestBodyExample;
            ResponseBodyDescription = Templates.Simple.Templates.ResponseBodyDescription;
            ResponseBodyExample = Templates.Simple.Templates.ResponseBodyExample;
            ResponseCode = Templates.Simple.Templates.ResponseCode;
            ResponseCodesList = Templates.Simple.Templates.ResponseCodesList; 
        }
    }
}
