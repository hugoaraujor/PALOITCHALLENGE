#pragma checksum "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5404697a2d83d82107705564fa01a816d51cd5a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
using PALOITChallenge;

#line default
#line hidden
#line 2 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\_ViewImports.cshtml"
using PALOITChallenge.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5404697a2d83d82107705564fa01a816d51cd5a7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17d4ff2dadde41cf33c554d261913a462f081d2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";


#line default
#line hidden
            BeginContext(71, 90, true);
            WriteLiteral("<script>\r\n    var coords = [];\r\n</script>\r\n\r\n<div class=\"formcontainer\">\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(161, 887, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "285a148024854d1790c493be2fe92298", async() => {
                BeginContext(167, 125, true);
                WriteLiteral("\r\n\r\n        <div class=\"row form-row  form-group  col-auto\">\r\n            <div class=\"form-group col-md-5\">\r\n                ");
                EndContext();
                BeginContext(293, 28, false);
#line 16 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
           Write(Html.Label("Level of Pain:"));

#line default
#line hidden
                EndContext();
                BeginContext(321, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(340, 118, false);
#line 17 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
           Write(Html.DropDownList("Level", Html.GetEnumSelectList<PainLevels>(), "Select Pain Level", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(458, 85, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group col-md-5\">\r\n                ");
                EndContext();
                BeginContext(544, 22, false);
#line 20 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
           Write(Html.Label("Illness:"));

#line default
#line hidden
                EndContext();
                BeginContext(566, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(585, 126, false);
#line 21 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
           Write(Html.DropDownList("Illnesspain", @ViewBag.illness as SelectList, "Select Illness Pain Level", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(711, 85, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group col-md-2\">\r\n                ");
                EndContext();
                BeginContext(797, 20, false);
#line 24 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
           Write(Html.Label("Search"));

#line default
#line hidden
                EndContext();
                BeginContext(817, 224, true);
                WriteLiteral("\r\n                <p>\r\n                    <button type=\"submit\" name=\"send\" id=\"send\" class=\"btn btn-primary\">Send</button>\r\n                </p>\r\n                \r\n            </div>\r\n                \r\n            </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1048, 752, true);
            WriteLiteral(@"
</div>
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th class=""col-md-2"">
                        <b>Level of Pain</b>
                    </th>
                    <th class=""col-md-4"">
                        <b>
                            HOSPITAL
                        </b>
                    </th>

                    <th class=""col-md-1""><b>Patients</b></th>
                    <th class=""col-md-2"">
                        <b>Average Process Time</b>

                    </th>
                    <th class=""col-md-2"">
                        <b>Waiting Time</b>
                    </th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 57 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
                 foreach (Hospital m in Model.hospitals)
                {

#line default
#line hidden
            BeginContext(1877, 101, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"col-md-2\">\r\n                            ");
            EndContext();
            BeginContext(1979, 51, false);
#line 61 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
                       Write(m.waitingList.ToList().FirstOrDefault().levelOfPain);

#line default
#line hidden
            EndContext();
            BeginContext(2030, 109, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-md-4 \">\r\n                            ");
            EndContext();
            BeginContext(2140, 6, false);
#line 64 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
                       Write(m.name);

#line default
#line hidden
            EndContext();
            BeginContext(2146, 78, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-md-1\">");
            EndContext();
            BeginContext(2225, 43, false);
#line 66 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
                                        Write(m.waitingList.FirstOrDefault().patientCount);

#line default
#line hidden
            EndContext();
            BeginContext(2268, 82, true);
            WriteLiteral("</td>\r\n                        <td class=\"col-md-2\">\r\n                            ");
            EndContext();
            BeginContext(2351, 40, false);
#line 68 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
                       Write(m.waitingList.First().averageProcessTime);

#line default
#line hidden
            EndContext();
            BeginContext(2391, 113, true);
            WriteLiteral(" min.\r\n                        </td>\r\n                        <td class=\"col-md-2\">\r\n                            ");
            EndContext();
            BeginContext(2506, 13, false);
#line 71 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
                        Write(m.waitingTime);

#line default
#line hidden
            EndContext();
            BeginContext(2520, 109, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n\r\n                    </tr>\r\n                    <script>coords.push({lat:");
            EndContext();
            BeginContext(2631, 14, false);
#line 76 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
                                         Write(m.location.lat);

#line default
#line hidden
            EndContext();
            BeginContext(2646, 5, true);
            WriteLiteral(",lng:");
            EndContext();
            BeginContext(2653, 14, false);
#line 76 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
                                                               Write(m.location.lng);

#line default
#line hidden
            EndContext();
            BeginContext(2668, 8, true);
            WriteLiteral(",title:\'");
            EndContext();
            BeginContext(2677, 6, false);
#line 76 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
                                                                                       Write(m.name);

#line default
#line hidden
            EndContext();
            BeginContext(2683, 15, true);
            WriteLiteral("\'});</script>\r\n");
            EndContext();
#line 77 "C:\Users\hugoa\source\repos\PALOITChallenge\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2717, 950, true);
            WriteLiteral(@"            </tbody>

        </table>

        <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyCc4MdB_ZPFe7caisyrs6uhDLKDUqsv7Tg&callback=initMap"" async defer></script>

        <script>
            var map;

            function initMap() {

                map = new google.maps.Map(document.getElementById('map'), {
                    center: { lat: -33.500, lng: 151.000 },
                    zoom: 8.5
                });
                coords.forEach(element => addMarker(element.lat, element.lng, element.title));
            }
            function addMarker(ilat, ilng, ititle) {
                var myLatLng = { lat: ilat, lng: ilng };
                var marker = new google.maps.Marker({
                    position: myLatLng,
                    map: map,
                    title: ititle
                });
            }
        </script>
        <div id=""map""></div>










");
            EndContext();
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
