// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="TextLoadOptions.cs">
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
    /// Allows to specify custom options for loading plain text (TXT) documents
    /// </summary>  
    public class TextLoadOptions : LoadOptions 
    {                       
        /// <summary>
        /// Gets or sets preferred option of a leading space handling. By default converts leading spaces to the left indent.
        /// </summary>
        /// <value>Gets or sets preferred option of a leading space handling. By default converts leading spaces to the left indent.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LeadingSpacesEnum
        { 
            /// <summary>
            /// Enum ConvertToIndent for "ConvertToIndent"
            /// </summary>            
            ConvertToIndent,
            
            /// <summary>
            /// Enum Preserve for "Preserve"
            /// </summary>            
            Preserve,
            
            /// <summary>
            /// Enum Trim for "Trim"
            /// </summary>            
            Trim            
        }

        /// <summary>
        /// Gets or sets preferred option of a trailing space handling. By default truncates all trailing spaces.
        /// </summary>
        /// <value>Gets or sets preferred option of a trailing space handling. By default truncates all trailing spaces.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TrailingSpacesEnum
        { 
            /// <summary>
            /// Enum Trim for "Trim"
            /// </summary>            
            Trim,
            
            /// <summary>
            /// Enum Preserve for "Preserve"
            /// </summary>            
            Preserve            
        }

        /// <summary>
        /// Gets or sets preferred option of a leading space handling. By default converts leading spaces to the left indent.
        /// </summary>
        public LeadingSpacesEnum? LeadingSpaces { get; set; }

        /// <summary>
        /// Gets or sets preferred option of a trailing space handling. By default truncates all trailing spaces.
        /// </summary>
        public TrailingSpacesEnum? TrailingSpaces { get; set; }

        /// <summary>
        /// Character encoding of the text document, which will be applied for its opening
        /// </summary>  
        public string Encoding { get; set; }

        /// <summary>
        /// Allows to specify how numbered list items are recognized when document is imported from plain text format. The default value is true.
        /// </summary>  
        public bool? RecognizeLists { get; set; }

        /// <summary>
        /// Allows to enable or disable pagination in the resultant HTML document. By default is disabled (false).
        /// </summary>  
        public bool? EnablePagination { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TextLoadOptions {\n");
          sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
          sb.Append("  RecognizeLists: ").Append(this.RecognizeLists).Append("\n");
          sb.Append("  LeadingSpaces: ").Append(this.LeadingSpaces).Append("\n");
          sb.Append("  TrailingSpaces: ").Append(this.TrailingSpaces).Append("\n");
          sb.Append("  EnablePagination: ").Append(this.EnablePagination).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
