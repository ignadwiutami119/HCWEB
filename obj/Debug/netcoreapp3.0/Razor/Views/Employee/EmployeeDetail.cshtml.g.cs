#pragma checksum "G:\HCWEB\Views\Employee\EmployeeDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6440dfb14f92d42a3dc2da230c23c47b7ea6846"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EmployeeDetail), @"mvc.1.0.view", @"/Views/Employee/EmployeeDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6440dfb14f92d42a3dc2da230c23c47b7ea6846", @"/Views/Employee/EmployeeDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7617a8a5b04142fd44fe79920582bdc0a6fd0da", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_EmployeeDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\HCWEB\Views\Employee\EmployeeDetail.cshtml"
  
    Layout = "_LayoutHC";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js""></script>
<script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
<!------ Include the above in your HEAD tag ---------->
<link href=""//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"" rel=""stylesheet"">

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
    c");
            WriteLiteral(@"olor: #777;
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
    paddi");
            WriteLiteral(@"ng: 20px;
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

.card-comments .media-heading {
    font-size: 13px;
    font-weight: bold;
}

.card.people {
    position: relative;
    display: inline-block;
    width: 170px;
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

.card.");
            WriteLiteral(@"people .card-top.blue {
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
    -moz-box-sizing");
            WriteLiteral(@": border-box;
    box-sizing: border-box;
}

.card.hovercard {
    position: relative;
    padding-top: 0;
    overflow: hidden;
    text-align: center;
    background-color: #D6EAF8;
}

.card.hovercard .cardheader {
    background: #1F618D;
    background-size: cover;
    height: 90px;
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
    border: 5px solid rgba(255,255,255,0.5);
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
    text-overflow: ellip");
            WriteLiteral("sis;\r\n}\r\n\r\n.card.hovercard .bottom {\r\n    padding: 0 20px;\r\n    margin-bottom: 17px;\r\n}\r\n\r\n</style>\r\n\r\n");
#nullable restore
#line 254 "G:\HCWEB\Views\Employee\EmployeeDetail.cshtml"
    
     var Employee = ViewBag.items;

#line default
#line hidden
#nullable disable
            WriteLiteral("     <input type=\"hidden\" id=\"ID\"");
            BeginWriteAttribute("value", " value=\"", 5332, "\"", 5352, 1);
#nullable restore
#line 256 "G:\HCWEB\Views\Employee\EmployeeDetail.cshtml"
WriteAttributeValue("", 5340, Employee.Id, 5340, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("<br><br>\r\n");
            WriteLiteral("<div class=\"container\">\r\n   <div class=\"column\">\r\n    <div class=\"column text-right\"> <div class=\"col-lg-12 col-sm-5\">\r\n");
            WriteLiteral(@"<button class=""btn btn-success"" onclick=""javascript:Update(this)""><b>Edit Data</b></button>
<button class=""btn btn-danger"" onclick=""javascript:Remove(this)""><b>Remove</b></button>
</div></div> </div>
	<div class=""row"">
		<div class=""col-lg-12 col-sm-6"">

            <div class=""card hovercard"">
                <div class=""cardheader"" style=""margin-top: 15px;"">
                    <div style=""padding-top:2px; padding-bottom:5px"">
                  <h2 style=""color:#EBF5FB""><b>");
#nullable restore
#line 275 "G:\HCWEB\Views\Employee\EmployeeDetail.cshtml"
                                          Write(Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2></div>\r\n                </div>\r\n                <div class=\"avatar\"><br>\r\n                    <img alt=\"profil-picture\"");
            BeginWriteAttribute("src", " src=", 6503, "", 6523, 1);
#nullable restore
#line 278 "G:\HCWEB\Views\Employee\EmployeeDetail.cshtml"
WriteAttributeValue("", 6508, Employee.Image, 6508, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"info\">\r\n                    <div style=\"color:#FF4842\">\r\n                        <b>");
#nullable restore
#line 282 "G:\HCWEB\Views\Employee\EmployeeDetail.cshtml"
                      Write(Employee.Occupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    </div>\r\n                    <div class=\"desc\">");
#nullable restore
#line 284 "G:\HCWEB\Views\Employee\EmployeeDetail.cshtml"
                                 Write(Employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"desc\">");
#nullable restore
#line 285 "G:\HCWEB\Views\Employee\EmployeeDetail.cshtml"
                                 Write(Employee.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                </div>
                <div class=""bottom"">
                    <a class=""btn btn-primary btn-twitter btn-sm"" href=""https://twitter.com/webmaniac"">
                        <i class=""fa fa-twitter""></i>
                    </a>
                    <a class=""btn btn-danger btn-sm"" rel=""publisher""
                       href=""https://plus.google.com/+ahmshahnuralam"">
                        <i class=""fa fa-google-plus""></i>
                    </a>
                    <a class=""btn btn-primary btn-sm"" rel=""publisher""
                       href=""https://plus.google.com/shahnuralam"">
                        <i class=""fa fa-facebook""></i>
                    </a>
                    <a class=""btn btn-warning btn-sm"" rel=""publisher"" href=""https://plus.google.com/shahnuralam"">
                        <i class=""fa fa-behance""></i>
                    </a>
                </div>
            </div>
        </div>
	</div>

<div class=""col-lg-12 col-sm-6"">
<table class=""table");
            WriteLiteral(@""">
  <thead class=""thead-dark"">
    <tr>
      <th scope=""col"">Birth Date</th>
      <th scope=""col"">Birth Place</th>
      <th scope=""col"">Gender</th>
      <th scope=""col"">Address</th>
      <th scope=""col"">Emergency Contact</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>");
#nullable restore
#line 320 "G:\HCWEB\Views\Employee\EmployeeDetail.cshtml"
     Write(Employee.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 321 "G:\HCWEB\Views\Employee\EmployeeDetail.cshtml"
     Write(Employee.BirthPlace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 322 "G:\HCWEB\Views\Employee\EmployeeDetail.cshtml"
     Write(Employee.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 323 "G:\HCWEB\Views\Employee\EmployeeDetail.cshtml"
     Write(Employee.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 324 "G:\HCWEB\Views\Employee\EmployeeDetail.cshtml"
     Write(Employee.EmergencyContact);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table> \r\n</div> \r\n\r\n</div>\r\n<br><br><br>\r\n");
            WriteLiteral(@"

<script type=""text/javascript"">
function Update()
{
    var Id = document.getElementById(""ID"").value;
    location.href='/Employee/EmployeeUpdate?Id='+Id;
}

function Remove()
{
    var Id = document.getElementById(""ID"").value;
    location.href='/Employee/EmployeeRemove?Id='+Id;
}
</script>




");
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
