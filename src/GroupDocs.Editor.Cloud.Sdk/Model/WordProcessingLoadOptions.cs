// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="WordProcessingLoadOptions.cs">
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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

namespace GroupDocs.Editor.Cloud.Sdk.Model 
{
    using System;  
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    
    /// <summary>
    /// Allows to specify custom options for loading WordProcessing-compliant documents
    /// </summary>  
    public class WordProcessingLoadOptions : LoadOptions 
    {                       
        /// <summary>
        /// Responsible for extracting font resources, which are used in the input WordProcessing document. By default doesn&#39;t extract any fonts (NotExtract).
        /// </summary>
        /// <value>Responsible for extracting font resources, which are used in the input WordProcessing document. By default doesn&#39;t extract any fonts (NotExtract).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FontExtractionEnum
        { 
            /// <summary>
            /// Enum NotExtract for "NotExtract"
            /// </summary>            
            NotExtract,
            
            /// <summary>
            /// Enum ExtractAllEmbedded for "ExtractAllEmbedded"
            /// </summary>            
            ExtractAllEmbedded,
            
            /// <summary>
            /// Enum ExtractEmbeddedWithoutSystem for "ExtractEmbeddedWithoutSystem"
            /// </summary>            
            ExtractEmbeddedWithoutSystem,
            
            /// <summary>
            /// Enum ExtractAll for "ExtractAll"
            /// </summary>            
            ExtractAll            
        }

        /// <summary>
        /// Responsible for extracting font resources, which are used in the input WordProcessing document. By default doesn&#39;t extract any fonts (NotExtract).
        /// </summary>
        public FontExtractionEnum? FontExtraction { get; set; }

        /// <summary>
        /// Allows to enable or disable pagination in the resultant HTML document. By default is disabled (false).
        /// </summary>  
        public bool? EnablePagination { get; set; }

        /// <summary>
        /// Specifies whether language information is exported to the HTML markup in a form of 'lang' HTML attributes. This option may be useful for roundtrip conversion of the multi-language documents. By default it is disabled (false).
        /// </summary>  
        public bool? EnableLanguageInformation { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class WordProcessingLoadOptions {\n");
          sb.Append("  EnablePagination: ").Append(this.EnablePagination).Append("\n");
          sb.Append("  EnableLanguageInformation: ").Append(this.EnableLanguageInformation).Append("\n");
          sb.Append("  FontExtraction: ").Append(this.FontExtraction).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
