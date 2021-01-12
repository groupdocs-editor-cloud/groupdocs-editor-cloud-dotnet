// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DelimitedTextSaveOptions.cs">
//  Copyright (c) 2003-2020 Aspose Pty Ltd
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
    /// Contains options for generating and saving text-based Spreadsheet documents (CSV, Tab-based etc.), that use a separator (delimiter)
    /// </summary>  
    public class DelimitedTextSaveOptions : SaveOptions 
    {                       
        /// <summary>
        /// Allows to specify a string separator (delimiter) for text-based Spreadsheet documents
        /// </summary>  
        public string Separator { get; set; }

        /// <summary>
        /// Allows to set an encoding for the text-based Spreadsheet document. By default (and if not specified) is UTF-8.
        /// </summary>  
        public string Encoding { get; set; }

        /// <summary>
        /// Indicates whether leading blank rows and columns should be trimmed like what MS Excel does
        /// </summary>  
        public bool? TrimLeadingBlankRowAndColumn { get; set; }

        /// <summary>
        /// Indicates whether separators should be output for blank row. Default value is false which means the content for blank row will be empty.
        /// </summary>  
        public bool? KeepSeparatorsForBlankRow { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DelimitedTextSaveOptions {\n");
          sb.Append("  Separator: ").Append(this.Separator).Append("\n");
          sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
          sb.Append("  TrimLeadingBlankRowAndColumn: ").Append(this.TrimLeadingBlankRowAndColumn).Append("\n");
          sb.Append("  KeepSeparatorsForBlankRow: ").Append(this.KeepSeparatorsForBlankRow).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
