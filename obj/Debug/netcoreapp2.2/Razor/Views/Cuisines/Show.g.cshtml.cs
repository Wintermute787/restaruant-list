#pragma checksum "/Users/Guest/Desktop/Restaurants/Views/Cuisines/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea819ce27c56c98f58288a23ae2c2883c0424cc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Show), @"mvc.1.0.view", @"/Views/Cuisines/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cuisines/Show.cshtml", typeof(AspNetCore.Views_Cuisines_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea819ce27c56c98f58288a23ae2c2883c0424cc8", @"/Views/Cuisines/Show.cshtml")]
    public class Views_Cuisines_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 73, true);
            WriteLiteral("<h3>Here are all of the Restaurants for this type of cuisine:</h3>\n\n<ol>\n");
            EndContext();
#line 4 "/Users/Guest/Desktop/Restaurants/Views/Cuisines/Show.cshtml"
   foreach(var restaurant in @Model["best_restaurant"])
  {

#line default
#line hidden
            BeginContext(133, 10, true);
            WriteLiteral("    <li><a");
            EndContext();
            BeginWriteAttribute("href", "\n    href=\"", 143, "\"", 221, 4);
            WriteAttributeValue("", 154, "/cuisines/", 154, 10, true);
#line 7 "/Users/Guest/Desktop/Restaurants/Views/Cuisines/Show.cshtml"
WriteAttributeValue("", 164, Model["cuisine"].GetId(), 164, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 189, "/restaurants/", 189, 13, true);
#line 7 "/Users/Guest/Desktop/Restaurants/Views/Cuisines/Show.cshtml"
WriteAttributeValue("", 202, restaurant.GetId(), 202, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(222, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(224, 20, false);
#line 7 "/Users/Guest/Desktop/Restaurants/Views/Cuisines/Show.cshtml"
                                                                          Write(restaurant.GetName());

#line default
#line hidden
            EndContext();
            BeginContext(244, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/Restaurants/Views/Cuisines/Show.cshtml"
  }

#line default
#line hidden
            BeginContext(258, 12, true);
            WriteLiteral("</ol>\n\n<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 270, "\'", 328, 3);
            WriteAttributeValue("", 277, "/cuisines/", 277, 10, true);
#line 11 "/Users/Guest/Desktop/Restaurants/Views/Cuisines/Show.cshtml"
WriteAttributeValue("", 287, Model["cuisine"].GetId(), 287, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 312, "/restaurants/new", 312, 16, true);
            EndWriteAttribute();
            BeginContext(329, 127, true);
            WriteLiteral(">Add a new Restaurant</a></p>\n<p><a href=\'/cuisines\'>Return to cuisine list</a></p>\n<p><a href=\'/\'>Return to Main Page</a></p>\n");
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