// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProySprintIII.Client.Pages.Components
{
    #line hidden
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
#line 1 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\CustomTypeaHead.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\CustomTypeaHead.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\CustomTypeaHead.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\CustomTypeaHead.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\CustomTypeaHead.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    public partial class CustomTypeaHead<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 266 "C:\ProysCicloIII\ProySprintIII\Client\Pages\Components\CustomTypeaHead.razor"
          
        [Parameter] public string Placeholder { get; set; }
        [Parameter] public TItem Value { get; set; }
        [Parameter] public EventCallback<TItem> ValueChanged { get; set; }
        [Parameter] public Func<string, Task<IEnumerable<TItem>>>
        SearchMethod { get; set; }
        [Parameter] public RenderFragment NotFoundTemplate { get; set; }
        [Parameter] public RenderFragment<TItem> ResultTemplate { get; set; }
        [Parameter] public RenderFragment<TItem> SelectedTemplate { get; set;}
        [Parameter] public RenderFragment FooterTemplate { get; set; }
        [Parameter] public int MinimumLength { get; set; } = 1;
        [Parameter] public int Debounce { get; set; } = 300;
        [Parameter] public int MaximumSuggestions { get; set; } = 25;
        [Parameter] public bool DisplayClear { get; set; } = true;
        protected bool IsSearching { get; private set; } = false;
        protected bool IsShowingSuggestions { get; private set; } = false;
        protected bool IsShowingSearchbar { get; private set; } = true;
        protected bool IsShowingMask { get; private set; } = false;
        protected TItem[] Suggestions { get; set; } = new TItem[0];
        protected string SearchText
        {
        get => _searchText;
        set
        {
        _searchText = value;
        if (value.Length == 0)
        {
        _debounceTimer.Stop();
        Suggestions = new TItem[0];
        }
        else if (value.Length >= MinimumLength)
        {
        _debounceTimer.Stop();
        _debounceTimer.Start();
        }
        }
        }
        protected ElementReference searchInput;
        protected ElementReference typeahead;
        private Timer _debounceTimer;
        private string _searchText = string.Empty;
        protected override void OnInitialized()
        {
        if (SearchMethod == null)
        {
        throw new InvalidOperationException ($"{GetType()} requires a {nameof(SearchMethod)} parameter.");

        }
        if (ResultTemplate == null)
        {
        throw new InvalidOperationException($"{GetType()} requires a{nameof(ResultTemplate)} parameter.");

        }
        _debounceTimer = new Timer();
        _debounceTimer.Interval = Debounce;
        _debounceTimer.AutoReset = false;
        _debounceTimer.Elapsed += Search;
        Initialize();
        }
        protected override void OnParametersSet()
        {
        Initialize();
        }
        private void Initialize()
        {
        IsShowingSuggestions = false;
        if (Value == null)
        {
        IsShowingMask = false;
        IsShowingSearchbar = true;
        }
        else
        {
        IsShowingSearchbar = false;
        IsShowingMask = true;
        }
        }
        protected void HandleClickOnMask()
        {
        IsShowingMask = false;
        IsShowingSearchbar = true;
        }
        protected async Task ShowMaximumSuggestions()
        {
        IsShowingSuggestions = !IsShowingSuggestions;
        if (IsShowingSuggestions)
        {
        SearchText = "";
        IsSearching = true;
        await InvokeAsync(StateHasChanged);
        Suggestions = (await

        SearchMethod?.Invoke(_searchText)).Take(MaximumSuggestions).ToArray();

        IsSearching = false;
        await InvokeAsync(StateHasChanged);
        }
        }
        protected void ShowSuggestions()
        {
        if (Suggestions.Any())
        {
        IsShowingSuggestions = true;
        }
        }
        protected async Task HandleKeyUpOnSuggestion(KeyboardEventArgs args,
        TItem item)
        {
        // Maybe on any key except Tab and Enter, continue the typing option.

        switch (args.Key)
        {
        case "Enter":
        await SelectResult(item);
        break;
        case "Escape":
        case "Backspace":
        case "Delete":
        Initialize();
        break;
        default:
        break;
        }
        }
        protected async Task HandleKeyUpOnShowMaximum(KeyboardEventArgs args)
        {
        if (args.Key == "Enter")
        await ShowMaximumSuggestions();
        }
        protected string GetSelectedSuggestionClass(TItem item)
        {
        if (Value == null)
        return null;
        if (Value.Equals(item))
        return "blazored-typeahead__result-selected";
        return null;
        }
        protected async void Search(Object source, ElapsedEventArgs e)
        {
        IsSearching = true;
        await InvokeAsync(StateHasChanged);
        Suggestions = (await

        SearchMethod?.Invoke(_searchText)).Take(MaximumSuggestions).ToArray();

        IsSearching = false;
        IsShowingSuggestions = true;
        await InvokeAsync(StateHasChanged);
        }
        protected async Task SelectResult(TItem item)
        {
        SearchText = "";
        await ValueChanged.InvokeAsync(item);
        }
        protected bool ShouldShowSuggestions()
        {
        return IsShowingSuggestions &&
        Suggestions.Any();

        }
        private bool HasValidSearch => !string.IsNullOrWhiteSpace(SearchText)
        && SearchText.Length >= MinimumLength;
        private bool IsSearchingOrDebouncing => IsSearching ||
        _debounceTimer.Enabled;
        protected bool ShowNotFound()
        {
        return IsShowingSuggestions &&
        HasValidSearch &&
        !IsSearchingOrDebouncing &&
        !Suggestions.Any();

        }
        protected void OnFocusOut(object sender, EventArgs e)
        {
        Initialize();
        InvokeAsync(StateHasChanged);
        }
        protected void OnEscape(object sender, EventArgs e)
        {
        Initialize();
        InvokeAsync(StateHasChanged);
        }
        public void Dispose()
        {
        _debounceTimer.Dispose();
        }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
