#pragma checksum "/Users/marielhamson/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41b0a2528aae7f3d3c3e7b4af0e6dd8c3a0953dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Index), @"mvc.1.0.view", @"/Views/Clients/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Index.cshtml", typeof(AspNetCore.Views_Clients_Index))]
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
#line 6 "/Users/marielhamson/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Index.cshtml"
using Tattoo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41b0a2528aae7f3d3c3e7b4af0e6dd8c3a0953dd", @"/Views/Clients/Index.cshtml")]
    public class Views_Clients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tattoo.Models.Client>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/marielhamson/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(86, 19, true);
            WriteLiteral("\n<h2>Clients</h2>\n\n");
            EndContext();
#line 11 "/Users/marielhamson/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(131, 43, true);
            WriteLiteral("  <h3>No Clients have been added yet!</h3>\n");
            EndContext();
#line 14 "/Users/marielhamson/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(177, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 16 "/Users/marielhamson/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Index.cshtml"
 foreach (Client client in Model)
{

#line default
#line hidden
            BeginContext(214, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(221, 79, false);
#line 18 "/Users/marielhamson/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Index.cshtml"
 Write(Html.ActionLink($"{client.FirstName}", "Details", new { id = client.ClientId }));

#line default
#line hidden
            EndContext();
            BeginContext(300, 7, true);
            WriteLiteral(" </li>\n");
            EndContext();
#line 19 "/Users/marielhamson/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Index.cshtml"
}

#line default
#line hidden
            BeginContext(309, 78, true);
            WriteLiteral("<input type=\"button\" class=\"btn btn-outline-info\" value=\"Book an Appointment!\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 387, "\"", 445, 3);
            WriteAttributeValue("", 397, "location.href=\'", 397, 15, true);
#line 20 "/Users/marielhamson/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Index.cshtml"
WriteAttributeValue("", 412, Url.Action("Create", "Clients"), 412, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 444, "\'", 444, 1, true);
            EndWriteAttribute();
            BeginContext(446, 4, true);
            WriteLiteral(" />\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Tattoo.Models.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
