#pragma checksum "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75cc2afa035458e7e283eba259d4bcc4b669d230"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EmployeeUpdate), @"mvc.1.0.view", @"/Views/Employee/EmployeeUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75cc2afa035458e7e283eba259d4bcc4b669d230", @"/Views/Employee/EmployeeUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7617a8a5b04142fd44fe79920582bdc0a6fd0da", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_EmployeeUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EmployeeUpdateData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-block rounded-0 py-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml"
  
    Layout = "_LayoutHC";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75cc2afa035458e7e283eba259d4bcc4b669d2305559", async() => {
                WriteLiteral(@"
<link href=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js""></script>
<script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
<!------ Include the above in your HEAD tag ---------->
<link href=""//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"" rel=""stylesheet"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
.card {
    padding-top: 20px;
    margin: 10px 0 20px 0;
    background-color:#D4E6F1;
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
.cardimage {
    margin: 10px 0 0px 0;
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
    border");
            WriteLiteral(@"-bottom: 1px solid #e5e5e5;
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
    border-radius: 5%;
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
    margin: 0");
            WriteLiteral(@";
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

.card.people .card-top.blue {");
            WriteLiteral(@"
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
    -moz-box-sizing: border-box;
    box-s");
            WriteLiteral(@"izing: border-box;
}

.card.hovercard {
    position: relative;
    padding-top: 0;
    overflow: hidden;
    text-align: center;
    background-color: #D6EAF8;
}

.card.hovercard .cardheader {
    background: #D4E6F1;
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
    color: #ffffff;
    vertical-align: middle;
}

.card.hovercard .info .desc {
    overflow: hidden;
    font-size: 12px;
    line-height: 20px;
    color: #737373;
    text-overflow: ellipsis;
}

.card.hoverca");
            WriteLiteral("rd .bottom {\r\n    padding: 0 20px;\r\n    margin-bottom: 17px;\r\n}\r\n\r\n</style>\r\n\r\n          \r\n<br><br>\r\n");
#nullable restore
#line 272 "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml"
       
        var Employee = ViewBag.items;
      

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"background:#D4E6F1\" class=\"container\">\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-lg-3 col-sm-6\">\r\n            <div class=\"cardimage\">\r\n                <div class=\"body\"><br>\r\n                    <img class=\"img avatar\" style=\"width:100%\"");
            BeginWriteAttribute("src", " src=\"", 6000, "\"", 6021, 1);
#nullable restore
#line 281 "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml"
WriteAttributeValue("", 6006, Employee.Image, 6006, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div> \r\n                <div class=\"bottom\">\r\n                     <h3 class=\"text-center\" style=\"color:#FF4842 \"><b>");
#nullable restore
#line 284 "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml"
                                                                  Write(Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n                     <p class=\"text-center\" style=\"color:#FF4842\">");
#nullable restore
#line 285 "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml"
                                                             Write(Employee.Occupation);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p><br>
                </div>
            </div>
        </div>
	
<div class=""col-lg-9 col-sm-6"">
<link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.1.0/css/all.css"" integrity=""sha384-lKuwvrZot6UHsBSfcMvOkWwlCMgc0TaWr+30HWe3a4ltaBwTZhyTEggF5tJv8tbt"" crossorigin=""anonymous"">
	<div class=""row justify-content-center"">
		<div class=""col-18 col-md-9 col-lg-12 pb-5"">
                    <!--Form with header-->
                        <div class=""card border-primary rounded-0"">
                            <div class=""card-header p-0"">
                                <div style=""background:#1A5276 ; padding-bottom:18px; padding-top:15px"" class=""text-center py-2""><p></p>
                                    <h3 style=""color:#F5FBFF  ""><b>Personal Data</b></h3>
");
            WriteLiteral("                                </div>\r\n                            </div>\r\n                            <div class=\"card-body p-3\">\r\n\r\n                                <!--Body-->\r\n                             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75cc2afa035458e7e283eba259d4bcc4b669d23014984", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 306 "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml"
                                
                                var Get = ViewBag.items;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 7590, "\"", 7605, 1);
#nullable restore
#line 308 "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml"
WriteAttributeValue("", 7598, Get.Id, 7598, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> ");
                WriteLiteral("                                <div class=\"form-group\">\r\n                                    <div class=\"text-center\">\r\n                                        <input type=\"text\" style=\"background:#F7F9F9;\" class=\"form-control\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 7851, "\"", 7868, 1);
#nullable restore
#line 311 "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml"
WriteAttributeValue("", 7859, Get.Name, 7859, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Name"" required>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""text-left"">
                                    <img");
                BeginWriteAttribute("src", " src=\"", 8143, "\"", 8159, 1);
#nullable restore
#line 316 "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml"
WriteAttributeValue("", 8149, Get.Image, 8149, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""width:70px;margin-bottom:3px"">
                                    <label for=""photo"">Change Photo</label><br>
                                       <input type=""file"" id=""photo"" name=""image"">
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""text-center"">
                                        <input type=""text"" style=""background:#F7F9F9;"" class=""form-control"" name=""email""");
                BeginWriteAttribute("value", " value=\"", 8690, "\"", 8708, 1);
#nullable restore
#line 323 "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml"
WriteAttributeValue("", 8698, Get.Email, 8698, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Email"" required>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""text-center"">
                                        <input type=""text"" style=""background:#F7F9F9;"" class=""form-control"" name=""phone""");
                BeginWriteAttribute("value", " value=\"", 9066, "\"", 9084, 1);
#nullable restore
#line 328 "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml"
WriteAttributeValue("", 9074, Get.Phone, 9074, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Phone"" required>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""text-center"">
                                        <input type=""text"" style=""background:#F7F9F9;"" class=""form-control"" name=""occupation""");
                BeginWriteAttribute("value", " value=\"", 9447, "\"", 9470, 1);
#nullable restore
#line 333 "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml"
WriteAttributeValue("", 9455, Get.Occupation, 9455, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Occupation"" required>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""text-center"">
                                        <input type=""text"" style=""background:#F7F9F9;"" class=""form-control"" name=""status""");
                BeginWriteAttribute("value", " value=\"", 9834, "\"", 9853, 1);
#nullable restore
#line 338 "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml"
WriteAttributeValue("", 9842, Get.Status, 9842, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Employee Status"" required>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""text-center"">
                                        <input type=""text"" style=""background:#F7F9F9;"" class=""form-control"" name=""placement""");
                BeginWriteAttribute("value", " value=\"", 10225, "\"", 10247, 1);
#nullable restore
#line 343 "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml"
WriteAttributeValue("", 10233, Get.Placement, 10233, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Placement"" required>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""text-center"">
                                        <input type=""text"" style=""background:#F7F9F9;"" class=""form-control"" name=""address""");
                BeginWriteAttribute("value", " value=\"", 10611, "\"", 10631, 1);
#nullable restore
#line 348 "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml"
WriteAttributeValue("", 10619, Get.Address, 10619, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Address"" required>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""text-center"">
                                        <input type=""text"" style=""background:#F7F9F9;"" class=""form-control"" name=""emergency""");
                BeginWriteAttribute("value", " value=\"", 10995, "\"", 11024, 1);
#nullable restore
#line 353 "G:\HCWEB\Views\Employee\EmployeeUpdate.cshtml"
WriteAttributeValue("", 11003, Get.EmergencyContact, 11003, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Emergency Contact\" required>\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <div class=\"text-center\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75cc2afa035458e7e283eba259d4bcc4b669d23022644", async() => {
                    WriteLiteral("Save Change");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <br>\r\n\r\n                        </div>\r\n                    \r\n                    <!--Form with header-->\r\n\r\n\r\n            </div>\r\n\t</div>\r\n</div>\r\n\r\n</div></div>\r\n<br><br><br>\r\n\r\n");
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
