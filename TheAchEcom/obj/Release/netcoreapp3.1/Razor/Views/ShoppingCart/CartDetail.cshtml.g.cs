#pragma checksum "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "838f3db998dec4d3ac59ccfa881d3b626b397cfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_CartDetail), @"mvc.1.0.view", @"/Views/ShoppingCart/CartDetail.cshtml")]
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
#line 1 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\_ViewImports.cshtml"
using TheAchEcom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\_ViewImports.cshtml"
using TheAchEcom.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
using Repository.DomainModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"838f3db998dec4d3ac59ccfa881d3b626b397cfc", @"/Views/ShoppingCart/CartDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1f16a9ae5a71c965ddd53c26902e77b1a46f52d", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_CartDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("faded_link none_deco"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icons/cancel.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("small_icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icons/next.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/cart-manager.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/cart-detail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""top_section"">
   <!-- breadcum -->
   <div id=""breadcrum_section"">
      <h3 class=""title""> Shopping Cart </h3>
   </div>
</div>

<div class=""line_separator""></div>

<!-- #Cart Detail Section -->
<div class=""shopping_cart_detail"">
   <div class=""cart_detail"">
      <!-- Cart Items -->
      <div class=""cart"">

         <div class=""cart_item"">
            <div class=""item_info"">
               <span class=""faded_span""> Product </span>
            </div>
            <div class=""item_controls"">
               <span class=""faded_span""> Quantity </span>
            </div>
            <div class=""item_summary"">
               <span class=""faded_span""> Total </span>
            </div>
         </div>

");
#nullable restore
#line 31 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
          if (Model.CartItems.Count() == 0)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 class=\"heading\"> Cart is empty! Let\'s shopping!</h3>\r\n");
#nullable restore
#line 34 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
         }
         else foreach (var item in Model.CartItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <div class=\"cart_item\"");
            BeginWriteAttribute("id", " id=\"", 1045, "\"", 1068, 2);
            WriteAttributeValue("", 1050, "cart_item_", 1050, 10, true);
#nullable restore
#line 37 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
WriteAttributeValue("", 1060, item.Id, 1060, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                  <div class=\"item_info\">\r\n                     <img class=\"product_img\">\r\n                     <div class=\"product_detail\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1240, "\"", 1289, 2);
            WriteAttributeValue("", 1247, "/Product/ProductDetail?id=", 1247, 26, true);
#nullable restore
#line 41 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
WriteAttributeValue("", 1273, item.Product.Id, 1273, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                           <span class=\"bold_span\">");
#nullable restore
#line 42 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
                                              Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                        </a>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838f3db998dec4d3ac59ccfa881d3b626b397cfc8592", async() => {
                WriteLiteral("\r\n                           ");
#nullable restore
#line 46 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
                      Write(item.Product.Brand.BrandName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1473, "~/shop/shoplist?brandid=", 1473, 24, true);
#nullable restore
#line 45 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
AddHtmlAttributeValue("", 1497, item.Product.BrandId, 1497, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        <span class=\"faded_span\"> ");
#nullable restore
#line 49 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
                                             Write(item.Product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" usd </span>\r\n                     </div>\r\n                  </div>\r\n                  <div class=\"item_controls\">\r\n                     <span class=\"control clickable\"");
            BeginWriteAttribute("onclick", "\r\n                           onclick=\"", 1853, "\"", 1955, 5);
            WriteAttributeValue("", 1891, "CART_DETAIL_CONTROLS.cart.decrease(\'", 1891, 36, true);
#nullable restore
#line 54 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
WriteAttributeValue("", 1927, item.Id, 1927, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1935, "\',", 1935, 2, true);
#nullable restore
#line 54 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
WriteAttributeValue(" ", 1937, item.Product.Id, 1938, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1954, ")", 1954, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        -\r\n                     </span>\r\n                     <span class=\"bold_span cart_item_quantity\"");
            BeginWriteAttribute("quantity", " quantity=\"", 2079, "\"", 2104, 1);
#nullable restore
#line 57 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
WriteAttributeValue("", 2090, item.Quantity, 2090, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 58 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     </span>\r\n                     <span class=\"control clickable\"");
            BeginWriteAttribute("onclick", "\r\n                           onclick=\"", 2230, "\"", 2332, 5);
            WriteAttributeValue("", 2268, "CART_DETAIL_CONTROLS.cart.increase(\'", 2268, 36, true);
#nullable restore
#line 61 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
WriteAttributeValue("", 2304, item.Id, 2304, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2312, "\',", 2312, 2, true);
#nullable restore
#line 61 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
WriteAttributeValue(" ", 2314, item.Product.Id, 2315, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2331, ")", 2331, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        +\r\n                     </span>\r\n\r\n                  </div>\r\n                  <div class=\"item_summary\">\r\n                     <span class=\"bold_span cart_item_total\"");
            BeginWriteAttribute("unit-price", " unit-price=\"", 2527, "\"", 2563, 1);
#nullable restore
#line 67 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
WriteAttributeValue("", 2540, item.Product.UnitPrice, 2540, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 68 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
                    Write(item.Quantity *
                        item.Product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" usd\r\n                     </span>\r\n                  </div>\r\n\r\n                  <div class=\"item_remove\">\r\n                     <span class=\"clickable\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2810, "\"", 2882, 5);
            WriteAttributeValue("", 2820, "CART_DETAIL_CONTROLS.cart.remove(\'", 2820, 34, true);
#nullable restore
#line 74 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
WriteAttributeValue("", 2854, item.Id, 2854, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2862, "\',", 2862, 2, true);
#nullable restore
#line 74 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
WriteAttributeValue(" ", 2864, item.Product.Id, 2865, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2881, ")", 2881, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "838f3db998dec4d3ac59ccfa881d3b626b397cfc15907", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                     </span>\r\n                  </div>\r\n               </div>\r\n");
#nullable restore
#line 79 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </div>\r\n      <div class=\"cart_info\">\r\n\r\n         <div class=\"info_item\">\r\n            <span class=\"faded_span\">\r\n               Total quantity:\r\n            </span>\r\n            <span id=\"cart_total_quantity\" class=\"bold_span\"> ");
#nullable restore
#line 88 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
                                                         Write(Model.CartItems.Sum(p => p.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
         </div>

         <div class=""info_item"">
            <span class=""faded_span"">
               Delivery cost:
            </span>
            <span class=""bold_span""> 499 usd </span>
         </div>

         <div class=""info_item"">
            <span class=""faded_span"">
               Estimated delivery date:
            </span>
            <span class=""bold_span"">
               April 4, 2020
            </span>
         </div>

      </div>
   </div>

   <!-- Cart Control -->
   <div class=""cart_controls"">
      <!-- Cart SUmmary -->
      <div class=""cart_summary"">
         <h3 class=""small_heading"">Summary</h3>
         <div class=""flex_center"">
            <span class=""faded_span""> Items:</span>
            <span id=""cart_total_item"" class=""bold_span""> ");
#nullable restore
#line 117 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
                                                     Write(Model.CartItems.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n         </div>\r\n\r\n         <div class=\"flex_center\">\r\n            <span class=\"faded_span\">Total: </span>\r\n            <span id=\"cart_total_price\" class=\"bold_span\"> ");
#nullable restore
#line 122 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
                                                      Write(Model.CartTotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" usd </span>\r\n         </div>\r\n      </div>\r\n\r\n");
#nullable restore
#line 126 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
       if (Model.CartItems.Count() != 0)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <a href=\"/Order/CheckOut\" class=\"cta_btn flex_center clickable\">\r\n            <span> Make Order </span>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "838f3db998dec4d3ac59ccfa881d3b626b397cfc20042", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n         </a>\r\n");
#nullable restore
#line 132 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
      }
      else
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <a class=\"cta_btn flex_center clickable\"\r\n            style=\"opacity:0.5;cursor:not-allowed\">\r\n            <span> Make Order </span>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "838f3db998dec4d3ac59ccfa881d3b626b397cfc21591", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n         </a>\r\n");
#nullable restore
#line 140 "C:\Users\huu\source\repos\dandy-dick\ecom-final-project-2020\TheAchEcom\Views\ShoppingCart\CartDetail.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("   </div>\r\n</div>\r\n\r\n");
            DefineSection("ViewScripts", async() => {
                WriteLiteral("\r\n   ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838f3db998dec4d3ac59ccfa881d3b626b397cfc23082", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n   ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838f3db998dec4d3ac59ccfa881d3b626b397cfc24181", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591