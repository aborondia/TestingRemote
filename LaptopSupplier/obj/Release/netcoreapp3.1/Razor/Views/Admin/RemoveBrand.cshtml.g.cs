#pragma checksum "C:\Users\MZ-admin\Desktop\SD\Assignments\LaptopSupplier\LaptopSupplier\Views\Admin\RemoveBrand.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd0a38b3ed84a0188eadb34b9dd4926b733172e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RemoveBrand), @"mvc.1.0.view", @"/Views/Admin/RemoveBrand.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\MZ-admin\Desktop\SD\Assignments\LaptopSupplier\LaptopSupplier\Views\_ViewImports.cshtml"
using LaptopSupplier;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MZ-admin\Desktop\SD\Assignments\LaptopSupplier\LaptopSupplier\Views\_ViewImports.cshtml"
using LaptopSupplier.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd0a38b3ed84a0188eadb34b9dd4926b733172e8", @"/Views/Admin/RemoveBrand.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86be5953a53f41e283ac7cefb8c3f374a7a646fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RemoveBrand : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_UserMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\MZ-admin\Desktop\SD\Assignments\LaptopSupplier\LaptopSupplier\Views\Admin\RemoveBrand.cshtml"
 if (DataBase.Brands.Count > 0)
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MZ-admin\Desktop\SD\Assignments\LaptopSupplier\LaptopSupplier\Views\Admin\RemoveBrand.cshtml"
   using (Html.BeginForm())
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"border\">\r\n      Brand to Remove: ");
#nullable restore
#line 7 "C:\Users\MZ-admin\Desktop\SD\Assignments\LaptopSupplier\LaptopSupplier\Views\Admin\RemoveBrand.cshtml"
                  Write(Html.DropDownList("Brand"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      <span class=\"text-danger\">WARNING! Pressing submit will remove the brand and all products associated with it.</span>\r\n    </div>\r\n    <input type=\"submit\" value=\"Submit\" />\r\n");
#nullable restore
#line 11 "C:\Users\MZ-admin\Desktop\SD\Assignments\LaptopSupplier\LaptopSupplier\Views\Admin\RemoveBrand.cshtml"
  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\MZ-admin\Desktop\SD\Assignments\LaptopSupplier\LaptopSupplier\Views\Admin\RemoveBrand.cshtml"
   
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dd0a38b3ed84a0188eadb34b9dd4926b733172e84857", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
