#pragma checksum "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\Projects\Project.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9be2afcb8cff95ec6a57c370659dac4c391a7103"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Project), @"mvc.1.0.view", @"/Views/Projects/Project.cshtml")]
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
#line 1 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\_ViewImports.cshtml"
using CleanCountry.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\_ViewImports.cshtml"
using CleanCountry.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\_ViewImports.cshtml"
using CleanCountry.Web.ViewModels.Projects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\_ViewImports.cshtml"
using CleanCountry.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\_ViewImports.cshtml"
using CleanCountry.Web.ViewModels.Profile;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be2afcb8cff95ec6a57c370659dac4c391a7103", @"/Views/Projects/Project.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dab43bf089c7935ffca31874d2d8f5353595a3e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Project : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\Projects\Project.cshtml"
  
    ViewData["Title"] = "Project";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card w-75 m-auto projectAnimated\">\r\n    <div class=\"card-header mb-3\">\r\n        <h3 class=\"font-weight-bold text-center\">");
#nullable restore
#line 8 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\Projects\Project.cshtml"
                                            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <img class=\"card-img w-75 m-auto\"");
            BeginWriteAttribute("src", " src=\"", 271, "\"", 290, 1);
#nullable restore
#line 10 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\Projects\Project.cshtml"
WriteAttributeValue("", 277, Model.Images, 277, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 291, "\"", 309, 1);
#nullable restore
#line 10 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\Projects\Project.cshtml"
WriteAttributeValue("", 297, Model.Title, 297, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <h4 class=\"text-center mt-5\">Описание</h4>\r\n    <p class=\"text-center\">");
#nullable restore
#line 12 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\Projects\Project.cshtml"
                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <div class=\'card-panel grey lighten-3 text-center mb-3\'>\r\n");
#nullable restore
#line 14 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\Projects\Project.cshtml"
         if (Model.Partisipant == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h6 class=\"text-center mt-5\">😃 Ти вече участваш в проекта 😃</h6>\r\n            <a class=\"btn btn-info mt-3\"");
            BeginWriteAttribute("href", " href=\"", 648, "\"", 682, 2);
            WriteAttributeValue("", 655, "/Projects/Join?id=", 655, 18, true);
#nullable restore
#line 17 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\Projects\Project.cshtml"
WriteAttributeValue("", 673, Model.id, 673, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Откажи се!</a>\r\n");
#nullable restore
#line 18 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\Projects\Project.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4 class=\"text-center mt-5\">Искаш да се присъединиш?</h4>\r\n            <p>Участници: ");
#nullable restore
#line 22 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\Projects\Project.cshtml"
                     Write(Model.PartisipiantCoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <a class=\"btn btn-info mt-3\"");
            BeginWriteAttribute("href", " href=\"", 904, "\"", 938, 2);
            WriteAttributeValue("", 911, "/Projects/Join?id=", 911, 18, true);
#nullable restore
#line 23 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\Projects\Project.cshtml"
WriteAttributeValue("", 929, Model.id, 929, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Присъедини се!</a>\r\n");
#nullable restore
#line 24 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\Projects\Project.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"card-footer mt-3\">\r\n        <p>Създаден на: ");
#nullable restore
#line 27 "C:\Users\Ibryam\Desktop\CleanCountry\Web\CleanCountry.Web\Views\Projects\Project.cshtml"
                   Write(Model.CreatedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
