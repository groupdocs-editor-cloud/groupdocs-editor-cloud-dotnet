// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DelimitedTextLoadOptions.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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
    /// Options for loading text-based Spreadsheet documents (CSV, Tab-based etc.), that use a separator (delimiter)
    /// </summary>  
    public class DelimitedTextLoadOptions : LoadOptions 
    {                       
        /// <summary>
        /// Allows to specify a string separator (delimiter) for text-based Spreadsheet documents             
        /// </summary>  
        public string Separator { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether the string in text-based document is converted to the date data. Default is false.
        /// </summary>  
        public bool? ConvertDateTimeData { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether the string in text-based document is converted to numeric data. Default is false.
        /// </summary>  
        public bool? ConvertNumericData { get; set; }

        /// <summary>
        /// Defines whether consecutive delimiters should be treated as one. By default is false.
        /// </summary>  
        public bool? TreatConsecutiveDelimitersAsOne { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DelimitedTextLoadOptions {\n");
          sb.Append("  Separator: ").Append(this.Separator).Append("\n");
          sb.Append("  ConvertDateTimeData: ").Append(this.ConvertDateTimeData).Append("\n");
          sb.Append("  ConvertNumericData: ").Append(this.ConvertNumericData).Append("\n");
          sb.Append("  TreatConsecutiveDelimitersAsOne: ").Append(this.TreatConsecutiveDelimitersAsOne).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
