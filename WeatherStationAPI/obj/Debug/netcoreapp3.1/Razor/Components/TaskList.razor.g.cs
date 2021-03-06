#pragma checksum "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\Components\TaskList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dd94194a110e9ebb7d48616d361908a321d0200"
// <auto-generated/>
#pragma warning disable 1591
namespace WeatherStationAPI.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using WeatherStationAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using WeatherStationAPI.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using WeatherStationAPI.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\_Imports.razor"
using WeatherStationAPI.Library.Models;

#line default
#line hidden
#nullable disable
    public partial class TaskList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TaskList</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\Components\TaskList.razor"
                  newTask

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\Components\TaskList.razor"
                                          AddTask

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(6);
                __builder2.AddAttribute(7, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\Components\TaskList.razor"
                            newTask.Task

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTask.Task = __value, newTask.Task))));
                __builder2.AddAttribute(9, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newTask.Task));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.AddMarkupContent(11, "<button type=\"submit\">Add Task</button>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenElement(13, "ul");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 9 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\Components\TaskList.razor"
     foreach(var task in taskModels)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "        ");
            __builder.OpenElement(16, "li");
            __builder.AddContent(17, 
#nullable restore
#line 11 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\Components\TaskList.razor"
             task.Task

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 12 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\Components\TaskList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\WeatherStationAPIRepo\WeatherStationAPI\WeatherStationAPI\Components\TaskList.razor"
       
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
