﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
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

using GroupDocs.Editor.Cloud.Sdk.Client;
using GroupDocs.Editor.Cloud.Sdk.Model;
using GroupDocs.Editor.Cloud.Sdk.Model.Requests;
using GroupDocs.Editor.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Editor.Cloud.Sdk.Test.Api
{    
    public class EditorInfoApiTests : BaseApiTest
    {
        [Test]
        public void TestGetInfoReturnsMissingFileInfo()
        {
            // Arrange
            var request = new GetInfoRequest(null);

            // Act & Assert    
            var ex = Assert.Throws<ApiException>(() => {
                InfoApi.GetInfo(request);
            });

            Assert.AreEqual("Missing required parameter 'fileInfo' when calling GetInfo", ex.Message);
        }

        [Test]
        public void TestGetInfoReturnsFileNotFound()
        {
            // Arrange
            var fileInfo = TestFiles.NotExist.ToFileInfo();
            
            var request = new GetInfoRequest(fileInfo);

            // Act & Assert
            var ex = Assert.Throws<ApiException>(() => {
                InfoApi.GetInfo(request);
            });

            Assert.AreEqual("Can't find file located at 'some-folder/NotExist.docx'.", ex.Message);
        }

        [Test]
        public void TestPostInfoWithMinimalOptions()
        {
            // Arrange
            var fileInfo = TestFiles.FourPagesDocx.ToFileInfo();
            
            var request = new GetInfoRequest(fileInfo);

            // Act & Assert
            var infoResult = InfoApi.GetInfo(request);

            Assert.AreEqual(4, infoResult.PageCount);
        }

        [Test]
        public void TestPostInfoWithPassword()
        {
            // Arrange
            var fileInfo = TestFiles.PasswordProtectedDocx.ToFileInfo();
            
            var request = new GetInfoRequest(fileInfo);

            // Act & Assert
            var infoResult = InfoApi.GetInfo(request);

            Assert.AreEqual(4, infoResult.PageCount);
        }   

    }
}
