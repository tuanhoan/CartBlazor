#pragma checksum "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\Features\Cart\Item.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73abce5a1636dd551aa0a1932523f09c038a5ba8"
// <auto-generated/>
#pragma warning disable 1591
namespace CartBlazor.Features.Cart
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\_Imports.razor"
using CartBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\_Imports.razor"
using CartBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\_Imports.razor"
using CartBlazor.Features.Cart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\_Imports.razor"
using CartBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class Item : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row border-bottom py-4 card");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "media");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 5 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\Features\Cart\Item.razor"
                       imgSrc

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "style", "width:100px");
            __builder.AddAttribute(12, "altText", 
#nullable restore
#line 5 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\Features\Cart\Item.razor"
                                                             Cart.imgText

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "class", "mr-3");
            __builder.AddAttribute(14, "alt", "Ảnh");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "media-body");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "h3");
            __builder.AddContent(20, 
#nullable restore
#line 8 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\Features\Cart\Item.razor"
                     Cart.imgText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "p");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __Blazor.CartBlazor.Features.Cart.Item.TypeInference.CreateMatNumericUpDownField_0(__builder, 24, 25, "Số Lượng", 26, 
#nullable restore
#line 11 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\Features\Cart\Item.razor"
                                                         Cart.count

#line default
#line hidden
#nullable disable
            , 27, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Cart.count = __value, Cart.count)), 28, () => Cart.count);
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-danger");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\Features\Cart\Item.razor"
                                                              OnDeleteClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-sm-2");
            __builder.AddMarkupContent(41, "\r\n        £");
            __builder.AddContent(42, 
#nullable restore
#line 19 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\Features\Cart\Item.razor"
          Cart.money

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\tuanHoan\source\repos\CartBlazor\CartBlazor\Features\Cart\Item.razor"
        
    [Parameter]
    public Cart Cart { get; set; }
    [Parameter]
    public string imgSrc { get; set; }
    [Parameter]
    public EventCallback<Cart> Ondelete { get; set; } 
    public async Task OnDeleteClicked()
    {
        await Ondelete.InvokeAsync(Cart);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CartData _cart { get; set; }
    }
}
namespace __Blazor.CartBlazor.Features.Cart.Item
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatNumericUpDownField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatNumericUpDownField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
