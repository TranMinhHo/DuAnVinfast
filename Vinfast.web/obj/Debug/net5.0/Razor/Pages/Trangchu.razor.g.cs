#pragma checksum "D:\DuAnVinFast\Vinfast.web\Pages\Trangchu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53298f920587e297eed52a6791d36e1b93d7f6b8"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Trangchu : ProductListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n    ");
            __builder.AddMarkupContent(1, "<style>\r\n        textarea {\r\n            resize: none;\r\n        }\r\n       option{\r\n           font-size:20px;\r\n       }\r\n        .checkboxtext {\r\n            font-size: 110%;\r\n            display: inline;\r\n        }\r\n        .checkradio {\r\n            margin-top:5px;\r\n            margin-bottom:5px;\r\n            transform: scale(1.5);\r\n            padding: 10px;\r\n        }\r\n        .buttonsubmit {\r\n            background-color: #58257b;\r\n            border: none;\r\n            color: white;\r\n            padding: 16px 32px;\r\n            text-align: center;\r\n            text-decoration: none;\r\n            display: inline-block;\r\n            font-size: 20px;\r\n            margin: 4px 2px;\r\n            -webkit-transition-duration: 0.4s;\r\n            transition-duration: 0.4s;\r\n            cursor: pointer;\r\n            border-radius: 4px;\r\n            position:center;\r\n            width:200px;\r\n        }\r\n        .button8 {\r\n            background-color: midnightblue;\r\n            color: white;\r\n            border: 2px solid midnightblue;\r\n        }\r\n\r\n            .button8:hover {\r\n                background-color: white;\r\n                color: black;\r\n                border: 2px solid midnightblue;\r\n            }\r\n        .title{\r\n            font-size:20px;\r\n            color:#0f112c;\r\n            font-weight:bold;\r\n        }\r\n        .contents{\r\n            font-size:15px;\r\n        }\r\n     \r\n        ul{\r\n            list-style:none;\r\n           \r\n        }\r\n        ul li{\r\n            text-align:left;\r\n            padding-left:100px;\r\n        }\r\n       \r\n    </style>\r\n<img class=\"banner\" src=\"/image/banner1.jpg\">\r\n");
            __builder.OpenElement(2, "section");
            __builder.AddAttribute(3, "class", "section");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "tb");
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddAttribute(8, "align", "center");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "image");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "id", "zoom-in");
            __builder.OpenElement(13, "figure");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", "/image/luxa.jpg");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "D:\DuAnVinFast\Vinfast.web\Pages\Trangchu.razor"
                                                                 Img_A20

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                            ");
            __builder.AddMarkupContent(18, "<figcaption>LUX A2.0</figcaption>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "td");
            __builder.AddAttribute(21, "align", "center");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "image");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "id", "zoom-in");
            __builder.OpenElement(26, "figure");
            __builder.OpenElement(27, "img");
            __builder.AddAttribute(28, "src", "/image/luxsa.jpg");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "D:\DuAnVinFast\Vinfast.web\Pages\Trangchu.razor"
                                                                  Img_Sa

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.AddMarkupContent(31, "<figcaption>LUX SA2.0</figcaption>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "td");
            __builder.AddAttribute(34, "align", "center");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "image");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "id", "zoom-in");
            __builder.OpenElement(39, "figure");
            __builder.OpenElement(40, "img");
            __builder.AddAttribute(41, "src", "/image/fadilhight.jpg");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "D:\DuAnVinFast\Vinfast.web\Pages\Trangchu.razor"
                                                                       Img_Fadil

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n                            ");
            __builder.AddMarkupContent(44, "<figcaption>FADIL</figcaption>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "align", "center");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "image");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "id", "zoom-in");
            __builder.OpenElement(52, "figure");
            __builder.OpenElement(53, "img");
            __builder.AddAttribute(54, "src", "/image/President-highlight.jpg");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 107 "D:\DuAnVinFast\Vinfast.web\Pages\Trangchu.razor"
                                                                                Img_President

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n                            ");
            __builder.AddMarkupContent(57, "<figcaption>PRESIDENT</figcaption>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    <hr>\r\n    ");
            __builder.OpenElement(59, "table");
            __builder.AddAttribute(60, "class", "tb");
            __builder.OpenElement(61, "tr");
            __builder.OpenElement(62, "td");
            __builder.AddAttribute(63, "align", "center");
            __builder.AddAttribute(64, "width", "50%");
            __builder.OpenElement(65, "img");
            __builder.AddAttribute(66, "src", 
#nullable restore
#line 119 "D:\DuAnVinFast\Vinfast.web\Pages\Trangchu.razor"
                                                      ImageOnClick1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "td");
            __builder.AddAttribute(69, "align", "center");
            __builder.AddAttribute(70, "width", "50%");
            __builder.OpenElement(71, "h1");
            __builder.AddContent(72, 
#nullable restore
#line 121 "D:\DuAnVinFast\Vinfast.web\Pages\Trangchu.razor"
                     Ten

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                <hr>\r\n                ");
            __builder.AddMarkupContent(74, "<h5>Số tiền đặt cọc</h5>");
            __builder.OpenElement(75, "h2");
            __builder.AddAttribute(76, "style", "color:cornflowerblue");
            __builder.AddContent(77, 
#nullable restore
#line 123 "D:\DuAnVinFast\Vinfast.web\Pages\Trangchu.razor"
                                                                          Datcoc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "<br>\r\n                ");
            __builder.AddMarkupContent(79, "<h5>Lựa chọn phiên bảng xe</h5>\r\n                ");
            __builder.AddMarkupContent(80, "<div><button class=\"button\">TIÊU CHUẨN</button>\r\n                    <button class=\"button\">NÂNG CAO</button>\r\n                    <button class=\"button\">CAO CẤP</button></div>\r\n                ");
            __builder.AddMarkupContent(81, @"<div><button class=""buttonround""></button>
                    <button class=""buttonround br1""></button>
                    <button class=""buttonround br2""></button>
                    <button class=""buttonround br3""></button>
                    <button class=""buttonround br4""></button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    <hr>\r\n    ");
            __builder.OpenElement(83, "table");
            __builder.AddAttribute(84, "class", "tb");
            __builder.OpenElement(85, "tr");
            __builder.AddMarkupContent(86, "<td width=\"25%\"></td>\r\n            <td width=\"25%\"></td>\r\n            <td width=\"25%\"></td>\r\n            ");
            __builder.OpenElement(87, "td");
            __builder.AddAttribute(88, "style", "text-align:left");
            __builder.AddAttribute(89, "width", "25%");
            __builder.OpenElement(90, "form");
            __builder.AddAttribute(91, "id", "form1");
            __builder.AddAttribute(92, "method", "get");
            __builder.AddMarkupContent(93, "<h3 style=\"text-align: center; margin-top: 20px; margin-bottom: 20px\">THÔNG TIN KHÁCH HÀNG</h3>\r\n                    ");
            __builder.AddMarkupContent(94, "<h5 style=\"font-weight: bold\">Quý khách là? <span style=\"color:blue\">*</span></h5>\r\n                    ");
            __builder.OpenElement(95, "select");
            __builder.AddAttribute(96, "style", "width:700px;height:50px");
            __builder.OpenElement(97, "option");
            __builder.AddMarkupContent(98, "Doanh Nghiệp");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.OpenElement(100, "option");
            __builder.AddMarkupContent(101, "Cá Nhân");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                    ");
            __builder.AddMarkupContent(103, @"<h5 style=""margin-top: 5px; font-weight: bold"">Họ tên khách hàng <span style=""color:blue"">*</span></h5>
                    <textarea style=""width: 700px; height: 50px; padding-top: 10px; padding-left: 10px; "" placeholder=""Điền đầy đủ họ tên..""></textarea>

                    ");
            __builder.AddMarkupContent(104, "<h5 style=\"font-weight: bold\">Doanh Nghiệp <span style=\"color:blue\">*</span></h5>\r\n                    <textarea style=\"width:700px;height:50px;padding-top:10px;padding-left:10px;\" placeholder=\"Tên doanh nghiệp..\"></textarea>\r\n\r\n                    ");
            __builder.AddMarkupContent(105, @"<h5 style=""font-weight: bold"">Số điện thoại <span style=""color:blue"">*</span></h5>
                    <textarea style=""width: 700px; height: 50px; padding-top: 10px; padding-left: 10px; "" placeholder=""Số điện thoại của bạn..""></textarea>

                    ");
            __builder.AddMarkupContent(106, "<h5 style=\"font-weight: bold\">Email <span style=\"color:blue\">*</span></h5>\r\n                    <textarea style=\"width: 700px; height: 50px; padding-top: 10px; padding-left: 10px; \" placeholder=\"Email của bạn..\"></textarea>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.OpenElement(108, "tr");
            __builder.AddMarkupContent(109, "<td width=\"25%\"></td>\r\n            <td width=\"25%\"></td>\r\n            <td width=\"25%\"></td>\r\n            ");
            __builder.OpenElement(110, "td");
            __builder.AddAttribute(111, "width", "25%");
            __builder.AddMarkupContent(112, "<h3 style=\"text-align: center; margin-top:20px;margin-bottom:20px\">LỰA CHỌN SHOWROOM MUA XE</h3>\r\n                ");
            __builder.AddMarkupContent(113, "<h5 style=\"font-weight:bold\">Tỉnh thành <span style=\"color:blue\">*</span></h5>\r\n                ");
            __builder.OpenElement(114, "select");
            __builder.AddAttribute(115, "style", "width:700px;height:50px;");
            __builder.OpenElement(116, "option");
            __builder.AddMarkupContent(117, "Hà Nội");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                    ");
            __builder.OpenElement(119, "option");
            __builder.AddMarkupContent(120, "TP Hồ Chí Minh");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                    ");
            __builder.OpenElement(122, "option");
            __builder.AddMarkupContent(123, "Kiên Giang");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                    ");
            __builder.OpenElement(125, "option");
            __builder.AddMarkupContent(126, "Đà Nẵng");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                    ");
            __builder.OpenElement(128, "option");
            __builder.AddMarkupContent(129, "Thanh Hóa");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                    ");
            __builder.OpenElement(131, "option");
            __builder.AddMarkupContent(132, "Hà Tỉnh");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                    ");
            __builder.OpenElement(134, "option");
            __builder.AddContent(135, "Gia Lai");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                    ");
            __builder.OpenElement(137, "option");
            __builder.AddMarkupContent(138, "Nghệ An");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                    ");
            __builder.OpenElement(140, "option");
            __builder.AddMarkupContent(141, "Bình Dương");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                ");
            __builder.AddMarkupContent(143, "<h5 style=\"margin-top: 5px; margin-bottom: 5px; font-weight: bold\">Showroom/Đại lý <span style=\"color:blue\">*</span></h5>\r\n                <textarea style=\"width:700px;height:50px\" required></textarea>\r\n                ");
            __builder.AddMarkupContent(144, @"<div style=""margin-bottom:5px;margin-top:5px""><input type=""checkbox"" name=""checkagree"" id=""accept"" class=""checkradio"">
                    <label for=""accept"" class=""checkboxtext"">
                        Tôi cam kết các thông tin cung cấp tại đây hoàn toàn chính xác
                    </label></div>
                ");
            __builder.AddMarkupContent(145, @"<div style=""margin-bottom:5px;margin-top:5px""><input type=""checkbox"" name=""checkagree"" id=""accept2"" class=""checkradio"">
                    <label for=""accept2"" class=""checkboxtext"">
                        Tôi đồng ý với toàn bộ nội dung <a href=""https://shop.vinfastauto.com/on/demandware.static/-/Sites/default/dw743bfcd5/Documents/VFT_Dieu_Khoan_Chung_Dat_Coc_Mua_Ban_O_To.pdf"">Điều khoản</a> trong Thỏa Thuận Đặt Cọc
                    </label></div>
                ");
            __builder.AddMarkupContent(146, @"<div style=""margin-bottom:5px;margin-top:5px""><input type=""checkbox"" name=""checkagree"" id=""accept3"" class=""checkradio"">
                    <label for=""accept3"" class=""checkboxtext"">
                        Tôi đồng ý với các <a href=""https://shop.vinfastauto.com/vn_vi/dieu-khoan-phap-ly.html"">Điều kiện & Điều khoản</a>của VinFast Online.
                    </label></div>
                ");
            __builder.AddMarkupContent(147, "<h5 style=\"margin-top:5px;margin-bottom:5px;font-weight:bold\">Hình thức thanh toán</h5>\r\n                ");
            __builder.AddMarkupContent(148, "<div style=\"margin-bottom:5px;margin-top:5px\"><input type=\"radio\" id=\"check1\" class=\"checkradio\">\r\n                    <lable for=\"check1\" class=\"checkboxtext\">Thanh toán qua thẻ tín dụng</lable></div>\r\n                ");
            __builder.AddMarkupContent(149, "<div style=\"margin-bottom:5px;margin-top:5px\"><input type=\"radio\" id=\"check2\" class=\"checkradio\">\r\n                    <lable for=\"check2\" class=\"checkboxtext\">Thanh toán qua thẻ tín dụng</lable></div>\r\n                ");
            __builder.AddMarkupContent(150, "<div style=\"margin-bottom:5px;margin-top:5px\"><input type=\"radio\" id=\"check3\" class=\"checkradio\">\r\n                    <lable for=\"check3\" class=\"checkboxtext\">Thanh toán qua thẻ tín dụng</lable></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n        ");
            __builder.AddMarkupContent(152, "<tr><td width=\"25%\"></td>\r\n            <td width=\"25%\"></td>\r\n            <td width=\"25%\"></td>\r\n            <td width=\"25%\" align=\"center\"><div><input type=\"submit\" id=\"send\" value=\"Đặt Cọc\" class=\"buttonsubmit button8\"></div></td></tr>");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n\r\n    <hr>\r\n    ");
            __builder.AddMarkupContent(154, @"<table class=""tb""><tr><td width=""100%"" align=""center""><a href=""/""><img src=""/image/footerlogo.png""></a></td></tr></table>

    <hr style=""border: 3px solid #0f112c; width:95%"">
    <hr style=""border: 3px solid #0f112c; width:92%"">
    <hr style=""border: 3px solid #0f112c; width:90%"">

    ");
            __builder.AddMarkupContent(155, "<table class=\"tb\"><tr><td width=\"20%\" style=\"text-align: center\"><p class=\"title\">GIỚI THIỆU</p></td>\r\n            <td width=\"20%\" style=\"text-align: center\"><p class=\"title\">XE Ô TÔ</p></td>\r\n            <td width=\"20%\" style=\"text-align: center\"><p class=\"title\">XE MÁY ĐIỆN</p></td>\r\n            <td width=\"20%\" style=\"text-align: center\"><p class=\"title\">TIN TỨC NỔI BẬT</p></td>\r\n            <td width=\"20%\" style=\"text-align: center\"><p class=\"title\">HỖ TRỢ</p></td></tr>\r\n        <tr><td width=\"20%\" style=\"text-align: left\"><ul><li><a href=\"https://vinfastauto.com/vn_vi/ve-chung-toi\" class=\"contents\">Về VinFast</a></li>\r\n                    <li><a href=\"https://vinfastauto.com/vn_vi/ve-vingroup\" class=\"contents\">Về VinGroup</a></li>\r\n                    <li><a href=\"https://vinfastauto.com/investor/\" class=\"contents\">Nhà đầu tư</a></li></ul></td>\r\n            <td width=\"20%\" style=\"text-align: left\"><ul><li><a href=\"https://localhost:44303/productdetails/1\" class=\"contents\">Lux A2.0</a></li>\r\n                    <li><a href=\"https://localhost:44303/productdetails/2\" class=\"contents\">Lux SA2.0</a></li>\r\n                    <li><a href=\"https://localhost:44303/productdetails/3\" class=\"contents\">Fadil</a></li>\r\n                    <li><a href=\"https://localhost:44303/productdetails/4\" class=\"contents\">President</a></li></ul></td>\r\n            <td width=\"20%\" style=\"text-align: left\"><ul><li>Theon</li>\r\n                    <li>Feliz</li>\r\n                    <li>Klara A2</li>\r\n                    <li>Klara S</li>\r\n                    <li>Impes</li>\r\n                    <li>Ludo</li></ul></td>\r\n            <td width=\"20%\" style=\"text-align: left\"><ul><li>Uư đãi</li>\r\n                    <li>Feliz</li>\r\n                    <li>Công ty</li>\r\n                    <li>Xu hướng chung</li>\r\n                    <li>Cộng đồng</li>\r\n                    <li>Báo chí viết về VinFast</li></ul></td>\r\n            <td width=\"20%\" style=\"text-align: left\"><ul><li>Câu hỏi thường gặp</li>\r\n                    <li>Hệ thống showroom và đại lý</li>\r\n                    <li>Đối tác trạm sạc</li>\r\n                    <li>Hệ sinh thái pin và trạm sạc</li>\r\n                    <li>Đặt lịch bảo dưỡng</li>\r\n                    <li>Liên hệ</li></ul></td></tr></table>\r\n\r\n    <hr style=\"border: 3px solid #0f112c; width:90%\">\r\n    <hr style=\"border: 3px solid #0f112c; width:92%\">\r\n    <hr style=\"border: 3px solid #0f112c; width:95%\">\r\n\r\n    ");
            __builder.AddMarkupContent(156, @"<table class=""tb""><tr><td width=""20%"" style=""text-align:right""><p>Hot line & Email</p></td>
            <td width=""20%"" style=""text-align:center""><button class=""button""><i class=""fa fa-phone"" style=""transform:scale(1.25);margin-right:10px""></i>
                    1900 23 23 89<br>
                    (1000đ/p)
                </button></td>
            <td width=""20%"" style=""text-align:left
    ""><button class=""button""><i class=""fa fa-envelope"" style=""transform:scale(1.25);margin-right:10px""></i>
                    minhho1220@gmail.com
                </button></td>
            <td width=""20%"" style=""text-align:right""><p>Kết nối với VinFast</p></td>
            <td width=""20%"" style=""text-align:center""><button onclick=""https://www.facebook.com/VinFastAuto.Official"" style=""border-radius:50%;text-align:center;width:50px;height:50px;border-color:#c3c3c3;""><i class=""fa fa-facebook"" style=""transform:scale(1.25)""></i></button>
                <button onclick=""https://www.facebook.com/VinFastEscooter.Official"" style=""border-radius: 50%; text-align: center; width: 50px; height: 50px; border-color: #c3c3c3 ""><i class=""fa fa-facebook"" style=""transform:scale(1.25)""></i></button>
                <button onclick=""https://www.youtube.com/channel/UCA5OijDHvvWJ3vy5iVdWcAQ"" style=""border-radius: 50%; text-align: center; width: 50px; height: 50px; border-color: #c3c3c3 ""><i class=""fa fa-youtube-play"" style=""transform:scale(1.25)""></i></button></td></tr></table>
    ");
            __builder.AddMarkupContent(157, @"<table><tr><td width=""20%"" style=""text-align:left""><p><b>
                        Công ty TNHH Kinh doanh Thương mại
                        và Dịch vụ VinFast
                    </b>
                    <br>
                    VinFast. All rights reserved.
                    © Copyright 2020
                </p></td>
            <td width=""20%""></td>
            <td width=""40%"" style=""text-align:left""><p><b>Số đăng ký kinh doanh:</b> 0108926276<br>

                    <b>Đăng ký lần đầu:</b> Ngày 01 tháng 10 năm 2019<br>

                    <b>Đăng ký thay đổi lần thứ 3:</b> Ngày 17 tháng 03 năm 2020<br>

                    <b>Nơi cấp:</b> Sở Kế hoạch và Đầu tư Thành phố Hà Nội
                </p></td>

            <td width=""30%"" style=""text-align:left""><p><b>Địa chỉ:</b> Số 7, Đường Bằng Lăng 1, Khu đô thị sinh thái<br>
                    Vinhomes Riverside, Phường Việt Hưng, Quận Long Biên, Thành phố Hà Nội, Việt Nam
                </p></td></tr></table>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
