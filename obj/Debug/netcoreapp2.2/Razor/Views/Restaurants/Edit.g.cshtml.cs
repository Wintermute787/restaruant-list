#pragma checksum "/Users/Guest/Desktop/Restaurants/Views/Restaurants/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2faa5b49a288569594996275d8da556430458750"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Edit), @"mvc.1.0.view", @"/Views/Restaurants/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Edit.cshtml", typeof(AspNetCore.Views_Restaurants_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2faa5b49a288569594996275d8da556430458750", @"/Views/Restaurants/Edit.cshtml")]
    public class Views_Restaurants_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 46, true);
            WriteLiteral("<h1>Restaurant List</h1>\n<hr>\n\n<h2>Edit item: ");
            EndContext();
            BeginContext(47, 34, false);
#line 4 "/Users/Guest/Desktop/Restaurants/Views/Restaurants/Edit.cshtml"
          Write(Model["best_restaurant"].GetName());

#line default
#line hidden
            EndContext();
            BeginContext(81, 12, true);
            WriteLiteral("</h2>\n\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 93, "\"", 183, 4);
            WriteAttributeValue("", 102, "/cuisines/", 102, 10, true);
#line 6 "/Users/Guest/Desktop/Restaurants/Views/Restaurants/Edit.cshtml"
WriteAttributeValue("", 112, Model["cuisine"].GetId(), 112, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 137, "/restaurants/", 137, 13, true);
#line 6 "/Users/Guest/Desktop/Restaurants/Views/Restaurants/Edit.cshtml"
WriteAttributeValue("", 150, Model["best_restaurant"].GetId(), 150, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(184, 88, true);
            WriteLiteral(" method=\"post\">\n  <label for=\"newName\">Name:</label>\n  <input type=\"text\" name=\"newName\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 272, "\"", 315, 1);
#line 8 "/Users/Guest/Desktop/Restaurants/Views/Restaurants/Edit.cshtml"
WriteAttributeValue("", 280, Model["best_restaurant"].GetName(), 280, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(316, 55, true);
            WriteLiteral(">\n  <button type=\"submit\">Edit</button>\n</form>\n\n<h4><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 371, "\"", 459, 4);
            WriteAttributeValue("", 378, "/cuisines/", 378, 10, true);
#line 12 "/Users/Guest/Desktop/Restaurants/Views/Restaurants/Edit.cshtml"
WriteAttributeValue("", 388, Model["cuisine"].GetId(), 388, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 413, "/restaurants/", 413, 13, true);
#line 12 "/Users/Guest/Desktop/Restaurants/Views/Restaurants/Edit.cshtml"
WriteAttributeValue("", 426, Model["best_restaurant"].GetId(), 426, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(460, 34, true);
            WriteLiteral(">Return to previous page</a></h4>\n");
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
