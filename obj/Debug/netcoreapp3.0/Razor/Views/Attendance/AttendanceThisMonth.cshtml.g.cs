#pragma checksum "D:\TRAININGC#\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8414be09301267492b10985cdcccca0a25d66b6b"
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
#line 1 "D:\TRAININGC#\HCWEB\Views\_ViewImports.cshtml"
using HC_WEB_FINALPROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TRAININGC#\HCWEB\Views\_ViewImports.cshtml"
using HC_WEB_FINALPROJECT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8414be09301267492b10985cdcccca0a25d66b6b", @"/Views/Attendance/AttendanceThisMonth.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7617a8a5b04142fd44fe79920582bdc0a6fd0da", @"/Views/_ViewImports.cshtml")]
    public class Views_Attendance_AttendanceThisMonth : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\TRAININGC#\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
  
    Layout = "_LayoutHC";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br><br><br><br><br><br>
<div class=""container"" style=""background: #D6EAF8;"">
<div style=""width:850px;margin-left:130px;margin-top:50px; margin-bottom:50px; border:solid"" class="" text-center"">
  <table style=""background:white"" class=""table text-left"">
            <tbody>
    <br>
    <thead class=""thead-dark"">
    <tr>
      <th class=""text-center"" scope=""col"">Date</th>
      <th class=""text-center"" scope=""col"">Clock In</th>
      <th class=""text-center"" scope=""col"">Clock Out</th>
      <th class=""text-center"" scope=""col"">Status</th>
    </tr>
  </thead>
");
#nullable restore
#line 19 "D:\TRAININGC#\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
      
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
#line 32 "D:\TRAININGC#\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
                                      Write(dateonly);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n");
#nullable restore
#line 33 "D:\TRAININGC#\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
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
#line 40 "D:\TRAININGC#\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
                                   Write(timeonly);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 41 "D:\TRAININGC#\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
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
#line 47 "D:\TRAININGC#\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
                                   Write(timeonly);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 48 "D:\TRAININGC#\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
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
#line 53 "D:\TRAININGC#\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
                                   Write(item.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> ");
#nullable restore
#line 53 "D:\TRAININGC#\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
                                                          }}
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr> \r\n");
#nullable restore
#line 56 "D:\TRAININGC#\HCWEB\Views\Attendance\AttendanceThisMonth.cshtml"
            } 
    

#line default
#line hidden
#nullable disable
            WriteLiteral(" </tbody> \r\n    </table></div></div><br><br><br>");
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
