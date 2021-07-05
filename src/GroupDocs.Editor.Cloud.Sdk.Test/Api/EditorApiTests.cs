// --------------------------------------------------------------------------------------------------------------------
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

using GroupDocs.Editor.Cloud.Sdk.Model;
using GroupDocs.Editor.Cloud.Sdk.Model.Requests;
using GroupDocs.Editor.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Editor.Cloud.Sdk.Test.Api
{
    public class EditorApiTests : BaseApiTest
    {
        [Test]
        public void TestOpenSaveDocx()
        {
            // Load
            var testFile = TestFiles.FourPagesDocx;
            var loadOptions = new LoadOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = DefaultOutputPath
            };

            var loadResult = EditApi.Load(new LoadRequest(loadOptions));

            Assert.IsNotEmpty(loadResult.HtmlPath);
            Assert.IsNotEmpty(loadResult.ResourcesPath);

            // Save
            var saveOptions = new SaveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                HtmlPath = loadResult.HtmlPath,
                ResourcesPath = loadResult.ResourcesPath,
                OutputPath = $"{DefaultOutputPath}/{testFile.FileName}"
            };

            var saveResult = EditApi.Save(new SaveRequest(saveOptions));

            Assert.AreEqual(saveOptions.OutputPath, saveResult.Path);
        }

        [Test]
        public void TestOpenSaveDocxProtected()
        {
            // Load
            var testFile = TestFiles.PasswordProtectedDocx;
            var loadOptions = new LoadOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = DefaultOutputPath
            };

            var loadResult = EditApi.Load(new LoadRequest(loadOptions));

            Assert.IsNotEmpty(loadResult.HtmlPath);
            Assert.IsNotEmpty(loadResult.ResourcesPath);

            // Save
            var saveOptions = new SaveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                HtmlPath = loadResult.HtmlPath,
                ResourcesPath = loadResult.ResourcesPath,
                OutputPath = $"{DefaultOutputPath}/{testFile.FileName}"
            };

            var saveResult = EditApi.Save(new SaveRequest(saveOptions));

            Assert.AreEqual(saveOptions.OutputPath, saveResult.Path);
        }

        [Test]
        public void TestOpenSaveDocxWithOptions()
        {
            // Load
            var testFile = TestFiles.PasswordProtectedDocx;
            var loadOptions = new WordProcessingLoadOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = DefaultOutputPath,
                EnablePagination = true,
                FontExtraction = WordProcessingLoadOptions.FontExtractionEnum.ExtractAll
            };

            var loadResult = EditApi.Load(new LoadRequest(loadOptions));

            Assert.IsNotEmpty(loadResult.HtmlPath);
            Assert.IsNotEmpty(loadResult.ResourcesPath);

            // Save
            var saveOptions = new WordProcessingSaveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                HtmlPath = loadResult.HtmlPath,
                ResourcesPath = loadResult.ResourcesPath,
                OutputPath = $"{DefaultOutputPath}/{testFile.FileName}",
                EnablePagination = true,
                Format = "Docx",
                Password = testFile.Password,
                ProtectionPassword = testFile.Password,
                ProtectionType = WordProcessingSaveOptions.ProtectionTypeEnum.AllowOnlyComments
            };

            var saveResult = EditApi.Save(new SaveRequest(saveOptions));

            Assert.AreEqual(saveOptions.OutputPath, saveResult.Path);
        }

        [Test]
        public void TestOpenSaveXlsx()
        {
            // Load
            var testFile = TestFiles.FourSheetsXlsx;
            var loadOptions = new LoadOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = DefaultOutputPath
            };

            var loadResult = EditApi.Load(new LoadRequest(loadOptions));

            Assert.IsNotEmpty(loadResult.HtmlPath);
            Assert.IsNotEmpty(loadResult.ResourcesPath);

            // Save
            var saveOptions = new SaveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                HtmlPath = loadResult.HtmlPath,
                ResourcesPath = loadResult.ResourcesPath,
                OutputPath = $"{DefaultOutputPath}/{testFile.FileName}"
            };

            var saveResult = EditApi.Save(new SaveRequest(saveOptions));

            Assert.AreEqual(saveOptions.OutputPath, saveResult.Path);
        }

        [Test]
        public void TestOpenSaveXlsxProtected()
        {
            // Load
            var testFile = TestFiles.FourSheetsProtectedXlsx;
            var loadOptions = new LoadOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = DefaultOutputPath
            };

            var loadResult = EditApi.Load(new LoadRequest(loadOptions));

            Assert.IsNotEmpty(loadResult.HtmlPath);
            Assert.IsNotEmpty(loadResult.ResourcesPath);

            // Save
            var saveOptions = new SaveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                HtmlPath = loadResult.HtmlPath,
                ResourcesPath = loadResult.ResourcesPath,
                OutputPath = $"{DefaultOutputPath}/{testFile.FileName}"
            };

            var saveResult = EditApi.Save(new SaveRequest(saveOptions));

            Assert.AreEqual(saveOptions.OutputPath, saveResult.Path);
        }

        [Test]
        public void TestOpenSaveXlsxWithOptions()
        {
            // Load
            var testFile = TestFiles.FourSheetsProtectedXlsx;
            var loadOptions = new SpreadsheetLoadOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = DefaultOutputPath,
                ExcludeHiddenWorksheets = true
            };

            var loadResult = EditApi.Load(new LoadRequest(loadOptions));

            Assert.IsNotEmpty(loadResult.HtmlPath);
            Assert.IsNotEmpty(loadResult.ResourcesPath);

            // Save
            var saveOptions = new SpreadsheetSaveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                HtmlPath = loadResult.HtmlPath,
                ResourcesPath = loadResult.ResourcesPath,
                OutputPath = $"{DefaultOutputPath}/{testFile.FileName}",
                Format = "xlsx",
                Password = testFile.Password,
                ProtectionPassword = testFile.Password,
                ProtectionType = SpreadsheetSaveOptions.ProtectionTypeEnum.All
            };

            var saveResult = EditApi.Save(new SaveRequest(saveOptions));

            Assert.AreEqual(saveOptions.OutputPath, saveResult.Path);
        }

        [Test]
        public void TestOpenSaveTsv()
        {
            // Load
            var testFile = TestFiles.Tsv;
            var loadOptions = new LoadOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = DefaultOutputPath
            };

            var loadResult = EditApi.Load(new LoadRequest(loadOptions));

            Assert.IsNotEmpty(loadResult.HtmlPath);
            Assert.IsNotEmpty(loadResult.ResourcesPath);

            // Save
            var saveOptions = new SaveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                HtmlPath = loadResult.HtmlPath,
                ResourcesPath = loadResult.ResourcesPath,
                OutputPath = $"{DefaultOutputPath}/{testFile.FileName}"
            };

            var saveResult = EditApi.Save(new SaveRequest(saveOptions));

            Assert.AreEqual(saveOptions.OutputPath, saveResult.Path);
        }

        [Test]
        public void TestOpenSaveTsvWithOptions()
        {
            // Load
            var testFile = TestFiles.Tsv;
            var loadOptions = new DelimitedTextLoadOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = DefaultOutputPath,
                Separator = "\t",
                ConvertNumericData = true,
                TreatConsecutiveDelimitersAsOne = true
            };

            var loadResult = EditApi.Load(new LoadRequest(loadOptions));

            Assert.IsNotEmpty(loadResult.HtmlPath);
            Assert.IsNotEmpty(loadResult.ResourcesPath);

            // Save
            var saveOptions = new DelimitedTextSaveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                HtmlPath = loadResult.HtmlPath,
                ResourcesPath = loadResult.ResourcesPath,
                OutputPath = $"{DefaultOutputPath}/{testFile.FileName}",
                Encoding = "UTF-8",
                Format = "tsv",
                KeepSeparatorsForBlankRow = true
            };

            var saveResult = EditApi.Save(new SaveRequest(saveOptions));

            Assert.AreEqual(saveOptions.OutputPath, saveResult.Path);
        }

        [Test]
        public void TestOpenSaveText()
        {
            // Load
            var testFile = TestFiles.Txt;
            var loadOptions = new LoadOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = DefaultOutputPath
            };

            var loadResult = EditApi.Load(new LoadRequest(loadOptions));

            Assert.IsNotEmpty(loadResult.HtmlPath);
            Assert.IsNotEmpty(loadResult.ResourcesPath);

            // Save
            var saveOptions = new SaveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                HtmlPath = loadResult.HtmlPath,
                ResourcesPath = loadResult.ResourcesPath,
                OutputPath = $"{DefaultOutputPath}/{testFile.FileName}"
            };

            var saveResult = EditApi.Save(new SaveRequest(saveOptions));

            Assert.AreEqual(saveOptions.OutputPath, saveResult.Path);
        }

        [Test]
        public void TestOpenSaveTextWithOptions()
        {
            // Load
            var testFile = TestFiles.Txt;
            var loadOptions = new TextLoadOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = DefaultOutputPath,
                EnablePagination = true,
                LeadingSpaces = TextLoadOptions.LeadingSpacesEnum.Trim,
                RecognizeLists = true
            };

            var loadResult = EditApi.Load(new LoadRequest(loadOptions));

            Assert.IsNotEmpty(loadResult.HtmlPath);
            Assert.IsNotEmpty(loadResult.ResourcesPath);

            // Save
            var saveOptions = new TextSaveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                HtmlPath = loadResult.HtmlPath,
                ResourcesPath = loadResult.ResourcesPath,
                OutputPath = $"{DefaultOutputPath}/{testFile.FileName}",
                AddBidiMarks = true,
                Encoding = "UTF-8",
                Format = "txt",
                PreserveTableLayout = true
            };

            var saveResult = EditApi.Save(new SaveRequest(saveOptions));

            Assert.AreEqual(saveOptions.OutputPath, saveResult.Path);
        }

        [Test]
        public void TestOpenSavePresentation()
        {
            // Load
            var testFile = TestFiles.Presentation;
            var loadOptions = new LoadOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = DefaultOutputPath
            };

            var loadResult = EditApi.Load(new LoadRequest(loadOptions));

            Assert.IsNotEmpty(loadResult.HtmlPath);
            Assert.IsNotEmpty(loadResult.ResourcesPath);

            // Save
            var saveOptions = new SaveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                HtmlPath = loadResult.HtmlPath,
                ResourcesPath = loadResult.ResourcesPath,
                OutputPath = $"{DefaultOutputPath}/{testFile.FileName}"
            };

            var saveResult = EditApi.Save(new SaveRequest(saveOptions));

            Assert.AreEqual(saveOptions.OutputPath, saveResult.Path);
        }

        [Test]
        public void TestOpenSavePresentationWithOptions()
        {
            // Load
            var testFile = TestFiles.PresentationWithHiddenSlide;
            var loadOptions = new PresentationLoadOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = DefaultOutputPath,
                ShowHiddenSlides = true,
                SlideNumber = 0
            };

            var loadResult = EditApi.Load(new LoadRequest(loadOptions));

            Assert.IsNotEmpty(loadResult.HtmlPath);
            Assert.IsNotEmpty(loadResult.ResourcesPath);

            // Save
            var saveOptions = new PresentationSaveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                HtmlPath = loadResult.HtmlPath,
                ResourcesPath = loadResult.ResourcesPath,
                OutputPath = $"{DefaultOutputPath}/{testFile.FileName}",
                Password = "password"
            };

            var saveResult = EditApi.Save(new SaveRequest(saveOptions));

            Assert.AreEqual(saveOptions.OutputPath, saveResult.Path);
        }
    }
}
