#pragma checksum "C:\Users\ABXYLR\desktop\project\csharp\VaOTracker.Solution\VaOTracker\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98097f490e290c34a66ff60005bdfb1d98dcb725"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Index.cshtml", typeof(AspNetCore.Views_Orders_Index))]
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
#line 1 "C:\Users\ABXYLR\desktop\project\csharp\VaOTracker.Solution\VaOTracker\Views\Orders\Index.cshtml"
using VaOTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98097f490e290c34a66ff60005bdfb1d98dcb725", @"/Views/Orders/Index.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 28, true);
            WriteLiteral("\r\n<h1>Pierre\'s Orders</h1>\r\n");
            EndContext();
#line 4 "C:\Users\ABXYLR\desktop\project\csharp\VaOTracker.Solution\VaOTracker\Views\Orders\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(82, 43, true);
            WriteLiteral("  <p>There are no orders in the list.</p>\r\n");
            EndContext();
#line 7 "C:\Users\ABXYLR\desktop\project\csharp\VaOTracker.Solution\VaOTracker\Views\Orders\Index.cshtml"
}

#line default
#line hidden
            BeginContext(128, 6, true);
            WriteLiteral("<ul>\r\n");
            EndContext();
#line 9 "C:\Users\ABXYLR\desktop\project\csharp\VaOTracker.Solution\VaOTracker\Views\Orders\Index.cshtml"
   foreach (Order order in Model)
  {

#line default
#line hidden
            BeginContext(174, 10, true);
            WriteLiteral("    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 184, "\'", 208, 2);
            WriteAttributeValue("", 191, "/orders/", 191, 8, true);
#line 11 "C:\Users\ABXYLR\desktop\project\csharp\VaOTracker.Solution\VaOTracker\Views\Orders\Index.cshtml"
WriteAttributeValue("", 199, order.Id, 199, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(209, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(211, 11, false);
#line 11 "C:\Users\ABXYLR\desktop\project\csharp\VaOTracker.Solution\VaOTracker\Views\Orders\Index.cshtml"
                               Write(order.Title);

#line default
#line hidden
            EndContext();
            BeginContext(222, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 12 "C:\Users\ABXYLR\desktop\project\csharp\VaOTracker.Solution\VaOTracker\Views\Orders\Index.cshtml"
  }

#line default
#line hidden
            BeginContext(238, 173, true);
            WriteLiteral("</ul>\r\n\r\n<a href=\"/orders/new\">Add a new item.</a>\r\n\r\n<form action=\"/orders/delete\" method=\"post\">\r\n  <button type=\"submit\" name=\"button\">Clear All Items</button>\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
