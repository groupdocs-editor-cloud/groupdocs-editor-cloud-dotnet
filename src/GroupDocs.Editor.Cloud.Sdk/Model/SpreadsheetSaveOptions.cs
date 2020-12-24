// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SpreadsheetSaveOptions.cs">
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
    /// Allows to specify custom options for generating and saving Spreadsheet (Excel-compliant) documents
    /// </summary>  
    public class SpreadsheetSaveOptions : SaveOptions 
    {                       
        /// <summary>
        /// Write-protection type. Default value is None.
        /// </summary>
        /// <value>Write-protection type. Default value is None.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtectionTypeEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>            
            All,
            
            /// <summary>
            /// Enum Contents for "Contents"
            /// </summary>            
            Contents,
            
            /// <summary>
            /// Enum Objects for "Objects"
            /// </summary>            
            Objects,
            
            /// <summary>
            /// Enum Scenarios for "Scenarios"
            /// </summary>            
            Scenarios,
            
            /// <summary>
            /// Enum Structure for "Structure"
            /// </summary>            
            Structure,
            
            /// <summary>
            /// Enum Window for "Window"
            /// </summary>            
            Window            
        }

        /// <summary>
        /// Write-protection type. Default value is None.
        /// </summary>
        public ProtectionTypeEnum? ProtectionType { get; set; }

        /// <summary>
        /// Allows to specify document password
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Write-protection password. Used when protection type is specified.
        /// </summary>  
        public string ProtectionPassword { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SpreadsheetSaveOptions {\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  ProtectionType: ").Append(this.ProtectionType).Append("\n");
          sb.Append("  ProtectionPassword: ").Append(this.ProtectionPassword).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
