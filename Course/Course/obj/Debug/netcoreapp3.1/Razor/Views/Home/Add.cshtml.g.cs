#pragma checksum "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df9bc45dd7cf8466c7a561e0850f3bfe4dd25eca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Add), @"mvc.1.0.view", @"/Views/Home/Add.cshtml")]
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
#line 1 "D:\Загрузки\kyrs\Course\Course\Views\_ViewImports.cshtml"
using Cyrsovay;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Загрузки\kyrs\Course\Course\Views\_ViewImports.cshtml"
using Cyrsovay.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df9bc45dd7cf8466c7a561e0850f3bfe4dd25eca", @"/Views/Home/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6a32245d01a64d0ad3cc269ec5fe82c78caed37", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cyrsovay.Models.BTGPModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
  
    //ViewData["Title"] = "Список студентов";
    //@Html.ActionLink("Группы", "dbOutput","Home")

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df9bc45dd7cf8466c7a561e0850f3bfe4dd25eca4998", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
#nullable restore
#line 12 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "df9bc45dd7cf8466c7a561e0850f3bfe4dd25eca5546", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "df9bc45dd7cf8466c7a561e0850f3bfe4dd25eca6811", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df9bc45dd7cf8466c7a561e0850f3bfe4dd25eca8780", async() => {
                WriteLiteral("\r\n    <div class=\"default\">\r\n        Страница добавления студентов\r\n");
#nullable restore
#line 19 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
       Write(Html.LabelFor(model => model.Name, "Имя студента"));

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n");
#nullable restore
#line 23 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
       Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br /><br />\r\n");
#nullable restore
#line 25 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
       Write(Html.LabelFor(model => model.Familia, "Фамилия"));

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n");
#nullable restore
#line 27 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
       Write(Html.EditorFor(model => model.Familia));

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>\r\n                ");
#nullable restore
#line 29 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
           Write(Html.LabelFor(model => model.Otchestvo, "Отчество"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 31 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
           Write(Html.EditorFor(model => model.Otchestvo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
#nullable restore
#line 34 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
           Write(Html.LabelFor(model => model.Cyrs, "Курс"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 36 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
           Write(Html.EditorFor(model => model.Cyrs));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
#nullable restore
#line 39 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
           Write(Html.LabelFor(model => model.Speciality, "Специальность"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 41 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
           Write(Html.EditorFor(model => model.Speciality));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
#nullable restore
#line 44 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
           Write(Html.LabelFor(model => model.State, "Стостояние"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 46 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
           Write(Html.EditorFor(model => model.State));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
#nullable restore
#line 49 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
           Write(Html.LabelFor(model => model.Postypil, "Дата зачисления"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 51 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
           Write(Html.EditorFor(model => model.Postypil));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n            <br /><br />\r\n            <input type=\"submit\" value=\"Добавить\" />\r\n");
#nullable restore
#line 55 "D:\Загрузки\kyrs\Course\Course\Views\Home\Add.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <script scr=\"~/js/bootstrap.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cyrsovay.Models.BTGPModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
