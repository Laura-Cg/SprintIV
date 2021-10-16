#pragma checksum "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\MovieComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "667683dcceae5ee4f43671dc4fd80f1c4352057b"
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
    public partial class MovieComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "margin-right: 2%; margin-bottom: 10px; text-aling: center;");
            __builder.OpenElement(2, "a");
            __builder.OpenElement(3, "img");
            __builder.AddAttribute(4, "src", 
#nullable restore
#line 3 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\MovieComponent.razor"
                   Movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "alt", "Lo sentimos, no se pudo mostrar la imagen.");
            __builder.AddAttribute(6, "width", "225px");
            __builder.AddAttribute(7, "height", "300px");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "href", 
#nullable restore
#line 4 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\MovieComponent.razor"
                  urlMovie

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, 
#nullable restore
#line 4 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\MovieComponent.razor"
                             Movie.MovieName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "p");
            __builder.AddAttribute(14, "style", "max-width: 225px; height: 44px: font-size: 15px; font-weight:bold;");
            __builder.AddContent(15, 
#nullable restore
#line 7 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\MovieComponent.razor"
         Movie.MovieName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddMarkupContent(18, "<a class=\"btn btn-info\"></a>\r\n        ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "type", "button");
            __builder.AddAttribute(21, "class", "btn btn-danger");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\MovieComponent.razor"
                                                                   ()=>DeleteMovie.InvokeAsync(Movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "\r\n            Eliminar\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\MovieComponent.razor"
      
    [Parameter] public Movie Movie{get;set;}
    [Parameter] public EventCallback<Movie> DeleteMovie{get;set;}

    private string urlMovie = string.Empty;
    protected override void OnInitialized(){
        urlMovie = $"movie/";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
