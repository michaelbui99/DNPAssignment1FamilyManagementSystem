#pragma checksum "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b52a49d6a2a1e4e4bc5a23ab134e17f2f573cca5"
// <auto-generated/>
#pragma warning disable 1591
namespace DNPAssignment1FamilyManagementSystem.Components
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
#line 1 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
using DNPAssignment1FamilyManagementSystem.Data.Impl;

#line default
#line hidden
#nullable disable
    public partial class PersonInfomation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
 if (Person != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "p");
            __builder.AddAttribute(1, "b-oe6jo7838c");
            __builder.AddContent(2, "Name: ");
            __builder.AddContent(3, 
#nullable restore
#line 8 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
          Person.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#nullable restore
#line 8 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                            Person.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, "  ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                                                               DeletePerson

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "b-oe6jo7838c");
            __builder.AddMarkupContent(10, "<i class=\"fas fa-trash\" b-oe6jo7838c></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "p");
            __builder.AddAttribute(13, "b-oe6jo7838c");
            __builder.AddContent(14, "Age: ");
            __builder.AddContent(15, 
#nullable restore
#line 9 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
         Person.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "p");
            __builder.AddAttribute(18, "b-oe6jo7838c");
            __builder.AddContent(19, "Sex: ");
            __builder.AddContent(20, 
#nullable restore
#line 10 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
         Person.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.OpenElement(22, "p");
            __builder.AddAttribute(23, "b-oe6jo7838c");
            __builder.AddContent(24, "Height: ");
            __builder.AddContent(25, 
#nullable restore
#line 11 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
            Person.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenElement(27, "p");
            __builder.AddAttribute(28, "b-oe6jo7838c");
            __builder.AddContent(29, "Weight: ");
            __builder.AddContent(30, 
#nullable restore
#line 12 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
            Person.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.OpenElement(32, "p");
            __builder.AddAttribute(33, "b-oe6jo7838c");
            __builder.AddContent(34, "EyeColor: ");
            __builder.AddContent(35, 
#nullable restore
#line 13 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
              Person.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.OpenElement(37, "p");
            __builder.AddAttribute(38, "b-oe6jo7838c");
            __builder.AddContent(39, "HairColor: ");
            __builder.AddContent(40, 
#nullable restore
#line 14 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
               Person.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
       

    [Parameter]
    public Person Person { get; set; }
    [Parameter]
    public Family Family { get; set; }

    [Parameter]
    public IDeleteStrategy DeleteStrategy { get; set; }

    private void DeletePerson()
    {
        if (DeleteStrategy != null)
        {
            DeleteStrategy.Delete(Person, Family);
            Person = null;
        
    /*
         *Fixes an issue where p-tags in Parent Component with Salary and Job
         * were not updated after the adult has been deleted. 
         */ 
            EventCoordinator.Notify();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEventCoordinator EventCoordinator { get; set; }
    }
}
#pragma warning restore 1591
