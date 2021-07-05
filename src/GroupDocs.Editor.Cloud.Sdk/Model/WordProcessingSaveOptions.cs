// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="WordProcessingSaveOptions.cs">
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
    /// Allows to specify custom options for generating and saving WordProcessing-compliant documents
    /// </summary>  
    public class WordProcessingSaveOptions : SaveOptions 
    {                       
        /// <summary>
        /// Write-protection type. Default value is NoProtection
        /// </summary>
        /// <value>Write-protection type. Default value is NoProtection</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtectionTypeEnum
        { 
            /// <summary>
            /// Enum NoProtection for "NoProtection"
            /// </summary>            
            NoProtection,
            
            /// <summary>
            /// Enum AllowOnlyRevisions for "AllowOnlyRevisions"
            /// </summary>            
            AllowOnlyRevisions,
            
            /// <summary>
            /// Enum AllowOnlyComments for "AllowOnlyComments"
            /// </summary>            
            AllowOnlyComments,
            
            /// <summary>
            /// Enum AllowOnlyFormFields for "AllowOnlyFormFields"
            /// </summary>            
            AllowOnlyFormFields,
            
            /// <summary>
            /// Enum ReadOnly for "ReadOnly"
            /// </summary>            
            ReadOnly            
        }

        /// <summary>
        /// Write-protection type. Default value is NoProtection
        /// </summary>
        public ProtectionTypeEnum? ProtectionType { get; set; }

        /// <summary>
        /// Allows to specify document password
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Allows to enable or disable pagination which will be used for saving the document. If the original document was opened and edited in pagination mode, this option also should be enabled. By default is disabled.
        /// </summary>  
        public bool? EnablePagination { get; set; }

        /// <summary>
        /// Allows to set override default locale (language) for the WordProcessing document, which will be applied during its creation. When is not specified (default value), MS Word (or other program) will detect (or choose) the document locale according to its own settings or other factors.
        /// </summary>  
        public string Locale { get; set; }

        /// <summary>
        /// Allows to set override locale (language) for the WordProcessing document for the RTL (right-to-left) text, which will be applied during its creation. When is not specified (default value), MS Word (or other program) will detect (or choose) the document RTL locale according to its own settings or other factors.
        /// </summary>  
        public string LocaleBi { get; set; }

        /// <summary>
        /// Allows to override the locale (language) for the WordProcessing document for the East-Asian text, which will be applied during its creation. When is not specified (default value), MS Word (or other program) will detect (or choose) the document East-Asian locale according to its own settings or other factors.
        /// </summary>  
        public string LocaleFarEast { get; set; }

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
          sb.Append("class WordProcessingSaveOptions {\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  EnablePagination: ").Append(this.EnablePagination).Append("\n");
          sb.Append("  Locale: ").Append(this.Locale).Append("\n");
          sb.Append("  LocaleBi: ").Append(this.LocaleBi).Append("\n");
          sb.Append("  LocaleFarEast: ").Append(this.LocaleFarEast).Append("\n");
          sb.Append("  ProtectionType: ").Append(this.ProtectionType).Append("\n");
          sb.Append("  ProtectionPassword: ").Append(this.ProtectionPassword).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
