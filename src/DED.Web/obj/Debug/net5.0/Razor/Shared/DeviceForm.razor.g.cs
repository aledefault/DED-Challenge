#pragma checksum "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f20d2cb38df3c7eae313607cddddd5aaea7fc97e"
// <auto-generated/>
#pragma warning disable 1591
namespace DED.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\_Imports.razor"
using DED.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\_Imports.razor"
using DED.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
using DED.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    public partial class DeviceForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
                  DeviceFormModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
                                             SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "class", "bg-light py-3 px-4 rounded");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-row");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                __builder2.CloseComponent();
#nullable restore
#line 10 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
         if (!string.IsNullOrEmpty(_errorMessage))
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(10, "ul");
                __builder2.AddAttribute(11, "class", "validation-errors");
                __builder2.OpenElement(12, "li");
                __builder2.AddAttribute(13, "class", "validation-message");
                __builder2.AddContent(14, 
#nullable restore
#line 14 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
                     _errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 17 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-row");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group col");
                __builder2.AddMarkupContent(20, "<label for=\"serialNumber\">Serial Number</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "id", "serialNumber");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
                                                      DeviceFormModel.SerialNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DeviceFormModel.SerialNumber = __value, DeviceFormModel.SerialNumber))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => DeviceFormModel.SerialNumber));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group col");
                __builder2.AddMarkupContent(30, "<label for=\"brand\">Brand</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "id", "brand");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
                                               DeviceFormModel.Brand

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DeviceFormModel.Brand = __value, DeviceFormModel.Brand))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => DeviceFormModel.Brand));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group col");
                __builder2.AddMarkupContent(40, "<label for=\"model\">Model</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(41);
                __builder2.AddAttribute(42, "id", "model");
                __builder2.AddAttribute(43, "class", "form-control");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
                                               DeviceFormModel.Model

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DeviceFormModel.Model = __value, DeviceFormModel.Model))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => DeviceFormModel.Model));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n    ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-row");
#nullable restore
#line 34 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
         if (DeviceToAdd == Device.Gateway)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group col-3");
                __builder2.AddMarkupContent(52, "<label for=\"ip\">Ip</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "id", "ip");
                __builder2.AddAttribute(55, "class", "form-control");
                __builder2.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
                                                DeviceFormModel.Ip

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DeviceFormModel.Ip = __value, DeviceFormModel.Ip))));
                __builder2.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => DeviceFormModel.Ip));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group col-3");
                __builder2.AddMarkupContent(62, "<label for=\"port\">Port</label>\r\n                ");
                __Blazor.DED.Web.Shared.DeviceForm.TypeInference.CreateInputNumber_0(__builder2, 63, 64, "port", 65, "form-control", 66, 
#nullable restore
#line 42 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
                                                    DeviceFormModel.Port

#line default
#line hidden
#nullable disable
                , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DeviceFormModel.Port = __value, DeviceFormModel.Port)), 68, () => DeviceFormModel.Port);
                __builder2.CloseElement();
#nullable restore
#line 44 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-row justify-content-end");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group");
                __builder2.OpenElement(74, "button");
                __builder2.AddAttribute(75, "type", "button");
                __builder2.AddAttribute(76, "class", "btn btn-secondary");
                __builder2.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
                                                                      async () => await OnHide.InvokeAsync()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(78, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.AddMarkupContent(80, "<button type=\"submit\" class=\"btn btn-primary\">Add</button>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Shared\DeviceForm.razor"
       
    [Parameter]
    public DeviceModel DeviceFormModel { get; set; }

    [Parameter]
    public Device DeviceToAdd { get; set; }

    [Parameter]
    public EventCallback OnHide { get; set; }

    [Parameter]
    public EventCallback OnSuccess { get; set; }


    public enum Device { EnergyMeter, Gateway, WaterMeter }

    private string _errorMessage = "";

    private async Task SubmitForm()
    {
        HttpResponseMessage response = null;
        switch (DeviceToAdd)
        {
            case Device.EnergyMeter:
                //response = await ClientFactory.CreateClient("api").PostAsync("energymeter", GetContentForm());
                break;

            case Device.Gateway:
                //response = await ClientFactory.CreateClient("api").PostAsync("gateway", GetContentForm());
                break;

            case Device.WaterMeter:
                //response = await ClientFactory.CreateClient("api").PostAsync("watermeter", GetContentForm());
                break;

            default:
                return;
        }

        if (response == null || !response.IsSuccessStatusCode)
        {
            _errorMessage = response.StatusCode == System.Net.HttpStatusCode.Conflict
            ? "Device already exist."
            : "There was an error adding this device. Please, try again.";
            return;
        }
        else
        {
            _errorMessage = "";
        }

        await OnSuccess.InvokeAsync();

        HttpContent GetContentForm()
        {
            HttpContent httpContent = new StringContent(System.Text.Json.JsonSerializer.Serialize(DeviceFormModel), Encoding.UTF8);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return httpContent;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
namespace __Blazor.DED.Web.Shared.DeviceForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
