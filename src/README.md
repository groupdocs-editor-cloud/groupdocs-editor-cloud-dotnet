# GroupDocs.Editor Cloud SDK for .NET

This repository contains GroupDocs.Editor Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Editor Cloud REST APIs in your .NET applications.

GroupDocs.Editor Cloud allows you to edit documents across wide range of supported document types:

+ Microsoft Word documents - DOC, DOCX, DOCM, DOT, DOTM, DOTX, RTF, FlatOpc, WordML, TXT;
+ Microsoft Excel spreadsheets - XLS, XLSX, XLSM, XLT, XLTX, XLTM, XLSB, SpreadsheetML, CSV, TSV;
+ Microsoft PowerPoint presentations - PPT, PPTX, PPTM, POT, PPS etc.;
+ Open Document formats - ODT, OTT, ODS, ODP, OTP;
+ Markup - HTML, MHTML, XML.

## How to use the SDK?

The complete source code is available in this repository folder, you can either directly use it in your project via NuGet package manager. For more details, please visit our [documentation website](https://docs.groupdocs.cloud/display/editorcloud/Available+SDKs#AvailableSDKs-.NET).

## Getting Started

```csharp
using System;
using System.Diagnostics;
using GroupDocs.Editor.Cloud.Sdk.Api;

namespace Example
{
    public class Example
    {
        public void Main()
        {
            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            var appSid = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX";
            var appKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

            var api = new InfoApi(appSid, appKey);

            try
            {
                // Get supported file formats
                var response = api.GetSupportedFileFormats();

                foreach (var format in response.Formats)
                {
                    Debug.Print(format.ToString());
                }
            }
            catch (Exception e)
            {
                Debug.Print("Something went wrong: " + e.Message);
            }
        }
    }
}
```

## Licensing

All GroupDocs.Editor Cloud SDKs are licensed under [MIT License](LICENSE).

## Resources

+[**Website**](https://www.groupdocs.cloud)
+[**Product Home**](https://products.groupdocs.cloud/editor)
+[**Documentation**](https://docs.groupdocs.cloud/editor/)
+[**Free Support Forum**](https://forum.groupdocs.cloud/c/editor)
+[**Blog**](https://blog.groupdocs.cloud/category/editor)
