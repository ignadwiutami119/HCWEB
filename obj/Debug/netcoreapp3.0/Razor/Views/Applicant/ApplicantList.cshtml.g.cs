#pragma checksum "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1245fd5001df7dbf248c1b5db7df02e8ae314691"
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
#line 1 "G:\FinalProject\HCWEB\Views\_ViewImports.cshtml"
using HC_WEB_FINALPROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\FinalProject\HCWEB\Views\_ViewImports.cshtml"
using HC_WEB_FINALPROJECT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1245fd5001df7dbf248c1b5db7df02e8ae314691", @"/Views/Applicant/ApplicantList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7617a8a5b04142fd44fe79920582bdc0a6fd0da", @"/Views/_ViewImports.cshtml")]
    public class Views_Applicant_ApplicantList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
  
    Layout = "_LayoutHC";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
<html>
<style>
   body {
    background-color: #EBF5FB;
    }

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
  ");
            WriteLiteral(@"  -moz-border-radius: 50%;
    border-radius: 50%;
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
.card .card-comments .comments-collapse");
            WriteLiteral(@"-toggle span {
    padding-right: 5px;
    overflow: hidden;
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
    -webkit");
            WriteLiteral(@"-box-sizing: border-box;
    -moz-box-sizing: border-box;
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
    box-shadow: 1px 1px 10px #5499C7;
    position: relative;
    padding-right: 15px;
    padding-left: 15px;
    overflow: hidden;
    text-align: center;
    background-color: whit");
            WriteLiteral(@"e;
}

.btn:focus{
background: #ffffff;
}
  
.card.hovercard .cardheader {
    background-color: rgba(214, 224, 226, 0.2);
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
    color: #");
            WriteLiteral(@"737373;
    text-overflow: ellipsis;
}

.card.hovercard .bottom {
    padding: 0 20px;
    margin-bottom: 17px;
}

.navbar:active{
    color:#5DADE2;
}

.btnx {
  border: 2px solid #FF5693;
  color: #FF5693;
  background-color: transparent;
  padding: 6px 50px;
  border-radius: 6px;
  font-size: 12px;
  font-weight: bold;
  cursor: pointer;
}
.custom-file-upload {
    border: 1px solid #ccc;
    display: inline-block;
    padding: 6px 12px;
    cursor: pointer;
}
input[type=""file""] {
    display: none;
}
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1245fd5001df7dbf248c1b5db7df02e8ae31469110959", async() => {
                WriteLiteral(@"
<br><br>
        <h2 class=""text-center"" style=""color:#FF5693; font-size:33px"">Applicant List</h2>
<br><br>
<div class=""container"">

<div class=""row"">
        <div class=""col-lg-12 col-sm-5"">

            <div class=""col-lg-6"">
                <div class=""row"" style=""margin-left: 7px;"">
                <a onclick=""location.href='/Applicant/CSVformat'"">download csv format here</a>
                </div>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1245fd5001df7dbf248c1b5db7df02e8ae31469111669", async() => {
                    WriteLiteral(@"
                    <div class=""column"">
                        <label class=""btnx"">
                        <input type=""file""/>Choose File</label>    
                        <button class=""btn btn-success""  type=""submit""><b>Import CSV</b></button>
                    </div>
                ");
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
            </div>

            <div class=""col-lg-6 text-right"">
                <div class=""row""><a style=""color:#EBF5FB"">export file</a></div>
                    <button onclick=""location.href='/Applicant/ExportCSV'"" class=""btn btn-success""><b>Export CSV</b></button>
                    <button onclick=""location.href='/Applicant/ExportAll'"" class=""btn btn-success""><b>Export CSV (All)</b></button>
                    <button onclick=""location.href='/Applicant/AddApplicant'"" class=""btn btn-success""><b>Add New Applicant</b></button>
            </div> 

        </div> 
    </div>


       <div class=""col-lg-12 col-sm-5"">
             <div class=""card hovercard"">
                   <div class=""row"">
");
#nullable restore
#line 328 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
                           var page = ViewBag.Paging;
                        if(page.StatusPage == "Unproccess"){

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <ul> 
                        <li style=""width:370px""><a style=""background:#FF5693; color:#F0F9FF"" href=""/Applicant/ApplicantList?status=Unproccess"">Unproccess</a></li>
                        <li style=""width:370px""><a style=""color:#F0F9FF"" href=""/Applicant/ApplicantList?status=Psychotest"">Psychotest</a></li>
                        <li style=""width:370px""><a style=""color:#F0F9FF"" href=""/Applicant/ApplicantList?status=Interview"">Interview</a></li>
                    </ul>");
#nullable restore
#line 334 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
                         }
                    else if(page.StatusPage == "Psychotest"){

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <ul> 
                        <li style=""width:370px""><a style=""color:#F0F9FF"" href=""/Applicant/ApplicantList?status=Unproccess"">Unproccess</a></li>
                        <li style=""width:370px""><a style=""background:#FF5693; color:#F0F9FF"" href=""/Applicant/ApplicantList?status=Psychotest"">Psychotest</a></li>
                        <li style=""width:370px""><a style=""color:#F0F9FF"" href=""/Applicant/ApplicantList?status=Interview"">Interview</a></li>
                    </ul>
");
#nullable restore
#line 341 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
                    }else {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <ul> 
                        <li style=""width:370px""><a style=""color:#F0F9FF"" href=""/Applicant/ApplicantList?status=Unproccess"">Unproccess</a></li>
                        <li style=""width:370px""><a style=""color:#F0F9FF"" href=""/Applicant/ApplicantList?status=Psychotest"">Psychotest</a></li>
                        <li style=""width:370px""><a style=""background:#FF5693; color:#F0F9FF"" href=""/Applicant/ApplicantList?status=Interview"">Interview</a></li>
                    </ul>
");
#nullable restore
#line 347 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
                    }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                   </div>\r\n                   <br>\r\n\r\n\r\n                   <div class=\"col-lg-12 col-sm-4\">\r\n                       <div class=\"row\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1245fd5001df7dbf248c1b5db7df02e8ae31469117568", async() => {
                    WriteLiteral(@"
                   <div class=""col-lg-11 col-sm-5"">
                    <input type=""text"" id=""keyword"" name=""search"" class=""form-control"" placeholder=""Type to search""></div>
                   <div>
                    <button onclick=""javascript:Search(this)"" class=""btn btn-primary"" type=""button""><span class=""fa fa-search""> Search</span>
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

<table style=""background:white;"" class=""table table-hover text-left"">
            <tbody>
  
    <br>
    <thead class=""thead-dark"">
    <tr>
      <th class=""text-center"" scope=""col"">Name</th>
      <th class=""text-center"" scope=""col"">Email</th>
      <th class=""text-center"" scope=""col"">Occupation</th>
      <th class=""text-center"" scope=""col"">Department</th>
      <th class=""text-center"" scope=""col"">Status Proccess</th>
      <th scope=""col""></th>
    </tr>
  </thead>
");
#nullable restore
#line 378 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
      
    var items = ViewBag.items;
    if(items!=null){
    foreach(var a in items) { 

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("id", "  id=\"", 10345, "\"", 10359, 2);
                WriteAttributeValue("", 10351, "Id-", 10351, 3, true);
#nullable restore
#line 383 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 10354, a.Id, 10354, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 10360, "\"", 10373, 1);
#nullable restore
#line 383 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 10368, a.Id, 10368, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <td class=\"text-center\"><b>");
#nullable restore
#line 384 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
                                      Write(a.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 385 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
                                   Write(a.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 386 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
                                   Write(a.Occupation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 387 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
                                   Write(a.Placement);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 388 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
                                   Write(a.Status_Proccess);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-left\"><a");
                BeginWriteAttribute("id", " id=\"", 10717, "\"", 10731, 2);
                WriteAttributeValue("", 10722, "btn-", 10722, 4, true);
#nullable restore
#line 389 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 10726, a.Id, 10726, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"javascript:ApplicantDetail(this)\"><span class=\"glyphicon glyphicon-chevron-right\"></span></a></td>\r\n");
#nullable restore
#line 390 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
                  if(a.Status_Proccess=="Interview"){

#line default
#line hidden
#nullable disable
                WriteLiteral("                <td class=\"text-right\"><button");
                BeginWriteAttribute("id", " id=\"", 10943, "\"", 10957, 2);
                WriteAttributeValue("", 10948, "btn-", 10948, 4, true);
#nullable restore
#line 391 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 10952, a.Id, 10952, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn\" style=\"background:#FF5693; color:white\" onclick=\"javascript:NextProccess(this)\">Approve as Employee</button>  <button");
                BeginWriteAttribute("id", " id=\"", 11088, "\"", 11102, 2);
                WriteAttributeValue("", 11093, "btn-", 11093, 4, true);
#nullable restore
#line 391 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 11097, a.Id, 11097, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn\" style=\"background:#3E3E3E; color:white\" onclick=\"javascript:Reject(this)\">Reject</button></td> ");
#nullable restore
#line 391 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
                                                                                                                                                                                                                                                                                                                          }
                else if(a.Status_Proccess == "Psychotest" || a.Status_Proccess == "Unproccess"){

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td class=\"text-right\"><button");
                BeginWriteAttribute("id", " id=\"", 11362, "\"", 11376, 2);
                WriteAttributeValue("", 11367, "btn-", 11367, 4, true);
#nullable restore
#line 393 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 11371, a.Id, 11371, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn\" style=\"background:#FF5693; color:white\" onclick=\"javascript:NextProccess(this)\">Next Proccess</button>  <button");
                BeginWriteAttribute("id", " id=\"", 11501, "\"", 11515, 2);
                WriteAttributeValue("", 11506, "btn-", 11506, 4, true);
#nullable restore
#line 393 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 11510, a.Id, 11510, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn\" style=\"background:#3E3E3E; color:white\" onclick=\"javascript:Reject(this)\">Reject</button></td>\r\n");
#nullable restore
#line 394 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr> \r\n");
#nullable restore
#line 396 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
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
            WriteLiteral("\r\n\r\n<div class=\"container text-center\">\r\n<div class=\"column\">\r\n<div class=\"col-lg-12 col-sm-5\">\r\n<nav aria-label=\"...\">\r\n  <ul style=\"margin-left:12px; box-shadow: 1px 1px 10px #5499C7;\" class=\"pagination marginleft\">\r\n");
#nullable restore
#line 415 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
      
      var paging = ViewBag.page;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"page-item\">\r\n      <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 12149, "\"", 12156, 0);
            EndWriteAttribute();
            WriteLiteral(">Previous</a>\r\n    </li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"1\" id=\"btn1\"");
            BeginWriteAttribute("href", " href=\"", 12249, "\"", 12318, 2);
            WriteAttributeValue("", 12256, "/Applicant/ApplicantList?_crntpage=1&status=", 12256, 44, true);
#nullable restore
#line 420 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 12300, paging.StatusPage, 12300, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">1</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"2\" id=\"btn2\"");
            BeginWriteAttribute("href", " href=\"", 12398, "\"", 12467, 2);
            WriteAttributeValue("", 12405, "/Applicant/ApplicantList?_crntpage=2&status=", 12405, 44, true);
#nullable restore
#line 421 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 12449, paging.StatusPage, 12449, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">2</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"3\" id=\"btn3\"");
            BeginWriteAttribute("href", " href=\"", 12547, "\"", 12616, 2);
            WriteAttributeValue("", 12554, "/Applicant/ApplicantList?_crntpage=3&status=", 12554, 44, true);
#nullable restore
#line 422 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 12598, paging.StatusPage, 12598, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">3</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"4\" id=\"btn4\"");
            BeginWriteAttribute("href", " href=\"", 12696, "\"", 12765, 2);
            WriteAttributeValue("", 12703, "/Applicant/ApplicantList?_crntpage=4&status=", 12703, 44, true);
#nullable restore
#line 423 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 12747, paging.StatusPage, 12747, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">4</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"5\" id=\"btn5\"");
            BeginWriteAttribute("href", " href=\"", 12845, "\"", 12914, 2);
            WriteAttributeValue("", 12852, "/Applicant/ApplicantList?_crntpage=5&status=", 12852, 44, true);
#nullable restore
#line 424 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 12896, paging.StatusPage, 12896, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">5</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" value=\"6\" id=\"btn6\"");
            BeginWriteAttribute("href", " href=\"", 12994, "\"", 13063, 2);
            WriteAttributeValue("", 13001, "/Applicant/ApplicantList?_crntpage=6&status=", 13001, 44, true);
#nullable restore
#line 425 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantList.cshtml"
WriteAttributeValue("", 13045, paging.StatusPage, 13045, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">6</a></li>\r\n    <li class=\"page-item\">\r\n      <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 13131, "\"", 13138, 0);
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
    location.href='/Applicant/ApplicantUpdate?Id='+Id;
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
