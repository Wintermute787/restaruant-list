#pragma checksum "/Users/Guest/Desktop/Restaurants/Views/Restaurants/DeleteItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9006f2d71ddbc636dcdfefc66949770e3a1ba733"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_DeleteItem), @"mvc.1.0.view", @"/Views/Restaurants/DeleteItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/DeleteItem.cshtml", typeof(AspNetCore.Views_Restaurants_DeleteItem))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9006f2d71ddbc636dcdfefc66949770e3a1ba733", @"/Views/Restaurants/DeleteItem.cshtml")]
    public class Views_Restaurants_DeleteItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 42, true);
            WriteLiteral("<h1>Your list has been cleared!</h1>\n<P><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 42, "\"", 84, 2);
            WriteAttributeValue("", 49, "/cuisines/", 49, 10, true);
#line 2 "/Users/Guest/Desktop/Restaurants/Views/Restaurants/DeleteItem.cshtml"
WriteAttributeValue("", 59, Model["cuisine"].GetId(), 59, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(85, 28, true);
            WriteLiteral(">Return to Cuisines</a></P>\n");
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