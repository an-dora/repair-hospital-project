#pragma checksum "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\Shared\_Export.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e08d953242f74dfee995ffccd4c14daef51f352"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Export), @"mvc.1.0.view", @"/Views/Shared/_Export.cshtml")]
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
#line 1 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\_ViewImports.cshtml"
using App.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\_ViewImports.cshtml"
using App.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\_ViewImports.cshtml"
using App.Web.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\_ViewImports.cshtml"
using App.Web.WebConfig;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\_ViewImports.cshtml"
using App.Share.Consts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\_ViewImports.cshtml"
using App.Share.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\_ViewImports.cshtml"
using App.Share.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e08d953242f74dfee995ffccd4c14daef51f352", @"/Views/Shared/_Export.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d491163f286f3e3732bb189720ac36e073370d2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Export : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Export", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" id=""mExport"" tabindex=""-1"" role=""dialog"" aria-labelledby=""mExport-label"" aria-hidden=""true"">
	<div class=""modal-dialog"" role=""document"">
		<div class=""modal-content"">
			<div class=""modal-header"">
				<h5 class=""modal-title"" id=""mExportTitle"">Chọn thời gian</h5>
				<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
					<span aria-hidden=""true"">&times;</span>
				</button>
			</div>
			<div class=""modal-body"">
				<!--Modal content-->
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e08d953242f74dfee995ffccd4c14daef51f3525372", async() => {
                WriteLiteral(@"
					<div class=""form-group"">
						<label for=""from"">Từ ngày</label>
						<input type=""date"" required name=""FromDate"" class=""form-control"" id=""from"" placeholder=""Chọn ngày"">
					</div>
					<div class=""form-group"">
						<label for=""from"">Đến ngày</label>
						<input type=""date"" required name=""ToDate"" class=""form-control"" id=""from"" placeholder=""Chọn ngày"">
					</div>
					<div class=""form-group"">
						<button class=""btn btn-success""><i class=""fas fa-file-download""></i>&ensp;Xuất Excel</button>
					</div>
				");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
