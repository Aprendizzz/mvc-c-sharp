#pragma checksum "c:\Users\jonat\Desktop\Galaxy.IO\Views\Home\Resume.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8aa25ede6d0434bfafaeb68d2d55e835cd47344"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Resume), @"mvc.1.0.view", @"/Views/Home/Resume.cshtml")]
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
#nullable restore
#line 1 "c:\Users\jonat\Desktop\Galaxy.IO\Views\_ViewImports.cshtml"
using Galaxy.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\jonat\Desktop\Galaxy.IO\Views\_ViewImports.cshtml"
using Galaxy.IO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8aa25ede6d0434bfafaeb68d2d55e835cd47344", @"/Views/Home/Resume.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04e4757e4fd44962fd77fbba45574ece3a8d4d5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Resume : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "c:\Users\jonat\Desktop\Galaxy.IO\Views\Home\Resume.cshtml"
  
    ViewData["Title"] = "Resume";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4""></h1>
</div>

<div id='stars'></div>
<div id='stars2'></div>
<div id='stars3'></div>
<div id='title'>
  <span>
    Galaxy.IO
  </span>
  <br>
  <p id=""resume"">
        Galaxy.IO é um jogo para browsers,  multiplayer, desenvolvido com Typescript, e canvas, todos os cálculos 
        e mecânicas foram feitas pelos desenvolvedores sem o uso de engines ou frameworks. 
        No jogo o jogador pode escolher entre 3 naves, uma atacante para causar danos massivos, 
        uma robusta para aguentar o dano e proteção para o time e uma suporte para oferecer escudos e reparos para as naves. 
        O jogador também escolhe a qual facção vai pertencer, que serão duas. O jogo termina quando uma facção ganhar, 
        então terá um reset no servidor e começa novamente o jogo com outras facções. 
    </p>
</div>
");
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
