#pragma checksum "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_03\Views\Home\Feedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "311fbb1fbd80a797ab020211c24d9be6b3e620f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Feedback), @"mvc.1.0.view", @"/Views/Home/Feedback.cshtml")]
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
#line 1 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_03\Views\_ViewImports.cshtml"
using ATIV_03;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_03\Views\_ViewImports.cshtml"
using ATIV_03.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"311fbb1fbd80a797ab020211c24d9be6b3e620f1", @"/Views/Home/Feedback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4691679193b2533229ecba16bd1601ba2c599a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Feedback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dados>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<table class=""table"">
        <thead>
            <tr>
                
                <th>Nome</th>
                <th>Email</th>
                <th>Telefone</th>
                <th>Mensagem</th>
                
            </tr>
        </thead>

");
#nullable restore
#line 16 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_03\Views\Home\Feedback.cshtml"
             foreach (Dados dados in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    \r\n                    <td>");
#nullable restore
#line 20 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_03\Views\Home\Feedback.cshtml"
                   Write(dados.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_03\Views\Home\Feedback.cshtml"
                   Write(dados.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_03\Views\Home\Feedback.cshtml"
                   Write(dados.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_03\Views\Home\Feedback.cshtml"
                   Write(dados.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    \r\n                </tr>\r\n");
#nullable restore
#line 26 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_03\Views\Home\Feedback.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n        \r\n        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dados>> Html { get; private set; }
    }
}
#pragma warning restore 1591
