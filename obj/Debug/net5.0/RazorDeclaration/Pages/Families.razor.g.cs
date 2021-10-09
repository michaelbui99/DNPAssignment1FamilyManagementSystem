// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DNPAssignment1FamilyManagementSystem.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using DNPAssignment1FamilyManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using DNPAssignment1FamilyManagementSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Interop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
using DNPAssignment1FamilyManagementSystem.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
using DNPAssignment1FamilyManagementSystem.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
using DNPAssignment1FamilyManagementSystem.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
using DNPAssignment1FamilyManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Families")]
    public partial class Families : Microsoft.AspNetCore.Components.ComponentBase, DNPAssignment1FamilyManagementSystem.Models.IEventListener
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 238 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
       
    private IList<Family> _familiesToShow;
    private IList<Family> _allFamilies;
    private bool _addFamilyToggle = false;
    private string _filterAdultByName;
    private string _addFamilyErrorLabel;
    private Family _familyToAdd = new Family();
    List<ValidationResult> _validationResults = new();

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
            EventCoordinator.Attach(this);
        }
    }

    private void FilterAdultsByName(ChangeEventArgs args)
    {
        _filterAdultByName = null;
        _filterAdultByName = args.Value.ToString();

        if (_filterAdultByName != null)
        {
            List<Family> familiesWithAdultsWithNameMatch = new List<Family>();

            foreach (var family in _allFamilies)
            {
                bool adultWithNameMatchFound = false;
                foreach (var adult in family.Adults)
                {
                    if ($"{adult.FirstName} {adult.LastName}".ToLower().Contains(_filterAdultByName.ToLower()))
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

    private void GoToAddAdult(Family f)
    {
        NavigationManager.NavigateTo($"/AddAdult/{f.StreetName}/{f.HouseNumber}");
    }


    private void AddNewFamily()
    {
        _validationResults.Clear();
        ValidationContext validationContext = new ValidationContext(_familyToAdd);
        bool familyIsValid = Validator.TryValidateObject(_familyToAdd, validationContext, _validationResults, true);
        if (familyIsValid)
        {
            try
            {
                FamilyService.CreateFamily(_familyToAdd);
                StateHasChanged();
                _addFamilyToggle = !_addFamilyToggle;
            }
            catch (Exception e)
            {
                _addFamilyErrorLabel = e.Message;
                _familyToAdd.StreetName = "";
                _familyToAdd.HouseNumber = 0; 
                return;
            }
        }
    }

    public void Notify()
    {
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEventCoordinator EventCoordinator { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
