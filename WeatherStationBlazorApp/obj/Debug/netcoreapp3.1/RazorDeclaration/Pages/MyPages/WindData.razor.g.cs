#pragma checksum "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\WindData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c564bd78b8615fd8a65b4398062056575f9450e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WeatherStationBlazorApp.Pages.MyPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\_Imports.razor"
using WeatherStationBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\_Imports.razor"
using WeatherStationBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\WindData.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\WindData.razor"
using DataAccessLibrary.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\WindData.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\WindData.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/Wind")]
    public partial class WindData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\WindData.razor"
       
    private List<WindDataModel> wind;
    protected override async Task OnInitializedAsync()
    {
        wind = _db.GetAllData();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWindData _db { get; set; }
    }
}
#pragma warning restore 1591