#pragma checksum "C:\Users\mReza\source\repos\BlogON\BlogON.Presentation\Pages\Single.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1e0da18d57b255b786027bd75dd389b66c51426"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MasterBlog.presentation.Pages.Pages_Single), @"mvc.1.0.razor-page", @"/Pages/Single.cshtml")]
namespace MasterBlog.presentation.Pages
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
#line 1 "C:\Users\mReza\source\repos\BlogON\BlogON.Presentation\Pages\_ViewImports.cshtml"
using MasterBlog.presentation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1e0da18d57b255b786027bd75dd389b66c51426", @"/Pages/Single.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f00d8c2e8660098bf18b2917d39157eb89b19e1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Single : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\mReza\source\repos\BlogON\BlogON.Presentation\Pages\Single.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""single_post"">
    <div class=""container-fluid"">
        <div class=""col-md-2""></div>
        <div class=""col-md-8"">
            <div class=""row"">
                <div class=""col-md-2""></div>
                <div class=""col-md-8"">
                    <div class=""post_img"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 415, "\"", 450, 1);
#nullable restore
#line 15 "C:\Users\mReza\source\repos\BlogON\BlogON.Presentation\Pages\Single.cshtml"
WriteAttributeValue("", 421, Model.articleQueryView.Image, 421, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 451, "\"", 457, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-2\"></div>\r\n            </div>\r\n            <div class=\"posts_meta text-center\">\r\n                <span><i class=\"fa fa-comment-o\"></i> (");
#nullable restore
#line 21 "C:\Users\mReza\source\repos\BlogON\BlogON.Presentation\Pages\Single.cshtml"
                                                  Write(Model.articleQueryView.CommentsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(") نظر</span>\r\n                <span><i class=\"fa fa-archive\"></i>");
#nullable restore
#line 22 "C:\Users\mReza\source\repos\BlogON\BlogON.Presentation\Pages\Single.cshtml"
                                              Write(Model.articleQueryView.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <span><i class=\"fa fa-calendar\"></i> ");
#nullable restore
#line 23 "C:\Users\mReza\source\repos\BlogON\BlogON.Presentation\Pages\Single.cshtml"
                                                Write(Model.articleQueryView.CreationDate.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"post_content\">\r\n                <h3 class=\"Bold\">");
#nullable restore
#line 26 "C:\Users\mReza\source\repos\BlogON\BlogON.Presentation\Pages\Single.cshtml"
                            Write(Model.articleQueryView.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <hr />\r\n\r\n                ");
#nullable restore
#line 29 "C:\Users\mReza\source\repos\BlogON\BlogON.Presentation\Pages\Single.cshtml"
           Write(Html.Raw(Model.articleQueryView.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n\r\n\r\n            <div class=\"comments_form\">\r\n                <h5>دیدگاه شما </h5>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1e0da18d57b255b786027bd75dd389b66c514266496", async() => {
                WriteLiteral(@"
                    <div class=""form-row"">
                        <div class=""col-md-6"">
                            <input type=""text"" name=""Name"" id=""Name"" class=""form-control"" placeholder=""نام شما"">
                        </div>
                        <div class=""col-md-6"">
                            <input type=""email"" name=""Email"" id=""Email"" class=""form-control"" placeholder=""ایمیل"">
                        </div>
                        <div class=""col-md-12"">
                            <textarea class=""form-control"" name=""Message"" id=""Message"" placeholder=""نظر شما ...""></textarea>
                        </div>
                        <input type=""hidden"" name=""ArticleId""");
                BeginWriteAttribute("value", " value=\"", 1998, "\"", 2032, 1);
#nullable restore
#line 49 "C:\Users\mReza\source\repos\BlogON\BlogON.Presentation\Pages\Single.cshtml"
WriteAttributeValue("", 2006, Model.articleQueryView.Id, 2006, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        <div class=""col-md-12"">
                            <div class=""text-left"">
                                <button class=""btn btn-primary"">ثبت نظر</button>
                            </div>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"comments_form\">\r\n                <div class=\"entry-comments\">\r\n                    <div class=\"title-wrap title-wrap--line\">\r\n                        <h3 class=\"section-title\">(");
#nullable restore
#line 64 "C:\Users\mReza\source\repos\BlogON\BlogON.Presentation\Pages\Single.cshtml"
                                              Write(Model.articleQueryView.CommentsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(") دیدگاه</h3>\r\n                    </div>\r\n                    <ul class=\"comment-list\">\r\n\r\n");
#nullable restore
#line 68 "C:\Users\mReza\source\repos\BlogON\BlogON.Presentation\Pages\Single.cshtml"
                         foreach (var item in Model.articleQueryView.Comments)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"comment\">\r\n                                <div class=\"comment-body\">\r\n                                    <div class=\"comment-avatar\">\r\n                                        <img");
            BeginWriteAttribute("alt", " alt=\"", 3026, "\"", 3032, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"/SiteTempelet/img/Comment.png\">\r\n                                    </div>\r\n                                    <div class=\"comment-text\">\r\n                                        <h6 class=\"comment-author\">");
#nullable restore
#line 76 "C:\Users\mReza\source\repos\BlogON\BlogON.Presentation\Pages\Single.cshtml"
                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <div class=\"comment-metadata\">\r\n                                            <a href=\"#\" class=\"comment-date\">");
#nullable restore
#line 78 "C:\Users\mReza\source\repos\BlogON\BlogON.Presentation\Pages\Single.cshtml"
                                                                        Write(item.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </div>\r\n                                        <p>\r\n                                            ");
#nullable restore
#line 81 "C:\Users\mReza\source\repos\BlogON\BlogON.Presentation\Pages\Single.cshtml"
                                       Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n\r\n                                      \r\n                                    </div>\r\n                                </div>\r\n                            </li>\r\n");
#nullable restore
#line 88 "C:\Users\mReza\source\repos\BlogON\BlogON.Presentation\Pages\Single.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <!--<ul class=""children"">
                        <li class=""comment"">
                            <div class=""comment-body"">
                                <div class=""comment-avatar"">
                                    <img alt="""" src=""/SiteTempelet/img/Comment.png"">
                                </div>
                                <div class=""comment-text"">
                                    <h6 class=""comment-author"">حامد</h6>
                                    <div class=""comment-metadata"">
                                        <a href=""#"" class=""comment-date"">۴ اردیبهشت ۱۳۹۸</a>
                                    </div>
                                    <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است.</p>
                                    <a href=""#"" class=""comment-reply"">پاسخ</a>
                                </div>
                  ");
            WriteLiteral(@"          </div>
                        </li>-->
                        <!-- end reply comment -->
                        <!--</ul>-->
                        <!-- end 1-2 comment -->



                    </ul>
                </div>
            </div>





        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogON.Presentation.Pages.SingleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BlogON.Presentation.Pages.SingleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BlogON.Presentation.Pages.SingleModel>)PageContext?.ViewData;
        public BlogON.Presentation.Pages.SingleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
