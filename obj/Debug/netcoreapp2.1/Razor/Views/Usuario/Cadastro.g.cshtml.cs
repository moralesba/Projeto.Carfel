#pragma checksum "C:\Users\47015374897\Desktop\htm & css\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25f117d8f6a44d71750d5dbed4fc1c639d93d6de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Cadastro), @"mvc.1.0.view", @"/Views/Usuario/Cadastro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Cadastro.cshtml", typeof(AspNetCore.Views_Usuario_Cadastro))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25f117d8f6a44d71750d5dbed4fc1c639d93d6de", @"/Views/Usuario/Cadastro.cshtml")]
    public class Views_Usuario_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\47015374897\Desktop\htm & css\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\Cadastro.cshtml"
  
    Layout= "MasterPageUsuario";

#line default
#line hidden
            BeginContext(41, 14, true);
            WriteLiteral("\r\n<html>\r\n    ");
            EndContext();
            BeginContext(56, 16, false);
#line 6 "C:\Users\47015374897\Desktop\htm & css\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\Cadastro.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(72, 329, true);
            WriteLiteral(@"

    <form action=""/Usuario/MasterPage"" method=""POST"">
        <input type=""text"" name=""nome"" placeholder=""Nome"">
        <input type=""text"" name=""email"" placeholder=""Email"">
        <input type=""password"" name=""senha"" placeholder=""Senha"">
        <button class=""bt4"" type=""submit"">cadastrar</button>
    </form>
</html>");
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
