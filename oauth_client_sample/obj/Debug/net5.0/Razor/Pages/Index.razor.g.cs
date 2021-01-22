#pragma checksum "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ffc50a368b3ad0d81a3100bcd21d4353a442315"
// <auto-generated/>
#pragma warning disable 1591
namespace oauth_client_sample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/_Imports.razor"
using oauth_client_sample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/_Imports.razor"
using oauth_client_sample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/Pages/Index.razor"
using Define;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/Pages/Index.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/Pages/Index.razor"
using Microsoft.AspNetCore.Mvc.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/Pages/Index.razor"
using oauth_client_sample.util;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\n\nWelcome to your new app. <br>\n\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/Pages/Index.razor"
                                          RedirectAuthorize

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Authorize");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n\n<br>");
#nullable restore
#line 16 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/Pages/Index.razor"
 if (_tokenInfo != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Token : ");
            __builder.AddContent(8, 
#nullable restore
#line 18 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/Pages/Index.razor"
                _tokenInfo.AccessToken

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/Pages/Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "<br>");
#nullable restore
#line 21 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/Pages/Index.razor"
 if (_user != null)
{   

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "p");
            __builder.AddContent(11, "ID : ");
            __builder.AddContent(12, 
#nullable restore
#line 23 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/Pages/Index.razor"
             _user.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.OpenElement(14, "p");
            __builder.AddContent(15, "Name : ");
            __builder.AddContent(16, 
#nullable restore
#line 24 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/Pages/Index.razor"
               _user.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n    ");
            __builder.OpenElement(18, "p");
            __builder.AddContent(19, "Email : ");
            __builder.AddContent(20, 
#nullable restore
#line 25 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/Pages/Index.razor"
                _user.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 26 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/Pages/Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "/Users/brian/Downloads/oauth_client_sample/oauth_client_sample/Pages/Index.razor"
       
    AccessTokenInfo _tokenInfo;
    User _user;
    
    private void RedirectAuthorize()
    {
        var url = Define.GetAuthorizeUrl();
        NavManager.NavigateTo(url);
    }

    protected override void OnInitialized()
    {
        _tokenInfo = TokenInstance.Instance.GetToken();
        if (_tokenInfo != null && _tokenInfo.AccessToken != "")
        {
            this._user = HttpSupport.SendHttp<User>(Define.GetUserInfoUrl(), "GET", "", _tokenInfo.AccessToken, "user");
        }
        
        base.OnInitialized();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
