#pragma checksum "C:\Users\47015374897\Desktop\htm & css\Carfel\Projeto.Carfel.Comentarios\Views\Shared\Comentario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "636bd6a412844019089a3296b4e342f746d85dcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Comentario), @"mvc.1.0.view", @"/Views/Shared/Comentario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Comentario.cshtml", typeof(AspNetCore.Views_Shared_Comentario))]
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
#line 1 "C:\Users\47015374897\Desktop\htm & css\Carfel\Projeto.Carfel.Comentarios\Views\Shared\Comentario.cshtml"
using Projeto.Carfel.Comentarios.Models;

#line default
#line hidden
#line 2 "C:\Users\47015374897\Desktop\htm & css\Carfel\Projeto.Carfel.Comentarios\Views\Shared\Comentario.cshtml"
using Projeto.Carfel.Comentarios.Repositorios;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"636bd6a412844019089a3296b4e342f746d85dcd", @"/Views/Shared/Comentario.cshtml")]
    public class Views_Shared_Comentario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(92, 854, true);
            WriteLiteral(@"
<link rel=""stylesheet"" href=""iziModal-master/css/iziModal.min.css"">
<link rel=""stylesheet"" href=""css/Comentario.css"">
<link rel=""stylesheet"" href=""css/MasterPage.css"">
<script src=""iziModal-master/js/jquery.min.js""></script>
<script src=""iziModal-master/js/iziModal.min.js""></script>

<div class=""container6"">
    <div class=""box-comentario"">
        <form action=""/Comentario/Cadastro"" method=""POST"">
            <h2>Comentários</h2>
            <textarea id=""areaComentario"" name=""Comentario"" placeholder=""Escreva seu comentário aqui""></textarea>
            <div class=""bt-comentario"">
                <button class=""bt5"" type=""submit"">
                    Comentar
                </button>
                <button>
                    Cancelar
                </button>
            </div>
        </form>
    </div>
</div>

");
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
