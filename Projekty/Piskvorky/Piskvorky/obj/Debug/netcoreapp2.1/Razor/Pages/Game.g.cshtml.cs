#pragma checksum "G:\Piskvorky\Piskvorky\Pages\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b76917718250554a0a3f3cc33c559fea4436ff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Game), @"mvc.1.0.razor-page", @"/Pages/Game.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Game.cshtml", typeof(AspNetCore.Pages_Game), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b76917718250554a0a3f3cc33c559fea4436ff8", @"/Pages/Game.cshtml")]
    public class Pages_Game : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Play", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(102, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(127, 993, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2084fbfb86c4891ae70a3bf9dc6bd2a", async() => {
                BeginContext(133, 980, true);
                WriteLiteral(@"
    <title>Hra Piškvorky</title>
    <meta charset=""utf-8"" />
    <style>
        #name {
            display: flex;
            justify-content: center;
            margin-bottom: -90px;
        }

        #text {
            font-size: 2rem;
        }
        table{margin: 0px;}
        .gamefield > table, tr, td {
            border: 1px solid black;
        }
        td {
            width: 60px;
            height: 60px;
            text-align: center;
        }
        #flexin {
            display: flex;
            justify-content: center;
            margin: 100px;
        }
        a {
            border: none;
            color: black;
            padding: 12px;
            
            text-decoration: none;
            display: inline-block;
            font-size: 15px;
            margin: 0px;
            cursor: pointer;
        }
        a:hover
        { text-decoration: none; color: black; }
    </style>

");
                EndContext();
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
            EndContext();
            BeginContext(1120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1122, 743, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b5323a81e9c40f4a1c6d602c83ad039", async() => {
                BeginContext(1128, 64, true);
                WriteLiteral("\r\n    <section id=\"name\">\r\n        <span id=\"text\">Jmenuješ se: ");
                EndContext();
                BeginContext(1193, 10, false);
#line 53 "G:\Piskvorky\Piskvorky\Pages\Game.cshtml"
                                Write(Model.Text);

#line default
#line hidden
                EndContext();
                BeginContext(1203, 102, true);
                WriteLiteral("</span>\r\n    </section>\r\n    <div id=\"flexin\">\r\n        <div class=\"gamefield\">\r\n            <table>\r\n");
                EndContext();
#line 58 "G:\Piskvorky\Piskvorky\Pages\Game.cshtml"
                 for (int i = 0; i < Math.Sqrt(Model.Plocha._Pole.Length); i++)
                {

#line default
#line hidden
                BeginContext(1405, 26, true);
                WriteLiteral("                    <tr>\r\n");
                EndContext();
#line 61 "G:\Piskvorky\Piskvorky\Pages\Game.cshtml"
                         for (int a = 0; a < Math.Sqrt(Model.Plocha._Pole.Length); a++)
                        {


#line default
#line hidden
                BeginContext(1549, 32, true);
                WriteLiteral("                            <td>");
                EndContext();
                BeginContext(1581, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efbedff731304972a73423b2b8dedbfe", async() => {
                    BeginContext(1643, 30, false);
#line 64 "G:\Piskvorky\Piskvorky\Pages\Game.cshtml"
                                                                                        Write(Model.Plocha._Pole[a, i].Value);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-X", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 64 "G:\Piskvorky\Piskvorky\Pages\Game.cshtml"
                                                            WriteLiteral(a);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["X"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-X", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["X"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 64 "G:\Piskvorky\Piskvorky\Pages\Game.cshtml"
                                                                             WriteLiteral(i);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Y"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Y", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Y"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1677, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 65 "G:\Piskvorky\Piskvorky\Pages\Game.cshtml"
                        }

#line default
#line hidden
                BeginContext(1711, 27, true);
                WriteLiteral("                    </tr>\r\n");
                EndContext();
#line 67 "G:\Piskvorky\Piskvorky\Pages\Game.cshtml"
                }

#line default
#line hidden
                BeginContext(1757, 43, true);
                WriteLiteral("            </table>\r\n            <p><span>");
                EndContext();
                BeginContext(1801, 10, false);
#line 69 "G:\Piskvorky\Piskvorky\Pages\Game.cshtml"
                Write(Model._win);

#line default
#line hidden
                EndContext();
                BeginContext(1811, 47, true);
                WriteLiteral("</span></p>\r\n        </div>\r\n    </div>\r\n    \r\n");
                EndContext();
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
            EndContext();
            BeginContext(1865, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Piskvorky.Pages.GameModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Piskvorky.Pages.GameModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Piskvorky.Pages.GameModel>)PageContext?.ViewData;
        public Piskvorky.Pages.GameModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
