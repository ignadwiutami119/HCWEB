#pragma checksum "G:\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0c757b7b0c69b98a18790028284a51c110f8a52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendance_AttendanceThisMonth), @"mvc.1.0.view", @"/Views/Attendance/AttendanceThisMonth.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0c757b7b0c69b98a18790028284a51c110f8a52", @"/Views/Attendance/AttendanceThisMonth.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7617a8a5b04142fd44fe79920582bdc0a6fd0da", @"/Views/_ViewImports.cshtml")]
    public class Views_Attendance_AttendanceThisMonth : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
  
    Layout = "_LayoutHC";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n  <style>\r\n    body {\r\n  background-color: #EBF5FB;\r\n         }\r\n  </style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0c757b7b0c69b98a18790028284a51c110f8a523328", async() => {
                WriteLiteral("\r\n  <br><br><br><br><br><br>\r\n");
#nullable restore
#line 13 "G:\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
    var employ = ViewBag.Employee;
  var dt = DateTime.Now;
  var month_ = dt.ToString("MMMM yyyy");

#line default
#line hidden
#nullable disable
                WriteLiteral("  <h3>Attendance of</h3>\r\n  <h2>");
#nullable restore
#line 17 "G:\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
 Write(employ.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n  <h3>on ");
#nullable restore
#line 18 "G:\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
    Write(month_);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
                WriteLiteral(@"<div class=""container"">
<div style=""width:915px;margin-left:80px;margin-top:50px; margin-bottom:50px;"" class="" text-center"">
  <table style=""background:white"" class=""table text-left"">
            <tbody>
    <br>
    <thead class=""thead-dark"">
    <tr>
      <th class=""text-center"" style=""background: #1F618D; color:white"" scope=""col"">Date</th>
      <th class=""text-center"" style=""background: #1F618D; color:white"" scope=""col"">Clock In</th>
      <th class=""text-center"" style=""background: #1F618D; color:white"" scope=""col"">Clock Out</th>
      <th class=""text-center"" style=""background: #1F618D; color:white"" scope=""col"">Status</th>
    </tr>
  </thead>
");
#nullable restore
#line 33 "G:\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
      
    var items = ViewBag.items;
    var get = DateTime.Now;
    var get_month = get.Month;
    var get_year = get.Year;
    var date = new DateTime(get_year,get_month,1);
    var get_day_number = System.DateTime.DaysInMonth(date.Year, date.Month);
    var dateonly="";
    for(int i=1;i<=get_day_number;i++) {
        date = new DateTime(get_year,get_month,i);
        var datetocheck = date.ToString("dd/MM/yyyy");
        dateonly = date.ToString("dd-MM-yyyy");

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td class=\"text-center\"><b>");
#nullable restore
#line 46 "G:\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
                                      Write(dateonly);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></td>\r\n");
#nullable restore
#line 47 "G:\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
                  var employee = ViewBag.Employee;
                var attendance = ViewBag.Attendance;
                foreach(var item in attendance){
                if(datetocheck == (item.ClockIn).ToString("dd/MM/yyyy"))
                {
                var time = item.ClockIn;
                var timeonly = time.ToString("hh:mm:ss tt");

#line default
#line hidden
#nullable disable
                WriteLiteral("                <td class=\"text-center\">");
#nullable restore
#line 54 "G:\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
                                   Write(timeonly);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 55 "G:\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
                }}
                foreach(var item in attendance){
                if(datetocheck == (item.ClockOut).ToString("dd/MM/yyyy"))
                {
                    var time = item.ClockOut;
                    var timeonly = time.ToString("hh:mm:ss tt");

#line default
#line hidden
#nullable disable
                WriteLiteral("                <td class=\"text-center\">");
#nullable restore
#line 61 "G:\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
                                   Write(timeonly);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 62 "G:\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
                 }
                 }
                 foreach(var item in attendance){
                if(datetocheck == (item.ClockIn).ToString("dd/MM/yyyy"))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <td class=\"text-center\">");
#nullable restore
#line 67 "G:\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
                                   Write(item.status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> ");
#nullable restore
#line 67 "G:\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
                                                          }}
                

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr> \r\n");
#nullable restore
#line 70 "G:\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
            } 
    

#line default
#line hidden
#nullable disable
                WriteLiteral(" </tbody> \r\n    </table></div></div><br><br><br>\r\n    ");
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
            WriteLiteral("</html>\r\n");
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
