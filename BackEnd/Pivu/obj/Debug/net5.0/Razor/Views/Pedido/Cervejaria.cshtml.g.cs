#pragma checksum "C:\Compartilhado\projetos\pivu\BackEnd\Pivu\Views\Pedido\Cervejaria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fd580318384f37946001eb8a9833e5c13c6a988"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Cervejaria), @"mvc.1.0.view", @"/Views/Pedido/Cervejaria.cshtml")]
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
#line 1 "C:\Compartilhado\projetos\pivu\BackEnd\Pivu\Views\_ViewImports.cshtml"
using Pivu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Compartilhado\projetos\pivu\BackEnd\Pivu\Views\_ViewImports.cshtml"
using Pivu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fd580318384f37946001eb8a9833e5c13c6a988", @"/Views/Pedido/Cervejaria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5198e5dc0015dc06ff05c76ab864e70c00d0141b", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Cervejaria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgBanner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cardImgCervejaria"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"container-fluid\">\r\n    <div class=\"divBanner\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9fd580318384f37946001eb8a9833e5c13c6a9883879", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 114, "~/images/banner/cervejaria/b_", 114, 29, true);
#nullable restore
#line 5 "C:\Compartilhado\projetos\pivu\BackEnd\Pivu\Views\Pedido\Cervejaria.cshtml"
AddHtmlAttributeValue("", 143, @Model.First().Cervejaria.ID_CERVEJARIA, 143, 42, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 185, ".png", 185, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""dadosCervejaria"">
        <h5 class=""estrela""></h5>
        <h5 class=""nota"">4.5</h5>        
        <p>Cervejaria Artesanal de taubate. qualidade sempre.</p>
    </div>
    <h4 class=""tituloDeSecao"">Cervejas</h4>
    <div class=""row"">

");
#nullable restore
#line 15 "C:\Compartilhado\projetos\pivu\BackEnd\Pivu\Views\Pedido\Cervejaria.cshtml"
         foreach (var produtos in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card m-2 cardCervejarias\">\r\n                <div class=\"row\">\r\n                    <div class=\"cardDivImgCervejaria\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9fd580318384f37946001eb8a9833e5c13c6a9886251", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 715, "~/images/produtos/p_", 715, 20, true);
#nullable restore
#line 20 "C:\Compartilhado\projetos\pivu\BackEnd\Pivu\Views\Pedido\Cervejaria.cshtml"
AddHtmlAttributeValue("", 735, produtos.ID_PRODUTO, 735, 22, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 757, "_p.jpeg", 757, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 20 "C:\Compartilhado\projetos\pivu\BackEnd\Pivu\Views\Pedido\Cervejaria.cshtml"
AddHtmlAttributeValue("", 771, produtos.NOME, 771, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <h3>");
#nullable restore
#line 23 "C:\Compartilhado\projetos\pivu\BackEnd\Pivu\Views\Pedido\Cervejaria.cshtml"
                       Write(Model.First().Cervejaria.NOME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 24 "C:\Compartilhado\projetos\pivu\BackEnd\Pivu\Views\Pedido\Cervejaria.cshtml"
                                          Write(produtos.NOME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text manterLinha\">");
#nullable restore
#line 25 "C:\Compartilhado\projetos\pivu\BackEnd\Pivu\Views\Pedido\Cervejaria.cshtml"
                                                    Write(produtos.ESTILO);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"text-muted\">");
#nullable restore
#line 26 "C:\Compartilhado\projetos\pivu\BackEnd\Pivu\Views\Pedido\Cervejaria.cshtml"
                                         Write(produtos.DESCRICAO);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text manterLinha\">IBU: ");
#nullable restore
#line 27 "C:\Compartilhado\projetos\pivu\BackEnd\Pivu\Views\Pedido\Cervejaria.cshtml"
                                                         Write(produtos.IBU);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text manterLinha\"> - </p>\r\n                        <p class=\"card-text manterLinha\">ABV: ");
#nullable restore
#line 29 "C:\Compartilhado\projetos\pivu\BackEnd\Pivu\Views\Pedido\Cervejaria.cshtml"
                                                          Write(produtos.ABV);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</p>\r\n                        <button class=\"invisivel stretched-link\" data-toggle=\"ajax-modal\" data-target=\"#details-modal\" data-url=\"");
#nullable restore
#line 30 "C:\Compartilhado\projetos\pivu\BackEnd\Pivu\Views\Pedido\Cervejaria.cshtml"
                                                                                                                            Write(Url.Action($"Details/{produtos.ID_PRODUTO}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 34 "C:\Compartilhado\projetos\pivu\BackEnd\Pivu\Views\Pedido\Cervejaria.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</section>\r\n\r\n<div id=\"placeholderhere\"></div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
<script>
    $(function () {
        var placeholderelement = $('#placeholderhere');
        $('button[data-toggle=""ajax-modal""]').click(function (event) {
            var url = $(this).data('url');
            var decodeUrl = decodeURIComponent(url);
            $.get(decodeUrl).done(function (data) {
                placeholderelement.html(data);
                placeholderelement.find('.modal').modal('show');
            })
        })
    })
</script> 
   
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591