// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PdfSaveOptions.cs">
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
    /// Allows to specify custom options for generating and saving PDF (Portable Document Format) documents
    /// </summary>  
    public class PdfSaveOptions : SaveOptions 
    {                       
        /// <summary>
        /// Specifies the PDF standards compliance level for output documents. Default is PdfCompliance.Pdf15.             
        /// </summary>
        /// <value>Specifies the PDF standards compliance level for output documents. Default is PdfCompliance.Pdf15.             </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ComplianceEnum
        { 
            /// <summary>
            /// Enum Pdf15 for "Pdf15"
            /// </summary>            
            Pdf15,
            
            /// <summary>
            /// Enum PdfA1a for "PdfA1a"
            /// </summary>            
            PdfA1a,
            
            /// <summary>
            /// Enum PdfA1b for "PdfA1b"
            /// </summary>            
            PdfA1b            
        }

        /// <summary>
        /// Specifies the PDF standards compliance level for output documents. Default is PdfCompliance.Pdf15.             
        /// </summary>
        public ComplianceEnum? Compliance { get; set; }

        /// <summary>
        /// Password, which will be applied to the generated PDF document as user password, required for opening. If NULL or empty, no password will be applied to the document. Otherwise, document will be encrypted with RC4 (key length of 128 bit).             
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfSaveOptions {\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  Compliance: ").Append(this.Compliance).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
