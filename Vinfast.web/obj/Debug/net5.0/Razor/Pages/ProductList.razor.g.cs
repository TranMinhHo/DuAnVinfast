#pragma checksum "D:\DuAnVinFast\Vinfast.web\Pages\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f64c2178118071b239447100fd54ac8249bb2e6"
// <auto-generated/>
#pragma warning disable 1591
namespace Vinfast.web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DuAnVinFast\Vinfast.web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DuAnVinFast\Vinfast.web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DuAnVinFast\Vinfast.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DuAnVinFast\Vinfast.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DuAnVinFast\Vinfast.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DuAnVinFast\Vinfast.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DuAnVinFast\Vinfast.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DuAnVinFast\Vinfast.web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DuAnVinFast\Vinfast.web\_Imports.razor"
using Vinfast.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DuAnVinFast\Vinfast.web\_Imports.razor"
using Vinfast.web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/allproduct")]
    public partial class ProductList : ProductListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n    ");
            __builder.AddMarkupContent(1, "<h3>Danh Sach San Pham</h3>\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddContent(3, "San pham da chon : ");
            __builder.AddContent(4, 
#nullable restore
#line 5 "D:\DuAnVinFast\Vinfast.web\Pages\ProductList.razor"
                             SelectedProductCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "checkbox");
            __builder.AddAttribute(8, "id", "showFooter");
            __builder.AddAttribute(9, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "D:\DuAnVinFast\Vinfast.web\Pages\ProductList.razor"
                                                  ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ShowFooter = __value, ShowFooter));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.AddMarkupContent(12, "<label for=\"showFooter\">Show Footer</label>\r\n    ");
            __builder.AddMarkupContent(13, "<a href=\"/editproduct\" style=\"margin-left:1650px;\"><i class=\"fa fa-plus-circle\" style=\"margin-right:10px;transform:scale(1.25)\"></i>Thêm Sản Phẩm</a>");
#nullable restore
#line 10 "D:\DuAnVinFast\Vinfast.web\Pages\ProductList.razor"
     if (Products == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<div class=\"loader\"><div class=\"inner one\"></div>\r\n            <div class=\"inner two\"></div>\r\n            <div class=\"inner three\"></div></div>");
#nullable restore
#line 17 "D:\DuAnVinFast\Vinfast.web\Pages\ProductList.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-deck");
#nullable restore
#line 21 "D:\DuAnVinFast\Vinfast.web\Pages\ProductList.razor"
             foreach (var product in Products)
            {


#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Vinfast.web.Pages.DisplayProduct>(17);
            __builder.AddAttribute(18, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Vinfast.models.Product>(
#nullable restore
#line 24 "D:\DuAnVinFast\Vinfast.web\Pages\ProductList.razor"
                                         product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ShowFooter", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "D:\DuAnVinFast\Vinfast.web\Pages\ProductList.razor"
                                                              ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "OnProductSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 24 "D:\DuAnVinFast\Vinfast.web\Pages\ProductList.razor"
                                                                                              ProductSelectionChange

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 25 "D:\DuAnVinFast\Vinfast.web\Pages\ProductList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 28 "D:\DuAnVinFast\Vinfast.web\Pages\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
