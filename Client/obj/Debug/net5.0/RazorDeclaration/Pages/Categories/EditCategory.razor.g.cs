// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProySprintIII.Client.Pages.Categories
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
#line 2 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Categories\EditCategory.razor"
using ProySprintIII.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories/edit/{Id:int}")]
    public partial class EditCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Categories\EditCategory.razor"
      
    [Parameter] public int Id {get;set;}
    private Category Category;

    protected override void OnInitialized(){
        Category = new Category(){
            Id = Id, Name="Comedia"};
    }
    private void Edit(){
        Console.WriteLine($"Id: {Category.Id}");
        Console.WriteLine($"Id: {Category.Name}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
