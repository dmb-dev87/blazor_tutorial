// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServerCRUD.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "e:\blazor_blazor-tutorial\BlazorServerCRUD\BlazorServerCRUD.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "e:\blazor_blazor-tutorial\BlazorServerCRUD\BlazorServerCRUD.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "e:\blazor_blazor-tutorial\BlazorServerCRUD\BlazorServerCRUD.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "e:\blazor_blazor-tutorial\BlazorServerCRUD\BlazorServerCRUD.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "e:\blazor_blazor-tutorial\BlazorServerCRUD\BlazorServerCRUD.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "e:\blazor_blazor-tutorial\BlazorServerCRUD\BlazorServerCRUD.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "e:\blazor_blazor-tutorial\BlazorServerCRUD\BlazorServerCRUD.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "e:\blazor_blazor-tutorial\BlazorServerCRUD\BlazorServerCRUD.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "e:\blazor_blazor-tutorial\BlazorServerCRUD\BlazorServerCRUD.Web\_Imports.razor"
using BlazorServerCRUD.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "e:\blazor_blazor-tutorial\BlazorServerCRUD\BlazorServerCRUD.Web\_Imports.razor"
using BlazorServerCRUD.Web.Shared;

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
#line 28 "e:\blazor_blazor-tutorial\BlazorServerCRUD\BlazorServerCRUD.Web\Shared\NavMenu.razor"
       
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
