#pragma checksum "/Users/barbaralapaz/Downloads/Projeto-2.Carfel-master/Projeto.Carfel.Comentarios/Views/Shared/Logado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "319f6a37ce0e890d87ebd516109ed4708b7ce957"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Logado), @"mvc.1.0.view", @"/Views/Shared/Logado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Logado.cshtml", typeof(AspNetCore.Views_Shared_Logado))]
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
#line 1 "/Users/barbaralapaz/Downloads/Projeto-2.Carfel-master/Projeto.Carfel.Comentarios/Views/Shared/Logado.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"319f6a37ce0e890d87ebd516109ed4708b7ce957", @"/Views/Shared/Logado.cshtml")]
    public class Views_Shared_Logado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 1204, true);
            WriteLiteral(@"<link rel=""stylesheet"" href=""iziModal-master/css/iziModal.min.css"">
<link rel=""stylesheet"" href=""css/Comentario.css"">
<link rel=""stylesheet"" href=""css/MasterPage.css"">
<script src=""iziModal-master/js/jquery.min.js""></script>
<script src=""iziModal-master/js/iziModal.min.js""></script>

<nav class=""navbar"">
    <div class=""container-menu"">
        <ul class=""menu"">
            <a href=""home.html"" class=""logo"">
                <img src=""imagens/logo.png"" alt=""logo"">
            </a>
            <li>
                <a href=""home.html"" class=""menu-itens"">home</a>
            </li>
            <li>
                <a href=""#"" class=""menu-itens"">nosso produto</a>
            </li>
            <li>
                <a href=""sobre-nos.html"" class=""menu-itens"">sobre nós</a>
            </li>
            <li>
                <a href=""#"" class=""menu-itens"">o que fazemos</a>
            </li>
            <li>
                <a href=""#"" class=""menu-itens"">planos</a>
            </li>
            <li>
                <a hre");
            WriteLiteral("f=\"FAQ.html\" class=\"menu-itens\">FAQ</a>\n            </li>\n            <li>\n                <a href=\"contato.html\" class=\"menu-itens\">contato</a>\n            </li>\n            <li>\n");
            EndContext();
#line 36 "/Users/barbaralapaz/Downloads/Projeto-2.Carfel-master/Projeto.Carfel.Comentarios/Views/Shared/Logado.cshtml"
                 if(@Context.Session.GetString("nomeUsuario") != null){

#line default
#line hidden
            BeginContext(1309, 116, true);
            WriteLiteral("                <a href=\"#\" class=\"menu-itens\">\n                    <i class=\"fas fa-user\"></i>\n                    ");
            EndContext();
            BeginContext(1426, 40, false);
#line 39 "/Users/barbaralapaz/Downloads/Projeto-2.Carfel-master/Projeto.Carfel.Comentarios/Views/Shared/Logado.cshtml"
               Write(Context.Session.GetString("nomeUsuario"));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 5, true);
            WriteLiteral("</a>\n");
            EndContext();
#line 40 "/Users/barbaralapaz/Downloads/Projeto-2.Carfel-master/Projeto.Carfel.Comentarios/Views/Shared/Logado.cshtml"
                }

#line default
#line hidden
            BeginContext(1489, 230, true);
            WriteLiteral("            </li>\n            <li class=\"bt-login-ul\">\n                <button class=\"login\" data-izimodal-open=\"#modal-login\" data-izimodal-transitionin=\"fadeInDown\">Sair</button>\n            </li>\n        </ul>\n    </div>\n</nav>");
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