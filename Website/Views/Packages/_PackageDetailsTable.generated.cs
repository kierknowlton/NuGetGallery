﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGetGallery.Views.Packages
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NuGetGallery;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Packages/_PackageDetailsTable.cshtml")]
    public class _PackageDetailsTable : System.Web.Mvc.WebViewPage<ListPackageItemViewModel>
    {
        public _PackageDetailsTable()
        {
        }
        public override void Execute()
        {

WriteLiteral("\n<table id=\"packageDetails\">\n    <tr>\n        <th>\n            <strong>Package ID" +
":</strong>\n        </th>\n        <td>\n            <strong>");


            
            #line 9 "..\..\Views\Packages\_PackageDetailsTable.cshtml"
               Write(Model.Id);

            
            #line default
            #line hidden
WriteLiteral("</strong>\n        </td>\n    </tr>\n\n    <tr>\n        <th>Authors</th>\n        <td>" +
"");


            
            #line 15 "..\..\Views\Packages\_PackageDetailsTable.cshtml"
       Write(Model.Authors.Flatten(item => new System.Web.WebPages.HelperResult(__razor_template_writer => {

            
            #line default
            #line hidden

WriteLiteralTo(@__razor_template_writer, "<a href=\"");


            
            #line 15 "..\..\Views\Packages\_PackageDetailsTable.cshtml"
            WriteTo(@__razor_template_writer, Url.Search(item.Name));

            
            #line default
            #line hidden
WriteLiteralTo(@__razor_template_writer, "\">");


            
            #line 15 "..\..\Views\Packages\_PackageDetailsTable.cshtml"
                                    WriteTo(@__razor_template_writer, item.Name);

            
            #line default
            #line hidden
WriteLiteralTo(@__razor_template_writer, "</a>");


            
            #line 15 "..\..\Views\Packages\_PackageDetailsTable.cshtml"
                                                                                 })));

            
            #line default
            #line hidden
WriteLiteral("\n        </td>\n    </tr>\n    <tr>\n        <th>Owners</th>\n        <td>");


            
            #line 20 "..\..\Views\Packages\_PackageDetailsTable.cshtml"
       Write(Model.Owners.Flatten(item => new System.Web.WebPages.HelperResult(__razor_template_writer => {

            
            #line default
            #line hidden

WriteLiteralTo(@__razor_template_writer, "<a href=\"");


            
            #line 20 "..\..\Views\Packages\_PackageDetailsTable.cshtml"
           WriteTo(@__razor_template_writer, Url.Search(item.Username));

            
            #line default
            #line hidden
WriteLiteralTo(@__razor_template_writer, "\">");


            
            #line 20 "..\..\Views\Packages\_PackageDetailsTable.cshtml"
                                       WriteTo(@__razor_template_writer, item.Username);

            
            #line default
            #line hidden
WriteLiteralTo(@__razor_template_writer, "</a>");


            
            #line 20 "..\..\Views\Packages\_PackageDetailsTable.cshtml"
                                                                                        })));

            
            #line default
            #line hidden
WriteLiteral("\n        </td>\n    </tr>\n");


            
            #line 23 "..\..\Views\Packages\_PackageDetailsTable.cshtml"
     if (Model.Tags.AnySafe()) {

            
            #line default
            #line hidden
WriteLiteral("        <tr>\n            <th>Tags:</th>\n            <td>");


            
            #line 26 "..\..\Views\Packages\_PackageDetailsTable.cshtml"
           Write(Model.Tags.Flatten(item => new System.Web.WebPages.HelperResult(__razor_template_writer => {

            
            #line default
            #line hidden

WriteLiteralTo(@__razor_template_writer, "<a href=\"");


            
            #line 26 "..\..\Views\Packages\_PackageDetailsTable.cshtml"
             WriteTo(@__razor_template_writer, Url.Search(item));

            
            #line default
            #line hidden
WriteLiteralTo(@__razor_template_writer, "\">");


            
            #line 26 "..\..\Views\Packages\_PackageDetailsTable.cshtml"
                                WriteTo(@__razor_template_writer, item);

            
            #line default
            #line hidden
WriteLiteralTo(@__razor_template_writer, "</a>");


            
            #line 26 "..\..\Views\Packages\_PackageDetailsTable.cshtml"
                                                                        })));

            
            #line default
            #line hidden
WriteLiteral("\n            </td>\n        </tr>\n");


            
            #line 29 "..\..\Views\Packages\_PackageDetailsTable.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <tr>\n        <th>Last updated:</th>\n        <td>");


            
            #line 32 "..\..\Views\Packages\_PackageDetailsTable.cshtml"
       Write(Model.LastUpdated.ToString("F"));

            
            #line default
            #line hidden
WriteLiteral("\n        </td>\n    </tr>\n</table>");


        }
    }
}
#pragma warning restore 1591