#pragma checksum "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_04\Views\CadastroCliente\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6868c83787caf433f233e1046c8dcc96979ed08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CadastroCliente_Lista), @"mvc.1.0.view", @"/Views/CadastroCliente/Lista.cshtml")]
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
#line 1 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_04\Views\_ViewImports.cshtml"
using ATIV_04;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_04\Views\_ViewImports.cshtml"
using ATIV_04.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6868c83787caf433f233e1046c8dcc96979ed08", @"/Views/CadastroCliente/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58e67c2a67a90ac88662819e50fadc4306bedab9", @"/Views/_ViewImports.cshtml")]
    public class Views_CadastroCliente_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_04\Views\CadastroCliente\Lista.cshtml"
  
    ViewData["Title"] = "Lista de Clientes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <table class=""table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>CPF</th>
                <th>Email</th>
                <th>Telefone</th>
                <th>Data de Nascimento</th>
                <th>Endereço</th>
                <th>Bairro</th>
                <th>Cidade</th>
                <th>Senha</th>
                <th>Operações</th>
            </tr>
        </thead>

");
#nullable restore
#line 24 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_04\Views\CadastroCliente\Lista.cshtml"
             foreach (Cliente cliente in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_04\Views\CadastroCliente\Lista.cshtml"
                   Write(cliente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_04\Views\CadastroCliente\Lista.cshtml"
                   Write(cliente.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_04\Views\CadastroCliente\Lista.cshtml"
                   Write(cliente.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_04\Views\CadastroCliente\Lista.cshtml"
                   Write(cliente.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_04\Views\CadastroCliente\Lista.cshtml"
                   Write(cliente.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_04\Views\CadastroCliente\Lista.cshtml"
                   Write(cliente.DataNascimento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_04\Views\CadastroCliente\Lista.cshtml"
                   Write(cliente.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_04\Views\CadastroCliente\Lista.cshtml"
                   Write(cliente.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_04\Views\CadastroCliente\Lista.cshtml"
                   Write(cliente.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_04\Views\CadastroCliente\Lista.cshtml"
                   Write(cliente.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                       \r\n                </tr>\r\n");
#nullable restore
#line 40 "C:\MEUS ARQUIVOS\Curso-SENAC\ModuloPROJETO-INTEGRADOR\ATIV_04\Views\CadastroCliente\Lista.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n        \r\n        </tbody>\r\n    </table>\r\n\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
