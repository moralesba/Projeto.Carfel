#pragma checksum "C:\Users\47015374897\Desktop\htm & css\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e208410ac83ddf79645b6e77bec1f05288d00d7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Editar), @"mvc.1.0.view", @"/Views/Usuario/Editar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Editar.cshtml", typeof(AspNetCore.Views_Usuario_Editar))]
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
#line 1 "C:\Users\47015374897\Desktop\htm & css\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\Editar.cshtml"
using Projeto.Carfel.Comentarios.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e208410ac83ddf79645b6e77bec1f05288d00d7f", @"/Views/Usuario/Editar.cshtml")]
    public class Views_Usuario_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\47015374897\Desktop\htm & css\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\Editar.cshtml"
  
    Layout= "MasterPageUsuario";

#line default
#line hidden
            BeginContext(84, 10, true);
            WriteLiteral("<html>\r\n\r\n");
            EndContext();
#line 7 "C:\Users\47015374897\Desktop\htm & css\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\Editar.cshtml"
      
        UsuarioModel usuario = ViewBag.Usuario;   
    

#line default
#line hidden
            BeginContext(161, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(168, 16, false);
#line 11 "C:\Users\47015374897\Desktop\htm & css\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\Editar.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(184, 85, true);
            WriteLiteral("\r\n\r\n    <form action=\"MasterPage.cshtml\" method=\"POST\">\r\n        <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 269, "\"", 288, 1);
#line 14 "C:\Users\47015374897\Desktop\htm & css\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 277, usuario.ID, 277, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(289, 78, true);
            WriteLiteral(" name=\"id\">\r\n        <label>\r\n            Nome\r\n            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 367, "\"", 388, 1);
#line 17 "C:\Users\47015374897\Desktop\htm & css\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 375, usuario.Nome, 375, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(389, 101, true);
            WriteLiteral(" name=\"nome\">\r\n        </label>\r\n        <label>\r\n            E-mail\r\n            <input type=\"email\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 490, "\"", 512, 1);
#line 21 "C:\Users\47015374897\Desktop\htm & css\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 498, usuario.Email, 498, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(513, 104, true);
            WriteLiteral(" name=\"email\">\r\n        </label>\r\n        <label>\r\n            Senha\r\n            <input type=\"password\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 617, "\"", 639, 1);
#line 25 "C:\Users\47015374897\Desktop\htm & css\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 625, usuario.Senha, 625, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(640, 101, true);
            WriteLiteral(" name=\"senha\">\r\n        </label>\r\n        <button type=\"submit\">Salvar</button>\r\n    </form>\r\n</html>");
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
