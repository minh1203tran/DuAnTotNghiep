#pragma checksum "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d98642270541e2399b67f45477b0929627bf8539"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
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
#line 1 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\_ViewImports.cshtml"
using DuAnTotNghiep;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
using DuAnTotNghiep.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
using DuAnTotNghiep.Constant;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d98642270541e2399b67f45477b0929627bf8539", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3232a1188cebe24fd3efc40aa88e011da7eff4fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DuAnTotNghiep.Models.ViewCart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
   string emailaddress = Context.Session.GetString(SessionKey.KhachHang.KH_Email); 

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
   string fullname = Context.Session.GetString(SessionKey.KhachHang.KH_FullName); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
  
    Layout = "~/Views/Shared/_WebLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Cart</h1>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>STT</th>\r\n        <th>Tên sản phẩm</th>\r\n        <th>Hình ảnh</th>\r\n        <th>Số lượng</th>\r\n        <th>Giá</th>\r\n        <th>Thành tiền</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 24 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
      
        int stt = 0;
        double total = 0;
        foreach (var item in Model)
        {
            int id = item.SanPham.SanPhamId;
            string txt_Id = "txtQuantity_" + id;
            stt++;
            double totalSub = item.SanPham.Gia * item.Quantity;
            total += totalSub;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("id", " id=\"", 992, "\"", 1003, 2);
            WriteAttributeValue("", 997, "tr_", 997, 3, true);
#nullable restore
#line 34 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1000, id, 1000, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <td>");
#nullable restore
#line 35 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
           Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
           Write(item.SanPham.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d98642270541e2399b67f45477b0929627bf85397282", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1101, "~/Images/hinhanh/", 1101, 17, true);
#nullable restore
#line 37 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
AddHtmlAttributeValue("", 1118, item.SanPham.HinhAnh, 1118, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            <td><input type=\"number\"");
            BeginWriteAttribute("id", " id=\"", 1208, "\"", 1220, 1);
#nullable restore
#line 38 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1213, txt_Id, 1213, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1221, "\"", 1243, 1);
#nullable restore
#line 38 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1229, item.Quantity, 1229, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onchange", " onchange=\"", 1244, "\"", 1288, 5);
            WriteAttributeValue("", 1255, "()", 1255, 2, true);
            WriteAttributeValue(" ", 1257, "=>", 1258, 3, true);
            WriteAttributeValue(" ", 1260, "javascript:updateCart(", 1261, 23, true);
#nullable restore
#line 38 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1283, id, 1283, 3, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1286, ");", 1286, 2, true);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n            <td><span");
            BeginWriteAttribute("id", " id=\"", 1319, "\"", 1333, 2);
            WriteAttributeValue("", 1324, "tdGia_", 1324, 6, true);
#nullable restore
#line 39 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1330, id, 1330, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
                                Write(item.SanPham.Gia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> VNĐ</td>\r\n            <td><span");
            BeginWriteAttribute("id", " id=\"", 1391, "\"", 1406, 2);
            WriteAttributeValue("", 1396, "tdTien_", 1396, 7, true);
#nullable restore
#line 40 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1403, id, 1403, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
                                 Write(totalSub);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> VNĐ</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1471, "\"", 1505, 3);
            WriteAttributeValue("", 1478, "javascript:updateCart(", 1478, 22, true);
#nullable restore
#line 42 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1500, id, 1500, 3, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1503, ");", 1503, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Cập nhật</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1563, "\"", 1597, 3);
            WriteAttributeValue("", 1570, "javascript:deleteCart(", 1570, 22, true);
#nullable restore
#line 43 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1592, id, 1592, 3, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1595, ");", 1595, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Xóa</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 46 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
        }


    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 51 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
 if (total == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p><div>Tổng tiền: 0 VNĐ</div></p>\r\n");
#nullable restore
#line 54 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p><div>Tổng tiền: <span id=\"spTotal\">");
#nullable restore
#line 57 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
                                     Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> VNĐ</div></p>\r\n");
#nullable restore
#line 58 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n");
#nullable restore
#line 61 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
     if (emailaddress != null && emailaddress != "")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModalCenter"">
            Đặt hàng
        </button>
        <div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
            <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLongTitle"">Thông báo</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        Đặt hàng thành công
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-se");
            WriteLiteral(@"condary"" data-dismiss=""modal"">Thoát</button>
                        <a class=""addProduct btn btn-primary"" href=""javascript:orderCart(true);"">OK</a>
                    </div>
                </div>
            </div>
        </div>
        <div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d98642270541e2399b67f45477b0929627bf853915619", async() => {
                WriteLiteral("Trở về trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 88 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModalCenter"">
            Đặt hàng
        </button>
        <div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
            <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLongTitle"">Thông báo</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        Bạn cần phải đăng nhập để đặt hàng.
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" c");
            WriteLiteral("lass=\"btn btn-secondary\" data-dismiss=\"modal\">Thoát</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d98642270541e2399b67f45477b0929627bf853918397", async() => {
                WriteLiteral("Trở về trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 115 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
<script>
    function updateCart(id) {
        var soluong = $(""#txtQuantity_"" + id).val();
        var gia = $(""#tdGia_"" + id).html();
        if (soluong > 0) {
            var thanhtien = soluong * gia;
        }
        $(""#tdTien_"" + id).html(thanhtien);
        $.ajax({
            type: ""POST"",
            url: ""/Home/UpdateCart"",
            data: {
                id: id,
                soluong: soluong
            },
            success: function (result) {
                $(""#spTotal"").html(result);
                if (result == ""0"") {
                    $(""#imgCart"").attr(""src"", ""/Images/cart.png"");
                }
            }
        });
    }

    function deleteCart(id) {
        $.ajax({
            type: ""POST"",
            url: ""/Home/DeleteCart"",
            data: {
                id: id,
            },
            success: function (result) {
                $(""#tr_"" + id).hide();
                $(""#spTotal"").html(result);
                if ");
            WriteLiteral(@"(result == ""0"") {
                    $(""#imgCart"").attr(""src"", ""/Images/cart.png"");
                    clearCart();
                }
            }
        });
    }

    function clearCart() {
        $(""#imgCart"").attr(""src"", '/Images/cart.png');
    }

    function orderCart(flagLogin) {
        if (!flagLogin) {
            return false;
        }
        $.ajax({
            type: ""POST"",
            url: ""/Home/OrderCart"",
            data: {},
            success: function (result) {
                window.location = ""/Home/History"";
            }
        });
    }
</script>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 181 "D:\Du_an_TN_(UDPM_NetCore)\DuAnTotNghiep\DuAnTotNghiep\Views\Home\Cart.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DuAnTotNghiep.Models.ViewCart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
