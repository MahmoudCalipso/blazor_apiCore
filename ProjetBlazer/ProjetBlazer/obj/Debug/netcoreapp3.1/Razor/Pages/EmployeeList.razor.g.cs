#pragma checksum "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da1d2ebd1a6a73ae9824088f58a6d60fb44267fb"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjetBlazer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\_Imports.razor"
using ProjetBlazer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\_Imports.razor"
using ProjetBlazer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\Pages\EmployeeList.razor"
using AtelierRestApi.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class EmployeeList : EmployeeListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Employee List</h3>\r\n");
#nullable restore
#line 9 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\Pages\EmployeeList.razor"
 if (employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 12 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\Pages\EmployeeList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-deck");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 16 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\Pages\EmployeeList.razor"
         foreach (var employee in employees)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card m-3");
            __builder.AddAttribute(10, "style", "min-width: 18rem; max-width: 30.5%;");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-header");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "h3");
            __builder.AddContent(16, " ");
            __builder.AddContent(17, 
#nullable restore
#line 20 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\Pages\EmployeeList.razor"
                          employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(18, " ");
            __builder.AddContent(19, 
#nullable restore
#line 20 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\Pages\EmployeeList.razor"
                                              employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "class", "card-img-top imageThubnail");
            __builder.AddAttribute(25, "src", 
#nullable restore
#line 22 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\Pages\EmployeeList.razor"
                                                              employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "card-footer text-center");
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", 
#nullable restore
#line 25 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\Pages\EmployeeList.razor"
                               $"EmployeeDetails/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "class", "btn btn-primary m-1");
            __builder.AddContent(33, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.AddMarkupContent(35, "<a href=\"#\" class=\"btn-primary m-1\">Edit</a>\r\n                    ");
            __builder.AddMarkupContent(36, "<a href=\"#\" class=\"btn-danger m-1\">Delete</a>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 30 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\Pages\EmployeeList.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 33 "C:\Users\CALIPSO\Downloads\location voiture\ProjetBlazer\ProjetBlazer\ProjetBlazer\Pages\EmployeeList.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
