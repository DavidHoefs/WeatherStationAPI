#pragma checksum "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationAPI\Components\TaskList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dd94194a110e9ebb7d48616d361908a321d0200"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WeatherStationAPI.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using WeatherStationAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using WeatherStationAPI.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using WeatherStationAPI.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using WeatherStationAPI.Library.Models;

#line default
#line hidden
#nullable disable
    public partial class TaskList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationAPI\Components\TaskList.razor"
       
    public List<TaskModel> taskModels = new List<TaskModel>();
    private TaskModel newTask = new TaskModel();

    private void AddTask()
    {
        taskModels.Add(newTask);
        newTask = new TaskModel();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591