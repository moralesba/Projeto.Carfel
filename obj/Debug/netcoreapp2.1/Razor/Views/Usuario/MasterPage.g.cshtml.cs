#pragma checksum "C:\Users\fabio\OneDrive\Área de Trabalho\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\MasterPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca7a94e5e292898cd812ea8cce2e4f59f5890de3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_MasterPage), @"mvc.1.0.view", @"/Views/Usuario/MasterPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/MasterPage.cshtml", typeof(AspNetCore.Views_Usuario_MasterPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca7a94e5e292898cd812ea8cce2e4f59f5890de3", @"/Views/Usuario/MasterPage.cshtml")]
    public class Views_Usuario_MasterPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(27, 723, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cff33aa4604ce5bde64bd2c8f9902a", async() => {
                BeginContext(33, 710, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.3.1/css/all.css"" integrity=""sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU""
        crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""iziModal-master/css/iziModal.min.css"">
    <link rel=""stylesheet"" href=""css/Comentario.css"">
    <link rel=""stylesheet"" href=""css/MasterPage.css"">
    <script src=""iziModal-master/js/jquery.min.js""></script>
    <script src=""iziModal-master/js/iziModal.min.js""></script>
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Carfel</title>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(750, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(754, 11701, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "935ef20f03114c2d8040cda5cf5c1a88", async() => {
                BeginContext(760, 1454, true);
                WriteLiteral(@"
    <header>
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
                        <a href=""FAQ.html"" class=""menu-itens"">FAQ</a>
                    </");
                WriteLiteral(@"li>
                    <li>
                        <a href=""contato.html"" class=""menu-itens"">contato</a>
                    </li>
                    <li class=""bt-login-ul"">
                        <button class=""login"" data-izimodal-open=""#modal-login"" data-izimodal-transitionin=""fadeInDown"">Login</button>
                    </li>
                </ul>
            </div>
        </nav>

    <partial>
        ");
                EndContext();
                BeginContext(2215, 21, false);
#line 55 "C:\Users\fabio\OneDrive\Área de Trabalho\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\MasterPage.cshtml"
   Write(Html.Partial("Login"));

#line default
#line hidden
                EndContext();
                BeginContext(2236, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2247, 24, false);
#line 56 "C:\Users\fabio\OneDrive\Área de Trabalho\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\MasterPage.cshtml"
   Write(Html.Partial("Cadastro"));

#line default
#line hidden
                EndContext();
                BeginContext(2271, 47, true);
                WriteLiteral("\r\n    </partial>\r\n\r\n    </header>\r\n    <main>\r\n");
                EndContext();
#line 61 "C:\Users\fabio\OneDrive\Área de Trabalho\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\MasterPage.cshtml"
         if (TempData["UsuarioLogado"] != null){

#line default
#line hidden
                BeginContext(2368, 87, true);
                WriteLiteral("        <div class=\"usuario\">\r\n            <i class=\"fas fa-user\"></i>\r\n            <p>");
                EndContext();
                BeginContext(2456, 25, false);
#line 64 "C:\Users\fabio\OneDrive\Área de Trabalho\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\MasterPage.cshtml"
          Write(TempData["UsuarioLogado"]);

#line default
#line hidden
                EndContext();
                BeginContext(2481, 22, true);
                WriteLiteral("</p>\r\n        </div>\r\n");
                EndContext();
#line 66 "C:\Users\fabio\OneDrive\Área de Trabalho\Carfel\Projeto.Carfel.Comentarios\Views\Usuario\MasterPage.cshtml"
        }

#line default
#line hidden
                BeginContext(2514, 9934, true);
                WriteLiteral(@"        <div class=""container"">
            <div class=""banner"">
                <img src=""imagens/banner.png"" alt=""banner"">
            </div>
            <div class=""name"">
                <h1>Carfel</h1>
                <br>
            </div>
            <div class=""slogan"">
                <span class=""slogan1"">Tornando Sua Empresa Melhor</span>
                <br>
                <br>
                <span class=""slogan2"">Lorem ipsum, dolores sit amet
                    <br>consectetur adipisicing ena elit.</span>
            </div>
            <div class=""inicie link1"">
                <a href=""#"" data-izimodal-open=""#modal-cadastro"" data-izimodal-transitionin=""fadeInDown"">inicie
                    gratuitamente</a>
            </div>
            <div class=""bola-rosa""></div>
            <div class=""bola-verde""></div>
            <div class=""bola-amarela""></div>
            <div class=""bola-azul""></div>
            <hr>
            <span class=""frase"">that's right</span>
   ");
                WriteLiteral(@"     </div>
        <div class=""container2"">
            <div class=""nosso-produto"">
                <h2>Nosso Produto</h2>
            </div>
            <div class=""sua-empresa"">
                <img src=""imagens/produtos1.png"" alt=""Sua Empresa"">
                <br>
                <br>
                <h3>Sua Empresa</h3>
                <br>
                <p>Lorem, ipsum dolor sit amet consectetur dolor adipisicing elit. Id harum corrupti architecto quis,
                    qui non
                    amet consectetur.</p>
            </div>
            <div class=""check-point"">
                <img src=""imagens/produtos2.png"" alt=""Check Point"">
                <br>
                <br>
                <h3>Check Point</h3>
                <br>
                <p>Lorem, ipsum dolor sit amet consectetur dolor adipisicing elit. Id harum corrupti architecto quis,
                    qui non
                    amet consectetur.</p>
            </div>
            <div class=""funcio");
                WriteLiteral(@"narios"">
                <img src=""imagens/produtos3.png"" alt=""Funcionarios"">
                <br>
                <br>
                <h3>Fucionarios</h3>
                <br>
                <p>Lorem, ipsum dolor sit amet consectetur dolor adipisicing elit. Id harum corrupti architecto quis,
                    qui non
                    amet consectetur.</p>
            </div>
            <div class=""acessibilidade"">
                <img src=""imagens/produtos4.png"" alt=""Acessibilidade"">
                <br>
                <br>
                <h3>Acessibilidade</h3>
                <br>
                <p>Lorem, ipsum dolor sit amet consectetur dolor adipisicing elit. Id harum corrupti architecto quis,
                    qui non
                    amet consectetur.</p>
            </div>
            <div class=""recursos"">
                <img src=""imagens/produtos5.png"" alt=""Recursos"">
                <br>
                <br>
                <h3>Recursos</h3>
                ");
                WriteLiteral(@"<br>
                <p>Lorem, ipsum dolor sit amet consectetur dolor adipisicing elit. Id harum corrupti architecto quis,
                    qui non
                    amet consectetur.</p>
            </div>
            <div class=""redes-sociais"">
                <img src=""imagens/produtos6.png"" alt=""Redes Sociais"">
                <br>
                <br>
                <h3>Redes Sociais</h3>
                <br>
                <p>Lorem, ipsum dolor sit amet consectetur dolor adipisicing elit. Id harum corrupti architecto quis,
                    qui non
                    amet consectetur.</p>
            </div>
            <hr>
        </div>
        <div class=""container3"">
            <div class=""sobre-nos"">
                <h2>Sobre Nós</h2>
            </div>
            <div class=""sobre-nos-texto"">
                <p>Lorem, ipsum dolor sit adipisicing elit. Repudiandae ipsa, itaque doloremque distinctio delectus,
                    error animi
                    ex,");
                WriteLiteral(@" earum minus exercitationem similique nam id nostrum nemo. Impedit inventore sunt minima. Lorem
                    ipsum
                    dolor sit amet adipisicing elit. Neque officiis expedita itaque, perspiciatis a eaque sit amet
                    perferendis
                    nulla aliquid nulla dolor sit amet dolor sit amet adipisicing elit.</p>
            </div>
            <div class=""saiba mais1 link2"">
                <a href=""#"">Saiba Mais</a>
            </div>
            <div class=""banner2"">
                <img src=""imagens/banner2.png"" alt=""Banner 2"">
            </div>
            <hr>
        </div>
        <div class=""container4"">
            <div class=""oq-fazemos"">
                <h2>O Que Fazemos</h2>
            </div>
            <div class=""oq-fazemos-texto"">
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Provident, volubus. Facilis corrupti soluta
                    explicabo
                    nemo iste doloribus odio acc");
                WriteLiteral(@"usantium, nul, nihil sunt aspernatur culpa asperiores dolorem fugit!
                    Illo,
                    fugit atque. Lorem ipsum dolor sit amet consectetur adipisicing elit. Iste ea aut itaque volutum,
                    quos
                    modi voluptatibus voluptatem facilis eum dolores! Dumus corrupti consequuntur animi perspiciatis
                    perferendis
                    numquam, blanditiis libero.</p>
            </div>
            <div class=""video"">
                <img src=""imagens/video.png"" alt=""Video"">
            </div>
            <div class=""saiba mais2 link2"">
                <a href=""#"">Saiba mais</a>
            </div>
            <hr>
        </div>

        <div class=""container6"">
            <div class=""dados1"">

            </div>
            <div class=""box-comentario"">
                <h2>Comentários</h2>
                <textarea id=""areaComentario"" name=""Comentario"" placeholder=""Escreva seu comentário aqui""></textarea>
            ");
                WriteLiteral(@"    <div class=""
                    bt-comentario"">
                    <button class=""bt5"" type=""submit"">
                        Comentar
                    </button>
                    <button>
                        Cancelar
                    </button>

                </div>
            </div>
        </div>
    </main>

    <footer>
        <hr>
        <div class=""rodape"">
            <div class=""logo2"">
                <a href=""home.html"" class=""logo2"">
                    <img src=""imagens/logo.png"" alt=""logo"">
                </a>
            </div>
            <div class=""lorem"">
                <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Libero tenetur beatae, optio suscipit
                    inventore
                    facilis reiciendis losam facere minus, harum maiores enim minus facilis reiciendis losam nullen.</p>
            </div>
            <div class=""fale-conosco"">
                <a href=""contato.html"">Fale Conosco</a>
           ");
                WriteLiteral(@"     <a href=""contato.html""><i class=""fas fa-comments""></i></a>
            </div>
            <div class=""lista"">
                <ul class=""lista"">
                    <li>
                        <a href=""#"" class=""rodape-itens"">home</a>
                    </li>
                    <li>
                        <a href=""#"" class=""rodape-itens"">nosso produto</a>
                    </li>
                    <li>
                        <a href=""#"" class=""rodape-itens"">sobre nós</a>
                    </li>
                    <li>
                        <a href=""#"" class=""rodape-itens"">o que fazemos</a>
                    </li>
                    <li>
                        <a href=""#"" class=""rodape-itens"">planos</a>
                    </li>
                    <li>
                        <a href=""#"" class=""rodape-itens"">FAQ</a>
                    </li>
                    <li>
                        <a href=""#"" class=""rodape-itens"">contato</a>
                    </li>
   ");
                WriteLiteral(@"             </ul>
            </div>
            <div class=""endereco"">
                <h3>Endereço</h3>
                <br>
                <i class=""fas fa-map-marker-alt""></i>
                Al. Barão de Limeira, 539
                <br> Santa Cecília, São Paulo
                <br> SP - CEP: 01202-001
                <br>
                <br>
                <i class=""fas fa-envelope""></i>
                carfel.contato@gmail.com
                <br>
                <br>
                <i class=""fas fa-phone""></i>
                +55 (11) 2783.8725
                <br>
                <br>
                <div class=""redes-sociais2"">
                    <a href=""https://www.facebook.com/""><i class=""fab fa-facebook-f""></i></a>
                    <a href=""https://twitter.com/""><i class=""fab fa-twitter""></i></a>
                    <a href=""https://www.youtube.com/""><i class=""fab fa-youtube""></i></a>
                </div>
            </div>
            <div class=""image"">
   ");
                WriteLiteral(@"             <img src=""imagens/rodape.png"" alt="""">
            </div>
            <hr>
        </div>
    </footer>

    <script>
        $(""#modal-login"").iziModal();
        $(""#modal-cadastro"").iziModal();

        var areaComentario = document.getElementById(""areaComentario"");

        areaComentario.onfocus = () => {
            if (areaComentario.innerText.length == 0) {
                areaComentario.removeAttribute(""placeholder"");
            }
        };

        areaComentario.onblur = () => {
            if (areaComentario.innerText.length == 0) {
                areaComentario.setAttribute(""placeholder"", ""Escreva o comentário aqui"");
            }
        }
    </script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12455, 1703, true);
            WriteLiteral(@"

<!-- <div id=""container5"">
            <div class=""quadros"">
                <div class=""planos gratuito"">
                    <h2 class=""planos1"">Plano Gratuito</h2>
                    <h3 class=""preco1"">FREE</h3>
                    <div class=""desc"">
                        <span class=""desc"">1 empresa cadastrada</span>
                        <span class=""desc"">Lorem ipsum</span>
                    </div>
                </div>
                <div class=""planos premium"">
                    <h2 class=""planos2"">Plano Premium</h2>
                    <div class=""preco"">
                        <span class=""cifrao"">R$</span>
                        <h3 class=""preco2"">59,90</h3>
                        <span class=""mes"">/mês</span>
                        <div class=""desc"">
                            <span class=""desc1"">5 empresas cadastrada</span>
                            <span class=""desc1"">Assistência 24 horas</span>
                        </div>
                    </div>
");
            WriteLiteral(@"                </div>
                <div class=""planos platinum"">
                    <h2 class=""planos1"">Plano Platinum</h2>
                    <div class=""preco"">
                        <span class=""cifrao"">R$</span>
                        <h3 class=""preco1"">99,90</h3>
                        <span class=""mes"">/mês</span>
                        <div class=""desc"">
                            <span class=""desc"">Empresas ilimitadas</span>
                            <span class=""desc"">Lorem ipsum dual</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div> -->

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