// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
                response = await ClientFactory.CreateClient("api").PostAsync("energymeter", GetContentForm());
                break;

            case Device.Gateway:
                response = await ClientFactory.CreateClient("api").PostAsync("gateway", GetContentForm());
                break;

            case Device.WaterMeter:
                response = await ClientFactory.CreateClient("api").PostAsync("watermeter", GetContentForm());
                break;

            default:
                return;
        }

        if (response == null || !response.IsSuccessStatusCode)
        {
            _errorMessage = (response?.StatusCode ?? System.Net.HttpStatusCode.InternalServerError) == System.Net.HttpStatusCode.Conflict
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
#pragma warning restore 1591
