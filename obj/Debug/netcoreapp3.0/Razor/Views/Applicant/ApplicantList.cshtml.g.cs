#pragma checksum "G:\HCWEB\Views\Applicant\ApplicantList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26b0b790e9397fca4d392836ddd4e5c9dd182751"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applicant_ApplicantList), @"mvc.1.0.view", @"/Views/Applicant/ApplicantList.cshtml")]
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
#line 1 "G:\HCWEB\Views\_ViewImports.cshtml"
using HC_WEB_FINALPROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\HCWEB\Views\_ViewImports.cshtml"
using HC_WEB_FINALPROJECT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b0b790e9397fca4d392836ddd4e5c9dd182751", @"/Views/Applicant/ApplicantList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7617a8a5b04142fd44fe79920582bdc0a6fd0da", @"/Views/_ViewImports.cshtml")]
    public class Views_Applicant_ApplicantList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Importy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Applicant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
  
    Layout = "_LayoutHC";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
<html>
<style>
    .card {
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
    border-radius: 50%;");
            WriteLiteral(@"
}

.card .card-heading.image .card-heading-header {
    display: inline-block;
    vertical-align: top;
}

.card .card-heading.image .card-heading-header h3 {
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
    overflo");
            WriteLiteral(@"w: hidden;
    font-size: 12px;
    color: #999;
    text-overflow: ellipsis;
    white-space: nowrap;
}

.card-comments .media-heading {
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
    -moz-box-sizing: borde");
            WriteLiteral(@"r-box;
    box-sizing: border-box;
}

.card.people .card-info .title {
    display: block;
    margin: 8px 14px 0 14px;
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
    bac");
            WriteLiteral(@"kground-color: rgba(214, 224, 226, 0.2);
    height: 500px;
}
.card.hovercard .cardjudul {
    background: #0c0f11;
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
    margin-bottom: 4px;
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
    padding: 0 20p");
            WriteLiteral("x;\r\n    margin-bottom: 17px;\r\n}\r\n\r\n.navbar:active{\r\n    color:#5DADE2;\r\n}\r\n\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26b0b790e9397fca4d392836ddd4e5c9dd18275110458", async() => {
                WriteLiteral("\r\n <br><br>\r\n\r\n<div class=\"container\">\r\n                <p class=\"text-center\" style=\"color:#FF5693; font-size:33px\">Applicant</p> <br><br>\r\n    <div class=\"column\">\r\n    <div class=\"col-lg-12 col-sm-5\"><div class=\"column text-right\"> \r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26b0b790e9397fca4d392836ddd4e5c9dd18275110976", async() => {
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
<button onclick=""location.href='/Applicant/ExportCSV'"" class=""btn btn-success""><b>Export CSV</b></button>
<button onclick=""location.href='/Applicant/ExportAll'"" class=""btn btn-success""><b>Export CSV (All)</b></button>
<button onclick=""location.href='/Applicant/AddApplicant'"" class=""btn btn-success""><b>New Applicant</b></button> </div></div> </div>


        <div class=""col-lg-12 col-sm-5"">
             <div class=""card hovercard"">
                    <div class=""row"" style=""background-color: #1F618D;"">
                   <div class=""col-lg-3 col-sm-3"">
                   </div>
                   <div class=""col-lg-2 col-sm-2"">
                       <br>
                    <a onclick=""location.href='/Applicant/ApplicantList?status=unproccess'"" style=""color:#F5FBFF; font-family:Helvetica, sans-serif; ""><b>Unproccess</b></a>
                   <br>
                   </div> 
                   <div class=""col-lg-2 col-sm-2"">
                       <br>
                    <a onclick=""loca");
                WriteLiteral(@"tion.href='/Applicant/ApplicantList?status=psychotest'"" style=""color:#F5FBFF; font-family:Helvetica, sans-serif""><b>Psychotest</b></a>
                   <h2></h2>
                   </div>
                   <div class=""col-lg-2 col-sm-2"">
                       <br>
                    <a onclick=""location.href='/Applicant/ApplicantList?status=interview'"" style=""color:#F5FBFF; font-family:Helvetica, sans-serif""><b>Interview</b></a>
                   <br>
                   </div>
                   <div class=""col-lg-3 col-sm-3"">
                   </div>
                   </div>
                   <br>
                   <div class=""col-lg-12 col-sm-4"">
                       <div class=""row"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26b0b790e9397fca4d392836ddd4e5c9dd18275115156", async() => {
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
                WriteLiteral(@"
                    </div><br>    
                <div class=""body"">

<table style=""background:white"" class=""table text-left"">
            <tbody>
  
    <br>
    <thead class=""thead-dark"">
    <tr>
      <th class=""text-center"" scope=""col"">Name</th>
      <th class=""text-center"" scope=""col"">Email</th>
      <th class=""text-center"" scope=""col"">Phone</th>
      <th class=""text-center"" scope=""col"">Department</th>
      <th class=""text-center"" scope=""col"">Status Proccess</th>
      <th scope=""col""></th>
    </tr>
  </thead>
");
#nullable restore
#line 335 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
      
    var items = ViewBag.items;
    if(items!=null){
    foreach(var a in items) { 

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("id", "  id=\"", 8677, "\"", 8691, 2);
                WriteAttributeValue("", 8683, "Id-", 8683, 3, true);
#nullable restore
#line 340 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 8686, a.Id, 8686, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 8692, "\"", 8705, 1);
#nullable restore
#line 340 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 8700, a.Id, 8700, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <td class=\"text-center\"><b>");
#nullable restore
#line 341 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
                                      Write(a.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 342 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
                                   Write(a.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 343 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
                                   Write(a.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 344 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
                                   Write(a.Placement);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 345 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
                                   Write(a.Status_Proccess);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-left\"><a");
                BeginWriteAttribute("id", " id=\"", 9044, "\"", 9058, 2);
                WriteAttributeValue("", 9049, "btn-", 9049, 4, true);
#nullable restore
#line 346 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 9053, a.Id, 9053, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"javascript:ApplicantDetail(this)\"><span class=\"glyphicon glyphicon-chevron-right\"></span></a></td>\r\n                <td class=\"text-right\"><button");
                BeginWriteAttribute("id", " id=\"", 9215, "\"", 9229, 2);
                WriteAttributeValue("", 9220, "btn-", 9220, 4, true);
#nullable restore
#line 347 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 9224, a.Id, 9224, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn\" style=\"background:#FF5693; color:white\" onclick=\"javascript:NextProccess(this)\">Next Proccess</button>  <button");
                BeginWriteAttribute("id", " id=\"", 9354, "\"", 9368, 2);
                WriteAttributeValue("", 9359, "btn-", 9359, 4, true);
#nullable restore
#line 347 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 9363, a.Id, 9363, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn\" style=\"background:#3E3E3E; color:white\" onclick=\"javascript:Reject(this)\">Reject</button></td>\r\n            </tr> \r\n");
#nullable restore
#line 349 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
            } 
    } 

#line default
#line hidden
#nullable disable
                WriteLiteral(" </tbody> \r\n    </table>\r\n                </div>\r\n            <br>\r\n        </div>\r\n    </div>\r\n</div>\r\n\t</div>\r\n</div>\r\n  </div>\r\n</div>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n<div class=\"column\">\r\n<div class=\"col-lg-12 col-sm-5\">\r\n<nav aria-label=\"...\">\r\n  <ul style=\"margin-left:12px\" class=\"pagination marginleft\">\r\n");
#nullable restore
#line 369 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
      
      var paging = ViewBag.page;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"page-item\">\r\n      <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 9937, "\"", 9944, 0);
            EndWriteAttribute();
            WriteLiteral(">Previous</a>\r\n    </li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"1\" id=\"btn1\"");
            BeginWriteAttribute("href", " href=\"", 10037, "\"", 10106, 2);
            WriteAttributeValue("", 10044, "/Applicant/ApplicantList?_crntpage=1&status=", 10044, 44, true);
#nullable restore
#line 374 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 10088, paging.StatusPage, 10088, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">1</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"2\" id=\"btn2\"");
            BeginWriteAttribute("href", " href=\"", 10186, "\"", 10255, 2);
            WriteAttributeValue("", 10193, "/Applicant/ApplicantList?_crntpage=2&status=", 10193, 44, true);
#nullable restore
#line 375 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 10237, paging.StatusPage, 10237, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">2</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"3\" id=\"btn3\"");
            BeginWriteAttribute("href", " href=\"", 10335, "\"", 10404, 2);
            WriteAttributeValue("", 10342, "/Applicant/ApplicantList?_crntpage=3&status=", 10342, 44, true);
#nullable restore
#line 376 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 10386, paging.StatusPage, 10386, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">3</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"4\" id=\"btn4\"");
            BeginWriteAttribute("href", " href=\"", 10484, "\"", 10553, 2);
            WriteAttributeValue("", 10491, "/Applicant/ApplicantList?_crntpage=4&status=", 10491, 44, true);
#nullable restore
#line 377 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 10535, paging.StatusPage, 10535, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">4</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"5\" id=\"btn5\"");
            BeginWriteAttribute("href", " href=\"", 10633, "\"", 10702, 2);
            WriteAttributeValue("", 10640, "/Applicant/ApplicantList?_crntpage=5&status=", 10640, 44, true);
#nullable restore
#line 378 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 10684, paging.StatusPage, 10684, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">5</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"6\" id=\"btn6\"");
            BeginWriteAttribute("href", " href=\"", 10782, "\"", 10851, 2);
            WriteAttributeValue("", 10789, "/Applicant/ApplicantList?_crntpage=6&status=", 10789, 44, true);
#nullable restore
#line 379 "G:\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 10833, paging.StatusPage, 10833, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">6</a></li>\r\n    <li class=\"page-item\">\r\n      <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 10919, "\"", 10926, 0);
            EndWriteAttribute();
            WriteLiteral(">Next</a>\r\n    </li> ");
            WriteLiteral(@"  </ul>
<br><br><br></div></div></html>



<script type=""text/javascript"">
function NextProccess(btn)
{
    var id = btn.id;
    id = id.substring(4,id.Length);
    var identify = ""Id-""+id;
    var Id = document.getElementById(identify).value;
    location.href='/Applicant/NextProccess?Id='+Id;
}

function Reject(btn)
{
    var id = btn.id;
    id = id.substring(4,id.Length);
    var identify = ""Id-""+id;
    var Id = document.getElementById(identify).value;
    location.href='/Applicant/Reject?Id='+Id;
}

function ApplicantDetail(btn)
{
    var id = btn.id;
    id = id.substring(4,id.Length);
    var identify = ""Id-""+id;
    var Id = document.getElementById(identify).value;
    location.href='/Applicant/ApplicantDetail?Id='+Id;
}

function Search()
{
    var keyword = document.getElementById(""keyword"").value;
    console.log(keyword);
    location.href='/Applicant/Search?keyword='+keyword;
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
