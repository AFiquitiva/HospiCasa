#pragma checksum "/Hospitalizacion/HospiEnCasa.App/HospiEnCasa.App.Frontend/Pages/Medicos/Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c2c58ec25542ec205ffa1a5ac34a80d97eb3f3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.App.Frontend.Pages.Medicos.Pages_Medicos_Index1), @"mvc.1.0.razor-page", @"/Pages/Medicos/Index1.cshtml")]
namespace HospiEnCasa.App.Frontend.Pages.Medicos
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
#line 1 "/Hospitalizacion/HospiEnCasa.App/HospiEnCasa.App.Frontend/Pages/_ViewImports.cshtml"
using HospiEnCasa.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c2c58ec25542ec205ffa1a5ac34a80d97eb3f3b", @"/Pages/Medicos/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08056ece19204f924bb1e05e247bbea9f829a0a7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Medicos_Index1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Listado de Medicos</h1>\r\n<table class=\"table table-striped\">\r\n");
#nullable restore
#line 7 "/Hospitalizacion/HospiEnCasa.App/HospiEnCasa.App.Frontend/Pages/Medicos/Index1.cshtml"
     foreach (var medico in Model.medicos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 10 "/Hospitalizacion/HospiEnCasa.App/HospiEnCasa.App.Frontend/Pages/Medicos/Index1.cshtml"
           Write(medico.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 11 "/Hospitalizacion/HospiEnCasa.App/HospiEnCasa.App.Frontend/Pages/Medicos/Index1.cshtml"
           Write(medico.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 12 "/Hospitalizacion/HospiEnCasa.App/HospiEnCasa.App.Frontend/Pages/Medicos/Index1.cshtml"
           Write(medico.Especialidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 14 "/Hospitalizacion/HospiEnCasa.App/HospiEnCasa.App.Frontend/Pages/Medicos/Index1.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasa.App.Frontend.Pages.Medicos.Index1Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.Frontend.Pages.Medicos.Index1Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.Frontend.Pages.Medicos.Index1Model>)PageContext?.ViewData;
        public HospiEnCasa.App.Frontend.Pages.Medicos.Index1Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
