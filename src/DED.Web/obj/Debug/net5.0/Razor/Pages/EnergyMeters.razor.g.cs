#pragma checksum "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a92be1ade1c7a939a6050f76e872594063dfcc76"
// <auto-generated/>
#pragma warning disable 1591
namespace DED.Web.Pages
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
#line 2 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
using DED.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
using DED.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/energymeters")]
    public partial class EnergyMeters : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>EnergyMeters</h1>");
#nullable restore
#line 11 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
 if (_showForm)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<DED.Web.Shared.DeviceForm>(1);
            __builder.AddAttribute(2, "DeviceToAdd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DED.Web.Shared.DeviceForm.Device>(
#nullable restore
#line 13 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
                             DeviceForm.Device.EnergyMeter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "DeviceFormModel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DED.Web.Models.DeviceModel>(
#nullable restore
#line 13 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
                                                                             _deviceModelForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnHide", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 13 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
                                                                                                       () => { _showForm = false; StateHasChanged(); }

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "OnSuccess", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 13 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
                                                                                                                                                                   FormSubmited

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 14 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "d-flex justify-content-end");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "class", "btn btn-primary");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
                                                                () => { _showForm = true; StateHasChanged(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Add");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "d-flex mt-3");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table");
            __builder.AddMarkupContent(17, "<thead><tr><th scope=\"col\">Id</th>\r\n                <th scope=\"col\">Serial Number</th>\r\n                <th scope=\"col\">Brand</th>\r\n                <th scope=\"col\">Model</th></tr></thead>\r\n        ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 32 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
             foreach (var energyMeter in _energyMeters)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.AddAttribute(21, "scope", "row");
            __builder.AddContent(22, 
#nullable restore
#line 35 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
                                     energyMeter.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 36 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
                         energyMeter.SerialNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 37 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
                         energyMeter.Brand

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 38 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
                         energyMeter.Model

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\EnergyMeters.razor"
 
    private List<DeviceModel> _energyMeters = new();
    private bool _showForm = false;
    private DeviceModel _deviceModelForm = new DeviceModel();
    private Timer _timer = new Timer();

    protected override async Task OnInitializedAsync()
    {
        _energyMeters = await ClientFactory.CreateClient("api").GetFromJsonAsync<List<DeviceModel>>("energymeter");
        _timer.Interval = 3000;
        _timer.Elapsed += PoolingData;
        _timer.Start();
    }

    private void PoolingData(object sender, ElapsedEventArgs e)
    {
        InvokeAsync(async () =>
        {
            _energyMeters = await ClientFactory.CreateClient("api").GetFromJsonAsync<List<DeviceModel>>("energymeter");
            StateHasChanged();
        });
    }

    private void FormSubmited()
    {
        _energyMeters.Add(_deviceModelForm);
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
#pragma warning restore 1591
