#pragma checksum "C:\Users\Pierrick\Documents\Cours\C#\coursV2\Venezia\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4b57b5b69d29362d8e3c6b418daa4ecd6df3b70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4b57b5b69d29362d8e3c6b418daa4ecd6df3b70", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1285ba38313528db6e4133684b02f7afa26e2718", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Venezia.Models.BasketViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Mon panier</h1>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Pierrick\Documents\Cours\C#\coursV2\Venezia\Views\Basket\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n");
#nullable restore
#line 11 "C:\Users\Pierrick\Documents\Cours\C#\coursV2\Venezia\Views\Basket\Index.cshtml"
                  this.Write(Html.DisplayNameForInnerType<Venezia.Models.Car, string>(x => x.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </th>
            <th>
                Modèle
            </th>
            <th>
                Prix
            </th>
            <th>
                Carburant
            </th>
            <th>
                Autonome
            </th>
            <th>
                Quantité
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 33 "C:\Users\Pierrick\Documents\Cours\C#\coursV2\Venezia\Views\Basket\Index.cshtml"
         foreach (var item in Model.Cars)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Pierrick\Documents\Cours\C#\coursV2\Venezia\Views\Basket\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Key.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Pierrick\Documents\Cours\C#\coursV2\Venezia\Views\Basket\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Key.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Pierrick\Documents\Cours\C#\coursV2\Venezia\Views\Basket\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Key.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Pierrick\Documents\Cours\C#\coursV2\Venezia\Views\Basket\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Key.FuelType.Label));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Pierrick\Documents\Cours\C#\coursV2\Venezia\Views\Basket\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Key.Autonomous));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Pierrick\Documents\Cours\C#\coursV2\Venezia\Views\Basket\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td></td>\r\n        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Pierrick\Documents\Cours\C#\coursV2\Venezia\Views\Basket\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <td></td>\r\n    </tbody>\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Prix total\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\Pierrick\Documents\Cours\C#\coursV2\Venezia\Views\Basket\Index.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
#nullable restore
#line 75 "C:\Users\Pierrick\Documents\Cours\C#\coursV2\Venezia\Views\Basket\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Votre panier est vide</h2>\r\n");
#nullable restore
#line 79 "C:\Users\Pierrick\Documents\Cours\C#\coursV2\Venezia\Views\Basket\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Venezia.Models.BasketViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
