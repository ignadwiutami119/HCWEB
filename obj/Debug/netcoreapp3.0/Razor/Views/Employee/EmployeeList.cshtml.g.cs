#pragma checksum "D:\HCWEB\Views\Employee\EmployeeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca64a3962142acbf27723edd6ffec2aa27b4539b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EmployeeList), @"mvc.1.0.view", @"/Views/Employee/EmployeeList.cshtml")]
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
#line 1 "D:\HCWEB\Views\_ViewImports.cshtml"
using HC_WEB_FINALPROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HCWEB\Views\_ViewImports.cshtml"
using HC_WEB_FINALPROJECT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca64a3962142acbf27723edd6ffec2aa27b4539b", @"/Views/Employee/EmployeeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7617a8a5b04142fd44fe79920582bdc0a6fd0da", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_EmployeeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Importy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:left;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
  
    Layout = "_LayoutHC";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<style>.card {
    padding-top: 20px;
    margin: 10px 0 20px 0;
    background-color: rgba(214, 224, 226, 0.2);
    border-top-width: 0;
    border-bottom-width: 2px;
    -webkit-border-radius: 3px;
    -moz-border-radius: 3px;
    border-radius: 3px;
    -webkit-box-shadow: none;
    -moz-box-shadow: none;
    box-shadow: none;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

.card .card-heading {
    padding: 0 20px;
    margin: 0;
}

.card .card-heading.simple {
    font-size: 20px;
    font-weight: 300;
    color: #777;
    border-bottom: 1px solid #e5e5e5;
}

.card .card-heading.image img {
    display: inline-block;
    width: 46px;
    height: 46px;
    margin-right: 15px;
    vertical-align: top;
    border: 0;
    -webkit-border-radius: 50%;
    -moz-border-radius: 50%;
    border-radius: 50%;
}

.card .card-heading.image .card-heading-header {
    display: inline-block;
    vertical-align: top;
}

.ca");
            WriteLiteral(@"rd .card-heading.image .card-heading-header h3 {
    margin: 0;
    font-size: 14px;
    line-height: 16px;
    color: #262626;
}

.card .card-heading.image .card-heading-header span {
    font-size: 12px;
    color: #999999;
}

.card .card-body {
    padding: 0 20px;
    margin-top: 20px;
}

.card .card-media {
    padding: 0 20px;
    margin: 0 -14px;
}

.card .card-media img {
    max-width: 100%;
    max-height: 100%;
}

.card .card-actions {
    min-height: 30px;
    padding: 0 20px 20px 20px;
    margin: 20px 0 0 0;
}

.card .card-comments {
    padding: 20px;
    margin: 0;
    background-color: #f8f8f8;
}

.card .card-comments .comments-collapse-toggle {
    padding: 0;
    margin: 0 20px 12px 20px;
}

.card .card-comments .comments-collapse-toggle a,
.card .card-comments .comments-collapse-toggle span {
    padding-right: 5px;
    overflow: hidden;
    font-size: 12px;
    color: #999;
    text-overflow: ellipsis;
    white-space: nowrap;
}

.card");
            WriteLiteral(@"-comments .media-heading {
    font-size: 13px;
    font-weight: bold;
}

.card.people {
    position: relative;
    display: inline-block;
    width: 500px;
    height: 300px;
    padding-top: 0;
    margin-left: 20px;
    overflow: hidden;
    vertical-align: top;
}

.card.people:first-child {
    margin-left: 0;
}

.card.people .card-top {
    position: absolute;
    top: 0;
    left: 0;
    display: inline-block;
    width: 170px;
    height: 150px;
    background-color: #ffffff;
}

.card.people .card-top.green {
    background-color: #53a93f;
}

.card.people .card-top.blue {
    background-color: #427fed;
}

.card.people .card-info {
    position: absolute;
    top: 150px;
    display: inline-block;
    width: 100%;
    height: 101px;
    overflow: hidden;
    background: #ffffff;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

.card.people .card-info .title {
    display: block;
    margin: 8px 14px ");
            WriteLiteral(@"0 14px;
    overflow: hidden;
    font-size: 16px;
    font-weight: bold;
    line-height: 18px;
    color: #404040;
}

.card.people .card-info .desc {
    display: block;
    margin: 8px 14px 0 14px;
    overflow: hidden;
    font-size: 12px;
    line-height: 16px;
    color: #737373;
    text-overflow: ellipsis;
}

.card.people .card-bottom {
    position: absolute;
    bottom: 0;
    left: 0;
    display: inline-block;
    width: 100%;
    padding: 10px 20px;
    line-height: 29px;
    text-align: center;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

.card.hovercard {
    position: relative;
    padding-right: 15px;
    padding-left: 15px;
    overflow: hidden;
    text-align: center;
    background-color: #D6EAF8;
}

.btn:focus{
background: #ffffff;
}
  
.card.hovercard .cardheader {
    background-color: rgba(214, 224, 226, 0.2);
    height: 500px;
}
.card.hovercard .cardjudul {
    background: #0c0f11");
            WriteLiteral(@";
    background-size: cover;
    height: 350px;
}

.card.hovercard .body {
    background-size: cover;
    height: 290px;
}

.card.hovercard .avatar {
    position: relative;
    top: -50px;
    margin-bottom: -50px;
}

.card.hovercard .avatar img {
    width: 100px;
    height: 100px;
    max-width: 100px;
    max-height: 100px;
    -webkit-border-radius: 50%;
    -moz-border-radius: 50%;
    border-radius: 50%;
    border: 5px solid rgba(20,105,148,0.5);
}

.card.hovercard .info {
    padding: 4px 8px 10px;
}

.card.hovercard .info .title {
    margin-bottom: 0px;
    font-size: 24px;
    line-height: 1;
    color: #262626;
    vertical-align: middle;
}

.card.hovercard .info .desc {
    overflow: hidden;
    font-size: 12px;
    line-height: 20px;
    color: #737373;
    text-overflow: ellipsis;
}

.card.hovercard .bottom {
    padding: 0 20px;
    margin-bottom: 0px;
}

.navbar:active{
    color:#5DADE2;
}

</style>

 <br>

<div class=""container");
            WriteLiteral(@""">
    <div class=""column"">
        <h2 class=""text-center"" style=""color:#FF5693; font-size:33px"">Employee List</h2> <br><br>
    <div class=""col-lg-12 col-sm-5""><div class=""column text-right""> 
<a onclick=""location.href='/Employee/CSVformat'"">download csv format here</a>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca64a3962142acbf27723edd6ffec2aa27b4539b10524", async() => {
                WriteLiteral("\r\n            <div class=\"column\">\r\n            <input name=\"file\" type=\"file\" value=\"file\" required />       \r\n            </div>\r\n            <button class=\"btn btn-success\"  type=\"submit\"><b>Import CSV</b></button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" 
<button onclick=""location.href='/Employee/ExportCSV'"" class=""btn btn-success""><b>Export CSV</b></button>
<button onclick=""location.href='/Employee/ExportAll'"" class=""btn btn-success""><b>Export CSV (All)</b></button>
<button onclick=""location.href='/Employee/AddEmployee'"" class=""btn btn-success""><b>Add New Employee</b></button> </div></div> </div>


        <div class=""col-lg-12 col-sm-5"">
             <div class=""card hovercard"">
                   <div class=""row"">
");
#nullable restore
#line 289 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
                           var page = ViewBag.Paging;
                        if(page.StatusPage == "permanent"){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <ul> 
                        <li style=""width:370px""><a style=""background:#FF5693; color:#F0F9FF"" href=""/Employee/EmployeeList?Status_Employee=permanent"">Permanent</a></li>
                        <li style=""width:370px""><a style=""color:#F0F9FF"" href=""/Employee/EmployeeList?Status_Employee=contract"">Contract</a></li>
                        <li style=""width:370px""><a style=""color:#F0F9FF"" href=""/Employee/EmployeeList?Status_Employee=probation"">Probation</a></li>
                    </ul>");
#nullable restore
#line 295 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
                         }
                    else if(page.StatusPage == "contract"){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <ul> 
                        <li style=""width:370px""><a style=""color:#F0F9FF"" href=""/Employee/EmployeeList?Status_Employee=permanent"">Permanent</a></li>
                        <li style=""width:370px""><a style=""background:#FF5693; color:#F0F9FF"" href=""/Employee/EmployeeList?Status_Employee=contract"">Contract</a></li>
                        <li style=""width:370px""><a style=""color:#F0F9FF"" href=""/Employee/EmployeeList?Status_Employee=probation"">Probation</a></li>
                    </ul>
");
#nullable restore
#line 302 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
                    }else {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <ul> 
                        <li style=""width:370px""><a style=""color:#F0F9FF"" href=""/Employee/EmployeeList?Status_Employee=permanent"">Permanent</a></li>
                        <li style=""width:370px""><a style=""color:#F0F9FF"" href=""/Employee/EmployeeList?Status_Employee=contract"">Contract</a></li>
                        <li style=""width:370px""><a style=""background:#FF5693; color:#F0F9FF"" href=""/Employee/EmployeeList?Status_Employee=probation"">Probation</a></li>
                    </ul>
");
#nullable restore
#line 308 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
                    }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                   </div>\r\n                   <br>\r\n                   <div class=\"col-lg-12 col-sm-4\">\r\n                       <div class=\"row\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca64a3962142acbf27723edd6ffec2aa27b4539b15962", async() => {
                WriteLiteral(@"
                   <div class=""col-lg-11 col-sm-5"">
                    <input type=""text"" id=""keyword"" name=""search"" class=""form-control"" placeholder=""Type to search""></div>
                   <div>
                    <button onclick=""javascript:Search(this)"" class=""btn btn-warning"" type=""button""><span class=""fa fa-search""> Search</span>
                    </button></div>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div><br>    \r\n                <div class=\"body\">\r\n\r\n<table style=\"background:white\" class=\"table text-left\">\r\n            <tbody>\r\n");
#nullable restore
#line 325 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
     
    var items = ViewBag.items;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <br>
    <thead class=""thead-dark"">
    <tr>
      <th scope=""col"">Name</th>
      <th scope=""col"">Email</th>
      <th scope=""col"">Phone</th>
      <th scope=""col"">Occupation</th>
      <th scope=""col"">Department</th>
      <th scope=""col""></th>
    </tr>
  </thead>    
");
#nullable restore
#line 338 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
    foreach(var a in items) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n        <input type=\"hidden\"");
            BeginWriteAttribute("id", "  id=\"", 9305, "\"", 9319, 2);
            WriteAttributeValue("", 9311, "Id-", 9311, 3, true);
#nullable restore
#line 340 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
WriteAttributeValue("", 9314, a.Id, 9314, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 9320, "\"", 9333, 1);
#nullable restore
#line 340 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
WriteAttributeValue("", 9328, a.Id, 9328, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("                <td><b>");
#nullable restore
#line 342 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
                  Write(a.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                <td>");
#nullable restore
#line 343 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
               Write(a.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 344 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
               Write(a.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 345 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
                                 Write(a.Occupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 346 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
                                 Write(a.Placement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\"><a");
            BeginWriteAttribute("id", " id=\"", 9676, "\"", 9690, 2);
            WriteAttributeValue("", 9681, "btn-", 9681, 4, true);
#nullable restore
#line 347 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
WriteAttributeValue("", 9685, a.Id, 9685, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"javascript:EmployeeDetail(this)\"><span class=\"glyphicon glyphicon-chevron-right\"></span></a></td>\r\n            </tr> \r\n");
#nullable restore
#line 349 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
            } 
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </tbody> 
    </table>
                </div>
            <br>
        </div>
    </div>
</div>
	</div>
</div>
  </div>
</div>

<div class=""container"">
<div class=""column"">
<div class=""col-lg-12 col-sm-5"">
<nav aria-label=""..."">
  <ul style=""margin-left:12px"" class=""pagination marginleft"">
");
#nullable restore
#line 368 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
      
      var paging = ViewBag.Paging;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"page-item\">\r\n      <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 10250, "\"", 10257, 0);
            EndWriteAttribute();
            WriteLiteral(">Previous</a>\r\n    </li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"1\" id=\"btn1\"");
            BeginWriteAttribute("href", " href=\"", 10350, "\"", 10426, 2);
            WriteAttributeValue("", 10357, "/Employee/EmployeeList?_crntpage=1&status_employee=", 10357, 51, true);
#nullable restore
#line 373 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
WriteAttributeValue("", 10408, paging.StatusPage, 10408, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">1</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"2\" id=\"btn2\"");
            BeginWriteAttribute("href", " href=\"", 10506, "\"", 10582, 2);
            WriteAttributeValue("", 10513, "/Employee/EmployeeList?_crntpage=2&status_employee=", 10513, 51, true);
#nullable restore
#line 374 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
WriteAttributeValue("", 10564, paging.StatusPage, 10564, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">2</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"3\" id=\"btn3\"");
            BeginWriteAttribute("href", " href=\"", 10662, "\"", 10738, 2);
            WriteAttributeValue("", 10669, "/Employee/EmployeeList?_crntpage=3&status_employee=", 10669, 51, true);
#nullable restore
#line 375 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
WriteAttributeValue("", 10720, paging.StatusPage, 10720, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">3</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"4\" id=\"btn4\"");
            BeginWriteAttribute("href", " href=\"", 10818, "\"", 10894, 2);
            WriteAttributeValue("", 10825, "/Employee/EmployeeList?_crntpage=4&status_employee=", 10825, 51, true);
#nullable restore
#line 376 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
WriteAttributeValue("", 10876, paging.StatusPage, 10876, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">4</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"5\" id=\"btn5\"");
            BeginWriteAttribute("href", " href=\"", 10974, "\"", 11050, 2);
            WriteAttributeValue("", 10981, "/Employee/EmployeeList?_crntpage=5&status_employee=", 10981, 51, true);
#nullable restore
#line 377 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
WriteAttributeValue("", 11032, paging.StatusPage, 11032, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">5</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"6\" id=\"btn6\"");
            BeginWriteAttribute("href", " href=\"", 11130, "\"", 11206, 2);
            WriteAttributeValue("", 11137, "/Employee/EmployeeList?_crntpage=6&status_employee=", 11137, 51, true);
#nullable restore
#line 378 "D:\HCWEB\Views\Employee\EmployeeList.cshtml"
WriteAttributeValue("", 11188, paging.StatusPage, 11188, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">6</a></li>\r\n    <li class=\"page-item\">\r\n      <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 11274, "\"", 11281, 0);
            EndWriteAttribute();
            WriteLiteral(">Next</a>\r\n    </li> ");
            WriteLiteral(@"  </ul>

<br><br><br></div></div>


<script type=""text/javascript"">
function EmployeeDetail(btn)
{
    var id = btn.id;
    id = id.substring(4,id.Length);
    var identify = ""Id-""+id;
    var Id = document.getElementById(identify).value;
    location.href='/Employee/EmployeeDetail?Id='+Id;
}

function Search()
{
    var keyword = document.getElementById(""keyword"").value;
    console.log(keyword);
    location.href='/Employee/Search?keyword='+keyword;
}

</script>");
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
