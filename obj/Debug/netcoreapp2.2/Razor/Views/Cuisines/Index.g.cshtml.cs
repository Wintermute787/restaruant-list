#pragma checksum "/Users/Guest/Desktop/Restaurants/Views/Cuisines/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73f9390ff756e99a781c7c1151c9fcdf1ea30845"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Index), @"mvc.1.0.view", @"/Views/Cuisines/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cuisines/Index.cshtml", typeof(AspNetCore.Views_Cuisines_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73f9390ff756e99a781c7c1151c9fcdf1ea30845", @"/Views/Cuisines/Index.cshtml")]
    public class Views_Cuisines_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 19, true);
            WriteLiteral("<h1>Cuisines</h1>\n\n");
            EndContext();
#line 3 "/Users/Guest/Desktop/Restaurants/Views/Cuisines/Index.cshtml"
 if (@Model.Count ==0)
{

#line default
#line hidden
            BeginContext(44, 43, true);
            WriteLiteral("  <h3>No Cuisines have been added yet</h3>\n");
            EndContext();
#line 6 "/Users/Guest/Desktop/Restaurants/Views/Cuisines/Index.cshtml"
}

#line default
#line hidden
            BeginContext(89, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/Restaurants/Views/Cuisines/Index.cshtml"
 foreach(var cuisine in Model)
{

#line default
#line hidden
            BeginContext(123, 8, true);
            WriteLiteral("  <h3><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 131, "\"", 164, 2);
            WriteAttributeValue("", 138, "/cuisines/", 138, 10, true);
#line 10 "/Users/Guest/Desktop/Restaurants/Views/Cuisines/Index.cshtml"
WriteAttributeValue("", 148, cuisine.GetId(), 148, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(165, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(167, 24, false);
#line 10 "/Users/Guest/Desktop/Restaurants/Views/Cuisines/Index.cshtml"
                                      Write(cuisine.GetCuisineName());

#line default
#line hidden
            EndContext();
            BeginContext(191, 10, true);
            WriteLiteral("</a></h3>\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/Restaurants/Views/Cuisines/Index.cshtml"
}

#line default
#line hidden
            BeginContext(203, 29, true);
            WriteLiteral("\n<p><a href=\"/\">Back</a></p>\n");
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