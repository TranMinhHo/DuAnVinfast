#pragma checksum "D:\DuAnVinFast\Vinfast.web\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "295148a701370525a251ce2f527270013e6eaee1"
// <auto-generated/>
#pragma warning disable 1591
namespace Vinfast.web.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\" b-p3fz4owbg2>\r\n");
            __builder.AddMarkupContent(1, @"<style b-p3fz4owbg2>

    .search {
        width: 200px;
        position: relative;
        display: flex;
    }

    .searchTerm {
        width: 200px;
        border: 3px solid #00B4CC;
        border-right: none;
        padding: 5px;
        height: 50px;
        border-radius: 5px 0 0 5px;
        outline: none;
        color: #9DBFAF;
    }

        .searchTerm:focus {
            color: #00B4CC;
        }

    .searchButton {
        width: 40px;
        height: 50px;
        border: 1px solid #00B4CC;
        background: #00B4CC;
        text-align: center;
        color: #fff;
        border-radius: 0 5px 5px 0;
        cursor: pointer;
        font-size: 20px;
    }

    /*Resize the wrap to see the search bar change!*/
    .wrap {
        width: 30%;
        position: center;
        
        transform: translate(-50%, -50%);
    }
</style>
        ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "navigation-bar");
            __builder.AddAttribute(4, "b-p3fz4owbg2");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "id", "navigation-container");
            __builder.AddAttribute(7, "b-p3fz4owbg2");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "b-p3fz4owbg2");
            __builder.AddMarkupContent(10, "<li b-p3fz4owbg2><img src=\"../image/logo.png\" b-p3fz4owbg2></li>\r\n                    ");
            __builder.AddMarkupContent(11, "<li b-p3fz4owbg2><i class=\"fa fa-home\" style=\"transform: scale(1.25);  \" b-p3fz4owbg2></i>\r\n                        <a href=\"https://localhost:44303/\" b-p3fz4owbg2>Trang Chủ</a></li>\r\n                    ");
            __builder.AddMarkupContent(12, "<li b-p3fz4owbg2><i class=\"fa fa-star\" style=\"transform: scale(1.25); \" b-p3fz4owbg2></i>\r\n                        <a href=\"https://localhost:44303/allproduct\" style=\"width:260px;\" b-p3fz4owbg2>Tất cả sản phẩm</a></li>\r\n                    ");
            __builder.AddMarkupContent(13, "<li b-p3fz4owbg2><i class=\"fa fa-car\" style=\"transform: scale(1.25);  \" b-p3fz4owbg2></i>\r\n                        <a href=\"#\" b-p3fz4owbg2>Ô tô</a></li>\r\n                    ");
            __builder.AddMarkupContent(14, "<li b-p3fz4owbg2><i class=\"fa fa-motorcycle\" style=\"transform: scale(1.25);  \" b-p3fz4owbg2></i>\r\n                        <a href=\"#\" b-p3fz4owbg2>Xe máy điện</a></li>\r\n                    ");
            __builder.AddMarkupContent(15, "<li b-p3fz4owbg2><i class=\"fa fa-fire\" style=\"transform: scale(1.25);  \" b-p3fz4owbg2></i>\r\n                        <a href=\"#\" b-p3fz4owbg2>Ưu đãi</a></li>\r\n                    ");
            __builder.AddMarkupContent(16, "<li b-p3fz4owbg2><i class=\"fa fa-thumbs-up\" style=\"transform: scale(1.25);  \" b-p3fz4owbg2></i>\r\n                        <a href=\"#\" b-p3fz4owbg2>Dịch vụ</a></li>\r\n                    ");
            __builder.AddMarkupContent(17, "<li b-p3fz4owbg2><i class=\"fa fa-cog\" style=\"transform: scale(1.25);\" b-p3fz4owbg2></i>\r\n                        <a href=\"#\" b-p3fz4owbg2>Công cụ</a></li>\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(18);
            __builder.AddAttribute(19, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(20, "li");
                __builder2.AddAttribute(21, "b-p3fz4owbg2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(22);
                __builder2.AddAttribute(23, "href", "/identity/account/logout");
                __builder2.AddAttribute(24, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 81 "D:\DuAnVinFast\Vinfast.web\Shared\MainLayout.razor"
                                                                                NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(26, "<i class=\"fa fa-user\" style=\"transform: scale(1.25);  \" b-p3fz4owbg2></i><br b-p3fz4owbg2>\r\n                                    Logout\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(27, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(28, "li");
                __builder2.AddAttribute(29, "b-p3fz4owbg2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
                __builder2.AddAttribute(31, "href", "/identity/account/login");
                __builder2.AddAttribute(32, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 89 "D:\DuAnVinFast\Vinfast.web\Shared\MainLayout.razor"
                                                                               NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(34, "<i class=\"fa fa-user\" style=\"transform: scale(1.25);  \" b-p3fz4owbg2></i><br b-p3fz4owbg2>\r\n                                    Login\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "page");
            __builder.AddAttribute(38, "b-p3fz4owbg2");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "main");
            __builder.AddAttribute(41, "b-p3fz4owbg2");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "content px-4");
            __builder.AddAttribute(44, "b-p3fz4owbg2");
            __builder.AddContent(45, 
#nullable restore
#line 105 "D:\DuAnVinFast\Vinfast.web\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
