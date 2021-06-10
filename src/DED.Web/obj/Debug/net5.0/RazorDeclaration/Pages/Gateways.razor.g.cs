// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\Gateways.razor"
using DED.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\Gateways.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\Gateways.razor"
using DED.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\Gateways.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/gateways")]
    public partial class Gateways : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\SISTEMAS_27\source\DED\src\DED.Web\Pages\Gateways.razor"
 
    private List<DeviceModel> _gateways = new();
    private bool _showForm = false;
    private DeviceModel _deviceModelForm = new DeviceModel();
    private Timer _timer = new Timer();

    protected override async Task OnInitializedAsync()
    {
        _gateways = await ClientFactory.CreateClient("api").GetFromJsonAsync<List<DeviceModel>>("gateway");
        _timer.Interval = 3000;
        _timer.Elapsed += PoolingData;
        _timer.Start();
    }

    private void PoolingData(object sender, ElapsedEventArgs e)
    {
        InvokeAsync(async () =>
        {
            _gateways = await ClientFactory.CreateClient("api").GetFromJsonAsync<List<DeviceModel>>("gateway");
            StateHasChanged();
        });
    }

    private void FormSubmited()
    {
        _gateways.Add(_deviceModelForm);
        StateHasChanged();
    }

    public void Dispose()
    {
        _timer.Elapsed -= PoolingData;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
#pragma warning restore 1591
