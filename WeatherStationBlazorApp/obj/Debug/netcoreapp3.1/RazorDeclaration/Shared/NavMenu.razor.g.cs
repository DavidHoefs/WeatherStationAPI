#pragma checksum "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fa09fa144b65b38b2b04456bf191c61363cf067"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WeatherStationBlazorApp.Shared
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
#line 10 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\_Imports.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\_Imports.razor"
using DataAccessLibrary.Models;

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
#line 13 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591