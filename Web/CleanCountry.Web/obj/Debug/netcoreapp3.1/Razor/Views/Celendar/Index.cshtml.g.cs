#pragma checksum "C:\Users\Ventcy\Documents\GitHub\CleanCountry\Web\CleanCountry.Web\Views\Celendar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dedbe3bfc4d7a664476d5441dc9f6b5caaeab85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Celendar_Index), @"mvc.1.0.view", @"/Views/Celendar/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Ventcy\Documents\GitHub\CleanCountry\Web\CleanCountry.Web\Views\_ViewImports.cshtml"
using CleanCountry.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ventcy\Documents\GitHub\CleanCountry\Web\CleanCountry.Web\Views\_ViewImports.cshtml"
using CleanCountry.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dedbe3bfc4d7a664476d5441dc9f6b5caaeab85", @"/Views/Celendar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92809903db706d12ed4d3d4fe5dc604cc0120b66", @"/Views/_ViewImports.cshtml")]
    public class Views_Celendar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ventcy\Documents\GitHub\CleanCountry\Web\CleanCountry.Web\Views\Celendar\Index.cshtml"
  
    ViewData["Title"] = "Celendar";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table>
    <summary><strong>February</strong> 2014</summary>
    <thead>
        <tr>
            <th>Mon</th>
            <th>Tue</th>
            <th>Wed</th>
            <th>Thu</th>
            <th>Fri</th>
            <th>Sat</th>
            <th>Sun</th>
        </tr>
    </thead>
    <tr>
        <td>
            <span class=""date previos-month"">
                27
            </span>
        </td>
        <td>
            <span class=""date previos-month"">28</span>
        </td>
        <td>
            <span class=""date previos-month"">29</span>
        </td>
        <td>
            <span class=""date previos-month"">30</span>
        </td>
        <td>
            <span class=""date previos-month"">31</span>
        </td>
        <td>
            <span class=""date weekend"">February 1</span>
        </td>
        <td>
            <span class=""date weekend"">
                2
                <ul>
                    <li>
                        <span class=""event");
            WriteLiteral(@""">Super Bowl</span>
                        <span class=""time"">6:30 pm</span>
                    </li>
                </ul>
            </span>
        </td>
    </tr>
    <tr>
        <td>
            <span class=""date"">3</span>
        </td>
        <td>
            <span class=""date"">4</span>
        </td>
        <td>
            <span class=""date"">5</span>
        </td>
        <td>
            <span class=""date"">6</span>
        </td>
        <td>
            <span class=""date"">7</span>
        </td>
        <td>
            <span class=""date weekend"">8</span>
        </td>
        <td>
            <span class=""date weekend"">9</span>
        </td>
    </tr>
    <tr>
        <td>
            <span class=""date"">10</span>
        </td>
        <td>
            <span class=""date"">11</span>
        </td>
        <td>
            <span class=""date"">12</span>
        </td>
        <td>
            <span class=""date"">13</span>
        </td>
        <td>
            ");
            WriteLiteral(@"<span class=""date current-day"">
                14
                <ul>
                    <li class=""different-calendar""><span class=""event"">Valentines Day</span></li>
                </ul>
            </span>
        </td>
        <td>
            <span class=""date weekend"">15</span>
        </td>
        <td>
            <span class=""date weekend"">16</span>
        </td>
    </tr>
    <tr>
        <td>
            <span class=""date"">17</span>
        </td>
        <td>
            <span class=""date"">18</span>
        </td>
        <td>
            <span class=""date"">19</span>
        </td>
        <td>
            <span class=""date"">20</span>
        </td>
        <td>
            <span class=""date"">21</span>
        </td>
        <td>
            <span class=""date weekend"">22</span>
        </td>
        <td>
            <span class=""date weekend"">23</span>
        </td>
    </tr>
    <tr>
        <td>
            <span class=""date"">24</span>
        </td>
       ");
            WriteLiteral(@" <td>
            <span class=""date"">
                25
                <ul>
                    <li class=""different-calendar"">
                        <span class=""event"">Breakfast with Joe Smchoe The Baker Man</span>
                        <span class=""time"">10 am</span>
                    </li>
                    <li>
                        <span class=""event"">Code Review</span>
                        <span class=""time"">Noon</span>
                    </li>
                    <li>
                        <span class=""event"">Project X Kickoff</span>
                        <span class=""time"">5 pm</span>
                    </li>
                </ul>
            </span>
        </td>
        <td>
            <span class=""date"">26</span>
        </td>
        <td>
            <span class=""date"">27</span>
        </td>
        <td>
            <span class=""date"">28</span>
        </td>
        <td>
            <span class=""date previos-month"">March 1</span>
        </td>");
            WriteLiteral("\n        <td>\r\n            <span class=\"date previos-month\">2</span>\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
