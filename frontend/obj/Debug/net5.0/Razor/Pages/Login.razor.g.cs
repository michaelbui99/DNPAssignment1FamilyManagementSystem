#pragma checksum "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9798ca85b307c62d1c44beed48e1f1fade47d0ac"
// <auto-generated/>
#pragma warning disable 1591
namespace DNPAssignment1FamilyManagementSystem.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using DNPAssignment1FamilyManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using DNPAssignment1FamilyManagementSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor.Interop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\Pages\Login.razor"
using DNPAssignment1FamilyManagementSystem.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "login-container");
                __builder2.AddAttribute(4, "b-32nbc844i2");
                __builder2.AddMarkupContent(5, @"<div class=""left-section"" b-32nbc844i2><img src=""images/Asset 880.svg"" alt b-32nbc844i2>
                <h4 b-32nbc844i2>
                    Family Management System
                </h4>
                <p b-32nbc844i2>Keep track of all your families</p></div>
            ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "right-section");
                __builder2.AddAttribute(8, "b-32nbc844i2");
                __builder2.AddMarkupContent(9, "<h3 b-32nbc844i2>Login</h3>\r\n                ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddAttribute(12, "b-32nbc844i2");
                __builder2.AddMarkupContent(13, "<label b-32nbc844i2>Username</label>\r\n                    ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "placeholder", "Username");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\Pages\Login.razor"
                                                                           _username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _username = __value, _username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(19, "b-32nbc844i2");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n\r\n                ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddAttribute(23, "b-32nbc844i2");
                __builder2.AddMarkupContent(24, "<label b-32nbc844i2>Password</label>\r\n                    ");
                __builder2.OpenElement(25, "input");
                __builder2.AddAttribute(26, "type", "password");
                __builder2.AddAttribute(27, "placeholder", "Password");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\Pages\Login.razor"
                                                                               _password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _password = __value, _password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(30, "b-32nbc844i2");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.OpenElement(32, "p");
                __builder2.AddAttribute(33, "id", "error-label");
                __builder2.AddAttribute(34, "b-32nbc844i2");
                __builder2.AddContent(35, 
#nullable restore
#line 29 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\Pages\Login.razor"
                                     _errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                ");
                __builder2.OpenElement(37, "button");
                __builder2.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\Pages\Login.razor"
                                  PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "b-32nbc844i2");
                __builder2.AddContent(40, "Login");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                ");
                __builder2.OpenElement(42, "p");
                __builder2.AddAttribute(43, "class", "create-acc-p");
                __builder2.AddAttribute(44, "b-32nbc844i2");
                __builder2.AddMarkupContent(45, "\r\n                    Not registered yet? ");
                __builder2.OpenElement(46, "span");
                __builder2.AddAttribute(47, "id", "create-account-cta");
                __builder2.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\Pages\Login.razor"
                                                                                OnCreateAccount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "b-32nbc844i2");
                __builder2.AddContent(50, " Create an account");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.OpenElement(52, "p");
                __builder2.AddAttribute(53, "b-32nbc844i2");
                __builder2.OpenElement(54, "span");
                __builder2.AddAttribute(55, "id", "guest-login-cta");
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\Pages\Login.razor"
                                                        LoginAsGuest

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "b-32nbc844i2");
                __builder2.AddContent(58, "Continue As Guest");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\Pages\Login.razor"
       
    private string _username;
    private string _password;
    private string _errorMessage;

    [CascadingParameter]
    protected Task<AuthenticationState> AuthStat { get; set; }

    protected override async Task OnInitializedAsync()
    {
    //Redirects the user to index if user is already logged in.
       
        var user = (await AuthStat).User;
        if (user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo("/");
        }
    }

    private async void PerformLogin()
    {
        _errorMessage = "";
        try
        {
          await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(_username, _password);
            _username = "";
            _password = "";
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            Console.WriteLine($"{this} {nameof(PerformLogin)} caught exception");
            _errorMessage = e.Message; 
            StateHasChanged();
        }
    }

    private void OnCreateAccount()
    {
        NavigationManager.NavigateTo("/SignUp");
    }

    private async void LoginAsGuest()
    {
       await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin("Guest", "Guest123");
        NavigationManager.NavigateTo("/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
