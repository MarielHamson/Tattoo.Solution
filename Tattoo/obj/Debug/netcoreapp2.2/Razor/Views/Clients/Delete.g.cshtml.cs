#pragma checksum "/Users/frederickernest/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "964e34d7e6618cb4a26c8fb4e64c83607f04c6df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Delete), @"mvc.1.0.view", @"/Views/Clients/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Delete.cshtml", typeof(AspNetCore.Views_Clients_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"964e34d7e6618cb4a26c8fb4e64c83607f04c6df", @"/Views/Clients/Delete.cshtml")]
    public class Views_Clients_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tattoo.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/frederickernest/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(57, 49, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this?</h2>\n\n");
            EndContext();
            BeginContext(107, 45, false);
#line 9 "/Users/frederickernest/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(152, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(155, 41, false);
#line 9 "/Users/frederickernest/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Delete.cshtml"
                                           Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(196, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(198, 44, false);
#line 10 "/Users/frederickernest/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(242, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(245, 40, false);
#line 10 "/Users/frederickernest/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Delete.cshtml"
                                          Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(285, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 11 "/Users/frederickernest/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(314, 41, true);
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 14 "/Users/frederickernest/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(357, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(359, 40, false);
#line 16 "/Users/frederickernest/Desktop/Tattoo.Solution/Tattoo/Views/Clients/Delete.cshtml"
Write(Html.ActionLink("back to List", "Index"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tattoo.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
