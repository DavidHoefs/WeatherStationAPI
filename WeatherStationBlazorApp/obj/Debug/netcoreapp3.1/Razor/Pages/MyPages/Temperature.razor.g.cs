#pragma checksum "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\Temperature.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3005177a21d0695304cecdfb19362d0d9d386a5"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\Temperature.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\Temperature.razor"
using DataAccessLibrary.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\Temperature.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\Temperature.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/Temp")]
    public partial class Temperature : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Temperature Page</h1>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<thead>\r\n        <tr>\r\n            <th>Temperature</th>\r\n            <th>TimeCaptured</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 18 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\Temperature.razor"
         foreach (var temp in temps)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 21 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\Temperature.razor"
                     temp.Temperature

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 22 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\Temperature.razor"
                     temp.TimeCaptured

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 24 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\Temperature.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenComponent<Blazorise.Button>(20);
            __builder.AddAttribute(21, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 28 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\Temperature.razor"
                   async () => await HandleRedraw()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(23, "Redraw");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.OpenComponent<Blazorise.Charts.LineChart<double>>(25);
            __builder.AddComponentReferenceCapture(26, (__value) => {
#nullable restore
#line 30 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\Temperature.razor"
                 lineChart = (Blazorise.Charts.LineChart<double>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.OpenComponent<Blazorise.Charts.BarChart<double>>(28);
            __builder.AddComponentReferenceCapture(29, (__value) => {
#nullable restore
#line 31 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\Temperature.razor"
                barChart = (Blazorise.Charts.BarChart<double>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\hoefs\source\repos\WeatherStationAPI\WeatherStationBlazorApp\Pages\MyPages\Temperature.razor"
      
    private List<TemperatureSensorModel> temps;
    protected override async Task OnInitializedAsync()
    {
        temps = _db.GetData();
    }

    LineChart<double> lineChart;
    BarChart<double> barChart;
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await HandleRedraw();
        }
    }

    async Task HandleRedraw()
    {
        await lineChart.Clear();

        await lineChart.AddLabelsDatasetsAndUpdate(GetLabels(temps), GetLineChartDataset());
        await barChart.Clear();
        await barChart.AddLabelsDatasetsAndUpdate(GetLabels(temps), GetBarChartDataset());
    }

    BarChartDataset<double> GetBarChartDataset()
    {
        return new BarChartDataset<double>
        {
            Label = "Temperature",
            Data = GetTempData(temps),
            BackgroundColor = backgroundColors,
            BorderColor = borderColors,

        };

    }
    LineChartDataset<double> GetLineChartDataset()
    {
        return new LineChartDataset<double>
        {
            Label = "Temperature",
            Data = GetTempData(temps),
            BackgroundColor = backgroundColors,
            BorderColor = borderColors,
            Fill = true,
            PointRadius = 2,
            BorderDash = new List<int> { }
        };
    }

    string[] Labels = { "Red", "Blue", "Yellow", "Green", "Purple", "Orange" };
    List<string> backgroundColors = new List<string> { ChartColor.FromRgba(255, 99, 132, 0.2f), ChartColor.FromRgba(54, 162, 235, 0.2f), ChartColor.FromRgba(255, 206, 86, 0.2f), ChartColor.FromRgba(75, 192, 192, 0.2f), ChartColor.FromRgba(153, 102, 255, 0.2f), ChartColor.FromRgba(255, 159, 64, 0.2f) };
    List<string> borderColors = new List<string> { ChartColor.FromRgba(255, 99, 132, 1f), ChartColor.FromRgba(54, 162, 235, 1f), ChartColor.FromRgba(255, 206, 86, 1f), ChartColor.FromRgba(75, 192, 192, 1f), ChartColor.FromRgba(153, 102, 255, 1f), ChartColor.FromRgba(255, 159, 64, 1f) };

    List<double> RandomizeData()
    {
        var r = new Random(DateTime.Now.Millisecond);

        return new List<double> { r.Next(3, 50) * r.NextDouble(), r.Next(3, 50) * r.NextDouble(), r.Next(3, 50) * r.NextDouble(), r.Next(3, 50) * r.NextDouble(), r.Next(3, 50) * r.NextDouble(), r.Next(3, 50) * r.NextDouble() };
    }
    List<double> GetTempData(List<TemperatureSensorModel> temps)
    {
        List<double> ts = new List<double>();
        foreach (var t in temps)
        {
            ts.Add(t.Temperature);
        }
        return ts;

    }
    string[] GetLabels(List<TemperatureSensorModel> temps)
    {
        string[] output = new string[temps.Count];
        for (int i = 0; i < temps.Count; i++)
        {
            output[i] = temps[i].TimeCaptured.ToString();
        }
        return output;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITemperatureData _db { get; set; }
    }
}
#pragma warning restore 1591
