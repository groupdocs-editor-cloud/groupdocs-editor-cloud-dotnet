// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="XmlLoadOptions.cs">
//  Copyright (c) 2003-2021 Aspose Pty Ltd
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
    /// Allows to specify custom options for loading XML (eXtensible Markup Language) documents
    /// </summary>  
    public class XmlLoadOptions : LoadOptions 
    {                       
        /// <summary>
        /// Allows to specify quote type (single or double quotes) for attribute values. Double quotes are default.             
        /// </summary>
        /// <value>Allows to specify quote type (single or double quotes) for attribute values. Double quotes are default.             </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AttributeValuesQuoteTypeEnum
        { 
            /// <summary>
            /// Enum DoubleQuote for "DoubleQuote"
            /// </summary>            
            DoubleQuote,
            
            /// <summary>
            /// Enum SingleQuote for "SingleQuote"
            /// </summary>            
            SingleQuote            
        }

        /// <summary>
        /// Allows to specify quote type (single or double quotes) for attribute values. Double quotes are default.             
        /// </summary>
        public AttributeValuesQuoteTypeEnum? AttributeValuesQuoteType { get; set; }

        /// <summary>
        /// Character encoding of the text document, which will be applied for its opening. By default is null - internal document encoding will be applied.             
        /// </summary>  
        public string Encoding { get; set; }

        /// <summary>
        /// Allows to enable or disable mechanism for fixing corrupted XML structure. By default is disabled (false).             
        /// </summary>  
        public bool? FixIncorrectStructure { get; set; }

        /// <summary>
        /// Allows to enable URI recognition algorithm
        /// </summary>  
        public bool? RecognizeUris { get; set; }

        /// <summary>
        /// Allows to enable recognition algorithm for email addresses in attribute values
        /// </summary>  
        public bool? RecognizeEmails { get; set; }

        /// <summary>
        /// Allows to enable the truncation of trailing whitespaces in the inner-tag text. By default is disabled (false) - trailing whitespaces will be preserved.             
        /// </summary>  
        public bool? TrimTrailingWhitespaces { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class XmlLoadOptions {\n");
          sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
          sb.Append("  FixIncorrectStructure: ").Append(this.FixIncorrectStructure).Append("\n");
          sb.Append("  RecognizeUris: ").Append(this.RecognizeUris).Append("\n");
          sb.Append("  RecognizeEmails: ").Append(this.RecognizeEmails).Append("\n");
          sb.Append("  TrimTrailingWhitespaces: ").Append(this.TrimTrailingWhitespaces).Append("\n");
          sb.Append("  AttributeValuesQuoteType: ").Append(this.AttributeValuesQuoteType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
