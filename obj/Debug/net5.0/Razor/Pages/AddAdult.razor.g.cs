#pragma checksum "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c1e7972a5a09fcab0818bbfac7702f437988718"
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
#line 2 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
using DNPAssignment1FamilyManagementSystem.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult/{StreetName}/{HouseNumber:int}")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "add-adult-container");
                __builder2.AddAttribute(4, "b-vlsghze0yy");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-container");
                __builder2.AddAttribute(7, "b-vlsghze0yy");
                __builder2.OpenElement(8, "h3");
                __builder2.AddAttribute(9, "b-vlsghze0yy");
                __builder2.AddContent(10, "Add Adult to Family: ");
                __builder2.AddContent(11, 
#nullable restore
#line 11 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
                                          StreetName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(12, " ");
                __builder2.AddContent(13, 
#nullable restore
#line 11 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
                                                      HouseNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddAttribute(17, "b-vlsghze0yy");
                __builder2.AddMarkupContent(18, "<label b-vlsghze0yy>First Name</label>\r\n                    ");
                __builder2.OpenElement(19, "input");
                __builder2.AddAttribute(20, "type", "text");
                __builder2.AddAttribute(21, "placeholder", "First name");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
                                                                             _newAdult.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newAdult.FirstName = __value, _newAdult.FirstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(24, "b-vlsghze0yy");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n\r\n                ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddAttribute(28, "b-vlsghze0yy");
                __builder2.AddMarkupContent(29, "<label b-vlsghze0yy>Last Name</label>\r\n                    ");
                __builder2.OpenElement(30, "input");
                __builder2.AddAttribute(31, "type", "text");
                __builder2.AddAttribute(32, "placeholder", "Last name");
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
                                                                            _newAdult.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newAdult.LastName = __value, _newAdult.LastName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(35, "b-vlsghze0yy");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n\r\n                ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddAttribute(39, "b-vlsghze0yy");
                __builder2.AddMarkupContent(40, "<label b-vlsghze0yy>Age</label>\r\n                    ");
                __builder2.OpenElement(41, "input");
                __builder2.AddAttribute(42, "type", "number");
                __builder2.AddAttribute(43, "placeholder", "Age");
                __builder2.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
                                                                        _newAdult.Age

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newAdult.Age = __value, _newAdult.Age, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(46, "b-vlsghze0yy");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n                ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group");
                __builder2.AddAttribute(50, "b-vlsghze0yy");
                __builder2.AddMarkupContent(51, "<label b-vlsghze0yy>Weight</label>\r\n                    ");
                __builder2.OpenElement(52, "input");
                __builder2.AddAttribute(53, "type", "number");
                __builder2.AddAttribute(54, "placeholder", "Weight");
                __builder2.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
                                                                           _newAdult.Weight

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newAdult.Weight = __value, _newAdult.Weight, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(57, "b-vlsghze0yy");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n\r\n                ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group");
                __builder2.AddAttribute(61, "b-vlsghze0yy");
                __builder2.AddMarkupContent(62, "<label b-vlsghze0yy>Height</label>\r\n                    ");
                __builder2.OpenElement(63, "input");
                __builder2.AddAttribute(64, "type", "number");
                __builder2.AddAttribute(65, "placeholder", "Height");
                __builder2.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
                                                                           _newAdult.Height

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newAdult.Height = __value, _newAdult.Height, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(68, "b-vlsghze0yy");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n\r\n                ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group");
                __builder2.AddAttribute(72, "b-vlsghze0yy");
                __builder2.AddMarkupContent(73, "<label for=\"sex\" b-vlsghze0yy>Sex</label>\r\n                    ");
                __builder2.OpenElement(74, "select");
                __builder2.AddAttribute(75, "name", "sex");
                __builder2.AddAttribute(76, "id", "sex");
                __builder2.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
                                                           e=>_selectedSex=e.Value.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "b-vlsghze0yy");
                __builder2.OpenElement(79, "option");
                __builder2.AddAttribute(80, "value", "M");
                __builder2.AddAttribute(81, "b-vlsghze0yy");
                __builder2.AddContent(82, "M");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                        ");
                __builder2.OpenElement(84, "option");
                __builder2.AddAttribute(85, "value", "F");
                __builder2.AddAttribute(86, "b-vlsghze0yy");
                __builder2.AddContent(87, "F");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n\r\n                ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "form-group");
                __builder2.AddAttribute(91, "b-vlsghze0yy");
                __builder2.AddMarkupContent(92, "<label b-vlsghze0yy>Eye Color</label>\r\n                    ");
                __builder2.OpenElement(93, "input");
                __builder2.AddAttribute(94, "type", "text");
                __builder2.AddAttribute(95, "placeholder", "Eye color");
                __builder2.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
                                                                            _newAdult.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newAdult.EyeColor = __value, _newAdult.EyeColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(98, "b-vlsghze0yy");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n\r\n                ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "form-group");
                __builder2.AddAttribute(102, "b-vlsghze0yy");
                __builder2.AddMarkupContent(103, "<label b-vlsghze0yy>Hair Color</label>\r\n                    ");
                __builder2.OpenElement(104, "input");
                __builder2.AddAttribute(105, "type", "text");
                __builder2.AddAttribute(106, "placeholder", "Hair Color");
                __builder2.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
                                                                             _newAdult.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newAdult.HairColor = __value, _newAdult.HairColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(109, "b-vlsghze0yy");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n\r\n                ");
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "form-group");
                __builder2.AddAttribute(113, "b-vlsghze0yy");
                __builder2.AddMarkupContent(114, "<label b-vlsghze0yy>Job Title</label>\r\n                    ");
                __builder2.OpenElement(115, "input");
                __builder2.AddAttribute(116, "type", "text");
                __builder2.AddAttribute(117, "placeholder", "Job Title");
                __builder2.AddAttribute(118, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
                                                                            _newAdult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(119, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newAdult.JobTitle.JobTitle = __value, _newAdult.JobTitle.JobTitle));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(120, "b-vlsghze0yy");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n\r\n                ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "form-group");
                __builder2.AddAttribute(124, "b-vlsghze0yy");
                __builder2.AddMarkupContent(125, "<label b-vlsghze0yy>Salary</label>\r\n                    ");
                __builder2.OpenElement(126, "input");
                __builder2.AddAttribute(127, "type", "number");
                __builder2.AddAttribute(128, "placeholder", "Salary");
                __builder2.AddAttribute(129, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
                                                                           _newAdult.JobTitle.Salary

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(130, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newAdult.JobTitle.Salary = __value, _newAdult.JobTitle.Salary, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(131, "b-vlsghze0yy");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n                \r\n                ");
                __builder2.OpenElement(133, "button");
                __builder2.AddAttribute(134, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
                                  AddAdultToFamily

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(135, "b-vlsghze0yy");
                __builder2.AddContent(136, "Add Adult");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
       

    [Parameter]
    public string StreetName { get; set; }

    [Parameter]
    public int HouseNumber { get; set; }

    private Adult _newAdult = new Adult() {JobTitle = new Job()};

    private string _selectedSex; 


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
    }

    private void AddAdultToFamily()
    {
        Family familyOfAdult = FamilyService.GetFamily(StreetName, HouseNumber);
        _newAdult.Sex = _selectedSex; 
        FamilyService.AddAdultToFamily(familyOfAdult, _newAdult);
        NavigationManager.NavigateTo("/Families");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
