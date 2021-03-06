#pragma checksum "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf665623532567fa7190bc821f4f957ebbf3c612"
// <auto-generated/>
#pragma warning disable 1591
namespace ProySprintIII.Client.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProysCicloIII\ProySprintIII\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\ProySprintIII\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\ProySprintIII\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\ProySprintIII\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProysCicloIII\ProySprintIII\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProysCicloIII\ProySprintIII\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProysCicloIII\ProySprintIII\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProysCicloIII\ProySprintIII\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProysCicloIII\ProySprintIII\Client\_Imports.razor"
using ProySprintIII.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProysCicloIII\ProySprintIII\Client\_Imports.razor"
using ProySprintIII.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProysCicloIII\ProySprintIII\Client\_Imports.razor"
using ProySprintIII.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\ProysCicloIII\ProySprintIII\Client\_Imports.razor"
using ProySprintIII.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor"
using ProySprintIII.Client.Model;

#line default
#line hidden
#nullable disable
    public partial class SelectorMultiple : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style type=""text/css"">
    .selector-multiple {
        display: flex;
    }
    .selectable-ul {
        height: 200px;
        overflow-y: auto;
        list-style-type: none;
        width: 170px;
        padding: 0;
        border-radius: 10px;
        border: 1px solid #ccc;
    }
    .selectable-ul li {
        cursor: pointer;
        border-bottom: 1px #eee solid;
        padding: 2px 10px;
        font-size: 14px;
    }
    .selectable-ul li:hover {
        background-color: #969992;
    }
    .selector-multiple-botones {
        display: flex;
        border-radius: 10px;
        flex-direction: column;
        justify-content: center;
        padding: 5px;
    }
    .selector-multiple-botones button {
        margin: 5px;
    }
    .selector-multiple-botones button:hover {
        background-color: #969992;
    }
</style>
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "selector-multiple");
            __builder.OpenElement(5, "ul");
            __builder.AddAttribute(6, "class", "selectable-ul");
#nullable restore
#line 42 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor"
             foreach (var item in NoSeleccionados)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor"
                                () => Seleccionar(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, 
#nullable restore
#line 44 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor"
                                                           item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 45 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "selector-multiple-botones");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor"
                                            SeleccionarTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, 
#nullable restore
#line 49 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor"
                                                              pasarTodoTexto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor"
                                            DeseleccionarTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, 
#nullable restore
#line 50 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor"
                                                                removerTodoTexto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "ul");
            __builder.AddAttribute(24, "class", "selectable-ul");
#nullable restore
#line 54 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor"
             foreach (var item in Seleccionados)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor"
                                () => Deseleccionar(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, 
#nullable restore
#line 56 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor"
                                                             item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 57 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor"
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
#line 61 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor"
       
    private string removerTodoTexto = "<<";
    private string pasarTodoTexto = ">>";

    [Parameter]
    public List<SelectorMultipleModel> NoSeleccionados { get; set; }
    = new List<SelectorMultipleModel>();

    [Parameter]
    public List<SelectorMultipleModel> Seleccionados { get; set; }
    = new List<SelectorMultipleModel>();

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor"
                                                                            
    private void Seleccionar(SelectorMultipleModel item)
    {
        NoSeleccionados.Remove(item);
        Seleccionados.Add(item);
    }
    private void Deseleccionar(SelectorMultipleModel item)
    {
        Seleccionados.Remove(item);
        NoSeleccionados.Add(item);
    }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\SelectorMultiple.razor"
                                                                 
    private void SeleccionarTodo()
    {
        Seleccionados.AddRange(NoSeleccionados);
        NoSeleccionados.Clear();
    }
    private void DeseleccionarTodo()
    {
        NoSeleccionados.AddRange(Seleccionados);
        Seleccionados.Clear();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
