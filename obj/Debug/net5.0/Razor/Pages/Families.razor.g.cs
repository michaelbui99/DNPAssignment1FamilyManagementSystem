#pragma checksum "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fbc58703b0127944932e4bc5d531b7c66cbd1a6"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "families-container animation-fade-in");
                __builder2.AddAttribute(4, "b-2chmzdkc7s");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "families-container__header");
                __builder2.AddAttribute(7, "b-2chmzdkc7s");
                __builder2.OpenElement(8, "h3");
                __builder2.AddAttribute(9, "b-2chmzdkc7s");
                __builder2.AddContent(10, "Families ");
                __builder2.OpenElement(11, "i");
                __builder2.AddAttribute(12, "class", "fas fa-plus");
                __builder2.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                                              ()=>_addFamilyToggle = !_addFamilyToggle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "b-2chmzdkc7s");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "type", "text");
                __builder2.AddAttribute(18, "placeholder", "Search by name of adult");
                __builder2.AddAttribute(19, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                                                                   (args) => FilterAdultsByName(args)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "b-2chmzdkc7s");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 21 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
             if(_addFamilyToggle) 
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "add-family-container animation-fade-in");
                __builder2.AddAttribute(23, "b-2chmzdkc7s");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddAttribute(26, "b-2chmzdkc7s");
                __builder2.AddMarkupContent(27, "<label b-2chmzdkc7s>Street name</label>\r\n                    ");
                __builder2.OpenElement(28, "input");
                __builder2.AddAttribute(29, "type", "text");
                __builder2.AddAttribute(30, "placeholder", "Street name");
                __builder2.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                                                              _familyToAdd.StreetName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _familyToAdd.StreetName = __value, _familyToAdd.StreetName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(33, "b-2chmzdkc7s");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddAttribute(37, "b-2chmzdkc7s");
                __builder2.AddMarkupContent(38, "<label b-2chmzdkc7s>House Number</label>\r\n                    ");
                __builder2.OpenElement(39, "input");
                __builder2.AddAttribute(40, "type", "number");
                __builder2.AddAttribute(41, "placeholder", "House Number");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                                                                 _familyToAdd.HouseNumber

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _familyToAdd.HouseNumber = __value, _familyToAdd.HouseNumber, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(44, "b-2chmzdkc7s");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.OpenElement(46, "p");
                __builder2.AddAttribute(47, "class", "error-label");
                __builder2.AddAttribute(48, "b-2chmzdkc7s");
                __builder2.AddContent(49, 
#nullable restore
#line 32 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                            _addFamilyErrorLabel

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 33 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                     foreach (var error in _validationResults)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(50, "p");
                __builder2.AddAttribute(51, "class", "error-label");
                __builder2.AddAttribute(52, "b-2chmzdkc7s");
                __builder2.AddContent(53, 
#nullable restore
#line 35 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                                error

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 36 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(54, "button");
                __builder2.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                  AddNewFamily

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "b-2chmzdkc7s");
                __builder2.AddMarkupContent(57, "\r\n                    Add Family\r\n                ");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 42 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
             if (_familiesToShow is null)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(58, "<p b-2chmzdkc7s><em b-2chmzdkc7s>Loading...</em></p>");
#nullable restore
#line 49 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
            }
            else if (!_familiesToShow.Any())
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(59, "<p b-2chmzdkc7s><em b-2chmzdkc7s>No Families has been created yet.</em></p>");
#nullable restore
#line 55 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(60, "table");
                __builder2.AddAttribute(61, "class", "table");
                __builder2.AddAttribute(62, "b-2chmzdkc7s");
                __builder2.AddMarkupContent(63, @"<thead b-2chmzdkc7s><tr b-2chmzdkc7s><th b-2chmzdkc7s></th>
                        <th b-2chmzdkc7s>Street Name</th>
                        <th b-2chmzdkc7s>House No</th>
                        <th b-2chmzdkc7s>Member Count</th>
                        <th b-2chmzdkc7s>Delete</th></tr></thead>
                    ");
                __builder2.OpenElement(64, "tbody");
                __builder2.AddAttribute(65, "b-2chmzdkc7s");
#nullable restore
#line 69 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                     foreach (var f in _familiesToShow)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<DNPAssignment1FamilyManagementSystem.Components.ExpandableFamilyTableRow>(66);
                __builder2.AddAttribute(67, "Family", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DNPAssignment1FamilyManagementSystem.Models.Family>(
#nullable restore
#line 71 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                                          f

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(69, "tr");
                    __builder3.AddAttribute(70, "b-2chmzdkc7s");
                    __builder3.OpenElement(71, "td");
                    __builder3.AddAttribute(72, "colspan", "4");
                    __builder3.AddAttribute(73, "b-2chmzdkc7s");
                    __builder3.OpenElement(74, "div");
                    __builder3.AddAttribute(75, "class", "content-container animation-fade-in");
                    __builder3.AddAttribute(76, "b-2chmzdkc7s");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "adults-container");
                    __builder3.AddAttribute(79, "b-2chmzdkc7s");
#nullable restore
#line 76 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                             if (f.Adults.Count >= 2)
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(80, "<h4 b-2chmzdkc7s>Adults: <button class=\"disabled\" b-2chmzdkc7s><i class=\"fas fa-plus\" b-2chmzdkc7s></i>Add Adult</button></h4>");
#nullable restore
#line 79 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                                
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(81, "h4");
                    __builder3.AddAttribute(82, "b-2chmzdkc7s");
                    __builder3.AddContent(83, "Adults: ");
                    __builder3.OpenElement(84, "button");
                    __builder3.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                                                          () => GoToAddAdult(f)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(86, "b-2chmzdkc7s");
                    __builder3.AddMarkupContent(87, "<i class=\"fas fa-plus\" b-2chmzdkc7s></i>Add Adult");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 84 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                             foreach (var a in f.Adults)
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<DNPAssignment1FamilyManagementSystem.Components.PersonInfomation>(88);
                    __builder3.AddAttribute(89, "Person", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DNPAssignment1FamilyManagementSystem.Models.Person>(
#nullable restore
#line 87 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                                                          a

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(90, "Family", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DNPAssignment1FamilyManagementSystem.Models.Family>(
#nullable restore
#line 87 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                                                                    f

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(91, "DeleteStrategy", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DNPAssignment1FamilyManagementSystem.Data.Impl.IDeleteStrategy>(
#nullable restore
#line 87 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                                                                                       new DeleteAdultStrategy(FamilyService)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(92, "\r\n                                                ");
                    __builder3.OpenElement(93, "p");
                    __builder3.AddAttribute(94, "b-2chmzdkc7s");
                    __builder3.AddContent(95, "Job: ");
                    __builder3.AddContent(96, 
#nullable restore
#line 88 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                                         a.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(97, "\r\n                                                ");
                    __builder3.OpenElement(98, "p");
                    __builder3.AddAttribute(99, "b-2chmzdkc7s");
                    __builder3.AddContent(100, "Salary: ");
                    __builder3.AddContent(101, 
#nullable restore
#line 89 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                                            a.JobTitle.Salary

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(102, "\r\n                                                <br b-2chmzdkc7s>");
#nullable restore
#line 91 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                            }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(103, "\r\n                                        \r\n                                        ");
                    __builder3.OpenElement(104, "div");
                    __builder3.AddAttribute(105, "class", "children-container");
                    __builder3.AddAttribute(106, "b-2chmzdkc7s");
                    __builder3.AddMarkupContent(107, "<h4 b-2chmzdkc7s>Children: </h4>");
#nullable restore
#line 96 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                             foreach (var c in f.Children)
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<DNPAssignment1FamilyManagementSystem.Components.PersonInfomation>(108);
                    __builder3.AddAttribute(109, "Person", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DNPAssignment1FamilyManagementSystem.Models.Person>(
#nullable restore
#line 98 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                                                          c

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(110, "Family", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DNPAssignment1FamilyManagementSystem.Models.Family>(
#nullable restore
#line 98 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                                                                    f

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(111, "\r\n                                                <br b-2chmzdkc7s>");
#nullable restore
#line 100 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                            }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(112, "\r\n                                        \r\n                                        ");
                    __builder3.OpenElement(113, "div");
                    __builder3.AddAttribute(114, "class", "family-pet-container");
                    __builder3.AddAttribute(115, "b-2chmzdkc7s");
                    __builder3.AddMarkupContent(116, "<h4 b-2chmzdkc7s>Pets: </h4>");
#nullable restore
#line 105 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                             foreach (var p in f.Pets)
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<DNPAssignment1FamilyManagementSystem.Components.PetInformation>(117);
                    __builder3.AddAttribute(118, "Pet", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DNPAssignment1FamilyManagementSystem.Models.Pet>(
#nullable restore
#line 107 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                                                                     p

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(119, "\r\n                                                <br b-2chmzdkc7s>");
#nullable restore
#line 109 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"

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
#line 116 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 119 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
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
#line 125 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Families.razor"
       
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
                _addFamilyToggle = !_addFamilyToggle;
            }
            catch (Exception e)
            {
                _addFamilyErrorLabel = e.Message;
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
