// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="EditApi.cs">
//  Copyright (c) 2003-2023 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Editor.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using GroupDocs.Editor.Cloud.Sdk.Client;
    using GroupDocs.Editor.Cloud.Sdk.Client.RequestHandlers;
    using GroupDocs.Editor.Cloud.Sdk.Model;
    using GroupDocs.Editor.Cloud.Sdk.Model.Requests;
    
    /// <summary>
    /// GroupDocs.Editor Cloud API.
    /// </summary>
    public class EditApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="EditApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public EditApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public EditApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }                            

        /// <summary>
        /// Load document for editing 
        /// </summary>
        /// <param name="request">Request. <see cref="LoadRequest" /></param>
        /// <returns><see cref="LoadResult"/></returns>
        public LoadResult Load(LoadRequest request)
        {
            // verify the required parameter 'loadOptions' is set
            if (request.loadOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'loadOptions' when calling Load");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/editor/load";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.loadOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (LoadResult)SerializationHelper.Deserialize(response, typeof(LoadResult));
            }

            return null;
        }

        /// <summary>
        /// Save document after editing 
        /// </summary>
        /// <param name="request">Request. <see cref="SaveRequest" /></param>
        /// <returns><see cref="DocumentResult"/></returns>
        public DocumentResult Save(SaveRequest request)
        {
            // verify the required parameter 'saveOptions' is set
            if (request.saveOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'saveOptions' when calling Save");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/editor/save";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.saveOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (DocumentResult)SerializationHelper.Deserialize(response, typeof(DocumentResult));
            }

            return null;
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="LoadRequest.cs">
//  Copyright (c) 2003-2023 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Editor.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Editor.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Editor.Cloud.Sdk.Api.EditApi.Load" /> operation.
    /// </summary>  
    public class LoadRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="LoadRequest"/> class.
          /// </summary>        
          public LoadRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="LoadRequest"/> class.
          /// </summary>
          /// <param name="loadOptions">The document load options</param>
          public LoadRequest(LoadOptions loadOptions)             
          {
              this.loadOptions = loadOptions;
          }
          
          /// <summary>
          /// The document load options
          /// </summary>  
          public LoadOptions loadOptions { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SaveRequest.cs">
//  Copyright (c) 2003-2023 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Editor.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Editor.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Editor.Cloud.Sdk.Api.EditApi.Save" /> operation.
    /// </summary>  
    public class SaveRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="SaveRequest"/> class.
          /// </summary>        
          public SaveRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="SaveRequest"/> class.
          /// </summary>
          /// <param name="saveOptions">Edited document save options</param>
          public SaveRequest(SaveOptions saveOptions)             
          {
              this.saveOptions = saveOptions;
          }
          
          /// <summary>
          /// Edited document save options
          /// </summary>  
          public SaveOptions saveOptions { get; set; }
    }
}
