#pragma checksum "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc5173570e030c73e97f20087bb35aa2baeecb5f"
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
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "families-container__header");
                __builder2.AddAttribute(7, "b-2chmzdkc7s");
                __builder2.AddMarkupContent(8, "<h3 b-2chmzdkc7s>Families</h3>\r\n\r\n                ");
                __builder2.AddMarkupContent(9, "<div class=\"icon-wrapper\" b-2chmzdkc7s><i class=\"fas fa-search\" b-2chmzdkc7s></i></div>\r\n                ");
                __builder2.OpenElement(10, "input");
                __builder2.AddAttribute(11, "type", "text");
                __builder2.AddAttribute(12, "placeholder", "Search by name");
                __builder2.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                                                                          (args) => FilterAdultsByName(args)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "b-2chmzdkc7s");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 18 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
             if (_familiesToShow is null)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(15, "<p b-2chmzdkc7s><em b-2chmzdkc7s>Loading...</em></p>");
#nullable restore
#line 23 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
            }
            else if (!_familiesToShow.Any())
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(16, "<p b-2chmzdkc7s><em b-2chmzdkc7s>No Families has been created yet.</em></p>");
#nullable restore
#line 29 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(17, "table");
                __builder2.AddAttribute(18, "class", "table");
                __builder2.AddAttribute(19, "b-2chmzdkc7s");
                __builder2.AddMarkupContent(20, @"<thead b-2chmzdkc7s><tr b-2chmzdkc7s><th b-2chmzdkc7s></th>
                        <th b-2chmzdkc7s>Street Name</th>
                        <th b-2chmzdkc7s>House No</th>
                        <th b-2chmzdkc7s>Member Count</th>
                        <th b-2chmzdkc7s>Delete</th></tr></thead>
                    ");
                __builder2.OpenElement(21, "tbody");
                __builder2.AddAttribute(22, "b-2chmzdkc7s");
#nullable restore
#line 43 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                     foreach (var f in _familiesToShow)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<DNPAssignment1FamilyManagementSystem.Pages.ExpandableFamilyTableRow>(23);
                __builder2.AddAttribute(24, "Family", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Models.Family>(
#nullable restore
#line 45 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                                                          f

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(26, "tr");
                    __builder3.AddAttribute(27, "b-2chmzdkc7s");
                    __builder3.OpenElement(28, "td");
                    __builder3.AddAttribute(29, "colspan", "4");
                    __builder3.AddAttribute(30, "b-2chmzdkc7s");
                    __builder3.OpenElement(31, "div");
                    __builder3.AddAttribute(32, "class", "content-container");
                    __builder3.AddAttribute(33, "b-2chmzdkc7s");
                    __builder3.OpenElement(34, "div");
                    __builder3.AddAttribute(35, "class", "adults-container");
                    __builder3.AddAttribute(36, "b-2chmzdkc7s");
                    __builder3.AddMarkupContent(37, "<h4 b-2chmzdkc7s>Adults:</h4>");
#nullable restore
#line 51 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                                             foreach (var a in f.Adults)
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<DNPAssignment1FamilyManagementSystem.Pages.PersonInfomation>(38);
                    __builder3.AddAttribute(39, "Person", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Models.Person>(
#nullable restore
#line 53 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                                                                          a

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\r\n                                                ");
                    __builder3.OpenElement(41, "p");
                    __builder3.AddAttribute(42, "b-2chmzdkc7s");
                    __builder3.AddContent(43, "Job: ");
                    __builder3.AddContent(44, 
#nullable restore
#line 54 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                                                         a.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\r\n                                                ");
                    __builder3.OpenElement(46, "p");
                    __builder3.AddAttribute(47, "b-2chmzdkc7s");
                    __builder3.AddContent(48, "Salary: ");
                    __builder3.AddContent(49, 
#nullable restore
#line 55 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                                                            a.JobTitle.Salary

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\r\n                                                <br b-2chmzdkc7s>");
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
       
    private IList<Family> _familiesToShow;
    private IList<Family> _allFamilies;

    private string _filterAdultByName;

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
            _allFamilies = FamilyService.GetFamilies();
            _familiesToShow = _allFamilies;
        }
    }

    private void FilterAdultsByName(ChangeEventArgs args)
    {
        _filterAdultByName = null;
        _filterAdultByName = args.Value.ToString();
        Console.WriteLine(_filterAdultByName);


        if (_filterAdultByName != null)
        {
            List<Family> familiesWithAdultsWithNameMatch = new List<Family>();

            foreach (var family in _allFamilies)
            {
                bool adultWithNameMatchFound = false;
                foreach (var adult in family.Adults)
                {
                    if ($"{adult.FirstName} {adult.LastName}".Contains(_filterAdultByName))
                    {
                        adultWithNameMatchFound = true;
                        break; 
                    }
                }
                if (adultWithNameMatchFound)
                {
                    familiesWithAdultsWithNameMatch.Add(family);
                }
            }

            _familiesToShow = familiesWithAdultsWithNameMatch; 
        }
        else
        {
            _familiesToShow = _allFamilies;
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
