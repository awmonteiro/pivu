#pragma checksum "C:\Compartilhado\projetos\pivu\Backend\Pivu\Views\Pedido\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a746348080b1872ee52239cfd46702294fda59e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Cadastro), @"mvc.1.0.view", @"/Views/Pedido/Cadastro.cshtml")]
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
#line 1 "C:\Compartilhado\projetos\pivu\Backend\Pivu\Views\_ViewImports.cshtml"
using Pivu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Compartilhado\projetos\pivu\Backend\Pivu\Views\_ViewImports.cshtml"
using Pivu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a746348080b1872ee52239cfd46702294fda59e", @"/Views/Pedido/Cadastro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5198e5dc0015dc06ff05c76ab864e70c00d0141b", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-cadastro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("        <div class=\"container\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a746348080b1872ee52239cfd46702294fda59e3589", async() => {
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-12 col-lg-6"">
                        <div class=""subTituloCadastro"">
                            <h5>Dados cadastrais</h5>
                        </div>
                        <div class=""mb-3"">
                            <label for=""email"" class=""form-label"">Email</label>
                            <input id=""email"" name=""email"" type=""email"" class=""form-control"">
                        </div>
                        <div class=""mb-3"">
                            <label for=""senha"" class=""form-label"">Senha</label>
                            <input id=""senha"" name=""senha"" type=""password"" class=""form-control"">
                        </div>
                        <div class=""mb-3"">
                            <label for=""nome"" class=""form-label"">Nome</label>
                            <input id=""nome"" name=""nome"" type=""text"" class=""form-control"">
                        </div>
                        <div class=""mb");
                WriteLiteral(@"-3"">
                            <label for=""cpf"" class=""form-label"">CPF</label>
                            <input id=""cpf"" type=""number"" class=""form-control"">
                        </div>
                        <div class=""mb-3"">
                            <label for=""telefone"" class=""form-label"">Telefone</label>
                            <input id=""telefone"" type=""number"" class=""form-control"">
                        </div>
                        <div class=""mb-3"">
                            <label for=""nascimento"" class=""form-label"">Nascimento</label>
                            <input id=""nascimento"" type=""date"" class=""form-control"">
                        </div>
                    </div>

                    <div class=""col-12 col-lg-6"">
                        <div class=""subTituloCadastro"">
                            <h5>Endereço de entrega</h5>
                        </div>
                        <div class=""mb-3"">
                            <label for=""cep"" class=""fo");
                WriteLiteral(@"rm-label"">Cep</label>
                            <input id=""cep"" type=""number"" class=""form-control"">
                        </div>
                        <div class=""mb-3"">
                            <label for=""rua"" class=""form-label"">Rua</label>
                            <input id=""rua"" type=""text"" class=""form-control"">
                        </div>
                        <div class=""mb-3"">
                            <label for=""numero"" class=""form-label"">Numero</label>
                            <input id=""numero"" type=""number"" class=""form-control"">
                        </div>
                        <div class=""mb-3"">
                            <label for=""bairro"" class=""form-label"">Bairro</label>
                            <input id=""bairro"" type=""text"" class=""form-control"">
                        </div>
                        <div class=""mb-3"">
                            <label for=""cidade"" class=""form-label"">Cidade</label>
                            <input id=""cidade");
                WriteLiteral(@""" type=""text"" class=""form-control"">
                        </div>
                        <div class=""mb-3"">
                            <label for=""estado"" class=""form-label"">Estado</label>
                            <input id=""estado"" type=""text"" class=""form-control"">
                        </div>
                    </div>
                </div>
                <div class=""row justify-content-center"">
                    <button type=""submit"" class=""btn btn-primary botaoSalvar"">Salvar</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n    ");
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
