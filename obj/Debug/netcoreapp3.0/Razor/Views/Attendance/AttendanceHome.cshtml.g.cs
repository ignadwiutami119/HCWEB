#pragma checksum "G:\FinalProject\HCWEB\Views\Attendance\AttendanceHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9c156a1c4cb32e64608ca876025c43174d0402f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendance_AttendanceHome), @"mvc.1.0.view", @"/Views/Attendance/AttendanceHome.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c156a1c4cb32e64608ca876025c43174d0402f", @"/Views/Attendance/AttendanceHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7617a8a5b04142fd44fe79920582bdc0a6fd0da", @"/Views/_ViewImports.cshtml")]
    public class Views_Attendance_AttendanceHome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Attendance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\FinalProject\HCWEB\Views\Attendance\AttendanceHome.cshtml"
  
    Layout = "_LayoutHC";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">

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
    -moz-");
            WriteLiteral(@"border-radius: 50%;
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
.card .card-comments .comments-collapse-toggle span {
    padding");
            WriteLiteral(@"-right: 5px;
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
    -webkit-box-sizing: border-box;
    -moz-box-si");
            WriteLiteral(@"zing: border-box;
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
    ba");
            WriteLiteral(@"ckground-color: rgba(214, 224, 226, 0.2);
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
    padding: 0 20px;
    margi");
            WriteLiteral(@"n-bottom: 17px;
}
.navbar:active{
    color:#5DADE2;
}
</style>

 <br><br>

<div class=""container"">
    <div class=""column"">
        <div class=""col-lg-12 col-sm-5"">
        <p class=""text-center"" style=""color:#FF5693; font-size:33px"">Attendance</p> <br><br>
    <div class=""col-lg-12 col-sm-5""><div class=""column text-right"" style=""margin-bottom:1px"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9c156a1c4cb32e64608ca876025c43174d0402f10803", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9c156a1c4cb32e64608ca876025c43174d0402f11062", async() => {
                    WriteLiteral("Search");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n<input type=\"text\" class=\"form-control\" style=\"width: 350px;float:right\" name=\"keyword\" placeholder=\"Type to search\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div><br>\r\n<table style=\"background:white; box-shadow: 1px 1px 10px #5499C7;\" class=\"table table-hover text-left\"> \r\n            <tbody>\r\n");
#nullable restore
#line 251 "G:\FinalProject\HCWEB\Views\Attendance\AttendanceHome.cshtml"
     
    var items = ViewBag.items;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <br>
    <thead class=""thead-dark"">
    <tr>
      <th style=""background:#1F618D; color:white"" scope=""col"">Name</th>
      <th style=""background:#1F618D; color:white"" scope=""col"">Occupation</th>
      <th style=""background:#1F618D; color:white"" scope=""col"">Department</th>
      <th style=""background:#1F618D; color:white"" scope=""col""></th>
    </tr>
  </thead>    
");
#nullable restore
#line 262 "G:\FinalProject\HCWEB\Views\Attendance\AttendanceHome.cshtml"
    foreach(var a in items) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n        <input type=\"hidden\"");
            BeginWriteAttribute("id", "  id=\"", 6429, "\"", 6443, 2);
            WriteAttributeValue("", 6435, "Id-", 6435, 3, true);
#nullable restore
#line 264 "G:\FinalProject\HCWEB\Views\Attendance\AttendanceHome.cshtml"
WriteAttributeValue("", 6438, a.Id, 6438, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 6444, "\"", 6457, 1);
#nullable restore
#line 264 "G:\FinalProject\HCWEB\Views\Attendance\AttendanceHome.cshtml"
WriteAttributeValue("", 6452, a.Id, 6452, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("                <td><b>");
#nullable restore
#line 266 "G:\FinalProject\HCWEB\Views\Attendance\AttendanceHome.cshtml"
                  Write(a.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 267 "G:\FinalProject\HCWEB\Views\Attendance\AttendanceHome.cshtml"
                                 Write(a.Occupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 268 "G:\FinalProject\HCWEB\Views\Attendance\AttendanceHome.cshtml"
                                 Write(a.Placement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\"><a");
            BeginWriteAttribute("id", " id=\"", 6730, "\"", 6744, 2);
            WriteAttributeValue("", 6735, "btn-", 6735, 4, true);
#nullable restore
#line 269 "G:\FinalProject\HCWEB\Views\Attendance\AttendanceHome.cshtml"
WriteAttributeValue("", 6739, a.Id, 6739, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"javascript:AttendanceDetail(this)\"><span class=\"glyphicon glyphicon-chevron-right\"></span></a></td>\r\n            </tr> \r\n");
#nullable restore
#line 271 "G:\FinalProject\HCWEB\Views\Attendance\AttendanceHome.cshtml"
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
</div><br><br><br><br>

<script type=""text/javascript"">
function AttendanceDetail(btn)
{
    var id = btn.id;
    id = id.substring(4,id.Length);
    var identify = ""Id-""+id;
    var Id = document.getElementById(identify).value;
    location.href='/Attendance/AttendanceList?Id='+Id;
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
