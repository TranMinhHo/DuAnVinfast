#pragma checksum "D:\DuAnVinFast\Vinfast.web\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d840267a18cd216a2933f09b53a2f58f63c70f6"
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
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\" b-p3fz4owbg2>\r\n        ");
            __builder.AddMarkupContent(1, "<div class=\"navigation-bar\" b-p3fz4owbg2><div id=\"navigation-container\" b-p3fz4owbg2><ul b-p3fz4owbg2><li style=\"margin-top:10px\" b-p3fz4owbg2><img src=\"../image/logo.png\" b-p3fz4owbg2></li>\r\n                    <li b-p3fz4owbg2><i class=\"fa fa-home\" style=\"transform: scale(1.25); margin-right: 10px; margin-top: 17px; \" b-p3fz4owbg2></i>\r\n                        <a href=\"https://localhost:44303/\" b-p3fz4owbg2>Trang Chủ</a></li>\r\n                    <li b-p3fz4owbg2><i class=\"fa fa-star\" style=\"transform: scale(1.25); margin-right: 10px; margin-top: 17px; \" b-p3fz4owbg2></i>\r\n                        <a href=\"https://localhost:44303/allproduct\" b-p3fz4owbg2>Tất cả sản phẩm</a></li>\r\n                    <li b-p3fz4owbg2><i class=\"fa fa-car\" style=\"transform: scale(1.25); margin-top: 17px; margin-right: 10px; \" b-p3fz4owbg2></i>\r\n                        <a href=\"#\" b-p3fz4owbg2>Ô tô</a></li>\r\n                    <li b-p3fz4owbg2><i class=\"fa fa-motorcycle\" style=\"transform: scale(1.25); margin-top: 17px; margin-right: 10px; \" b-p3fz4owbg2></i>\r\n                        <a href=\"#\" b-p3fz4owbg2>Xe máy điện</a></li>\r\n                    <li b-p3fz4owbg2><i class=\"fa fa-fire\" style=\"transform: scale(1.25); margin-top: 17px; margin-right: 10px; \" b-p3fz4owbg2></i>\r\n                        <a href=\"#\" b-p3fz4owbg2>Ưu đãi</a></li>\r\n                    <li b-p3fz4owbg2><i class=\"fa fa-thumbs-up\" style=\"transform: scale(1.25); margin-top: 17px; margin-right: 10px; \" b-p3fz4owbg2></i>\r\n                        <a href=\"#\" b-p3fz4owbg2>Dịch vụ</a></li>\r\n                    <li b-p3fz4owbg2><i class=\"fa fa-cog\" style=\"transform: scale(1.25); margin-top: 17px ; margin-right: 10px;\" b-p3fz4owbg2></i>\r\n                        <a href=\"#\" b-p3fz4owbg2>Công cụ</a></li></ul>\r\n                <ul b-p3fz4owbg2><li b-p3fz4owbg2><i class=\"fa fa-user\" style=\"transform: scale(1.25); margin-top: 17px; margin-right: 10px; \" b-p3fz4owbg2></i>\r\n                        <a href=\"#\" b-p3fz4owbg2>Tài khoản</a></li></ul></div></div>\r\n\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "page");
            __builder.AddAttribute(4, "b-p3fz4owbg2");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "main");
            __builder.AddAttribute(7, "b-p3fz4owbg2");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "content px-4");
            __builder.AddAttribute(10, "b-p3fz4owbg2");
            __builder.AddContent(11, 
#nullable restore
#line 53 "D:\DuAnVinFast\Vinfast.web\Shared\MainLayout.razor"
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
