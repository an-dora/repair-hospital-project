#pragma checksum "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "182d53e56276a714dda8a86d05b56ca3849eed90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182d53e56276a714dda8a86d05b56ca3849eed90", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d491163f286f3e3732bb189720ac36e073370d2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<App.Web.ViewModels.User.UserListItemVM>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary btn-sm js-delete-confirm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Pager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
  
	ViewData["Title"] = "Danh sách tài khoản";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
 if (User.IsInPermission(AuthConst.AppUser.CREATE))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"my-2\">\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "182d53e56276a714dda8a86d05b56ca3849eed907082", async() => {
                WriteLiteral("\r\n\t\t<i class=\"fas fa-user-plus\"></i> &nbsp; Tạo mới người dùng\r\n\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 14 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""table-responsive"">
	<table class=""table table-bordered table-hover"">
		<thead>
			<tr>
				<th>#</th>
				<th>Tài khoản</th>
				<th>Họ tên</th>
				<th>SĐT</th>
				<th>Email</th>
				<th>Vai trò</th>
				<th>Ngày tạo</th>
				<th></th>
			</tr>
		</thead>
		<tbody>
");
#nullable restore
#line 32 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
             foreach (var item in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td class=\"fit\">");
#nullable restore
#line 35 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
                           Write(item.RowIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 37 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
               Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 38 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
                     if (item.Username == Context.User.Identity.Name)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<span class=\"badge badge-info js-tooltip\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Đây là bạn!\">\r\n\t\t\t\t\t\t\t<i class=\"fas fa-user\"></i>\r\n\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 43 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 45 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
               Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 46 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
               Write(item.PhoneNumber1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 47 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 48 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
               Write(item.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 49 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
               Write(item.CreatedDate.ToDMY());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td class=\"fit\">\r\n");
#nullable restore
#line 53 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
                     if (User.IsInPermission(AuthConst.AppUser.UPDATE))
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "182d53e56276a714dda8a86d05b56ca3849eed9011993", async() => {
                WriteLiteral("<i class=\"fa fas fa-pen\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 57 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
                     if (User.IsInPermission(AuthConst.AppUser.DELETE))
					{
						if (item.Username == Context.User.Identity.Name)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<a href=\"#\"\r\n\t\t\t\t\t\t\t   class=\"btn btn-outline-secondary btn-sm invisible\"><i class=\"fa fas fa-trash\"></i></a>\r\n");
#nullable restore
#line 64 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
						}else{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "182d53e56276a714dda8a86d05b56ca3849eed9015140", async() => {
                WriteLiteral("<i class=\"fa fas fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            WriteLiteral("Xác nhận xóa tài khoản [");
#nullable restore
#line 67 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
                                                            Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("]?");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-msg", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 68 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
						}
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 72 "D:\Projects\C#\Lien_BenhVien_2\BaseProjectTemplate\App.Web\Views\User\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "182d53e56276a714dda8a86d05b56ca3849eed9018555", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<App.Web.ViewModels.User.UserListItemVM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
