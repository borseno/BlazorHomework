#pragma checksum "C:\Users\v-vmark\source\repos\Delivery1\Pages\Albums.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "607c8ac0fc84e41ffc44ff5cc14d3a85839016b6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Delivery1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\v-vmark\source\repos\Delivery1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\v-vmark\source\repos\Delivery1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\v-vmark\source\repos\Delivery1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\v-vmark\source\repos\Delivery1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\v-vmark\source\repos\Delivery1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\v-vmark\source\repos\Delivery1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\v-vmark\source\repos\Delivery1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\v-vmark\source\repos\Delivery1\_Imports.razor"
using Delivery1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\v-vmark\source\repos\Delivery1\_Imports.razor"
using Delivery1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\v-vmark\source\repos\Delivery1\_Imports.razor"
using Delivery1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\v-vmark\source\repos\Delivery1\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\v-vmark\source\repos\Delivery1\_Imports.razor"
using Delivery1.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\v-vmark\source\repos\Delivery1\_Imports.razor"
using Delivery1.HttpClients;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Albums : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\v-vmark\source\repos\Delivery1\Pages\Albums.razor"
       
    private IEnumerable<Album> albums = new List<Album>();
    private IEnumerable<Photo> photos = new List<Photo>();
    private List<Comment> comments = new List<Comment>();
    private CurrentState currentState = new CurrentState();

    private void ExpandComments(int photoId) => comments.AddRange(client.GetComments(photoId));

    private void HideComments(int photoId) => comments.RemoveAll(i => i.PostId == photoId);

    private void AlbumsSubmit()
    {
        photos = client.GetPhotos(currentState);
    }

    private void OnSubmit()
    {
        albums = client.GetAlbums(currentState);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AClient client { get; set; }
    }
}
#pragma warning restore 1591
