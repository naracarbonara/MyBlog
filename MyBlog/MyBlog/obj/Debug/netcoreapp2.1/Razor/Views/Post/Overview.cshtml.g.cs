#pragma checksum "D:\GitHub\MyBlog\MyBlog\MyBlog\Views\Post\Overview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b31e88071c905ebb66448556de9ddceea5479e57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Overview), @"mvc.1.0.view", @"/Views/Post/Overview.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Overview.cshtml", typeof(AspNetCore.Views_Post_Overview))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b31e88071c905ebb66448556de9ddceea5479e57", @"/Views/Post/Overview.cshtml")]
    public class Views_Post_Overview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyBlog.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\GitHub\MyBlog\MyBlog\MyBlog\Views\Post\Overview.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Home";

#line default
#line hidden
            BeginContext(151, 25, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 12 "D:\GitHub\MyBlog\MyBlog\MyBlog\Views\Post\Overview.cshtml"
     foreach (var post in Model)
    {

#line default
#line hidden
            BeginContext(217, 159, true);
            WriteLiteral("        <div class=\"col-md-12\">\r\n            <div class=\"card\" style=\"width: 50%; margin: 0 auto; margin-top:20px;\">\r\n                <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 376, "\"", 396, 1);
#line 16 "D:\GitHub\MyBlog\MyBlog\MyBlog\Views\Post\Overview.cshtml"
WriteAttributeValue("", 382, post.ImageUrl, 382, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(397, 109, true);
            WriteLiteral(" alt=\"card image cap\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\"> ");
            EndContext();
            BeginContext(507, 10, false);
#line 18 "D:\GitHub\MyBlog\MyBlog\MyBlog\Views\Post\Overview.cshtml"
                                       Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(517, 49, true);
            WriteLiteral(" </h5>\r\n                    <p class=\"card-text\">");
            EndContext();
            BeginContext(567, 16, false);
#line 19 "D:\GitHub\MyBlog\MyBlog\MyBlog\Views\Post\Overview.cshtml"
                                    Write(post.Description);

#line default
#line hidden
            EndContext();
            BeginContext(583, 28, true);
            WriteLiteral("</p>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 611, "\"", 640, 2);
            WriteAttributeValue("", 618, "/Post/Details/", 618, 14, true);
#line 20 "D:\GitHub\MyBlog\MyBlog\MyBlog\Views\Post\Overview.cshtml"
WriteAttributeValue("", 632, post.Id, 632, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(641, 101, true);
            WriteLiteral(" class=\"btn btn-primary\">See more</a>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
            EndContext();
#line 25 "D:\GitHub\MyBlog\MyBlog\MyBlog\Views\Post\Overview.cshtml"
    }

#line default
#line hidden
            BeginContext(749, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MyBlog.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
