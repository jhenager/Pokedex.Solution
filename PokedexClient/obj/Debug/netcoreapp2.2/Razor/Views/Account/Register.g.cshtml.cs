#pragma checksum "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Account/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d16098f42451ffaec6a4900c0e3cafdfe08ef57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 5 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Account/Register.cshtml"
using PokedexClient.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d16098f42451ffaec6a4900c0e3cafdfe08ef57", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Account/Register.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(85, 36, true);
            WriteLiteral("\n<h1>Register a new user</h1>\n<hr/>\n");
            EndContext();
#line 10 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Account/Register.cshtml"
 using (Html.BeginForm("Register", "Account", FormMethod.Post))
{
  

#line default
#line hidden
            BeginContext(190, 33, false);
#line 12 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Account/Register.cshtml"
Write(Html.LabelFor(user => user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(227, 35, false);
#line 13 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Account/Register.cshtml"
Write(Html.TextBoxFor(user => user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(267, 36, false);
#line 15 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Account/Register.cshtml"
Write(Html.LabelFor(user => user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(307, 39, false);
#line 16 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Account/Register.cshtml"
Write(Html.PasswordFor(user => user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(351, 43, false);
#line 18 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Account/Register.cshtml"
Write(Html.LabelFor(user => user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(398, 46, false);
#line 19 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Account/Register.cshtml"
Write(Html.PasswordFor(user => user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(446, 42, true);
            WriteLiteral("  <input type=\"submit\" value=\"Register\"/>\n");
            EndContext();
#line 22 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Account/Register.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591