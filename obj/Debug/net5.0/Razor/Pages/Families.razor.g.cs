#pragma checksum "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "431c55c4a7786a6789fbed317a361048d9e57304"
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
#line 1 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using DNPAssignment1FamilyManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using DNPAssignment1FamilyManagementSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
using DNPAssignment1FamilyManagementSystem.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Families")]
    public partial class Families : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "families-container");
                __builder2.AddAttribute(4, "b-2chmzdkc7s");
                __builder2.AddMarkupContent(5, @"<div class=""families-container__header"" b-2chmzdkc7s><h3 b-2chmzdkc7s>Families</h3>

                <div class=""icon-wrapper"" b-2chmzdkc7s><i class=""fas fa-search"" b-2chmzdkc7s></i></div>
                <input type=""text"" placeholder=""Search by name"" b-2chmzdkc7s></div>");
#nullable restore
#line 18 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
             if (_families is null)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(6, "<p b-2chmzdkc7s><em b-2chmzdkc7s>Loading...</em></p>");
#nullable restore
#line 23 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
            }
            else if (!_families.Any())
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(7, "<p b-2chmzdkc7s><em b-2chmzdkc7s>No Families has been created yet.</em></p>");
#nullable restore
#line 29 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(8, "table");
                __builder2.AddAttribute(9, "class", "table");
                __builder2.AddAttribute(10, "b-2chmzdkc7s");
                __builder2.AddMarkupContent(11, @"<thead b-2chmzdkc7s><tr b-2chmzdkc7s><th b-2chmzdkc7s></th>
                        <th b-2chmzdkc7s>Street Name</th>
                        <th b-2chmzdkc7s>House No</th>
                        <th b-2chmzdkc7s>Member Count</th>
                        <th b-2chmzdkc7s>Delete</th></tr></thead>
                    ");
                __builder2.OpenElement(12, "tbody");
                __builder2.AddAttribute(13, "b-2chmzdkc7s");
#nullable restore
#line 43 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                     foreach (var f in _families)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<DNPAssignment1FamilyManagementSystem.Pages.ExpandableFamilyTableRow>(14);
                __builder2.AddAttribute(15, "Family", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Models.Family>(
#nullable restore
#line 45 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                                                          f

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(17, "tr");
                    __builder3.AddAttribute(18, "b-2chmzdkc7s");
                    __builder3.OpenElement(19, "td");
                    __builder3.AddAttribute(20, "colspan", "4");
                    __builder3.AddAttribute(21, "b-2chmzdkc7s");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "content-container");
                    __builder3.AddAttribute(24, "b-2chmzdkc7s");
                    __builder3.OpenElement(25, "div");
                    __builder3.AddAttribute(26, "class", "adults-container");
                    __builder3.AddAttribute(27, "b-2chmzdkc7s");
                    __builder3.AddMarkupContent(28, "<h4 b-2chmzdkc7s>Adults:</h4>");
#nullable restore
#line 51 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                                             foreach (var a in f.Adults)
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<DNPAssignment1FamilyManagementSystem.Pages.PersonInfomation>(29);
                    __builder3.AddAttribute(30, "Person", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Models.Person>(
#nullable restore
#line 53 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                                                                          a

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n                                                ");
                    __builder3.OpenElement(32, "p");
                    __builder3.AddAttribute(33, "b-2chmzdkc7s");
                    __builder3.AddContent(34, "Job: ");
                    __builder3.AddContent(35, 
#nullable restore
#line 54 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                                                         a.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(36, "\r\n                                                ");
                    __builder3.OpenElement(37, "p");
                    __builder3.AddAttribute(38, "b-2chmzdkc7s");
                    __builder3.AddContent(39, "Salary: ");
                    __builder3.AddContent(40, 
#nullable restore
#line 55 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                                                            a.JobTitle.Salary

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\r\n                                                <br b-2chmzdkc7s>");
#nullable restore
#line 57 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                                            }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 63 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 66 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
       
    private IList<Family> _families;

    [CascadingParameter]
    protected Task<AuthenticationState> AuthStat { get; set; }


    protected override async Task OnInitializedAsync()
    {
        base.OnInitialized();
        var user = (await AuthStat).User;
        if (!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo("/Login");
        }
        else
        {
            _families = FamilyService.GetFamilies();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
